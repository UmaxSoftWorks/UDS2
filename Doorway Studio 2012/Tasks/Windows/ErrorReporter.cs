using System;
using System.Windows.Forms;

namespace Umax.Plugins.Tasks.Windows
{
    public partial class ErrorReporter : Form
    {
        public ErrorReporter()
        {
            InitializeComponent();
            this.ShowDetails = false;
        }

        public string Message { get; set; }
        public string StackTrace { get; set; }

        public bool ShowDetails { get; set; }

        private void ErrorReporterLoad(object sender, EventArgs e)
        {
            this.Icon = Umax.Resources.Resources.IconGears;
            mainPictureBox.Image = Umax.Resources.Resources.Error;

            if (this.ShowDetails)
            {
                this.Height = 464;
            }

            messageTextBox.Text = this.Message;
            errorTextBox.Text = this.StackTrace;
        }

        private void okButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
