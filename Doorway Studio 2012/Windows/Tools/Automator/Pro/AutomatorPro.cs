using System;
using Umax.Windows.Windows;

namespace Umax.Windows.Tools.Automator.Pro
{
    public partial class AutomatorPro : StandardWindow
    {
        public AutomatorPro()
        {
            InitializeComponent();
        }

        private void AutomatorProLoad(object sender, EventArgs e)
        {
            this.Icon = Resources.Resources.IconRed;
            this.Text = Brand.Brand.Name + " " + this.Text;
        }
    }
}
