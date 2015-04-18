using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.ConceptualGraph.Custom
{
    public partial class ConceptualGraphCustomTextControl : TextControl
    {
        public ConceptualGraphCustomTextControl()
        {
            InitializeComponent();

            this.Name = "ConceptualGraphCustomTextControl";
            this.TextMaker = new ConceptualGraphCustomTextMaker();
        }

        protected override void ApplySettings()
        {
            base.ApplySettings();
            this.ApplyConceptualGraphCustomSettings();
        }

        private void ApplyConceptualGraphCustomSettings()
        {
            switch (((this.TextMaker as TextMaker).Settings as ConceptualGraphCustomTextSettings).TextPunctuationMarks)
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

            switch (((this.TextMaker as TextMaker).Settings as ConceptualGraphCustomTextSettings).TextConstruction)
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
                ((this.TextMaker as TextMaker).Settings as ConceptualGraphCustomTextSettings).TextConstructionMin;
            generalConstructionMaxNumericUpDown.Value =
                ((this.TextMaker as TextMaker).Settings as ConceptualGraphCustomTextSettings).TextConstructionMax;
        }

        protected override ITextSettings CollectSettings()
        {
            ConceptualGraphCustomTextSettings settings = new ConceptualGraphCustomTextSettings(base.CollectSettings());

            this.CollectConceptualGraphCustomSettings(settings);

            return settings;
        }

        protected virtual void CollectConceptualGraphCustomSettings(ITextSettings Settings)
        {
            if (!(Settings is ConceptualGraphCustomTextSettings))
            {
                return;
            }

            switch (generalPunctuationComboBox.SelectedIndex)
            {
                    // Consider
                case 0:
                    {
                        (Settings as ConceptualGraphCustomTextSettings).TextPunctuationMarks = PunctuationMarksType.Consider;
                        break;
                    }

                    // Don't consider
                case 1:
                    {
                        (Settings as ConceptualGraphCustomTextSettings).TextPunctuationMarks =
                            PunctuationMarksType.DontConsider;
                        break;
                    }
            }

            switch (generalConstructionComboBox.SelectedIndex)
            {
                // Short
                case 0:
                    {
                        (Settings as ConceptualGraphCustomTextSettings).TextConstruction = ConstructionType.Short;
                        break;
                    }

                // Long
                case 1:
                    {
                        (Settings as ConceptualGraphCustomTextSettings).TextConstruction = ConstructionType.Long;
                        break;
                    }
            }

            (Settings as ConceptualGraphCustomTextSettings).TextConstructionMin = (int)generalConstructionMinNumericUpDown.Value;
            (Settings as ConceptualGraphCustomTextSettings).TextConstructionMax = (int)generalConstructionMaxNumericUpDown.Value;

            (Settings as ConceptualGraphCustomTextSettings).TextProbability = generalProbabilityCheckBox.Checked;
        }

        public override object NewInstance()
        {
            return new ConceptualGraphCustomTextControl();
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
