using System.Collections.Generic;
using System.Linq;
using Umax.Classes.Helpers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Plugins.Tasks.Classes;
using Umax.Plugins.Tasks.Common;
using Umax.Plugins.Tasks.Enums;
using IO = System.IO;

namespace Umax.Plugins.Tasks.HTMLStaticSite.Classes
{
    public class HTMLStaticTaskSite : TaskSite
    {
        protected override string MakePageName(IPage Page)
        {
            string name = string.Empty;

            switch (Page.Type)
            {
                case FileType.Index:
                    {
                        name = this.MakeIndexPageName(Page);

                        break;
                    }

                case FileType.Page:
                    {
                        name = this.MakeRegularPageName(Page);

                        break;
                    }

                case FileType.Static:
                    {
                        name = this.MakeStaticPageName(Page);

                        break;
                    }

                case FileType.Category:
                    {
                        name = this.MakeCategoryPageName(Page);

                        break;
                    }

                case FileType.Map:
                    {
                        name = this.MakeMapPageName(Page);

                        break;
                    }
            }

            // Number
            name = name.Replace("[N]", (Page.ID + 1).ToString());

            // Random number
            while (name.Contains("[RN]"))
            {
                int startIndex = name.IndexOf("[RN]");
                name = name.Remove(startIndex, 4);
                name = name.Insert(startIndex, this.Random.Next(0, 100).ToString());
            }

            name = StringHelper.Cut(IO.Path.Combine(this.Directory, name.Replace("/", "\\").Replace(" ", (this.Settings as HTMLStaticSiteTaskSettings).PageNamesGeneralSeparator)
                                                                                                                             .Trim().TrimEnd('-').Clear()), 255 - (this.Settings as HTMLStaticSiteTaskSettings).PageNamesGeneralExtension.Length);

            // Tar
            if ((this.Settings as HTMLStaticSiteTaskSettings).GeneralArchive  == ArchiveType.TarGz)
            {
                name = name.Cut(100 - (this.Settings as HTMLStaticSiteTaskSettings).PageNamesGeneralExtension.Length);
            }

            // Extension
            if (Page.Type != FileType.Custom)
            {
                name += (this.Settings as HTMLStaticSiteTaskSettings).PageNamesGeneralExtension;
            }

            return name;
        }

        protected virtual string MakeIndexPageName(IPage Page)
        {
            return Page.ContinueNumber == 0
                       ? "index"
                       : (this.Settings as HTMLStaticSiteTaskSettings).PageNamesMainPageContinuesName.Replace("[Name]", "index").Replace("[N]", Page.ContinueNumber.ToString());
        }

        protected virtual string MakeCategoryPageName(IPage Page)
        {
            string name = Page.ContinueNumber == 0 ? (this.Settings as HTMLStaticSiteTaskSettings).PageNamesCategoryPagesName : (this.Settings as HTMLStaticSiteTaskSettings).PageNamesCategoryPagesContinuesName.Replace("[N]", (Page.ContinueNumber + 1).ToString());

            switch ((this.Settings as HTMLStaticSiteTaskSettings).PageNamesCategoryPages)
            {
                case PageNameType.Keyword:
                    {
                        name = name.Replace("[Name]", Page.Category.Keyword);
                        break;
                    }

                case PageNameType.KeywordToEn:
                    {
                        name = name.Replace("[Name]", Page.Category.Keyword.Translite());

                        break;
                    }

                case PageNameType.NumberGlobal:
                    {
                        name = name.Replace("[Name]", (Page.ID + 1).ToString());
                        break;
                    }

                case PageNameType.NumberLocal:
                    {
                        List<IPage> items = (from IPage item in this.Content.Pages
                                             where item.Category == Page.Category && item.Type == FileType.Category
                                             orderby item.ID
                                             select item).ToList();

                        for (int i = 0; i < items.Count; i++)
                        {
                            if (items[i] == Page)
                            {
                                name = name.Replace("[Name]", (i + 1).ToString());
                            }
                        }

                        break;
                    }

                case PageNameType.Custom:
                    {
                        name = name.Replace("[Name]", string.Empty);
                        break;
                    }
            }

            // Parent category name
            if ((Page.Category as TaskCategory).Parent == null)
            {
                name = name.Replace("[CName]", string.Empty);
            }
            else
            {
                List<IPage> items = (from IPage item in this.Content.Pages
                                     where item.Category == (Page.Category as TaskCategory).Parent && item.ContinueNumber == 0
                                     select item).ToList();

                if (items.Count == 0)
                {
                    name = name.Replace("[CName]", string.Empty);
                }
                else
                {
                    string parent = items[0].Path;

                    if (parent.StartsWith(this.Directory))
                    {
                        parent = parent.Substring(0, this.Directory.Length);
                    }

                    if (parent.EndsWith((this.Settings as HTMLStaticSiteTaskSettings).PageNamesGeneralSeparator))
                    {
                        parent = parent.Substring(0, parent.Length - (this.Settings as HTMLStaticSiteTaskSettings).PageNamesGeneralSeparator.Length);
                    }

                    name = name.Replace("[CName]", parent);
                }
            }

            return name;
        }

        protected virtual string MakeRegularPageName(IPage Page)
        {
            string name = (this.Settings as HTMLStaticSiteTaskSettings).PageNamesRegularPagesName;
            switch ((this.Settings as HTMLStaticSiteTaskSettings).PageNamesRegularPages)
            {
                case PageNameType.Keyword:
                case PageNameType.KeywordToEn:
                    {
                        string keywords = Page.Keywords.AsString();

                        if ((this.Settings as HTMLStaticSiteTaskSettings).PageNamesRegularPages == PageNameType.KeywordToEn)
                        {
                            keywords = keywords.Translite();
                        }

                        name = name.Replace("[Name]", keywords);
                        break;
                    }

                case PageNameType.NumberLocal:
                    {
                        List<IPage> items = (from IPage item in this.Content.Pages
                                             where item.Category == Page.Category && item.Type == FileType.Page
                                             orderby item.ID
                                             select item).ToList();

                        for (int i = 0; i < items.Count; i++)
                        {
                            if (items[i] == Page)
                            {
                                name = name.Replace("[Name]", (i + 1).ToString()).Trim();
                            }
                        }

                        break;
                    }

                case PageNameType.NumberGlobal:
                    {
                        name = name.Replace("[Name]", (Page.ID + 1).ToString()).Trim();

                        break;
                    }

                case PageNameType.Custom:
                    {
                        name = name.Replace("[Name]", string.Empty).Trim();

                        break;
                    }
            }

            // Categories
            if (this.Content.Categories.Count != 0 && Page.Category != null)
            {
                List<IPage> items = (from IPage item in this.Content.Pages
                                     where item.Category == Page.Category && item.Type == FileType.Category && item.ContinueNumber == 0
                                     select item).ToList();

                if (items.Count != 0)
                {
                    string categoryName = items[0].Name.Replace((this.Settings as HTMLStaticSiteTaskSettings).PageNamesGeneralExtension, string.Empty);
                    if (categoryName.StartsWith(this.Directory))
                    {
                        categoryName = categoryName.Substring(this.Directory.Length);
                    }

                    name = name.Replace("[CName]", categoryName);
                }
                else
                {
                    name = name.Replace("[CName]", string.Empty);
                }
            }
            else
            {
                name = name.Replace("[CName]", string.Empty);
            }

            return name;
        }

        protected virtual string MakeStaticPageName(IPage Page)
        {
            string name = (this.Settings as HTMLStaticSiteTaskSettings).PageNamesStaticPagesName;
            switch ((this.Settings as HTMLStaticSiteTaskSettings).PageNamesStaticPages)
            {
                case PageNameType.Keyword:
                    {
                        name = name.Replace("[Name]", Page.Keywords[0]);

                        break;
                    }

                case PageNameType.KeywordToEn:
                    {
                        name = name.Replace("[Name]", Page.Keywords[0].Translite());
                        break;
                    }

                case PageNameType.NumberLocal:
                case PageNameType.NumberGlobal:
                    {
                        name = name.Replace("[Name]", Page.ID.ToString());
                        break;
                    }

                default:
                    {
                        name = name.Replace("[Name]", string.Empty);
                        break;
                    }
            }


            return name;
        }

        protected virtual string MakeMapPageName(IPage Page)
        {
            return (this.Settings as HTMLStaticSiteTaskSettings).MapHTMLName;
        }

        protected override string MakePageURL(IPage Page)
        {
            string url = string.Empty;

            if (Page.Type == FileType.Index)
            {
                switch ((this.Settings as TaskSettings).TokenMainLink)
                {
                    case TokenMainLinkType.Index:
                        {
                            url = "index" + (this.Settings as HTMLStaticSiteTaskSettings).PageNamesGeneralExtension;

                            break;
                        }

                    case TokenMainLinkType.Other:
                        {
                            if ((this.Settings as TaskSettings).TokenMainLinks.Count < this.Index)
                            {
                                url = (this.Settings as TaskSettings).TokenMainLinks[Index];
                            }

                            break;
                        }
                }
            }
            else
            {
                if (Page.Name.StartsWith(this.Directory))
                {
                    url = Page.Name.Substring(this.Directory.Length);
                }
                else
                {
                    return Page.Name;
                }
            }

            if (this.URL != string.Empty)
            {
                url = this.URL + url;
            }
            else
            {
                url = "/" + url;
            }

            while (url.Contains("\\"))
            {
                url = url.Replace("\\", "/");
            }

            if (url.StartsWith("http://"))
            {
                while (url.IndexOf("//", 7) >= 0)
                {
                    url = "http://" + url.Substring(7).Replace("//", "/");
                }
            }
            else
            {
                while (url.Contains("//"))
                {
                    url = url.Replace("//", "/");
                }
            }

            return url;
        }

        public override void Save()
        {

        }
    }
}
