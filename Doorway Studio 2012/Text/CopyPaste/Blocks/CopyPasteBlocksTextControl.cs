using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;

namespace Umax.Plugins.Text.CopyPaste.Blocks
{
    public partial class CopyPasteBlocksTextControl : TextControl
    {
        public CopyPasteBlocksTextControl()
        {
            InitializeComponent();

            this.Name = "CopyPasteBlocksTextControl";
            this.TextMaker = new CopyPasteBlocksTextMaker();
        }

        public override ITextMaker TextMaker
        {
            get
            {
                if (base.TextMaker == null)
                {
                    return new CopyPasteBlocksTextMaker();
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
            return new CopyPasteBlocksTextSettings(base.CollectSettings());
        }

        public override object NewInstance()
        {
            return new CopyPasteBlocksTextControl();
        }
    }
}
