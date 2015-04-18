using System.Drawing;
using System.Windows.Forms;
using Umax.Windows.Classes;

namespace Umax.Windows.Windows.Common
{
    public partial class TrayWindow : Form
    {
        public TrayWindow()
        {
            InitializeComponent();

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            if (GuiOptions.Instanse.TrayWindowOpacity < 0)
            {
                GuiOptions.Instanse.TrayWindowOpacity = 75;
            }

            if (GuiOptions.Instanse.TrayWindowOpacity > 100)
            {
                GuiOptions.Instanse.TrayWindowOpacity = 100;
            }

            this.Opacity = (double)GuiOptions.Instanse.TrayWindowOpacity / 100;

            this.TopMost = GuiOptions.Instanse.TrayWindowPinned;
        }

        private void TrayWindowFormClosing(object sender, FormClosingEventArgs e)
        {
            activeTasksGridManagerControl.DeInitializeEvents();
        }
    }
}
