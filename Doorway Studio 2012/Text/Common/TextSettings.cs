using System;
using System.Xml.Serialization;
using Umax.Interfaces.Compatibility.ID;
using Umax.Interfaces.Text;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.Common
{
    [Serializable, XmlRoot(ElementName = "TextSettings")]
    public class TextSettings : ITextSettings, ITextIDCompatible
    {
        public TextSettings()
        {
            this.TextID = -1;
            this.TextLocation = LocationType.Internal;
            this.TextExternalLocation = ExternalLocationType.File;
            this.TextExternalLocationPath = string.Empty;

            this.Brackets = false;

            this.KeywordsInsert = KeywordsInsertType.Random;
            this.KeywordsInsertStep = 20;
            this.KeywordsInsertStepInfelicity = 3;
            this.KeywordsPercentageMin = 4.0m;
            this.KeywordsPercentageMax = 7.0m;
            this.KeywordsPersentagePerEachKeyword = false;
            
            this.Paragraphs = true;
            this.ParagraphsMin = 1;
            this.ParagraphsMax = 3;

            this.PunctuationMarks = true;
            this.PunctuationMarksBigLetters = true;
            this.PunctuationMarksBigLettersList = ". ? !";
            this.PunctuationMarksList = ", ; : - ? !";
            this.PunctuationMarksMin = 5;
            this.PunctuationMarksMax = 7;

            this.SelectKeywords = false;
            this.SelectKeywordsTags = "strong b i em";
            this.SelectPercentageMin = 4.0m;
            this.SelectPercentageMax = 7.0m;
            this.SelectPhrases = false;
            this.SelectPhrasesTags = "strong b i em";

            this.Sentences = SentencesType.Random;
            this.SentencesLength = 15;
            this.SentencesLengthInfelicity = 3;
            this.SentencesMin = 5;
            this.SentencesMax = 10;

            this.TextLengthMin = 200;
            this.TextLengthMax = 300;
        }

        /// <summary>
        /// Gets text settings name
        /// </summary>
        [XmlElement(ElementName = "Name")]
        public virtual string Name { get { return "TextSettings"; } }

        /// <summary>
        /// Gets or sets TextID
        /// </summary>
        [XmlElement(ElementName = "TextID")]
        public int TextID { get; set; }

        /// <summary>
        /// Gets or sets TextLocation
        /// </summary>
        [XmlElement(ElementName = "TextLocation")]
        public LocationType TextLocation { get; set; }

        /// <summary>
        /// Gets or sets TextExternalLocation
        /// </summary>
        [XmlElement(ElementName = "TextExternalLocation")]
        public ExternalLocationType TextExternalLocation { get; set; }

        /// <summary>
        /// Gets or sets TextExternalLocationPath
        /// </summary>
        [XmlElement(ElementName = "TextExternalLocationPath")]
        public string TextExternalLocationPath { get; set; }

        /// <summary>
        /// Gets or sets minimum text length
        /// </summary>
        [XmlElement(ElementName = "TextLengthMin")]
        public int TextLengthMin { get; set; }

        /// <summary>
        /// Gets or sets maximum text length
        /// </summary>
        [XmlElement(ElementName = "TextLengthMax")]
        public int TextLengthMax { get; set; }

        /// <summary>
        /// Gets or sets minimum keywords percentage on page
        /// </summary>
        [XmlElement(ElementName = "KeywordsPercentageMin")]
        public decimal KeywordsPercentageMin { get; set; }

        /// <summary>
        /// Gets or sets maximum keywords percentage on page
        /// </summary>
        [XmlElement(ElementName = "KeywordsPercentageMax")]
        public decimal KeywordsPercentageMax { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether keywords percentage should be applied for each keyword
        /// </summary>
        [XmlElement(ElementName = "KeywordsPersentagePerEachKeyword")]
        public bool KeywordsPersentagePerEachKeyword { get; set; }

        /// <summary>
        /// Gets or sets keywords insert type
        /// </summary>
        [XmlElement(ElementName = "KeywordsInsert")]
        public KeywordsInsertType KeywordsInsert { get; set; }

        /// <summary>
        /// Gets or sets insert step length (0 - auto)
        /// </summary>
        [XmlElement(ElementName = "KeywordsInsertStep")]
        public int KeywordsInsertStep { get; set; }

        ///
        /// Gets or sets infelicity (±) with Step insert type
        /// </summary>
        [XmlElement(ElementName = "KeywordsInsertStepInfelicity")]
        public int KeywordsInsertStepInfelicity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether keywords should be selected with tags
        /// </summary>
                [XmlElement(ElementName = "SelectKeywords")]
        public bool SelectKeywords { get; set; }

        /// <summary>
        /// Gets or sets keywords selection tags, separated by spaces
        /// </summary>
        [XmlElement(ElementName = "SelectKeywordsTags")]
        public string SelectKeywordsTags { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether phrases should be selected with tags
        /// </summary>
        [XmlElement(ElementName = "SelectPhrases")]
        public bool SelectPhrases { get; set; }

        /// <summary>
        /// Gets or sets phrases selection tags, separated by spaces
        /// </summary>
        [XmlElement(ElementName = "SelectPhrasesTags")]
        public string SelectPhrasesTags { get; set; }

        /// <summary>
        /// Gets or sets minimum % of keywords/phrases to be selected with tags
        /// </summary>
        [XmlElement(ElementName = "SelectPercentageMin")]
        public decimal SelectPercentageMin { get; set; }

        /// <summary>
        /// Gets or sets maximum % of keywords/phrases to be selected with tags
        /// </summary>
        [XmlElement(ElementName = "SelectPercentageMax")]
        public decimal SelectPercentageMax { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether punctuation marks should be inserted
        /// </summary>
        [XmlElement(ElementName = "PunctuationMarks")]
        public bool PunctuationMarks { get; set; }

        /// <summary>
        /// Gets or sets minimum number of punctuation marks
        /// </summary>
        [XmlElement(ElementName = "PunctuationMarksMin")]
        public int PunctuationMarksMin { get; set; }

        /// <summary>
        /// Gets or sets maximum number of punctuation marks
        /// </summary>
        [XmlElement(ElementName = "PunctuationMarksMax")]
        public int PunctuationMarksMax { get; set; }

        /// <summary>
        /// Gets or sets list of punctuation marks, separated by spaces
        /// </summary>
        [XmlElement(ElementName = "PunctuationMarksList")]
        public string PunctuationMarksList { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether should be Big letters after punctuation list
        /// </summary>
        [XmlElement(ElementName = "PunctuationMarksBigLetters")]
        public bool PunctuationMarksBigLetters { get; set; }

        /// <summary>
        /// Gets or sets list of punctuation marks, after which should be big letter, separated by spaces
        /// </summary>
        [XmlElement(ElementName = "PunctuationMarksBigLettersList")]
        public string PunctuationMarksBigLettersList { get; set; }

        /// <summary>
        /// Gets or sets sentences type
        /// </summary>
        [XmlElement(ElementName = "Sentences")]
        public SentencesType Sentences { get; set; }

        /// <summary>
        /// Gets or sets minimum sentences number
        /// </summary>
        [XmlElement(ElementName = "SentencesMin")]
        public int SentencesMin { get; set; }

        /// <summary>
        /// Gets or sets maximum sentences number
        /// </summary>
        [XmlElement(ElementName = "SentencesMax")]
        public int SentencesMax { get; set; }

        /// <summary>
        /// Gets or sets sentences length
        /// </summary>
        [XmlElement(ElementName = "SentencesLength")]
        public int SentencesLength { get; set; }

        /// <summary>
        /// Gets or sets sentences length (±) infelicity
        /// </summary>
        [XmlElement(ElementName = "SentencesLengthInfelicity")]
        public int SentencesLengthInfelicity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether paragraphs should be used
        /// </summary>
        [XmlElement(ElementName = "Paragraphs")]
        public bool Paragraphs { get; set; }

        /// <summary>
        /// Gets or sets minimum paragraph number
        /// </summary>
        [XmlElement(ElementName = "ParagraphsMin")]
        public int ParagraphsMin { get; set; }

        /// <summary>
        /// Gets or sets maximum paragraph number
        /// </summary>
        [XmlElement(ElementName = "ParagraphsMax")]
        public int ParagraphsMax { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether brackets should be used
        /// </summary>
        [XmlElement(ElementName = "Brackets")]
        public bool Brackets { get; set; }

        public virtual void Dispose()
        {
        }

        public virtual object NewInstance()
        {
            return null;
        }
    }
}
