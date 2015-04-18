using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Umax.Brand;
using Umax.Resources;

namespace WebParser.Windows.Tasks
{
    public partial class TaskLog : Form
    {
        public TaskLog()
        {
            InitializeComponent();
        }

        public string Content { get; set; }

        private void TaskLogLoad(object sender, EventArgs e)
        {
            this.Icon = Resources.IconGrey;

            this.Text = Brand.Name + " " + this.Text;

            this.saveToolStripButton.Image = Resources.Save;

            mainTextBox.Text = this.Content ?? string.Empty;
        }

        private void saveToolStripButtonClick(object sender, EventArgs e)
        {
            mainSaveFileDialog.FileName = string.Empty;
            mainSaveFileDialog.ShowDialog();
            if (mainSaveFileDialog.FileName == string.Empty)
            {
                return;
            }

            File.WriteAllText(mainSaveFileDialog.FileName, mainTextBox.Text, Encoding.Default);
        }
    }
}
