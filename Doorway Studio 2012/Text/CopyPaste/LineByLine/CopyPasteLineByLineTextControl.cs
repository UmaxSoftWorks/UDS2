using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;

namespace Umax.Plugins.Text.CopyPaste.LineByLine
{
    public partial class CopyPasteLineByLineTextControl : TextControl
    {
        public CopyPasteLineByLineTextControl()
        {
            InitializeComponent();

            this.Name = "CopyPasteLineByLineTextControl";
            this.TextMaker = new CopyPasteLineByLineTextMaker();
        }

        public override ITextMaker TextMaker
        {
            get
            {
                if (base.TextMaker == null)
                {
                    return new CopyPasteLineByLineTextMaker();
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
            return new CopyPasteLineByLineTextSettings(base.CollectSettings());
        }

        public override object NewInstance()
        {
            return new CopyPasteLineByLineTextControl();
        }
    }
}
