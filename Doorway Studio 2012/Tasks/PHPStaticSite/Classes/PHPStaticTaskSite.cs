using System.Collections.Generic;
using System.Linq;
using System.Text;
using Umax.Classes.Helpers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Plugins.Tasks.Classes;
using Umax.Plugins.Tasks.Common;
using Umax.Plugins.Tasks.Enums;
using System.IO;

namespace Umax.Plugins.Tasks.PHPStaticSite.Classes
{
    public abstract class PHPStaticTaskSite : TaskSite
    {
        public override void Invoke()
        {
            base.Invoke();

            this.MakePHPFile();
        }

        protected abstract string MakePHPFileContent();

        protected virtual void MakePHPFile()
        {
            string content = this.MakePHPFileContent();

            content = content.Replace("[PAGE]", (this.Settings as PHPStaticSiteTaskSettings).PageNamesRegularPagesName);
            content = content.Replace("[CATEGORY]", (this.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesName);
            content = content.Replace("[STATICPAGE]", (this.Settings as PHPStaticSiteTaskSettings).PageNamesStaticPagesName);
            content = content.Replace("[INDECXONTINUE]", (this.Settings as PHPStaticSiteTaskSettings).PageNamesMainPageContinuesName);
            content = content.Replace("[CATEGORYCONTINUE1]", (this.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesName);
            content = content.Replace("[CATEGORYCONTINUE2]", (this.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesContinuesName);

            IOHelper.WriteText(Path.Combine(this.Directory, "index.php"), content, Encoding.Default);
        }

        protected override string MakePageName(IPage Page)
        {
            string name = string.Empty;

            switch (Page.Type)
            {
                case FileType.Index:
                    {
                        if (Page.ContinueNumber == 0)
                        {
                            name = "index";
                        }
                        else
                        {
                            name = "index" + "-" + (Page.ContinueNumber + 1).ToString();
                        }

                        break;
                    }

                case FileType.Page:
                    {
                        name = (this.Settings as PHPStaticSiteTaskSettings).PageNamesRegularPagesName + "-" + (Page.ID + 1).ToString();

                        break;
                    }

                case FileType.Static:
                    {
                        name = (this.Settings as PHPStaticSiteTaskSettings).PageNamesStaticPagesName + "-" + (Page.ID + 1).ToString();

                        break;
                    }

                case FileType.Category:
                    {
                        if (Page.ContinueNumber == 0)
                        {
                            name = (this.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesName + "-" + (Page.ID + 1).ToString();
                        }
                        else
                        {
                            // Find page where ContinueNumber == 0
                            List<IPage> items = (from IPage item in this.Content.Pages
                                                 where item.Type == FileType.Category && item.Category == Page.Category && item.ContinueNumber == 0
                                                 select item).ToList();

                            if (items.Count == 0)
                            {
                                name = (this.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesName + "-" + (Page.ID + 1).ToString() +
                                       (this.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesContinuesName + "-" + (Page.ContinueNumber + 1).ToString();
                            }
                            else
                            {
                                name = (this.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesName + "-" + (items[0].ID + 1).ToString() +
                                       (this.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesContinuesName + "-" + (Page.ContinueNumber + 1).ToString();
                            }
                        }

                        break;
                    }

                case FileType.Map:
                    {
                        name = "sitemap-" + (Page.ID + 1).ToString();

                        break;
                    }
            }

            return name;
        }

        protected override string MakePageURL(IPage Page)
        {
            string url = string.Empty;
            switch (Page.Type)
            {
                case FileType.Index:
                    {
                        switch ((this.Settings as TaskSettings).TokenMainLink)
                        {
                            case TokenMainLinkType.Index:
                                {
                                    if (Page.ContinueNumber == 0)
                                    {
                                        url = "index.php";
                                    }
                                    else
                                    {
                                        url = "index.php?" + (this.Settings as PHPStaticSiteTaskSettings).PageNamesMainPageContinuesName + "=" + (Page.ContinueNumber + 1).ToString();
                                    }

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

                        break;
                    }

                case FileType.Page:
                    {
                        url = "index.php?" + (this.Settings as PHPStaticSiteTaskSettings).PageNamesRegularPagesName + "=" + (Page.ID + 1).ToString();

                        break;
                    }

                case FileType.Static:
                    {
                        url = "index.php?" + (this.Settings as PHPStaticSiteTaskSettings).PageNamesStaticPagesName + "=" + (Page.ID + 1).ToString();

                        break;
                    }

                case FileType.Category:
                    {
                        if (Page.ContinueNumber == 0)
                        {
                            url = "index.php?" + (this.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesName + "=" + (Page.ID + 1).ToString();
                        }
                        else
                        {
                            // Find page where ContinueNumber == 0
                            List<IPage> items = (from IPage item in this.Content.Pages
                                                 where item.Type == FileType.Category && item.Category == Page.Category && item.ContinueNumber == 0
                                                 select item).ToList();

                            if (items.Count == 0)
                            {
                                url = "index.php?" + (this.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesName + "=" + (Page.ID + 1).ToString() +
                                      (this.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesContinuesName + "=" + (Page.ContinueNumber + 1).ToString() + ".txt";
                            }
                            else
                            {
                                url = "index.php?" + (this.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesName + "=" + (items[0].ID + 1).ToString() +
                                      (this.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesContinuesName + "=" + (Page.ContinueNumber + 1).ToString() + ".txt";
                            }
                        }

                        break;
                    }

                case FileType.Map:
                    {
                        url = "index.php?sitemap=" + (Page.ID + 1).ToString();
                        break;
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
    }
}
