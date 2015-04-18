using Umax.Interfaces.Text;
using Umax.Plugins.Text.Common;

namespace Umax.Plugins.Text.Reverse.Simple.LineByLine
{
    public partial class ReverseSimpleLineByLineTextControl : TextControl
    {
        public ReverseSimpleLineByLineTextControl()
        {
            InitializeComponent();

            this.Name = "ReverseSimpleLineByLineTextControl";
            this.TextMaker = new ReverseSimpleLineByLineTextMaker();
        }

        public override ITextMaker TextMaker
        {
            get
            {
                if (base.TextMaker == null)
                {
                    return new ReverseSimpleLineByLineTextMaker();
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
            return new ReverseSimpleLineByLineTextSettings(base.CollectSettings());
        }

        public override object NewInstance()
        {
            return new ReverseSimpleLineByLineTextControl();
        }
    }
}
