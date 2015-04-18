using System;
using System.IO;
using System.Text;

namespace Umax.Windows.Windows.Log
{
    public partial class TaskLog : StandardWindow
    {
        public TaskLog()
        {
            InitializeComponent();
        }

        public string Content { get; set; }
        public string Task { get; set; }

        protected void LogTasks_Load(object sender, EventArgs e)
        {
            this.InitializeImages();
            this.InitializeMUI();

            mainTextBox.Text = this.Content;
            mainTextBox.SelectionStart = mainTextBox.Text.Length;
            mainTextBox.ScrollToCaret();
        }

        protected void InitializeImages()
        {
            this.Icon = Resources.Resources.IconRed;
            saveToolStripButton.Image = Resources.Resources.Save;
            closeToolStripButton.Image = Resources.Resources.Delete;
        }

        protected void InitializeMUI()
        {
            this.Text = Brand.Brand.Name + " " + this.Text + Task;
        }

        protected void closeToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void saveToolStripButton_Click(object sender, EventArgs e)
        {
            mainSaveFileDialog.FileName = string.Empty;
            mainSaveFileDialog.ShowDialog();
            if (mainSaveFileDialog.FileName == string.Empty)
            {
                return;
            }

            File.WriteAllText(mainSaveFileDialog.FileName, mainTextBox.Text, Encoding.UTF8);
        }
    }
}
