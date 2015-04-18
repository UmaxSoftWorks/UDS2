using Umax.Interfaces.Text;
using Umax.Plugins.Text.CommaConnection.Common;
using Umax.Plugins.Text.Common;

namespace Umax.Plugins.Text.CommaConnection.Random
{
    public partial class CommaConnectionRandomTextControl : TextControl
    {
        public CommaConnectionRandomTextControl()
        {
            InitializeComponent();

            this.Name = "CommaConnectionRandomTextControl";
            this.TextMaker = new CommaConnectionRandomTextMaker();
        }

        public override ITextMaker TextMaker
        {
            get
            {
                if (base.TextMaker == null)
                {
                    return new CommaConnectionRandomTextMaker();
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
            return new CommaConnectionTextSettings(base.CollectSettings());
        }

        public override object NewInstance()
        {
            return new CommaConnectionRandomTextControl();
        }
    }
}
