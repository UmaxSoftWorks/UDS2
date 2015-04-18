using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.Grams.Bi
{
    public partial class BiGramTextControl : TextControl
    {
        public BiGramTextControl()
        {
            InitializeComponent();

            this.Name = "BiGramTextControl";
            this.TextMaker = new BiGramTextMaker();
        }

        protected override void ApplySettings()
        {
            base.ApplySettings();
            this.ApplyBiGramSettings();
        }

        private void ApplyBiGramSettings()
        {
            switch (((this.TextMaker as TextMaker).Settings as BiGramTextSettings).TextAnalysis)
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
                ((this.TextMaker as TextMaker).Settings as BiGramTextSettings).TextAnalysisLength;

            switch (((this.TextMaker as TextMaker).Settings as BiGramTextSettings).TextPunctuationMarks)
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

            switch (((this.TextMaker as TextMaker).Settings as BiGramTextSettings).TextConstruction)
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
                ((this.TextMaker as TextMaker).Settings as BiGramTextSettings).TextConstructionMin;
            generalConstructionMaxNumericUpDown.Value =
                ((this.TextMaker as TextMaker).Settings as BiGramTextSettings).TextConstructionMax;
        }

        protected override ITextSettings CollectSettings()
        {
            BiGramTextSettings settings = new BiGramTextSettings(base.CollectSettings());

            this.CollectBiGramSettings(settings);

            return settings;
        }

        protected virtual void CollectBiGramSettings(ITextSettings Settings)
        {
            if (!(Settings is BiGramTextSettings))
            {
                return;
            }

            switch (generalAnalysisComboBox.SelectedIndex)
            {
                case 0:
                    {
                        (Settings as BiGramTextSettings).TextAnalysis = AnalyseType.Whole;
                        break;
                    }

                case 1:
                    {
                        (Settings as BiGramTextSettings).TextAnalysis = AnalyseType.WithoutEndings;
                        break;
                    }
            }

            (Settings as BiGramTextSettings).TextAnalysisLength = (int)generalAnalysisNumericUpDown.Value;

            switch (generalPunctuationComboBox.SelectedIndex)
            {
                    // Consider
                case 0:
                    {
                        (Settings as BiGramTextSettings).TextPunctuationMarks = PunctuationMarksType.Consider;
                        break;
                    }

                    // Don't consider
                case 1:
                    {
                        (Settings as BiGramTextSettings).TextPunctuationMarks =
                            PunctuationMarksType.DontConsider;
                        break;
                    }
            }

            switch (generalConstructionComboBox.SelectedIndex)
            {
                // Short
                case 0:
                    {
                        (Settings as BiGramTextSettings).TextConstruction = ConstructionType.Short;
                        break;
                    }

                // Long
                case 1:
                    {
                        (Settings as BiGramTextSettings).TextConstruction = ConstructionType.Long;
                        break;
                    }
            }

            (Settings as BiGramTextSettings).TextConstructionMin = (int)generalConstructionMinNumericUpDown.Value;
            (Settings as BiGramTextSettings).TextConstructionMax = (int)generalConstructionMaxNumericUpDown.Value;
        }

        public override object NewInstance()
        {
            return new BiGramTextControl();
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
