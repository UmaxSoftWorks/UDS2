using System;
using System.Text;
using System.Windows.Forms;
using Core.Classes.Containers.Items;
using IO = System.IO;

namespace Umax.Windows.Controls.Editors
{
    public partial class TextEditorControl : UserControl
    {
        public TextEditorControl()
        {
            InitializeComponent();
        }

        private void InitializeImages()
        {
            saveToolStripButton.Image = Resources.Resources.Save;
            cancelToolStripButton.Image = Resources.Resources.Delete;
            openToolStripSplitButton.Image = Resources.Resources.Import;
            exportToolStripSplitButton.Image = Resources.Resources.Export;
        }

        private void TextEditorControlLoad(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            this.Initialized = true;

            this.InitializeImages();
        }

        public int SelectedWorkSpace { get; set; }
        public int SelectedText { get; set; }

        protected bool CanExecuteAction
        {
            get { return (this.SelectedWorkSpace != -1) && (this.SelectedText != -1); }
        }

        protected bool Initialized { get; set; }

        public void UpdateControl()
        {
            if (!this.Initialized)
            {
                this.OnLoad(EventArgs.Empty);
            }

            contentTextBox.Enabled = this.CanExecuteAction;

            if (!this.CanExecuteAction)
            {
                contentTextBox.Text = string.Empty;
                return;
            }

            contentTextBox.Text = Core.Core.Instanse.Data[this.SelectedWorkSpace].Text[this.SelectedText].Content;
        }

        protected void Save(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            (Core.Core.Instanse.Data[this.SelectedWorkSpace].Text[this.SelectedText] as Text).Content = contentTextBox.Text;
        }

        protected void Cancel(object sender, EventArgs e)
        {
            this.UpdateControl();
        }

        protected void contentTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                contentTextBox.SelectAll();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(contentTextBox.SelectedText);
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                contentTextBox.SelectedText = Clipboard.GetText();
            }
            else if (e.Control && e.KeyCode == Keys.X)
            {
                Clipboard.SetText(contentTextBox.SelectedText);
                contentTextBox.SelectedText = string.Empty;
            }
        }

        protected void Export(Encoding Encoding)
        {
            if (contentTextBox.Text == string.Empty)
            {
                return;
            }

            mainSaveFileDialog.FileName = string.Empty;
            mainSaveFileDialog.ShowDialog();
            if (mainSaveFileDialog.FileName == string.Empty)
            {
                return;
            }

            try
            {
                IO.File.WriteAllText(mainSaveFileDialog.FileName, contentTextBox.Text, Encoding);
            }
            catch (Exception) { }
        }

        protected void Open(Encoding Encoding)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            contentTextBox.Text = IO.File.ReadAllText(mainOpenFileDialog.FileName, Encoding);
        }

        private void OpenANSI(object sender, EventArgs e)
        {
            this.Open(Encoding.Default);
        }

        private void OpenUTF8(object sender, EventArgs e)
        {
            this.Open(Encoding.UTF8);
        }

        private void ExportANSI(object sender, EventArgs e)
        {
            this.Export(Encoding.Default);
        }

        private void ExportUTF8(object sender, EventArgs e)
        {
            this.Export(Encoding.UTF8);
        }
    }
}
