using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Tasks;
using Umax.Plugins.Tasks.Classes;
using Umax.Plugins.Tasks.Enums;

namespace Umax.Plugins.Tasks.Common
{
    [Serializable, XmlRootAttribute(ElementName = "TaskSettings")]
    public class TaskSettings : ITaskSettings
    {
        public TaskSettings()
        {
            this.GeneralSiteCount = 1;
            this.GeneralThreadCount = 1;
            this.GeneralUrls = new List<string>();

            this.WorkSpaceID = -1;
            this.PresetID = -1;
            this.TemplateID = -1;

            this.GeneralSavePath = string.Empty;
            this.GeneralSubDirectories = SubDirectoriesType.KeywordNumber;

            this.GeneralFileDirectoryModificationStartTime = DateTime.Now;
            this.GeneralFileDirectoryModificationEndTime = DateTime.Now;

            this.GeneralArchive = ArchiveType.None;
            this.GeneralArchiveName = string.Empty;

            this.ImageMakerName = string.Empty;

            this.FileTokens = new List<FileToken>();

            this.KeywordsID = -1;
            this.KeywordsSelect = KeywordsSelectType.All;
            this.KeywordsSelectMin = 500;
            this.KeywordsSelectMax = 1000;
            this.KeywordsOnPageMin = 1;
            this.KeywordsOnPageMax = 3;
            this.KeywordsReorder = false;
            this.KeywordsReorderWords = false;
            this.KeywordsReorderWordsMinPercent = 10;
            this.KeywordsReorderWordsMaxPercent = 15;
            this.KeywordsSynonyms = KeywordsSynonymsType.None;
            this.KeywordsSynonymsID = -1;
            this.KeywordsSynonymsFilePath = string.Empty;
            this.KeywordsSynonymsFileEncoding = EncodingType.ANSI;
            this.KeywordsSynonymsMinPercent = 15;
            this.KeywordsSynonymsMaxPercent = 20;
            this.KeywordsMerge = KeywordsMergeType.None;
            this.KeywordsMergeID = -1;
            this.KeywordsMergeFilePath = string.Empty;
            this.KeywordsMergeFileEncoding = EncodingType.ANSI;
            this.KeywordsMergeMin = 1;
            this.KeywordsMergeMax = 3;
            this.KeywordsGenerateTwoWords = false;
            this.KeywordsGenerateTwoWordsMin = 20;
            this.KeywordsGenerateTwoWordsMax = 30;
            this.KeywordsGenerateThreeWords = false;
            this.KeywordsGenerateThreeWordsMin = 20;
            this.KeywordsGenerateThreeWordsMax = 30;
            this.KeywordsGenerateFourWords = false;
            this.KeywordsGenerateFourWordsMin = 20;
            this.KeywordsGenerateFourWordsMax = 30;

            this.CategoriesDistribution = CategoriesDistributionType.Random;
            this.Categories = new List<ICategory>();

            this.StaticPages = new List<string>();

            this.Map = MapType.None;
            this.MapIncludeIndex = true;
            this.MapIncludeRegularPages = true;
            this.MapIncludeStaticPages = true;
            this.MapIncludeCategories = true;
            this.MapIncludeCustomPages = true;
            this.MapHTML = MapHTMLType.SinglePage;
            this.MapHTMLName = "map-[N]";
            this.MapHTMLLinksOnPageMin = 50;
            this.MapHTMLLinksOnPageMax = 100;
            this.MapXMLName = "map.xml";

            this.TextMakerName = string.Empty;
            this.TextLinks = TextLinksType.None;
            this.TextLinksNumberMin = 1;
            this.TextLinksNumberMax = 4;
            this.TextLinksLengthMin = 1;
            this.TextLinksLengthMax = 4;

            this.Entrance = EntranceType.Custom;
            this.EntranceInsert = EntranceInsertType.Direct;
            this.EntranceAcceptorURL = string.Empty;
            this.EntranceAcceptor = EntranceAcceptorType.Static;
            this.EntranceJSEncrypt = false;
            this.EntranceCode = string.Empty;

            this.TokenMainLink = TokenMainLinkType.FullURL;
            this.TokenMainLinks = new List<string>();
            this.TokenTitle = new List<string>();
            this.TokenSite = new List<string>();
            this.TokenCounter = new List<string>();
            this.TokenInternalLinks = new List<string>();
            this.TokenExternalLinks = new List<string[]>();

            this.RSS = RSSType.None;
            this.RSSLength = 10;
            this.RSSContent = RSSContentType.Generate;

            this.Robots = RobotsType.None;
            this.RobotsContent = string.Empty;

            this.Links = new List<string>();
            this.LinksSave = LinksSaveType.DontSave;
            this.LinksSaveEncoding = EncodingType.ANSI;
            this.LinksSavePath = string.Empty;

            this.FTP = FTPType.None;
            this.FTPExportPath = string.Empty;
            this.FTPDeleteWhenUpload = true;
            this.FTPData = new List<FTPConnection>();

            this.Tags = new List<Tag>();
        }

        /// <summary>
        /// Gets settings name
        /// </summary>
        [XmlElement(ElementName = "Name")]
        public virtual string Name { get { return "TaskSettings"; } }

        #region Global
        /// <summary>
        /// WorkSpaceID ID
        /// </summary>
        [XmlElementAttribute(ElementName = "WorkSpaceID")]
        public int WorkSpaceID { get; set; }

        /// <summary>
        /// Preset ID
        /// </summary>
        [XmlElementAttribute(ElementName = "SelectedPresetID")]
        public int PresetID { get; set; }

        /// <summary>
        /// Template ID
        /// </summary>
        [XmlElementAttribute(ElementName = "TemplateID")]
        public int TemplateID { get; set; }
        #endregion

        #region General
        /// <summary>
        /// Number of sites
        /// </summary>
        [XmlElementAttribute(ElementName="GeneralSiteCount")]
        public int GeneralSiteCount { get; set; }
        /// <summary>
        /// URls
        /// </summary>
        [XmlElementAttribute(ElementName="GeneralUrls")]
        public List<string> GeneralUrls { get; set; }
        /// <summary>
        /// Number of threads
        /// </summary>
        [XmlElementAttribute(ElementName="GeneralThreadCount")]
        public int GeneralThreadCount { get; set; }
        /// <summary>
        /// Save path
        /// </summary>
        [XmlElementAttribute(ElementName="GeneralSavePath")]
        public string GeneralSavePath { get; set; }

        /// <summary>
        /// SubDirectories type
        /// </summary>
        [XmlElementAttribute(ElementName="GeneralSubDirectories")]
        public SubDirectoriesType GeneralSubDirectories { get; set; }

        public DateTime GeneralFileDirectoryModificationStartTime { get; set; }

        public DateTime GeneralFileDirectoryModificationEndTime { get; set; }
        /// <summary>
        /// Archive type
        /// </summary>
        [XmlElementAttribute(ElementName="GeneralArchive")]
        public ArchiveType GeneralArchive { get; set; }

        /// <summary>
        /// Archive name
        /// </summary>
        [XmlElementAttribute(ElementName="GeneralArchiveName")]
        public string GeneralArchiveName { get; set; }
        #endregion

        #region Images
        [XmlElementAttribute(ElementName = "Images")]
        public bool Images { get; set; }

        [XmlElementAttribute(ElementName = "ImageMakerName")]
        public string ImageMakerName { get; set; }
        #endregion

        #region FileTokens
        [XmlElementAttribute(ElementName="FileTokens")]
        public List<FileToken> FileTokens { get; set; }
        #endregion

        #region Keywords
        /// <summary>
        /// Keywords ID
        /// </summary>
        [XmlElement(ElementName="KeywordsID")]
        public int KeywordsID { get; set; }
        /// <summary>
        /// Select type
        /// </summary>
        [XmlElement(ElementName="KeywordsSelect")]
        public KeywordsSelectType KeywordsSelect { get; set; }
        /// <summary>
        /// Минимально выбираемое количество кейвордов
        /// </summary>
        [XmlElement(ElementName="KeywordsSelectMin")]
        public int KeywordsSelectMin { get; set; }
        /// <summary>
        /// Миксимально выбираемое количество кейвордов
        /// </summary>
        [XmlElement(ElementName="KeywordsSelectMax")]
        public int KeywordsSelectMax { get; set; }
        /// <summary>
        /// Минимальное количество кейвордов на странице
        /// </summary>
        [XmlElement(ElementName="KeywordsOnPageMin")]
        public int KeywordsOnPageMin { get; set; }
        /// <summary>
        /// Максимальное количество кейвордов на странице
        /// </summary>
        [XmlElement(ElementName="KeywordsOnPageMax")]
        public int KeywordsOnPageMax { get; set; }
        /// <summary>
        /// Перемешивание кейвордов
        /// </summary>
        [XmlElement(ElementName="KeywordsReorder")]
        public bool KeywordsReorder { get; set; }
        /// <summary>
        /// Перемешивание слов в кейвордах
        /// </summary>
        [XmlElement(ElementName="KeywordsReorderWords")]
        public bool KeywordsReorderWords { get; set; }
        /// <summary>
        /// Количество кейвордов в процентах, в котоых нужно перемешивать слова
        /// </summary>
        [XmlElement(ElementName="KeywordsReorderWordsMinPercent")]
        public int KeywordsReorderWordsMinPercent { get; set; }
        /// <summary>
        /// Количество кейвордов в процентах, в котоых нужно перемешивать слова
        /// </summary>
        [XmlElement(ElementName="KeywordsReorderWordsMaxPercent")]
        public int KeywordsReorderWordsMaxPercent { get; set; }
        /// <summary>
        /// Использовать синонимы
        /// </summary>
        [XmlElement(ElementName="KeywordsSynonyms")]
        public KeywordsSynonymsType KeywordsSynonyms { get; set; }
        /// <summary>
        /// Количество кейвордов в процентах, которые нужно заменить синонимами
        /// </summary>
        [XmlElement(ElementName="KeywordsSynonymsMinPercent")]
        public int KeywordsSynonymsMinPercent { get; set; }
        /// <summary>
        /// Количество кейвордов в процентах, которые нужно заменить синонимами
        /// </summary>
        [XmlElement(ElementName="KeywordsSynonymsMaxPercent")]
        public int KeywordsSynonymsMaxPercent { get; set; }
        /// <summary>
        /// ID кейвордов, кейвордами откуда нужно синонимизировать кейворды
        /// </summary>
        [XmlElement(ElementName="KeywordsSynonymsID")]
        public int KeywordsSynonymsID { get; set; }
        /// <summary>
        /// Path to external file, that will be used as synonyms
        /// </summary>
        [XmlElement(ElementName="KeywordsSynonymsFilePath")]
        public string KeywordsSynonymsFilePath { get; set; }
        /// <summary>
        /// Encoding of external file, that will be used as synonyms
        /// </summary>
        [XmlElement(ElementName = "KeywordsSynonymsFileEncoding")]
        public EncodingType KeywordsSynonymsFileEncoding { get; set; }
        /// <summary>
        /// ID кейвордов, с которыми нужно склеитьвать кейворды
        /// </summary>
        [XmlElement(ElementName="KeywordsMergeID")]
        public int KeywordsMergeID { get; set; }

        /// <summary>
        /// Использовать мердж
        /// </summary>
        [XmlElement(ElementName="KeywordsMerge")]
        public KeywordsMergeType KeywordsMerge { get; set; }

        /// <summary>
        /// Тип склейки кейвордов
        /// </summary>
        [XmlElement(ElementName = "KeywordsMergeUsage")]
        public KeywordsMergeUsageType KeywordsMergeUsage { get; set; }
        /// <summary>
        /// Минимальное количество кейвордов для склейки
        /// </summary>
        [XmlElement(ElementName="KeywordsMergeMin")]
        public int KeywordsMergeMin { get; set; }
        /// <summary>
        /// Максимальное количество кейвордов для склейки
        /// </summary>
        [XmlElement(ElementName="KeywordsMergeMax")]
        public int KeywordsMergeMax { get; set; }
        /// <summary>
        /// Path to external file, that will be used to merge with
        /// </summary>
        [XmlElement(ElementName="KeywordsMergeFilePath")]
        public string KeywordsMergeFilePath { get; set; }
        /// <summary>
        /// Encoding of external file, that will be used to merge with
        /// </summary>
        [XmlElement(ElementName = "KeywordsMergeFileEncoding")]
        public EncodingType KeywordsMergeFileEncoding { get; set; }
        /// <summary>
        /// Enables or disables keyword generation based on two words keywords
        /// </summary>
        [XmlElement(ElementName = "KeywordsGenerateTwoWords")]
        public bool KeywordsGenerateTwoWords { get; set; }
        /// <summary>
        /// Sets or gets minimum count of keyword generation based on two words keywords in percents
        /// </summary>
        [XmlElement(ElementName = "KeywordsGenerateTwoWordsMin")]
        public int KeywordsGenerateTwoWordsMin { get; set; }
        /// <summary>
        /// Sets or gets maximum count of keyword generation based on two words keywords in percents
        /// </summary>
        [XmlElement(ElementName = "KeywordsGenerateTwoWordsMax")]
        public int KeywordsGenerateTwoWordsMax { get; set; }

        /// <summary>
        /// Enables or disables keyword generation based on Three words keywords
        /// </summary>
        [XmlElement(ElementName = "KeywordsGenerateThreeWords")]
        public bool KeywordsGenerateThreeWords { get; set; }
        /// <summary>
        /// Sets or gets minimum count of keyword generation based on Three words keywords in percents
        /// </summary>
        [XmlElement(ElementName = "KeywordsGenerateThreeWordsMin")]
        public int KeywordsGenerateThreeWordsMin { get; set; }
        /// <summary>
        /// Sets or gets maximum count of keyword generation based on Three words keywords in percents
        /// </summary>
        [XmlElement(ElementName = "KeywordsGenerateThreeWordsMax")]
        public int KeywordsGenerateThreeWordsMax { get; set; }

        /// <summary>
        /// Enables or disables keyword generation based on Three words keywords
        /// </summary>
        [XmlElement(ElementName = "KeywordsGenerateFourWords")]
        public bool KeywordsGenerateFourWords { get; set; }
        /// <summary>
        /// Sets or gets minimum count of keyword generation based on Three words keywords in percents
        /// </summary>
        [XmlElement(ElementName = "KeywordsGenerateFourWordsMin")]
        public int KeywordsGenerateFourWordsMin { get; set; }
        /// <summary>
        /// Sets or gets maximum count of keyword generation based on Three words keywords in percents
        /// </summary>
        [XmlElement(ElementName = "KeywordsGenerateFourWordsMax")]
        public int KeywordsGenerateFourWordsMax { get; set; }
        
        #endregion

        #region Categories
        /// <summary>
        /// Gets or sets list of categories
        /// </summary>
        [XmlElement(ElementName = "Categories")]
        public List<ICategory> Categories { get; set; }

        /// <summary>
        /// Тип распределения кейвордов по категориям
        /// </summary>
        [XmlElement(ElementName = "CategoriesDistribution")]
        public CategoriesDistributionType CategoriesDistribution { get; set; }
        #endregion

        #region Static Pages
        /// <summary>
        /// Список статических страниц
        /// </summary>
        [XmlElement(ElementName = "StaticPages")]
        public List<string> StaticPages { get; set; }
        #endregion

        #region Map
        /// <summary>
        /// Тип карты сайта
        /// </summary>
        [XmlElement(ElementName = "Map")]
        public MapType Map { get; set; }
        /// <summary>
        /// Тип ХТМЛ карты сайта
        /// </summary>
        [XmlElement(ElementName = "MapHTML")]
        public MapHTMLType MapHTML { get; set; }
        /// <summary>
        /// Имя ХТМЛ карты сайта
        /// </summary>
        [XmlElement(ElementName = "MapHTMLName")]
        public string MapHTMLName { get; set; }
        /// <summary>
        /// Минимальное количество ссылок на карте сайты
        /// </summary>
        [XmlElement(ElementName = "MapHTMLLinksOnPageMin")]
        public int MapHTMLLinksOnPageMin { get; set; }
        /// <summary>
        /// Максимальное количество ссылок на карте сайты
        /// </summary>
        [XmlElement(ElementName = "MapHTMLLinksOnPageMax")]
        public int MapHTMLLinksOnPageMax { get; set; }

        /// <summary>
        /// XML sitemap name
        /// </summary>
        [XmlElement(ElementName = "MapXMLName")]
        public string MapXMLName { get; set; }

        /// <summary>
        /// Include Index page into sitemap
        /// </summary>
        [XmlElement(ElementName = "MapIncludeIndex")]
        public bool MapIncludeIndex { get; set; }
        /// <summary>
        /// Include regular pages into sitemap
        /// </summary>
        [XmlElement(ElementName = "MapIncludeRegularPages")]
        public bool MapIncludeRegularPages { get; set; }
        /// <summary>
        /// Include static pages into sitemap
        /// </summary>
        [XmlElement(ElementName = "MapIncludeStaticPages")]
        public bool MapIncludeStaticPages { get; set; }
        /// <summary>
        /// Include categories pages into sitemap
        /// </summary>
        [XmlElement(ElementName = "MapIncludeCategories")]
        public bool MapIncludeCategories { get; set; }
        /// <summary>
        /// Include custom pages into sitemap
        /// </summary>
        [XmlElement(ElementName = "MapIncludeCustomPages")]
        public bool MapIncludeCustomPages { get; set; }
        #endregion

        #region TextGenerating
        /// <summary>
        /// Text maker name
        /// </summary>
        [XmlElement(ElementName = "TextMakerName")]
        public string TextMakerName { get; set; }
        
        /// <summary>
        /// Type of inserting links into text
        /// </summary>
        [XmlElement(ElementName = "TextLinks")]
        public TextLinksType TextLinks { get; set; }

        /// <summary>
        /// Minimum number of links in text
        /// </summary>
        [XmlElement(ElementName = "TextLinksNumberMin")]
        public int TextLinksNumberMin { get; set; }

        /// <summary>
        /// Maximum number of links in text
        /// </summary>
        [XmlElement(ElementName = "TextLinksNumberMax")]
        public int TextLinksNumberMax { get; set; }

        /// <summary>
        /// Minimum link length in words
        /// </summary>
        [XmlElement(ElementName = "TextLinksLengthMin")]
        public int TextLinksLengthMin { get; set; }

        /// <summary>
        /// Maximum link length in words
        /// </summary>
        [XmlElement(ElementName = "TextLinksLengthMax")]
        public int TextLinksLengthMax { get; set; }
        #endregion


        #region Entrance
        /// <summary>
        /// Тип редиректа
        /// </summary>
        [XmlElement(ElementName = "Entrance")]
        public EntranceType Entrance { get; set; }
        /// <summary>
        /// Тип вставки кода в страницу
        /// </summary>
        [XmlElement(ElementName = "EntranceInsert")]
        public EntranceInsertType EntranceInsert { get; set; }
        /// <summary>
        /// Тип адреса сайта-акцептора
        /// </summary>
        [XmlElement(ElementName = "EntranceAcceptor")]
        public EntranceAcceptorType EntranceAcceptor { get; set; }
        /// <summary>
        /// Адрес сайт-акцептора
        /// </summary>
        [XmlElement(ElementName = "EntranceAcceptorURL")]
        public string EntranceAcceptorURL { get; set; }
        /// <summary>
        /// Шифровать JS файлы
        /// </summary>
        [XmlElement(ElementName = "EntranceJSEncrypt")]
        public bool EntranceJSEncrypt { get; set; }
        /// <summary>
        /// ХТМЛ код редирект/фрейма/кнопки вход
        /// </summary>
        [XmlElement(ElementName = "EntranceCode")]
        public string EntranceCode { get; set; }
        #endregion

        #region Tokens
        /// <summary>
        /// Тип ссылки на главную
        /// </summary>
        [XmlElement(ElementName = "TokenMainLink")]
        public TokenMainLinkType TokenMainLink { get; set; }

        /// <summary>
        /// Пользовательская ссылка на главную
        /// </summary>
        [XmlElement(ElementName = "TokenMainLinks")]
        public List<string> TokenMainLinks { get; set; }

        /// <summary>
        /// [TITLE]
        /// </summary>
        [XmlElement(ElementName = "TokenTitle")]
        public List<string> TokenTitle { get; set; }

        /// <summary>
        /// [SITE]
        /// </summary>
        [XmlElement(ElementName = "TokenSite")]
        public List<string> TokenSite { get; set; }

        /// <summary>
        /// [COUNTER]
        /// </summary>
        [XmlElement(ElementName = "TokenCounter")]
        public List<string> TokenCounter { get; set; }

        /// <summary>
        /// TokenInternalLinks
        /// </summary>
        [XmlElement(ElementName = "TokenInternalLinks")]
        public List<string> TokenInternalLinks { get; set; }

        /// <summary>
        /// TokenExternalLinks
        /// </summary>
        [XmlElement(ElementName = "TokenExternalLinks")]
        public List<string[]> TokenExternalLinks { get; set; }
        #endregion


        #region RSS
        /// <summary>
        /// Создавать RSS
        /// </summary>
        [XmlElement(ElementName = "RSS")]
        public RSSType RSS { get; set; }
        /// <summary>
        /// Количество записей в RSS
        /// </summary>
        [XmlElement(ElementName = "RSSLength")]
        public int RSSLength { get; set; }
        /// <summary>
        /// RSS Content type
        /// </summary>
        [XmlElement(ElementName = "RSSContent")]
        public RSSContentType RSSContent { get; set; }
        #endregion

        #region robots.txt
        /// <summary>
        /// Создание robots.txt
        /// </summary>
        [XmlElement(ElementName = "Robots")]
        public RobotsType Robots { get; set; }
        /// <summary>
        /// Содержимое robots.txt
        /// </summary>
        [XmlElement(ElementName = "RobotsContent")]
        public string RobotsContent { get; set; }
        #endregion

        #region Links
        /// <summary>
        /// Links templates
        /// </summary>
        [XmlElement(ElementName = "Links")]
        public List<string> Links { get; set; }

        /// <summary>
        /// Тип сохранения спам-сылок в файлы
        /// </summary>
        [XmlElement(ElementName = "LinksSave")]
        public LinksSaveType LinksSave { get; set; }

        /// <summary>
        /// Путь папки, в которую будут сохранятся файлы
        /// </summary>
        [XmlElement(ElementName = "LinksSavePath")]
        public string LinksSavePath { get; set; }

        /// <summary>
        /// Кодировка файлов с спам-ссылками
        /// </summary>
        [XmlElement(ElementName = "LinksSaveEncoding")]
        public EncodingType LinksSaveEncoding { get; set; }
        #endregion

        #region FTP
        /// <summary>
        /// Тип выгрузки
        /// </summary>
        [XmlElement(ElementName = "FTP")]
        public FTPType FTP { get; set; }

        /// <summary>
        /// Путь к папке, куда сохранять проекты
        /// </summary>
        [XmlElement(ElementName = "FTPExportPath")]
        public string FTPExportPath { get; set; }

        /// <summary>
        /// Удаление файлов после загрузки
        /// </summary>
        [XmlElement(ElementName = "FTPDeleteWhenUpload")]
        public bool FTPDeleteWhenUpload { get; set; }


        [XmlElement(ElementName = "FTPData")]
        public List<FTPConnection> FTPData { get; set; }
        #endregion

        public List<Tag> Tags { get; set; }

        public virtual object NewInstance()
        {
            return null;
        }
    }
}
