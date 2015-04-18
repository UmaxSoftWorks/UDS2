using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.MarkovChain.Custom
{
    public partial class MarkovChainCustomTextControl : TextControl
    {
        public MarkovChainCustomTextControl()
        {
            InitializeComponent();

            this.Name = "MarkovChainCustomTextControl";
            this.TextMaker = new MarkovChainCustomTextMaker();
        }

        protected override void ApplySettings()
        {
            base.ApplySettings();
            this.ApplyMarkovChainCustomSettings();
        }

        private void ApplyMarkovChainCustomSettings()
        {
            switch (((this.TextMaker as TextMaker).Settings as MarkovChainCustomTextSettings).TextAnalysis)
            {
                case AnalyseType.Whole:
                    {
                        generalAnalysisComboBox.SelectedIndex = 0;
                        break;
                    }

                case AnalyseType.WithoutEndings:
                    {
                        generalAnalysisComboBox.SelectedIndex = 1;
                        break;
                    }
            }

            generalAnalysisNumericUpDown.Value =
                ((this.TextMaker as TextMaker).Settings as MarkovChainCustomTextSettings).TextAnalysisLength;

            switch (((this.TextMaker as TextMaker).Settings as MarkovChainCustomTextSettings).TextPunctuationMarks)
            {
                case PunctuationMarksType.Consider:
                    {
                        generalPunctuationComboBox.SelectedIndex = 0;
                        break;
                    }

                case PunctuationMarksType.DontConsider:
                    {
                        generalPunctuationComboBox.SelectedIndex = 1;
                        break;
                    }
            }

            switch (((this.TextMaker as TextMaker).Settings as MarkovChainCustomTextSettings).TextConstruction)
            {
                // Short
                case ConstructionType.Short:
                    {
                        generalConstructionComboBox.SelectedIndex = 0;
                        break;
                    }

                // Long
                case ConstructionType.Long:
                    {
                        generalConstructionComboBox.SelectedIndex = 1;
                        break;
                    }
            }

            generalConstructionMinNumericUpDown.Value =
                ((this.TextMaker as TextMaker).Settings as MarkovChainCustomTextSettings).TextConstructionMin;
            generalConstructionMaxNumericUpDown.Value =
                ((this.TextMaker as TextMaker).Settings as MarkovChainCustomTextSettings).TextConstructionMax;
        }

        protected override ITextSettings CollectSettings()
        {
            MarkovChainCustomTextSettings settings = new MarkovChainCustomTextSettings(base.CollectSettings());

            this.CollectMarkovChainCustomSettings(settings);

            return settings;
        }

        protected virtual void CollectMarkovChainCustomSettings(ITextSettings Settings)
        {
            if (!(Settings is MarkovChainCustomTextSettings))
            {
                return;
            }

            switch (generalAnalysisComboBox.SelectedIndex)
            {
                case 0:
                    {
                        (Settings as MarkovChainCustomTextSettings).TextAnalysis = AnalyseType.Whole;
                        break;
                    }

                case 1:
                    {
                        (Settings as MarkovChainCustomTextSettings).TextAnalysis = AnalyseType.WithoutEndings;
                        break;
                    }
            }

            (Settings as MarkovChainCustomTextSettings).TextAnalysisLength = (int)generalAnalysisNumericUpDown.Value;

            switch (generalPunctuationComboBox.SelectedIndex)
            {
                    // Consider
                case 0:
                    {
                        (Settings as MarkovChainCustomTextSettings).TextPunctuationMarks = PunctuationMarksType.Consider;
                        break;
                    }

                    // Don't consider
                case 1:
                    {
                        (Settings as MarkovChainCustomTextSettings).TextPunctuationMarks =
                            PunctuationMarksType.DontConsider;
                        break;
                    }
            }

            switch (generalConstructionComboBox.SelectedIndex)
            {
                // Short
                case 0:
                    {
                        (Settings as MarkovChainCustomTextSettings).TextConstruction = ConstructionType.Short;
                        break;
                    }

                // Long
                case 1:
                    {
                        (Settings as MarkovChainCustomTextSettings).TextConstruction = ConstructionType.Long;
                        break;
                    }
            }

            (Settings as MarkovChainCustomTextSettings).TextConstructionMin = (int)generalConstructionMinNumericUpDown.Value;
            (Settings as MarkovChainCustomTextSettings).TextConstructionMax = (int)generalConstructionMaxNumericUpDown.Value;

            (Settings as MarkovChainCustomTextSettings).TextProbability = generalProbabilityCheckBox.Checked;
        }

        public override object NewInstance()
        {
            return new MarkovChainCustomTextControl();
        }

        protected virtual void generalAnalysisComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (generalAnalysisComboBox.SelectedIndex == -1)
            {
                return;
            }

            switch (generalAnalysisComboBox.SelectedIndex)
            {
                case 0:
                    {
                        generalAnalysisNumericUpDown.Enabled = false;
                        break;
                    }

                case 1:
                    {
                        generalAnalysisNumericUpDown.Enabled = true;
                        break;
                    }
            }
        }

        protected virtual void generalConstructionComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (generalConstructionComboBox.SelectedIndex == -1)
            {
                return;
            }

            switch (generalConstructionComboBox.SelectedIndex)
            {
                case 0:
                    {
                        generalConstructionMinNumericUpDown.Enabled = false;
                        generalConstructionMaxNumericUpDown.Enabled = false;
                        break;
                    }

                case 1:
                    {
                        generalConstructionMinNumericUpDown.Enabled = true;
                        generalConstructionMaxNumericUpDown.Enabled = true;
                        break;
                    }
            }
        }
    }
}
