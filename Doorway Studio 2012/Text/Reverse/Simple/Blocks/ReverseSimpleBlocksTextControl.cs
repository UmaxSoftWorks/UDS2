using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;

namespace Umax.Plugins.Text.Reverse.Simple.Blocks
{
    public partial class ReverseSimpleBlocksTextControl : TextControl
    {
        public ReverseSimpleBlocksTextControl()
        {
            InitializeComponent();

            this.Name = "ReverseSimpleBlocksTextControl";
            this.TextMaker = new ReverseSimpleBlocksTextMaker();
        }

        public override ITextMaker TextMaker
        {
            get
            {
                if (base.TextMaker == null)
                {
                    return new ReverseSimpleBlocksTextMaker();
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
            return new ReverseSimpleBlocksTextSettings(base.CollectSettings());
        }

        public override object NewInstance()
        {
            return new ReverseSimpleBlocksTextControl();
        }
    }
}
