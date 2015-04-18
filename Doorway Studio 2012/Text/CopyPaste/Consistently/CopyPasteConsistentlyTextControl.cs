using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;

namespace Umax.Plugins.Text.CopyPaste.Consistently
{
    public partial class CopyPasteConsistentlyTextControl : TextControl
    {
        public CopyPasteConsistentlyTextControl()
        {
            InitializeComponent();

            this.Name = "CopyPasteConsistentlyTextControl";
            this.TextMaker = new CopyPasteConsistentlyTextMaker();
        }

        public override ITextMaker TextMaker
        {
            get
            {
                if (base.TextMaker == null)
                {
                    return new CopyPasteConsistentlyTextMaker();
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

        protected override ITextSettings CollectSettings()
        {
            return new CopyPasteConsistentlyTextSettings(base.CollectSettings());
        }

        public override object NewInstance()
        {
            return new CopyPasteConsistentlyTextControl();
        }
    }
}
