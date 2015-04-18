using System;
using System.Windows.Forms;
using Umax.Interfaces.Compatibility.ID;
using Umax.Interfaces.Compatibility.Text;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Text;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.Common
{
    public partial class TextControl : UserControl, ITextControl, ITextDataCompatible, ITextIDCompatible
    {
        public TextControl()
        {
            InitializeComponent();
        }

        private ITextMaker textMaker;
        public virtual ITextMaker TextMaker
        {
            get
            {
                if (this.textMaker == null)
                {
                    return null;
                }

                // Validate settings
                this.ValidateSettings();

                // Collect settings
                (this.textMaker as TextMaker).Settings = this.CollectSettings();

                if (this.textMaker is ITextDataCompatible)
                {
                    (this.textMaker as ITextDataCompatible).TextData = this.TextData;
                }

                return this.textMaker;
            }

            set
            {
                this.textMaker = value;
                this.ApplySettings();
            }
        }

        protected virtual void ApplySettings()
        {
            this.TextID = ((this.textMaker as TextMaker).Settings as TextSettings).TextID;

            switch (((this.textMaker as TextMaker).Settings as TextSettings).TextLocation)
            {
                case LocationType.Internal:
                    {
                        textLocationComboBox.SelectedIndex = 0;
                        break;
                    }

                case LocationType.External:
                    {
                        textLocationComboBox.SelectedIndex = 1;
                        break;
                    }
            }

            switch (((this.textMaker as TextMaker).Settings as TextSettings).TextExternalLocation)
            {
                case ExternalLocationType.File:
                    {
                        textLocationTypeComboBox.SelectedIndex = 0;
                        break;
                    }

                case ExternalLocationType.Directory:
                    {
                        textLocationTypeComboBox.SelectedIndex = 1;
                        break;
                    }
            }

            textLocationTextBox.Text = ((this.textMaker as TextMaker).Settings as TextSettings).TextExternalLocationPath;

            textLengthMinNumericUpDown.Value = ((this.textMaker as TextMaker).Settings as TextSettings).TextLengthMin;
            textLengthMaxNumericUpDown.Value = ((this.textMaker as TextMaker).Settings as TextSettings).TextLengthMax;

            keywordsMinNumericUpDown.Value = ((this.textMaker as TextMaker).Settings as TextSettings).KeywordsPercentageMin;
            keywordsMaxNumericUpDown.Value =
                ((this.textMaker as TextMaker).Settings as TextSettings).KeywordsPercentageMax;
            keywordsPpKCheckBox.Checked = ((this.textMaker as TextMaker).Settings as TextSettings).KeywordsPersentagePerEachKeyword;

            switch (((this.textMaker as TextMaker).Settings as TextSettings).KeywordsInsert)
            {
                case KeywordsInsertType.Random:
                    {
                        insertComboBox.SelectedIndex = 0;
                        break;
                    }

                case KeywordsInsertType.Step:
                    {
                        insertComboBox.SelectedIndex = 1;
                        break;
                    }

                case KeywordsInsertType.SentenseBeginning:
                    {
                        insertComboBox.SelectedIndex = 2;
                        break;
                    }

                case KeywordsInsertType.AfterPunctuationMarks:
                    {
                        insertComboBox.SelectedIndex = 3;
                        break;
                    }
            }

            insertStepNumericUpDown.Value = ((this.textMaker as TextMaker).Settings as TextSettings).KeywordsInsertStep;
            insertStepInfelicityNumericUpDown.Value =
                ((this.textMaker as TextMaker).Settings as TextSettings).KeywordsInsertStepInfelicity;

            selectionKeywordsCheckBox.Checked = ((this.textMaker as TextMaker).Settings as TextSettings).SelectKeywords;
            selectionKeywordsTextBox.Text = ((this.textMaker as TextMaker).Settings as TextSettings).SelectKeywordsTags;
            selectionPhrasesCheckBox.Checked = ((this.textMaker as TextMaker).Settings as TextSettings).SelectPhrases;
            selectionPhrasesTextBox.Text = ((this.textMaker as TextMaker).Settings as TextSettings).SelectPhrasesTags;
            selectionMinNumericUpDown.Value =
                ((this.textMaker as TextMaker).Settings as TextSettings).SelectPercentageMin;
            selectionMaxNumericUpDown.Value =
                ((this.textMaker as TextMaker).Settings as TextSettings).SelectPercentageMax;

            punctuationCheckBox.Checked = ((this.textMaker as TextMaker).Settings as TextSettings).PunctuationMarks;
            punctuationMinNumericUpDown.Value =
                ((this.textMaker as TextMaker).Settings as TextSettings).PunctuationMarksMin;
            punctuationMaxNumericUpDown.Value =
                ((this.textMaker as TextMaker).Settings as TextSettings).PunctuationMarksMax;
            punctuationTextBox.Text = ((this.textMaker as TextMaker).Settings as TextSettings).PunctuationMarksList;
            punctuationBigLettersCheckBox.Checked =
                ((this.textMaker as TextMaker).Settings as TextSettings).PunctuationMarksBigLetters;
            punctuationBigLettersTextBox.Text =
                ((this.textMaker as TextMaker).Settings as TextSettings).PunctuationMarksBigLettersList;

            switch (((this.textMaker as TextMaker).Settings as TextSettings).Sentences)
            {
                case SentencesType.None:
                    {
                        sentencesСomboBox.SelectedIndex = 0;
                        break;
                    }

                case SentencesType.Random:
                    {
                        sentencesСomboBox.SelectedIndex = 1;
                        break;
                    }

                case SentencesType.Step:
                    {
                        sentencesСomboBox.SelectedIndex = 2;
                        break;
                    }
            }

            sentencesMinNumericUpDown.Value = ((this.textMaker as TextMaker).Settings as TextSettings).SentencesMin;
            sentencesMaxNumericUpDown.Value = ((this.textMaker as TextMaker).Settings as TextSettings).SentencesMax;
            sentencesLengthNumericUpDown.Value =
                ((this.textMaker as TextMaker).Settings as TextSettings).SentencesLength;
            sentencesLengthInfelicityNumericUpDown.Value =
                ((this.textMaker as TextMaker).Settings as TextSettings).SentencesLengthInfelicity;

            paragraphsCheckBox.Checked = ((this.textMaker as TextMaker).Settings as TextSettings).Paragraphs;
            paragraphsMinNumericUpDown.Value = ((this.textMaker as TextMaker).Settings as TextSettings).ParagraphsMin;
            paragraphsMaxNumericUpDown.Value = ((this.textMaker as TextMaker).Settings as TextSettings).ParagraphsMax;

            bracketsCheckBox.Checked = ((this.textMaker as TextMaker).Settings as TextSettings).Brackets;
        }

        protected virtual void ValidateSettings()
        {
            if (this.TextData != null && textLocationComboBox.SelectedIndex == 0)
            {
                if (this.TextID == -1)
                {
                    throw new Exception("Please select Text!");
                }
            }
        }

        protected virtual ITextSettings CollectSettings()
        {
            TextSettings settings = new TextSettings
                                        {
                                            TextID = this.TextID,
                                            TextLengthMin = (int) textLengthMinNumericUpDown.Value,
                                            TextLengthMax = (int) textLengthMaxNumericUpDown.Value,
                                            KeywordsPercentageMin = keywordsMinNumericUpDown.Value,
                                            KeywordsPercentageMax = keywordsMaxNumericUpDown.Value,
                                            KeywordsPersentagePerEachKeyword = keywordsPpKCheckBox.Checked
                                        };

            switch (textLocationComboBox.SelectedIndex)
            {
                case 0:
                    {
                        settings.TextLocation = LocationType.Internal;
                        break;
                    }

                case 1:
                    {
                        settings.TextLocation = LocationType.External;
                        break;
                    }
            }

            switch (textLocationTypeComboBox.SelectedIndex)
            {
                case 0:
                    {
                        settings.TextExternalLocation = ExternalLocationType.File;
                        break;
                    }

                case 1:
                    {
                        settings.TextExternalLocation = ExternalLocationType.Directory;
                        break;
                    }
            }

            settings.TextExternalLocationPath = textLocationTextBox.Text;

            switch (insertComboBox.SelectedIndex)
            {
                    // Random
                case 0:
                    {
                        settings.KeywordsInsert = KeywordsInsertType.Random;
                        break;
                    }

                    // Step
                case 1:
                    {
                        settings.KeywordsInsert = KeywordsInsertType.Step;
                        break;
                    }

                    // At the beginning of sentence
                case 2:
                    {
                        settings.KeywordsInsert = KeywordsInsertType.SentenseBeginning;
                        break;
                    }

                    // After punctuation marks
                case 3:
                    {
                        settings.KeywordsInsert = KeywordsInsertType.AfterPunctuationMarks;
                        break;
                    }
            }

            settings.KeywordsInsertStep = (int)insertStepNumericUpDown.Value;
            settings.KeywordsInsertStepInfelicity = (int)insertStepInfelicityNumericUpDown.Value;

            settings.SelectKeywords = selectionKeywordsCheckBox.Checked;
            settings.SelectKeywordsTags = selectionKeywordsTextBox.Text;
            settings.SelectPhrases = selectionPhrasesCheckBox.Checked;
            settings.SelectPhrasesTags = selectionPhrasesTextBox.Text;
            settings.SelectPercentageMin = selectionMinNumericUpDown.Value;
            settings.SelectPercentageMax = selectionMaxNumericUpDown.Value;

            settings.PunctuationMarks = punctuationCheckBox.Checked;
            settings.PunctuationMarksMin = (int)punctuationMinNumericUpDown.Value;
            settings.PunctuationMarksMax = (int)punctuationMaxNumericUpDown.Value;
            settings.PunctuationMarksList = punctuationTextBox.Text;
            settings.PunctuationMarksBigLetters = punctuationBigLettersCheckBox.Checked;
            settings.PunctuationMarksBigLettersList = punctuationBigLettersTextBox.Text;

            switch (sentencesСomboBox.SelectedIndex)
            {
                // None
                case 0:
                    {
                        settings.Sentences = SentencesType.None;
                        break;
                    }

                // Random
                case 1:
                    {
                        settings.Sentences = SentencesType.Random;
                        break;
                    }

                // Step
                case 2:
                    {
                        settings.Sentences = SentencesType.Step;
                        break;
                    }
            }

            settings.SentencesMin = (int)sentencesMinNumericUpDown.Value;
            settings.SentencesMax = (int)sentencesMaxNumericUpDown.Value;
            settings.SentencesLength = (int)sentencesLengthNumericUpDown.Value;
            settings.SentencesLengthInfelicity = (int)sentencesLengthInfelicityNumericUpDown.Value;

            settings.Paragraphs = paragraphsCheckBox.Checked;
            settings.ParagraphsMin = (int) paragraphsMinNumericUpDown.Value;
            settings.ParagraphsMax = (int)paragraphsMaxNumericUpDown.Value;

            settings.Brackets = bracketsCheckBox.Checked;

            return settings;
        }

        public virtual object NewInstance()
        {
            return null;
        }

        protected void insertComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (insertComboBox.SelectedIndex == 1)
            {
                insertStepNumericUpDown.Enabled = true;
                insertStepInfelicityNumericUpDown.Enabled = true;
            }
            else
            {
                insertStepNumericUpDown.Enabled = false;
                insertStepInfelicityNumericUpDown.Enabled = false;
            }
        }

        protected void selectionKeywordsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            selectionKeywordsTextBox.Enabled = selectionKeywordsCheckBox.Checked;

            if (selectionKeywordsCheckBox.Checked || selectionPhrasesCheckBox.Checked)
            {
                this.SelectionNumbers(true);
            }
            else
            {
                this.SelectionNumbers(false);
            }
        }

        protected void SelectionNumbers(bool Enabled)
        {
            selectionMinNumericUpDown.Enabled = Enabled;
            selectionMaxNumericUpDown.Enabled = Enabled;
        }

        protected void selectionPhrasesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            selectionPhrasesTextBox.Enabled = selectionPhrasesCheckBox.Checked;
        }

        protected void punctuationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            punctuationMinNumericUpDown.Enabled = punctuationCheckBox.Checked;
            punctuationMaxNumericUpDown.Enabled = punctuationCheckBox.Checked;
            punctuationTextBox.Enabled = punctuationCheckBox.Checked;
            punctuationBigLettersCheckBox.Enabled = punctuationCheckBox.Checked;
            punctuationBigLettersTextBox.Enabled = punctuationCheckBox.Checked;

            if (punctuationCheckBox.Checked)
            {
                punctuationBigLettersCheckBox.Enabled = true;
                this.punctuationBigLettersCheckBox_CheckedChanged(null, null);
            }
            else
            {
                punctuationBigLettersCheckBox.Enabled = false;
                punctuationBigLettersTextBox.Enabled = false;
            }
        }

        protected void punctuationBigLettersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            punctuationBigLettersTextBox.Enabled = punctuationBigLettersCheckBox.Checked;
        }

        protected void sentencesСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sentencesСomboBox.SelectedIndex)
            {
                    // None
                case 0:
                    {
                        sentencesMinNumericUpDown.Enabled = false;
                        sentencesMaxNumericUpDown.Enabled = false;
                        sentencesLengthNumericUpDown.Enabled = false;
                        sentencesLengthInfelicityNumericUpDown.Enabled = false;
                        break;
                    }

                    // Random
                case 1:
                    {
                        sentencesMinNumericUpDown.Enabled = true;
                        sentencesMaxNumericUpDown.Enabled = true;
                        sentencesLengthNumericUpDown.Enabled = false;
                        sentencesLengthInfelicityNumericUpDown.Enabled = false;
                        break;
                    }

                    // Step
                case 2:
                    {
                        sentencesMinNumericUpDown.Enabled = false;
                        sentencesMaxNumericUpDown.Enabled = false;
                        sentencesLengthNumericUpDown.Enabled = true;
                        sentencesLengthInfelicityNumericUpDown.Enabled = true;
                        break;
                    }
            }
        }

        protected void paragraphsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            paragraphsMinNumericUpDown.Enabled = paragraphsCheckBox.Checked;
            paragraphsMaxNumericUpDown.Enabled = paragraphsCheckBox.Checked;
        }

        private void TextControl_Load(object sender, EventArgs e)
        {
            this.UpdateTextControls();

            // Events
            this.insertComboBox_SelectedIndexChanged(null, null);
            this.selectionKeywordsCheckBox_CheckedChanged(null, null);
            this.selectionPhrasesCheckBox_CheckedChanged(null, null);
            this.punctuationCheckBox_CheckedChanged(null, null);
            this.punctuationBigLettersCheckBox_CheckedChanged(null, null);
            this.sentencesСomboBox_SelectedIndexChanged(null, null);
            this.paragraphsCheckBox_CheckedChanged(null, null);
        }

        public int TextID
        {
            get
            {
                if (this.TextData == null)
                {
                    return -1;
                }

                if (textComboBox.SelectedIndex < this.TextData.Count)
                {
                    return this.TextData[textComboBox.SelectedIndex].ID;
                }

                return -1;
            }

            set
            {
                if (this.TextData != null)
                {
                    for (int i = 0; i < this.TextData.Count; i++)
                    {
                        if (this.TextData[i].ID == value)
                        {
                            textComboBox.SelectedIndex = i;
                            return;
                        }
                    }
                }

                textComboBox.SelectedIndex = -1;
            }
        }

        protected IEventedList<IText> textData;

        public IEventedList<IText> TextData
        {
            get { return this.textData; }
            set
            {
                this.textData = value;
                this.UpdateTextControls();
            }
        }

        private void UpdateTextControls()
        {
            textComboBox.Items.Clear();
            if (this.TextData == null)
            {
                return;
            }

            for (int i = 0; i < this.TextData.Count; i++)
            {
                textComboBox.Items.Add(this.TextData[i].Name);
            }
        }

        private void textLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (textLocationComboBox.SelectedIndex)
            {
                case 0:
                    {
                        textComboBox.Enabled = true;
                        textLocationTypeComboBox.Enabled = false;
                        textLocationTextBox.Enabled = false;
                        textLocationButton.Enabled = false;
                        break;
                    }

                case 1:
                    {
                        textComboBox.Enabled = false;
                        textLocationTypeComboBox.Enabled = true;
                        textLocationTextBox.Enabled = true;
                        textLocationButton.Enabled = true;
                        break;
                    }
            }
        }

        private void textLocationTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textLocationTextBox.Text = string.Empty;
        }

        private void textLocationButton_Click(object sender, EventArgs e)
        {
            switch (textLocationTypeComboBox.SelectedIndex)
            {
                case 0:
                    {
                        mainOpenFileDialog.FileName = string.Empty;
                        mainOpenFileDialog.ShowDialog();
                        if (mainOpenFileDialog.FileName == string.Empty)
                        {
                            return;
                        }

                        textLocationTextBox.Text = mainOpenFileDialog.FileName;

                        break;
                    }

                case 1:
                    {
                        mainFolderBrowserDialog.SelectedPath = string.Empty;
                        mainFolderBrowserDialog.ShowDialog();
                        if (mainFolderBrowserDialog.SelectedPath == string.Empty)
                        {
                            return;
                        }

                        textLocationTextBox.Text = mainFolderBrowserDialog.SelectedPath;

                        break;
                    }
            }
        }
    }
}
