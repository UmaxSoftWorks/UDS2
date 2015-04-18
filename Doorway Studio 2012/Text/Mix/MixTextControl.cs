using Umax.Classes.Enums;
using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.Mix
{
    public partial class MixTextControl : TextControl
    {
        public MixTextControl()
        {
            InitializeComponent();

            this.Name = "MixTextControl";
            this.TextMaker = new MixTextMaker();
        }

        public override ITextMaker TextMaker
        {
            get
            {
                if (base.TextMaker == null)
                {
                    return new MixTextMaker();
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
            this.ApplyMixSettings();
        }

        private void ApplyMixSettings()
        {
            switch (((this.TextMaker as TextMaker).Settings as MixTextSettings).TextSplit)
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

            switch (((this.TextMaker as TextMaker).Settings as MixTextSettings).TextPunctuationMarks)
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

            generalRadiusNumericUpDown.Value = ((this.TextMaker as TextMaker).Settings as MixTextSettings).TextRadius;
        }

        protected override ITextSettings CollectSettings()
        {
            MixTextSettings settings = new MixTextSettings(base.CollectSettings());

            this.CollectMixSettings(settings);

            return settings;
        }

        protected virtual void CollectMixSettings(ITextSettings Settings)
        {
            if (!(Settings is MixTextSettings))
            {
                return;
            }

            switch (generalComboBox.SelectedIndex)
            {
                    // Words
                case 0:
                    {
                        (Settings as MixTextSettings).TextSplit = StringSplitType.Word;
                        break;
                    }

                    // Parts of sentences
                case 1:
                    {
                        (Settings as MixTextSettings).TextSplit = StringSplitType.Fragment;
                        break;
                    }

                    // Sentences
                case 2:
                    {
                        (Settings as MixTextSettings).TextSplit = StringSplitType.Sentence;
                        break;
                    }

                    // Line
                case 3:
                    {
                        (Settings as MixTextSettings).TextSplit = StringSplitType.Line;
                        break;
                    }
            }

            switch (generalPunctuationComboBox.SelectedIndex)
            {
                // Consider
                case 0:
                    {
                        (Settings as MixTextSettings).TextPunctuationMarks = PunctuationMarksType.Consider;
                        break;
                    }

                // Don't consider
                case 1:
                    {
                        (Settings as MixTextSettings).TextPunctuationMarks = PunctuationMarksType.DontConsider;
                        break;
                    }
            }

            (Settings as MixTextSettings).TextRadius = (int)generalRadiusNumericUpDown.Value;
        }

        public override object NewInstance()
        {
            return new MixTextControl();
        }
    }
}
