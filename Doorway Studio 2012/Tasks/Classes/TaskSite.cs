using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Core.Classes.Containers.Items;
using Umax.Classes;
using Umax.Classes.Containers;
using Umax.Classes.Helpers;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using Umax.Interfaces.Images;
using Umax.Interfaces.Tasks;
using Umax.Interfaces.Text;
using Umax.Plugins.Tasks.Common;
using Umax.Plugins.Tasks.Enums;
using Umax.Plugins.Tasks.Interfaces;
using IO = System.IO;

namespace Umax.Plugins.Tasks.Classes
{
    public abstract class TaskSite : ITaskSite
    {
        public TaskSite()
        {
            this.Index = 0;
            this.Progress = 0;

            this.Logger = new List<string>();
            this.State = TaskStateType.New;

            this.Random = new Random(Environment.TickCount);

            this.HTMLLinks = new List<HTMLLink>();

            this.Content = new ContentContainer();

            this.TokenExecutor = new TaskTokenExecutor(this.Content);

            this.FileTokens = new List<FileTokenExecutor>();
        }

        protected virtual ContentContainer Content { get; set; }

        public event SimpleEventHandler StateChanged;
        public event SimpleEventHandler ProgressChanged;

        public virtual TaskTokenExecutor TokenExecutor { get; set; }

        private TaskStateType state;
        public virtual TaskStateType State
        {
            get { return this.state; }
            protected set
            {
                this.state = value;
                if (this.StateChanged != null)
                {
                    this.StateChanged.Invoke();
                }
            }
        }

        private int progress;
        public virtual int Progress
        {
            get { return this.progress; }
            protected set
            {
                this.progress = value;
                if (this.ProgressChanged != null)
                {
                    this.ProgressChanged.Invoke();
                }
            }
        }

        protected virtual Random Random { get; set; }

        public virtual List<string> Logger { get; set; }

        public virtual IDataContainer Data { get; set; }

        /// <summary>
        /// Gets or sets tokens
        /// </summary>
        public virtual ITokenContainer Tokens
        {
            get { return this.TokenExecutor.Tokens; }
            set { this.TokenExecutor.Tokens = value; }
        }

        public virtual ITaskSettings Settings { get; set; }
        public virtual ITextMaker TextMaker
        {
            get { return this.TokenExecutor.TextMaker; }
            set { this.TokenExecutor.TextMaker = value; }
        }

        public virtual IImageMaker ImageMaker
        {
            get { return this.TokenExecutor.ImageMaker; }
            set { this.TokenExecutor.ImageMaker = value; }
        }

        public virtual int Index { get; set; }

        /// <summary>
        /// Gets or sets site URL
        /// </summary>
        public virtual string URL { get; protected set; }

        /// <summary>
        /// Gets site Domain
        /// </summary>
        public virtual string Domain
        {
            get
            {
                string site = this.URL.ToLower().Replace("http://", string.Empty).Replace("https://", string.Empty);

                if (site.Contains("/"))
                {
                    site = site.Substring(0, site.IndexOf("/"));
                }

                return site;
            }
        }

        /// <summary>
        /// Gets site directory
        /// </summary>
        public virtual string Directory
        {
            get
            {
                switch ((this.Settings as TaskSettings).GeneralSubDirectories)
                {
                    case SubDirectoriesType.None:
                        {
                            return (this.Settings as TaskSettings).GeneralSavePath;
                        }

                    case SubDirectoriesType.Keyword:
                        {
                            return IO.Path.Combine((this.Settings as TaskSettings).GeneralSavePath, this.Keywords[0]);
                        }

                    case SubDirectoriesType.Number:
                        {
                            return IO.Path.Combine((this.Settings as TaskSettings).GeneralSavePath, (this.Index + 1).ToString());
                        }

                    case SubDirectoriesType.KeywordNumber:
                        {
                            return IO.Path.Combine((this.Settings as TaskSettings).GeneralSavePath, this.Keywords[0] + " " + (this.Index + 1).ToString());
                        }

                    case SubDirectoriesType.URL:
                        {
                            return IO.Path.Combine((this.Settings as TaskSettings).GeneralSavePath, (string.IsNullOrEmpty(this.Domain) ? this.Keywords[0] : this.Domain));
                        }
                }

                return (this.Settings as TaskSettings).GeneralSavePath;
            }
        }

        public virtual List<HTMLLink> HTMLLinks { get; protected set; }

        public virtual List<string> Keywords
        {
            get { return this.Content.Keywords.ToList(); }
            set { this.Content.Keywords = value.ToArray(); }
        }

        protected virtual ITemplate Template { get; set; }

        public virtual void Initialize()
        {
            this.Content.Index = this.Index;
            this.Content.Path = this.Directory;

            // Check template
            this.Template = this.Data.Select((this.Settings as TaskSettings).WorkSpaceID, ItemSelectType.ID).SelectTemplate((this.Settings as TaskSettings).TemplateID, ItemSelectType.ID);

            // Categories
            if ((this.Settings as TaskSettings).Categories.Count != 0)
            {
                this.InitializeCategories();
            }

            // Static Pages
            if ((this.Settings as TaskSettings).StaticPages.Count != 0)
            {
                this.InitializeStaticPages();
            }

            // Custom Pages
            if (this.Template.Select(FileType.Custom).Count != 0)
            {
                this.InitializeCustomPages();
            }

            // Category Pages
            if ((this.Settings as TaskSettings).Categories.Count != 0)
            {
                this.InitializeCategoriesPages();
            }

            // Regular Pages
            this.InitializeRegularPages();

            // Index Pages
            this.InitializeIndexPages();

            // Map Pages
            if ((this.Settings as TaskSettings).Map != MapType.None)
            {
                this.InitializeMap();
            }

            // Apply filenames, URLs and Encoding to the pages
            for (int i = 0; i < this.Content.Pages.Count; i++)
            {
                (this.Content.Pages[i] as Page).Encoding = this.Template.Encoding;
                (this.Content.Pages[i] as Page).Name = this.MakePageName(this.Content.Pages[i]);
                (this.Content.Pages[i] as Page).URL = this.MakePageURL(this.Content.Pages[i]);
            }

            // Links
            if ((this.Settings as TaskSettings).Links.Count != 0)
            {
                this.MakeHTMLLinks();
            }
        }

        protected virtual void InitializeMap()
        {
            switch ((this.Settings as TaskSettings).Map)
            {
                case MapType.HTML:
                case MapType.XMLHTML:
                    {
                        this.InitializeHTMLMap();
                        break;
                    }

                case MapType.AutoHTML:
                case MapType.XMLAutoHTML:
                    {
                        this.InitializeAutoHTMLMap();
                        break;
                    }
            }
        }

        protected virtual void MakeMap()
        {
            switch ((this.Settings as TaskSettings).Map)
            {
                case MapType.XML:
                    {
                        this.MakeXMLMap();
                        break;
                    }

                case MapType.HTML:
                case MapType.AutoHTML:
                    {
                        this.MakeHTMLMap();
                        break;
                    }

                case MapType.XMLHTML:
                case MapType.XMLAutoHTML:
                    {
                        this.MakeHTMLMap();
                        this.MakeXMLMap();
                        break;
                    }
            }
        }

        protected virtual void MakePages(FileType Type)
        {
            List<IPage> items = (from IPage item in this.Content.Pages
                                where item.Type == Type
                                select item).ToList();

            List<IFile> templates = this.Template.Select(Type);

            if (templates.Count == 0)
            {
                templates = this.Template.Select(FileType.Index);
            }

            for (int i = 0; i < items.Count; i++)
            {
                while (this.Paused)
                {
                    Thread.Sleep(1000);
                }

                // Set template content
                items[i].Content = templates[this.Random.Next(templates.Count)].Content;

                // Replace tokens
                this.TokenExecutor.Invoke(items[i]);

                // Update progress

            }
        }

        protected virtual void MakeCustomPages()
        {
            List<Page> items = (from IPage item in this.Content.Pages
                                where item.Type == FileType.Custom
                                select item).Cast<Page>().ToList();

            for (int i = 0; i < items.Count; i++)
            {
                while (this.Paused)
                {
                    Thread.Sleep(1000);
                }

                // Replace tokens
                this.TokenExecutor.Invoke(items[i]);

                // Update progress

            }
        }

        protected virtual void InitializeAutoHTMLMap()
        {
            // Set one page html map
            (this.Settings as TaskSettings).MapHTML = MapHTMLType.SinglePage;

            // Initialize sitemap pages
            this.InitializeHTMLMap();
        }

        protected virtual void InitializeHTMLMap()
        {
            switch ((this.Settings as TaskSettings).MapHTML)
            {
                case MapHTMLType.SinglePage:
                    {
                        this.InitializeSinglePageHTMLMap();
                        break;
                    }

                case MapHTMLType.MultiPage:
                    {
                        this.InitializeMultiPageHTMLMap();
                        break;
                    }
            }
        }

        protected virtual void InitializeMultiPageHTMLMap()
        {
            if (this.Template.Select(FileType.Map).Count == 0)
            {
                return;
            }

            int used = 0;
            int total = this.MakeMapItems().Count;
            int pages = 0;

            Sequence sequence = new Sequence();

            while (used < total)
            {
                int use = this.Random.Next((this.Settings as TaskSettings).MapHTMLLinksOnPageMin, (this.Settings as TaskSettings).MapHTMLLinksOnPageMax);

                if (total < (use + used))
                {
                    use = total - used;
                }

                this.Content.Pages.Add(new Page
                                           {
                                               Type = FileType.Map,
                                               ContinueNumber = pages,
                                               ContinueNumberStart = used,
                                               ContinueNumberEnd = used + use,
                                               ID = sequence.Invoke()
                                           });

                used += use;
                pages++;
            }
        }

        protected virtual void InitializeSinglePageHTMLMap()
        {
            this.Content.Pages.Add(new Page
                                       {
                                           Type = FileType.Map,
                                           ContinueNumberEnd = this.MakeMapItems().Count
                                       });
        }

        protected virtual void MakeHTMLMap()
        {
            List<IFile> templates = this.Template.Select(FileType.Map);

            List<IPage> items = (from IPage page in this.Content.Pages
                                where page.Type == FileType.Map
                                select page).ToList();

            for (int i = 0; i < items.Count; i++)
            {
                while (this.Paused)
                {
                    Thread.Sleep(1000);
                }

                if ((this.Settings as TaskSettings).MapHTML == MapHTMLType.SinglePage)
                {
                    if ((this.Settings as TaskSettings).Map == MapType.XMLAutoHTML || (this.Settings as TaskSettings).Map == MapType.AutoHTML)
                    {
                        items[i].Content = Stuff.Resources.AutoHTMLMap.Replace("#TITLE#", string.Empty);
                    }
                    else
                    {
                        items[i].Content = templates[this.Random.Next(templates.Count)].Content;
                    }
                }
                else
                {
                    items[i].Content = templates[this.Random.Next(templates.Count)].Content;
                }

                // Replace tokens
                this.TokenExecutor.Invoke(items[i]);

                // Update progress

            }
        }

        protected virtual List<IPage> MakeMapItems()
        {
            List<IPage> pages = new List<IPage>();

            if ((this.Settings as TaskSettings).MapIncludeIndex)
            {
                pages.AddRange((from IPage item in this.Content.Pages
                           where item.Type == FileType.Index
                                select item));
            }

            if ((this.Settings as TaskSettings).MapIncludeCategories)
            {
                pages.AddRange((from IPage item in this.Content.Pages
                                where item.Type == FileType.Category
                                select item));
            }

            if ((this.Settings as TaskSettings).MapIncludeRegularPages)
            {
                pages.AddRange((from IPage item in this.Content.Pages
                                where item.Type == FileType.Page
                                select item));
            }

            if ((this.Settings as TaskSettings).MapIncludeStaticPages)
            {
                pages.AddRange((from IPage item in this.Content.Pages
                                where item.Type == FileType.Static
                                select item));
            }

            if ((this.Settings as TaskSettings).MapIncludeCustomPages)
            {
                pages.AddRange((from IPage item in this.Content.Pages
                                where item.Type == FileType.Custom
                                select item));
            }

            return pages;
        }

        protected virtual void MakeXMLMap()
        {
            if (string.IsNullOrEmpty(this.URL))
            {
                return;
            }

            List<IPage> pages = this.MakeMapItems();

            if (pages.Count == 0)
            {
                return;
            }

            StringBuilder content = new StringBuilder("<?xml version=\"1.0\" encoding=\"UTF-8\"?><urlset xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://www.sitemaps.org/schemas/sitemap/0.9 http://www.sitemaps.org/schemas/sitemap/0.9/sitemap.xsd\" xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">\r\n", 100000);

            for (int i = 0; i < pages.Count; i++)
            {
                content.Append("<url><loc>");
                content.Append(pages[i].URL);
                content.Append("</loc>\r\n");
                switch (pages[i].Type)
                {
                    case FileType.Index:
                        {
                            content.Append("<changefreq>daily</changefreq>\r\n<priority>1.0</priority>");
                            break;
                        }

                    case FileType.Category:
                    case FileType.Map:
                        {
                            content.Append("<changefreq>weekly</changefreq>\r\n<priority>0.8</priority>");
                            break;
                        }

                    case FileType.Page:
                    case FileType.Static:
                    case FileType.Custom:
                        {
                            content.Append("<changefreq>monthly</changefreq>\r\n<priority>0.6</priority>");
                            break;
                        }
                }

                content.Append("</url>");
            }

            content.Append("</urlset>");

            IOHelper.WriteText(IO.Path.Combine(this.Directory, "sitemap.xml"), content.ToString(), Encoding.UTF8);
        }

        protected virtual void InitializeIndexPages()
        {
            this.Content.Pages.Add(new Page()
                                       {
                                           Keywords = new List<string>() {this.Keywords[0]},
                                           Type = FileType.Index
                                       });
        }

        protected virtual void InitializeRegularPages()
        {
            int used = 1;

            Sequence sequence = new Sequence();

            while (used < this.Keywords.Count)
            {
                int number = this.Random.Next((this.Settings as TaskSettings).KeywordsOnPageMin, (this.Settings as TaskSettings).KeywordsOnPageMax);
                List<string> keywords = new List<string>(number);

                for (int i = 0; i < number; i++)
                {
                    keywords.Add(this.Keywords[used + i]);
                }

                this.Content.Pages.Add(new Page()
                                           {
                                               Keywords = keywords,
                                               Type = FileType.Page,
                                               ID = sequence.Invoke()
                                           });
            }
        }

        protected virtual void InitializeStaticPages()
        {
            Sequence sequence = new Sequence();
            for (int i = 0; i < (this.Settings as TaskSettings).StaticPages.Count; i++)
            {
                this.Content.Pages.Add(new Page()
                                           {
                                               Keywords = new List<string>() {(this.Settings as TaskSettings).StaticPages[i]},
                                               Type = FileType.Static,
                                               ID = sequence.Invoke()
                                           });
            }
        }

        protected virtual void InitializeCategoriesPages()
        {
            
        }

        protected virtual void InitializeCustomPages()
        {
            List<IFile> items = this.Template.Select(FileType.Custom);
            Sequence sequence = new Sequence();

            for (int i = 0; i < items.Count; i++)
            {
                // Create page name
                string name = items[i].Path;
                if (!name.ToLower().StartsWith("http"))
                {
                    if (name.StartsWith(this.Template.Path))
                    {
                        name = name.Substring(this.Template.Path.Length);
                    }
                }

                // Create page
                this.Content.Pages.Add(new Page()
                                           {
                                               Keywords = new List<string>() {items[i].Items[this.Random.Next(items[i].Items.Length)]},
                                               Type = FileType.Custom,
                                               Name = IO.Path.Combine(this.Directory, name),
                                               ID = sequence.Invoke(),
                                               Content = items[i].Content
                                           });
            }
        }

        protected abstract string MakePageName(IPage Page);

        protected abstract string MakePageURL(IPage Page);

        protected virtual void MakePages()
        {
            // Index Pages
            this.MakePages(FileType.Index);

            // Static Pages
            if ((this.Settings as TaskSettings).StaticPages.Count != 0)
            {
                this.MakePages(FileType.Static);
            }

            // Custom Pages
            if (this.Template.Select(FileType.Custom).Count != 0)
            {
                this.MakeCustomPages();
            }

            // Category Pages
            if ((this.Settings as TaskSettings).Categories.Count != 0)
            {
                this.MakePages(FileType.Category);
            }

            // Regular Pages
            this.MakePages(FileType.Page);

            if ((this.Settings as TaskSettings).Map != MapType.None)
            {
                this.MakeMap();
            }
        }

        public virtual List<FileTokenExecutor> FileTokens
        {
            get { return this.TokenExecutor.FileTokens; }
            set { this.TokenExecutor.FileTokens = value; }
        }

        protected virtual void InitializeCategories()
        {
            for (int i = 0; i < (this.Settings as TaskSettings).Categories.Count; i++)
            {
                this.Content.Categories.Add(new TaskCategory((this.Settings as TaskSettings).Categories[i]));
            }

            // Process tokens in categories
            foreach (TaskCategory category in this.Content.Categories)
            {
                category.Keyword = this.ReplaceTokens(category.Keyword).Clear();
            }
        }

        /// <summary>
        /// Replace non-paged tokens
        /// </summary>
        /// <param name="Content"></param>
        /// <returns></returns>
        protected virtual string ReplaceTokens(string Content)
        {
            return this.TokenExecutor.Invoke(Content);
        }

        public virtual void Invoke()
        {
            // Copy template files
            this.CopyTemplateFiles();

            // Make pages
            this.MakePages();

            // Robots
            if ((this.Settings as TaskSettings).Robots != RobotsType.None)
            {
                this.MakeRobots();
            }

            // RSS
            if ((this.Settings as TaskSettings).RSS != RSSType.None)
            {
                this.MakeRSS();
            }
        }

        protected virtual void MakeRobots()
        {
            string content = (this.Settings as TaskSettings).RobotsContent;

            if ((this.Settings as TaskSettings).Map == MapType.XML || (this.Settings as TaskSettings).Map == MapType.XMLHTML || (this.Settings as TaskSettings).Map == MapType.XMLAutoHTML)
            {
                if (content.Contains("Sitemap:"))
                {
                    content = content.Substring(0, content.LastIndexOf("Sitemap:"));
                }
            }
            else
            {
                if (content.Contains("Sitemap:"))
                {
                    content = string.IsNullOrEmpty(this.URL) ? content.Substring(0, content.LastIndexOf("Sitemap:")) : content.Replace("[SITEMAP]", this.URL + "sitemap.xml");
                }
            }

            IOHelper.WriteText(IO.Path.Combine(this.Directory, "robots.txt"), content, Encoding.Default);
        }

        protected virtual DateTime MakeRandomDateTime()
        {
            int month = this.Random.Next(1, 13);
            DateTime date =
                new DateTime(
                    this.Random.Next((this.Settings as TaskSettings).GeneralFileDirectoryModificationStartTime.Year, (this.Settings as TaskSettings).GeneralFileDirectoryModificationEndTime.Year + 1),
                    month,
                    this.Random.Next(1,
                                     new DateTime(DateTime.Now.Year, 1, 1).AddMonths(month).AddMonths(1).Subtract(
                                         new TimeSpan(1, 0, 0, 0)).Day + 1), this.Random.Next(0, 24), this.Random.Next(0, 60), this.Random.Next(0, 60));

            return date;
        }

        protected virtual void CopyTemplateFiles()
        {
            List<IFile> items = this.Template.Select(FileType.File);

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Path.ToLower().Contains("http"))
                {
                    continue;
                }

                string destination = this.Directory;
                if (items[i].Path.ToLower().StartsWith(this.Template.Path.ToLower()))
                {
                    destination = IO.Path.Combine(this.Directory, items[i].Path.Substring(this.Template.Path.Length));
                }

                IOHelper.CopyFile(items[i].Path, destination, this.MakeRandomDateTime());
            }
        }

        protected virtual void MakeRSS()
        {
            if (this.URL == string.Empty)
            {
                return;
            }

            string content = string.Empty;

            switch ((this.Settings as TaskSettings).RSSContent)
            {
                case RSSContentType.Generate:
                    {
                        content = this.MakeGeneratedRSS();
                        break;
                    }

                case RSSContentType.PageContent:
                    {
                        content = this.MakeContentRSS();
                        break;
                    }
            }

            IOHelper.WriteText(IO.Path.Combine(this.Directory, "feed.xml"), content, Encoding.UTF8);
        }

        protected virtual string MakeGeneratedRSS()
        {
            StringBuilder content = new StringBuilder(1500);
            content.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            content.AppendLine("<rss version=\"2.0\" xmlns:content=\"http://purl.org/rss/1.0/modules/content/\" xmlns:wfw=\"http://wellformedweb.org/CommentAPI/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:atom=\"http://www.w3.org/2005/Atom\" xmlns:sy=\"http://purl.org/rss/1.0/modules/syndication/\" xmlns:slash=\"http://purl.org/rss/1.0/modules/slash/\">");
            content.AppendLine("<channel>");

            List<IPage> items = (from IPage page in this.Content.Pages
                                where page.Type == FileType.Page
                                select page).ToList();
                
            for (int i = 0; i < (this.Settings as TaskSettings).RSSLength; i++)
            {
                string title = string.Empty;
                string url = string.Empty;

                if (i == 0)
                {
                    title = (this.Index < (this.Settings as TaskSettings).TokenTitle.Count ? (this.Settings as TaskSettings).TokenTitle[this.Index] : this.Keywords[0]);
                    url = this.URL;
                }
                else
                {
                    if (items.Count <= (i - 1))
                    {
                        break;
                    }

                    title = items[i - 1].Keywords[0];
                    url = items[i - 1].URL;
                }

                content.AppendLine("<item>");
                content.AppendLine("<title>" + title + "</title>");
                content.AppendLine("<link>" + url + "</link>");
                content.AppendLine("<description><![CDATA[" + this.ReplaceTokens("[TEXT]").ClearHTML().Clear().Cut(500) + "[...]]]></description>");
                content.AppendLine("</item>");
            }

            content.AppendLine("</channel>");
            content.AppendLine("</rss>");

            return content.ToString();
        }

        protected virtual string MakeContentRSS()
        {
            StringBuilder content = new StringBuilder(1500);
            content.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            content.AppendLine("<rss version=\"2.0\" xmlns:content=\"http://purl.org/rss/1.0/modules/content/\" xmlns:wfw=\"http://wellformedweb.org/CommentAPI/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:atom=\"http://www.w3.org/2005/Atom\" xmlns:sy=\"http://purl.org/rss/1.0/modules/syndication/\" xmlns:slash=\"http://purl.org/rss/1.0/modules/slash/\">");
            content.AppendLine("<channel>");

            List<IPage> items = (from IPage page in this.Content.Pages
                                 where page.Type == FileType.Page
                                 select page).ToList();

            for (int i = 0; i < (this.Settings as TaskSettings).RSSLength; i++)
            {
                string title = string.Empty;
                string url = string.Empty;
                string pageContent = string.Empty;

                if (i == 0)
                {
                    List<IPage> index = (from IPage page in this.Content.Pages
                                         where page.Type == FileType.Image && page.ContinueNumber == 0
                                         select page).ToList();

                    title = (this.Index < (this.Settings as TaskSettings).TokenTitle.Count ? (this.Settings as TaskSettings).TokenTitle[this.Index] : this.Keywords[0]);
                    url = this.URL;
                    pageContent = index[0].Content;
                }
                else
                {
                    if (items.Count <= (i - 1))
                    {
                        break;
                    }

                    title = items[i - 1].Keywords[0];
                    url = items[i - 1].URL;
                    pageContent = items[i - 1].Content;
                }

                content.AppendLine("<item>");
                content.AppendLine("<title>" + title + "</title>");
                content.AppendLine("<link>" + url + "</link>");
                content.AppendLine("<description><![CDATA[" + pageContent.ClearHTML().Clear().Cut(500) + "[...]]]></description>");
                content.AppendLine("</item>");
            }

            content.AppendLine("</channel>");
            content.AppendLine("</rss>");

            return content.ToString();
        }

        protected bool Paused { get; set; }

        public virtual void Pause()
        {
            this.Paused = !this.Paused;
            this.State = this.Paused ? TaskStateType.Paused : TaskStateType.Running;
        }

        public virtual void Stop()
        {

        }

        protected virtual void MakeHTMLLinks()
        {
            for (int i = 0; i < this.Content.Pages.Count; i++)
            {
                this.HTMLLinks.Add(new HTMLLink()
                                       {
                                           URL = this.Content.Pages[i].URL,
                                           Keywords = this.Content.Pages[i].Keywords
                                       });
            }
        }

        public abstract void Save();
    }
}
