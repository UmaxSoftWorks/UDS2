using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.CopyPaste.Random
{
    public partial class CopyPasteRandomTextControl : TextControl
    {
        public CopyPasteRandomTextControl()
        {
            InitializeComponent();

            this.Name = "CopyPasteRandomTextControl";
            this.TextMaker = new CopyPasteRandomTextMaker();
        }

        protected override void ApplySettings()
        {
            base.ApplySettings();
            this.ApplyCopyPasteSettings();
        }

        private void ApplyCopyPasteSettings()
        {
            switch (((this.TextMaker as TextMaker).Settings as CopyPasteRandomTextSettings).TextPunctuationMarks)
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
            CopyPasteRandomTextSettings settings = new CopyPasteRandomTextSettings(base.CollectSettings());

            this.CollectCopyPasteRandomSettings(settings);

            return settings;
        }

        protected virtual void CollectCopyPasteRandomSettings(ITextSettings Settings)
        {
            if (!(Settings is CopyPasteRandomTextSettings))
            {
                return;
            }

            switch (generalPunctuationComboBox.SelectedIndex)
            {
                // Consider
                case 0:
                    {
                        (Settings as CopyPasteRandomTextSettings).TextPunctuationMarks = PunctuationMarksType.Consider;
                        break;
                    }

                // Don't consider
                case 1:
                    {
                        (Settings as CopyPasteRandomTextSettings).TextPunctuationMarks = PunctuationMarksType.DontConsider;
                        break;
                    }
            }
        }

        public override object NewInstance()
        {
            return new CopyPasteRandomTextControl();
        }
    }
}
