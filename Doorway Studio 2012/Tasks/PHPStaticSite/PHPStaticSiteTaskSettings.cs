using System;
using System.Xml.Serialization;
using Umax.Interfaces.Tasks;
using Umax.Plugins.Tasks.Common;

namespace Umax.Plugins.Tasks.PHPStaticSite
{
    [Serializable, XmlRoot(ElementName = "PHPStaticSiteTaskSettings")]
    public class PHPStaticSiteTaskSettings : TaskSettings
    {
        public PHPStaticSiteTaskSettings()
        {
            this.PageNamesMainPageContinues = false;
            this.PageNamesMainPageContinuesName = "index";
            this.PageNamesMainPageContinuesKeywordsPerPage = 10;
            this.PageNamesRegularPagesName = "page";
            this.PageNamesStaticPagesName = "static";
            this.PageNamesCategoryPagesName = "category";
            this.PageNamesCategoryPagesContinues = false;
            this.PageNamesCategoryPagesContinuesName = "page";
            this.PageNamesCategoryPagesContinuesKeywordsPerPage = 10;
        }

        public PHPStaticSiteTaskSettings(ITaskSettings Settings)
            : this()
        {
            if (!(Settings is TaskSettings))
            {
                return;
            }

            // Apply Settings settings
            this.Categories = (Settings as TaskSettings).Categories;
            this.CategoriesDistribution = (Settings as TaskSettings).CategoriesDistribution;

            this.Entrance = (Settings as TaskSettings).Entrance;
            this.EntranceAcceptor = (Settings as TaskSettings).EntranceAcceptor;
            this.EntranceAcceptorURL = (Settings as TaskSettings).EntranceAcceptorURL;
            this.EntranceCode = (Settings as TaskSettings).EntranceCode;
            this.EntranceInsert = (Settings as TaskSettings).EntranceInsert;
            this.EntranceJSEncrypt = (Settings as TaskSettings).EntranceJSEncrypt;

            this.FileTokens = (Settings as TaskSettings).FileTokens;

            this.FTP = (Settings as TaskSettings).FTP;
            this.FTPData = (Settings as TaskSettings).FTPData;
            this.FTPDeleteWhenUpload = (Settings as TaskSettings).FTPDeleteWhenUpload;
            this.FTPExportPath = (Settings as TaskSettings).FTPExportPath;

            this.GeneralArchive = (Settings as TaskSettings).GeneralArchive;
            this.GeneralArchiveName = (Settings as TaskSettings).GeneralArchiveName;
            this.GeneralSavePath = (Settings as TaskSettings).GeneralSavePath;
            this.GeneralSiteCount = (Settings as TaskSettings).GeneralSiteCount;
            this.GeneralSubDirectories = (Settings as TaskSettings).GeneralSubDirectories;
            this.GeneralThreadCount = (Settings as TaskSettings).GeneralThreadCount;
            this.GeneralUrls = (Settings as TaskSettings).GeneralUrls;

            this.ImageMakerName = (Settings as TaskSettings).ImageMakerName;
            this.Images = (Settings as TaskSettings).Images;

            this.KeywordsGenerateFourWords = (Settings as TaskSettings).KeywordsGenerateFourWords;
            this.KeywordsGenerateFourWordsMax = (Settings as TaskSettings).KeywordsGenerateFourWordsMax;
            this.KeywordsGenerateFourWordsMin = (Settings as TaskSettings).KeywordsGenerateFourWordsMin;
            this.KeywordsGenerateThreeWords = (Settings as TaskSettings).KeywordsGenerateThreeWords;
            this.KeywordsGenerateThreeWordsMax = (Settings as TaskSettings).KeywordsGenerateThreeWordsMax;
            this.KeywordsGenerateThreeWordsMin = (Settings as TaskSettings).KeywordsGenerateThreeWordsMin;
            this.KeywordsGenerateTwoWords = (Settings as TaskSettings).KeywordsGenerateTwoWords;
            this.KeywordsGenerateTwoWordsMax = (Settings as TaskSettings).KeywordsGenerateTwoWordsMax;
            this.KeywordsGenerateTwoWordsMin = (Settings as TaskSettings).KeywordsGenerateTwoWordsMin;
            this.KeywordsID = (Settings as TaskSettings).KeywordsID;
            this.KeywordsMerge = (Settings as TaskSettings).KeywordsMerge;
            this.KeywordsMergeUsage = (Settings as TaskSettings).KeywordsMergeUsage;
            this.KeywordsMergeFileEncoding = (Settings as TaskSettings).KeywordsMergeFileEncoding;
            this.KeywordsMergeFilePath = (Settings as TaskSettings).KeywordsMergeFilePath;
            this.KeywordsMergeID = (Settings as TaskSettings).KeywordsMergeID;
            this.KeywordsMergeMax = (Settings as TaskSettings).KeywordsMergeMax;
            this.KeywordsMergeMin = (Settings as TaskSettings).KeywordsMergeMin;
            this.KeywordsOnPageMax = (Settings as TaskSettings).KeywordsOnPageMax;
            this.KeywordsOnPageMin = (Settings as TaskSettings).KeywordsOnPageMin;
            this.KeywordsReorder = (Settings as TaskSettings).KeywordsReorder;
            this.KeywordsReorderWords = (Settings as TaskSettings).KeywordsReorderWords;
            this.KeywordsReorderWordsMaxPercent = (Settings as TaskSettings).KeywordsReorderWordsMaxPercent;
            this.KeywordsReorderWordsMinPercent = (Settings as TaskSettings).KeywordsReorderWordsMinPercent;
            this.KeywordsSelect = (Settings as TaskSettings).KeywordsSelect;
            this.KeywordsSelectMax = (Settings as TaskSettings).KeywordsSelectMax;
            this.KeywordsSelectMin = (Settings as TaskSettings).KeywordsSelectMin;
            this.KeywordsSynonyms = (Settings as TaskSettings).KeywordsSynonyms;
            this.KeywordsSynonymsFileEncoding = (Settings as TaskSettings).KeywordsSynonymsFileEncoding;
            this.KeywordsSynonymsFilePath = (Settings as TaskSettings).KeywordsSynonymsFilePath;
            this.KeywordsSynonymsID = (Settings as TaskSettings).KeywordsSynonymsID;
            this.KeywordsSynonymsMaxPercent = (Settings as TaskSettings).KeywordsSynonymsMaxPercent;
            this.KeywordsSynonymsMinPercent = (Settings as TaskSettings).KeywordsSynonymsMinPercent;

            this.Links = (Settings as TaskSettings).Links;
            this.LinksSave = (Settings as TaskSettings).LinksSave;
            this.LinksSaveEncoding = (Settings as TaskSettings).LinksSaveEncoding;
            this.LinksSavePath = (Settings as TaskSettings).LinksSavePath;

            this.Map = (Settings as TaskSettings).Map;
            this.MapHTML = (Settings as TaskSettings).MapHTML;
            this.MapHTMLLinksOnPageMax = (Settings as TaskSettings).MapHTMLLinksOnPageMax;
            this.MapHTMLLinksOnPageMin = (Settings as TaskSettings).MapHTMLLinksOnPageMin;
            this.MapHTMLName = (Settings as TaskSettings).MapHTMLName;
            this.MapIncludeCategories = (Settings as TaskSettings).MapIncludeCategories;
            this.MapIncludeCustomPages = (Settings as TaskSettings).MapIncludeCustomPages;
            this.MapIncludeIndex = (Settings as TaskSettings).MapIncludeIndex;
            this.MapIncludeRegularPages = (Settings as TaskSettings).MapIncludeRegularPages;
            this.MapIncludeStaticPages = (Settings as TaskSettings).MapIncludeStaticPages;
            this.MapXMLName = (Settings as TaskSettings).MapXMLName;

            this.PresetID = (Settings as TaskSettings).PresetID;

            this.Robots = (Settings as TaskSettings).Robots;
            this.RobotsContent = (Settings as TaskSettings).RobotsContent;

            this.RSS = (Settings as TaskSettings).RSS;
            this.RSSContent = (Settings as TaskSettings).RSSContent;
            this.RSSLength = (Settings as TaskSettings).RSSLength;

            this.StaticPages = (Settings as TaskSettings).StaticPages;

            this.TemplateID = (Settings as TaskSettings).TemplateID;

            this.TextLinks = (Settings as TaskSettings).TextLinks;
            this.TextLinksLengthMax = (Settings as TaskSettings).TextLinksLengthMax;
            this.TextLinksLengthMin = (Settings as TaskSettings).TextLinksLengthMin;
            this.TextLinksNumberMax = (Settings as TaskSettings).TextLinksNumberMax;
            this.TextLinksNumberMin = (Settings as TaskSettings).TextLinksNumberMin;
            this.TextMakerName = (Settings as TaskSettings).TextMakerName;

            this.TokenCounter = (Settings as TaskSettings).TokenCounter;
            this.TokenExternalLinks = (Settings as TaskSettings).TokenExternalLinks;
            this.TokenInternalLinks = (Settings as TaskSettings).TokenInternalLinks;
            this.TokenMainLink = (Settings as TaskSettings).TokenMainLink;
            this.TokenMainLinks = (Settings as TaskSettings).TokenMainLinks;
            this.TokenSite = (Settings as TaskSettings).TokenSite;
            this.TokenTitle = (Settings as TaskSettings).TokenTitle;

            this.WorkSpaceID = (Settings as TaskSettings).WorkSpaceID;
        }

        #region Page Names
        /// <summary>
        /// Gets or sets a value indicating whether there should be generated main page continue pages
        /// </summary>
        [XmlElement(ElementName = "PageNamesMainPageContinues")]
        public bool PageNamesMainPageContinues { get; set; }

        /// <summary>
        /// Gets or sets main page continues name
        /// </summary>
        [XmlElement(ElementName = "PageNamesMainPageContinuesName")]
        public string PageNamesMainPageContinuesName { get; set; }

        /// <summary>
        /// Gets or sets main page continues number keywords per page
        /// </summary>
        [XmlElement(ElementName = "PageNamesMainPageContinuesKeywordsPerPage")]
        public int PageNamesMainPageContinuesKeywordsPerPage { get; set; }

        /// <summary>
        /// Gets or sets regular page names
        /// </summary>
        [XmlElement(ElementName = "PageNamesRegularPagesName")]
        public string PageNamesRegularPagesName { get; set; }

        /// <summary>
        /// Gets or sets static page names
        /// </summary>
        [XmlElement(ElementName = "PageNamesStaticPagesName")]
        public string PageNamesStaticPagesName { get; set; }

        /// <summary>
        /// Gets or sets categories page names
        /// </summary>
        [XmlElement(ElementName = "PageNamesCategoryPagesName")]
        public string PageNamesCategoryPagesName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether there should be generated categories pages continue pages
        /// </summary>
        [XmlElement(ElementName = "PageNamesCategoryPagesContinues")]
        public bool PageNamesCategoryPagesContinues { get; set; }

        /// <summary>
        /// Gets or sets categories page continue pages names
        /// </summary>
        [XmlElement(ElementName = "PageNamesCategoryPagesContinuesName")]
        public string PageNamesCategoryPagesContinuesName { get; set; }

        /// <summary>
        /// Gets or sets categories page continues number keywords per page
        /// </summary>
        [XmlElement(ElementName = "PageNamesCategoryPagesContinuesKeywordsPerPage")]
        public int PageNamesCategoryPagesContinuesKeywordsPerPage { get; set; }
        #endregion
    }
}
