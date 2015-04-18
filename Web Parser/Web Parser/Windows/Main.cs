using System;
using System.Windows.Forms;
using Umax.Brand;
using Umax.Resources;
using WebParser.Classes;
using WebParser.Windows.Tasks;
using WebParser.Windows.Tools;

namespace WebParser.Windows
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Exit = false;
        }

        private bool Exit { get; set; }

        private void MainLoad(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            this.Icon = Resources.IconGrey;
            this.Text = Brand.Name + " " + this.Text;

            this.mainNotifyIcon.Icon = Resources.IconGrey;
            this.mainNotifyIcon.Text = this.Text;

            this.InitializeImages();
        }

        private void InitializeImages()
        {
            // Main menu
            fileToolStripMenuItem.Image = Resources.Save;
            fileTasksToolStripMenuItem.Image = Resources.Task;
            fileTasksNewTaskToolStripMenuItem.Image = Resources.PlusGreen;
            fileTasksEditToolStripMenuItem.Image = Resources.Edit;
            fileTasksDeleteToolStripMenuItem.Image = Resources.Delete;
            fileTasksDeleteNewToolStripMenuItem.Image = Resources.ImageGreen;
            fileTasksDeleteCompletedToolStripMenuItem.Image = Resources.Ok;
            fileTasksDeleteFailedToolStripMenuItem.Image = Resources.Delete;
            fileHistoryToolStripMenuItem.Image = Resources.History;
            fileExitToolStripMenuItem.Image = Resources.Delete;

            toolsToolStripMenuItem.Image = Resources.Tools;
            toolsOptionsToolStripMenuItem.Image = Resources.Settings;

            helpToolStripMenuItem.Image = Resources.Help;
            helpHelpToolStripMenuItem.Image = Resources.Help;
            helpAboutToolStripMenuItem.Image = Resources.Info;

            // Icon menu
            iconTasksToolStripMenuItem.Image = Resources.Task;
            iconTasksNewToolStripMenuItem.Image = Resources.PlusGreen;
            iconTasksEditToolStripMenuItem.Image = Resources.Edit;
            iconTasksDeleteToolStripMenuItem.Image = Resources.Delete;
            iconTasksDeleteNewToolStripMenuItem.Image = Resources.ImageGreen;
            iconTasksDeleteCompletedToolStripMenuItem.Image = Resources.Ok;
            iconTasksDeleteFailedToolStripMenuItem.Image = Resources.Delete;

            iconHistoryToolStripMenuItem.Image = Resources.History;
            iconExitToolStripMenuItem.Image = Resources.Delete;
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            // Confirm
            if (!this.Exit)
            {
                e.Cancel = true;
                this.Visible = false;
                return;
            }

            if (MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                this.Exit = false;
                e.Cancel = true;
                return;
            }

            mainNotifyIcon.Visible = false;

            GuiOptions.Instanse.Save();

            allTasksGrid.DeInitializeEvents();
            activeTasksGrid.DeInitializeEvents();

            Core.Core.Instanse.Close();
        }

        private void ShowHistory(object sender, EventArgs e)
        {
            new MainLog().Show();
        }

        private void exitToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Exit = true;
            Close();
        }

        private void ShowHide(object sender, EventArgs e)
        {
            bool wasInvisible = this.Visible == false;

            this.Visible = !this.Visible;

            if (wasInvisible)
            {
                allTasksGrid.UpdateControl();
                activeTasksGrid.UpdateControl();
            }
        }

        private void CreateTask(object sender, EventArgs e)
        {
            new TaskCreate().Show();
        }

        private void iconExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Visible = true;
                Application.DoEvents();
            }

            this.exitToolStripMenuItemClick(sender, e);
        }
    }
}
