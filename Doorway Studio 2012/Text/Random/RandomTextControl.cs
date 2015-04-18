using Umax.Classes.Enums;
using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.Random
{
    public partial class RandomTextControl : TextControl
    {
        public RandomTextControl()
        {
            InitializeComponent();

            this.Name = "RandomTextControl";
            this.TextMaker = new RandomTextMaker();
        }

        public override ITextMaker TextMaker
        {
            get
            {
                if (base.TextMaker == null)
                {
                    return new RandomTextMaker();
                }

                // Validate settings

                // Collect settings
                (base.TextMaker as TextMaker).Settings = this.CollectSettings();

                return base.TextMaker;
            }

            set
            {
                base.TextMaker = value;
                this.ApplySettings();
            }
        }

        protected override void ApplySettings()
        {
            base.ApplySettings();
            this.ApplyRandomSettings();
        }

        private void ApplyRandomSettings()
        {
            switch (((this.TextMaker as TextMaker).Settings as RandomTextSettings).TextSplit)
            {
                case StringSplitType.Word:
                    {
                        generalComboBox.SelectedIndex = 0;
                        break;
                    }

                case StringSplitType.Fragment:
                    {
                        generalComboBox.SelectedIndex = 1;
                        break;
                    }

                case StringSplitType.Sentence:
                    {
                        generalComboBox.SelectedIndex = 2;
                        break;
                    }

                case StringSplitType.Line:
                    {
                        generalComboBox.SelectedIndex = 3;
                        break;
                    }
            }

            switch (((this.TextMaker as TextMaker).Settings as RandomTextSettings).TextPunctuationMarks)
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

            generalRadiusNumericUpDown.Value = ((this.TextMaker as TextMaker).Settings as RandomTextSettings).TextRadius;

            switch (((this.TextMaker as TextMaker).Settings as RandomTextSettings).TextConstruction)
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
                ((this.TextMaker as TextMaker).Settings as RandomTextSettings).TextConstructionMin;
            generalConstructionMaxNumericUpDown.Value =
                ((this.TextMaker as TextMaker).Settings as RandomTextSettings).TextConstructionMax;
        }

        protected override ITextSettings CollectSettings()
        {
            RandomTextSettings settings = new RandomTextSettings(base.CollectSettings());

            this.CollectRandomSettings(settings);

            return settings;
        }

        protected virtual void CollectRandomSettings(ITextSettings Settings)
        {
            if (!(Settings is RandomTextSettings))
            {
                return;
            }

            switch (generalComboBox.SelectedIndex)
            {
                    // Words
                case 0:
                    {
                        (Settings as RandomTextSettings).TextSplit = StringSplitType.Word;
                        break;
                    }

                    // Parts of sentences
                case 1:
                    {
                        (Settings as RandomTextSettings).TextSplit = StringSplitType.Fragment;
                        break;
                    }

                    // Sentences
                case 2:
                    {
                        (Settings as RandomTextSettings).TextSplit = StringSplitType.Sentence;
                        break;
                    }

                    // Line
                case 3:
                    {
                        (Settings as RandomTextSettings).TextSplit = StringSplitType.Line;
                        break;
                    }
            }

            switch (generalPunctuationComboBox.SelectedIndex)
            {
                // Consider
                case 0:
                    {
                        (Settings as RandomTextSettings).TextPunctuationMarks = PunctuationMarksType.Consider;
                        break;
                    }

                // Don't consider
                case 1:
                    {
                        (Settings as RandomTextSettings).TextPunctuationMarks = PunctuationMarksType.DontConsider;
                        break;
                    }
            }

            (Settings as RandomTextSettings).TextRadius = (int)generalRadiusNumericUpDown.Value;

            switch (generalConstructionComboBox.SelectedIndex)
            {
                // Short
                case 0:
                    {
                        (Settings as RandomTextSettings).TextConstruction = ConstructionType.Short;
                        break;
                    }

                // Long
                case 1:
                    {
                        (Settings as RandomTextSettings).TextConstruction = ConstructionType.Long;
                        break;
                    }
            }

            (Settings as RandomTextSettings).TextConstructionMin = (int)generalConstructionMinNumericUpDown.Value;
            (Settings as RandomTextSettings).TextConstructionMax = (int)generalConstructionMaxNumericUpDown.Value;
        }

        public override object NewInstance()
        {
            return new RandomTextControl();
        }

        private void generalConstructionComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
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
