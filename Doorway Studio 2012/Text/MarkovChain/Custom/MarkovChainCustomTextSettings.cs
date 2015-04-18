using System;
using System.Xml.Serialization;
using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.MarkovChain.Custom
{
    [Serializable, XmlRoot(ElementName = "MarkovChainCustomTextSettings")]
    public class MarkovChainCustomTextSettings : TextSettings
    {
        public MarkovChainCustomTextSettings()
        {
            this.TextAnalysis = AnalyseType.Whole;
            this.TextAnalysisLength = 6;
            this.TextPunctuationMarks = PunctuationMarksType.Consider;
            this.TextConstruction = ConstructionType.Short;
            this.TextConstructionMin = 2;
            this.TextConstructionMax = 5;
            this.TextProbability = false;
        }

        public MarkovChainCustomTextSettings(ITextSettings Settings)
            : this()
        {
            if (!(Settings is TextSettings))
            {
                return;
            }

            this.TextLocation = (Settings as TextSettings).TextLocation;
            this.TextExternalLocation = (Settings as TextSettings).TextExternalLocation;
            this.TextExternalLocationPath = (Settings as TextSettings).TextExternalLocationPath;

            this.Brackets = (Settings as TextSettings).Brackets;

            this.KeywordsInsert = (Settings as TextSettings).KeywordsInsert;
            this.KeywordsInsertStep = (Settings as TextSettings).KeywordsInsertStep;
            this.KeywordsInsertStepInfelicity = (Settings as TextSettings).KeywordsInsertStepInfelicity;
            this.KeywordsPercentageMin = (Settings as TextSettings).KeywordsPercentageMin;
            this.KeywordsPercentageMax = (Settings as TextSettings).KeywordsPercentageMax;
            this.KeywordsPersentagePerEachKeyword = (Settings as TextSettings).KeywordsPersentagePerEachKeyword;

            this.Paragraphs = (Settings as TextSettings).Paragraphs;
            this.ParagraphsMin = (Settings as TextSettings).ParagraphsMin;
            this.ParagraphsMax = (Settings as TextSettings).ParagraphsMax;

            this.PunctuationMarks = (Settings as TextSettings).PunctuationMarks;
            this.PunctuationMarksBigLetters = (Settings as TextSettings).PunctuationMarksBigLetters;
            this.PunctuationMarksBigLettersList = (Settings as TextSettings).PunctuationMarksBigLettersList;
            this.PunctuationMarksList = (Settings as TextSettings).PunctuationMarksList;
            this.PunctuationMarksMin = (Settings as TextSettings).PunctuationMarksMin;
            this.PunctuationMarksMax = (Settings as TextSettings).PunctuationMarksMax;

            this.SelectKeywords = (Settings as TextSettings).SelectKeywords;
            this.SelectKeywordsTags = (Settings as TextSettings).SelectKeywordsTags;
            this.SelectPercentageMin = (Settings as TextSettings).SelectPercentageMin;
            this.SelectPercentageMax = (Settings as TextSettings).SelectPercentageMax;
            this.SelectPhrases = (Settings as TextSettings).SelectPhrases;
            this.SelectPhrasesTags = (Settings as TextSettings).SelectPhrasesTags;

            this.Sentences = (Settings as TextSettings).Sentences;
            this.SentencesLength = (Settings as TextSettings).SentencesLength;
            this.SentencesLengthInfelicity = (Settings as TextSettings).SentencesLengthInfelicity;
            this.SentencesMin = (Settings as TextSettings).SentencesMin;
            this.SentencesMax = (Settings as TextSettings).SentencesMax;

            this.TextLengthMin = (Settings as TextSettings).TextLengthMin;
            this.TextLengthMax = (Settings as TextSettings).TextLengthMax;
        }

        [XmlElement(ElementName = "Name")]
        public override string Name { get { return "MarkovChainCustomTextSettings"; } }

        /// <summary>
        /// Gets or sets punctuation marks consideration type
        /// </summary>
        [XmlElement(ElementName = "TextPunctuationMarks")]
        public virtual PunctuationMarksType TextPunctuationMarks { get; set; }

        /// <summary>
        /// Gets or sets maximum length of copy/paste with non short construction type
        /// </summary>
        [XmlElement(ElementName = "TextConstructionMax")]
        public virtual int TextConstructionMax { get; set; }

        /// <summary>
        /// Gets or sets minimum length of copy/paste with non short construction type
        /// </summary>
        [XmlElement(ElementName = "TextConstructionMin")]
        public virtual int TextConstructionMin { get; set; }

        /// <summary>
        /// Gets or sets text construction type
        /// </summary>
        [XmlElement(ElementName = "TextConstruction")]
        public virtual ConstructionType TextConstruction { get; set; }

        /// <summary>
        /// Gets or sets text analysis type
        /// </summary>
        [XmlElement(ElementName = "TextAnalysis")]
        public virtual AnalyseType TextAnalysis { get; set; }

        /// <summary>
        /// Gets or sets maximum word length for taxt analysis w/o endings
        /// </summary>
        [XmlElement(ElementName = "TextAnalysisLength")]
        public virtual int TextAnalysisLength { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether text should be generated considering words probability
        /// </summary>
        [XmlElement(ElementName = "TextProbability")]
        public virtual bool TextProbability { get; set; }


        /// <summary>
        /// Create new instance of MarkovChainCustomTextSettings
        /// </summary>
        /// <returns>New instance of MarkovChainCustomTextSettings</returns>
        public override object NewInstance()
        {
            return new MarkovChainCustomTextSettings();
        }
    }
}
