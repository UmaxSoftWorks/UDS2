using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;

namespace Umax.Plugins.Text.Reverse.Advanced.Random
{
    public partial class ReverseAdvancedRandomTextControl : TextControl
    {
        public ReverseAdvancedRandomTextControl()
        {
            InitializeComponent();

            this.Name = "ReverseAdvancedRandomTextControl";
            this.TextMaker = new ReverseAdvancedRandomTextMaker();
        }

        public override ITextMaker TextMaker
        {
            get
            {
                if (base.TextMaker == null)
                {
                    return new ReverseAdvancedRandomTextMaker();
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
            return new ReverseAdvancedRandomTextSettings(base.CollectSettings());
        }

        public override object NewInstance()
        {
            return new ReverseAdvancedRandomTextControl();
        }
    }
}
