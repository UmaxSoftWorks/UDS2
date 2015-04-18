using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;

namespace Umax.Plugins.Text.Reverse.Simple.Consistently
{
    public partial class ReverseSimpleConsistentlyTextControl : TextControl
    {
        public ReverseSimpleConsistentlyTextControl()
        {
            InitializeComponent();

            this.Name = "ReverseSimpleConsistentlyTextControl";
            this.TextMaker = new ReverseSimpleConsistentlyTextMaker();
        }

        public override ITextMaker TextMaker
        {
            get
            {
                if (base.TextMaker == null)
                {
                    return new ReverseSimpleConsistentlyTextMaker();
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
            return new ReverseSimpleConsistentlyTextSettings(base.CollectSettings());
        }

        public override object NewInstance()
        {
            return new ReverseSimpleConsistentlyTextControl();
        }
    }
}
