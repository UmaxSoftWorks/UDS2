using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;

namespace Umax.Plugins.Text.Reverse.Simple.Random
{
    public partial class ReverseSimpleRandomTextControl : TextControl
    {
        public ReverseSimpleRandomTextControl()
        {
            InitializeComponent();

            this.Name = "ReverseSimpleRandomTextControl";
            this.TextMaker = new ReverseSimpleRandomTextMaker();
        }

        public override ITextMaker TextMaker
        {
            get
            {
                if (base.TextMaker == null)
                {
                    return new ReverseSimpleRandomTextMaker();
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
            return new ReverseSimpleRandomTextSettings(base.CollectSettings());
        }

        public override object NewInstance()
        {
            return new ReverseSimpleRandomTextControl();
        }
    }
}
