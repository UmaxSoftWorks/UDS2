using Umax.Windows.Windows;

namespace Umax.Windows.Tools.Automator.Regular
{
    public partial class Automator : StandardWindow
    {
        public Automator()
        {
            InitializeComponent();
        }

        private void AutomatorLoad(object sender, System.EventArgs e)
        {
            this.Icon = Resources.Resources.IconRed;
            this.Text = Brand.Brand.Name + " " + this.Text;
        }
    }
}
