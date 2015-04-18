using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.MarkovChain.Classic
{
    public partial class MarkovChainClassicTextControl : TextControl
    {
        public MarkovChainClassicTextControl()
        {
            InitializeComponent();

            this.Name = "MarkovChainClassicTextControl";
            this.TextMaker = new MarkovChainClassicTextMaker();
        }

        protected override void ApplySettings()
        {
            base.ApplySettings();
            this.ApplyMarkovChainClassicSettings();
        }

        private void ApplyMarkovChainClassicSettings()
        {
            switch (((this.TextMaker as TextMaker).Settings as MarkovChainClassicTextSettings).TextPunctuationMarks)
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
        }

        protected override ITextSettings CollectSettings()
        {
            MarkovChainClassicTextSettings settings = new MarkovChainClassicTextSettings(base.CollectSettings());

            this.CollectMarkovChainClassicSettings(settings);

            return settings;
        }

        protected virtual void CollectMarkovChainClassicSettings(ITextSettings Settings)
        {
            if (!(Settings is MarkovChainClassicTextSettings))
            {
                return;
            }

            switch (generalPunctuationComboBox.SelectedIndex)
            {
                // Consider
                case 0:
                    {
                        (Settings as MarkovChainClassicTextSettings).TextPunctuationMarks = PunctuationMarksType.Consider;
                        break;
                    }

                // Don't consider
                case 1:
                    {
                        (Settings as MarkovChainClassicTextSettings).TextPunctuationMarks = PunctuationMarksType.DontConsider;
                        break;
                    }
            }
        }

        public override object NewInstance()
        {
            return new MarkovChainClassicTextControl();
        }
    }
}
