using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.Grams.Tri
{
    public partial class TriGramTextControl : TextControl
    {
        public TriGramTextControl()
        {
            InitializeComponent();

            this.Name = "TriGramTextControl";
            this.TextMaker = new TriGramTextMaker();
        }

        protected override void ApplySettings()
        {
            base.ApplySettings();
            this.ApplyTriGramSettings();
        }

        private void ApplyTriGramSettings()
        {
            switch (((this.TextMaker as TextMaker).Settings as TriGramTextSettings).TextAnalysis)
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
                ((this.TextMaker as TextMaker).Settings as TriGramTextSettings).TextAnalysisLength;

            switch (((this.TextMaker as TextMaker).Settings as TriGramTextSettings).TextPunctuationMarks)
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

            switch (((this.TextMaker as TextMaker).Settings as TriGramTextSettings).TextConstruction)
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
                ((this.TextMaker as TextMaker).Settings as TriGramTextSettings).TextConstructionMin;
            generalConstructionMaxNumericUpDown.Value =
                ((this.TextMaker as TextMaker).Settings as TriGramTextSettings).TextConstructionMax;
        }

        protected override ITextSettings CollectSettings()
        {
            TriGramTextSettings settings = new TriGramTextSettings(base.CollectSettings());

            this.CollectTriGramSettings(settings);

            return settings;
        }

        protected virtual void CollectTriGramSettings(ITextSettings Settings)
        {
            if (!(Settings is TriGramTextSettings))
            {
                return;
            }

            switch (generalAnalysisComboBox.SelectedIndex)
            {
                case 0:
                    {
                        (Settings as TriGramTextSettings).TextAnalysis = AnalyseType.Whole;
                        break;
                    }

                case 1:
                    {
                        (Settings as TriGramTextSettings).TextAnalysis = AnalyseType.WithoutEndings;
                        break;
                    }
            }

            (Settings as TriGramTextSettings).TextAnalysisLength = (int)generalAnalysisNumericUpDown.Value;

            switch (generalPunctuationComboBox.SelectedIndex)
            {
                    // Consider
                case 0:
                    {
                        (Settings as TriGramTextSettings).TextPunctuationMarks = PunctuationMarksType.Consider;
                        break;
                    }

                    // Don't consider
                case 1:
                    {
                        (Settings as TriGramTextSettings).TextPunctuationMarks =
                            PunctuationMarksType.DontConsider;
                        break;
                    }
            }

            switch (generalConstructionComboBox.SelectedIndex)
            {
                // Short
                case 0:
                    {
                        (Settings as TriGramTextSettings).TextConstruction = ConstructionType.Short;
                        break;
                    }

                // Long
                case 1:
                    {
                        (Settings as TriGramTextSettings).TextConstruction = ConstructionType.Long;
                        break;
                    }
            }

            (Settings as TriGramTextSettings).TextConstructionMin = (int)generalConstructionMinNumericUpDown.Value;
            (Settings as TriGramTextSettings).TextConstructionMax = (int)generalConstructionMaxNumericUpDown.Value;
        }

        public override object NewInstance()
        {
            return new TriGramTextControl();
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
