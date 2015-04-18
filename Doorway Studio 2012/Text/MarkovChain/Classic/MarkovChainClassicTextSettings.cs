using System;
using System.Xml.Serialization;
using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.MarkovChain.Classic
{
    [Serializable, XmlRoot(ElementName = "MarkovChainClassicTextSettings")]
    public class MarkovChainClassicTextSettings : TextSettings
    {
        public MarkovChainClassicTextSettings()
        {
            this.TextPunctuationMarks = PunctuationMarksType.Consider;
        }

        public MarkovChainClassicTextSettings(ITextSettings Settings)
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
        public override string Name { get { return "MarkovChainClassicTextSettings"; } }

        /// <summary>
        /// Gets or sets punctuation marks consideration type
        /// </summary>
        [XmlElement(ElementName = "TextPunctuationMarks")]
        public virtual PunctuationMarksType TextPunctuationMarks { get; set; }

        /// <summary>
        /// Create new instance of CopyPasteTextSettings
        /// </summary>
        /// <returns>New instance of CopyPasteTextSettings</returns>
        public override object NewInstance()
        {
            return new MarkovChainClassicTextSettings();
        }
    }
}
