using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Classes.Containers.Items;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Interfaces.TemplateEditor;
using Umax.Interfaces.Tokens;
using IO = System.IO;

namespace Umax.Windows.Tools.TemplateEditor.Controls
{
    public partial class TextEditorControl : UserControl
    {
        public TextEditorControl()
        {
            InitializeComponent();

            this.SelectedWorkSpace = -1;
            this.SelectedTemplate = -1;
            this.SelectedItem = -1;
        }

        void richTextBoxMouseWheel(object sender, MouseEventArgs e)
        {
            if (mainRichTextBox.ZoomFactor != this.Zoom)
            {
                this.Zoom = mainRichTextBox.ZoomFactor;
                this.mainRichTextBox.Refresh();
            }
        }

        private void mainTrackBarScroll(object sender, EventArgs e)
        {
            mainRichTextBox.ZoomFactor = this.Zoom;
        }

        protected float Zoom
        {
            get { return ((float)mainTrackBar.Value) / 100; }
            set
            {
                if (value < (((float) mainTrackBar.Minimum)/100))
                {
                    this.Zoom = ((float) mainTrackBar.Minimum)/100;
                    return;
                }

                if ((((float) mainTrackBar.Maximum)/100) < value)
                {
                    this.Zoom = ((float) mainTrackBar.Maximum)/100;
                    return;
                }

                mainRichTextBox.ZoomFactor = value;
                mainTrackBar.Value = ((int) (value*100));
            }
        }

        private void TextEditorControlLoad(object sender, EventArgs e)
        {
            this.InitializeImages();

            this.InitializeEvents();

            if (this.CanExecuteAction)
            {
                this.mainRichTextBox.Text = Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Content;
            }

            this.ShowItemPath();
        }

        public List<IToken> Tokens { get { return this.mainRichTextBox.Tokens; } set { this.mainRichTextBox.Tokens = value; } }

        public IToken SelectedToken
        {
            set
            {
                this.mainRichTextBox.HidePopUp();

                string filter = string.Empty;
                if (value is ITokenTemplateEditorCompatible)
                {
                    if ((value as ITokenTemplateEditorCompatible).Token.Length != 0)
                    {
                        filter = (value as ITokenTemplateEditorCompatible).Token[0];
                    }
                }
                else
                {
                    if (value.Tokens.Length != 0)
                    {
                        filter = value.Tokens[0];
                    }
                }

                filter = filter.Replace("[", string.Empty).Replace("]", string.Empty);

                if (filter.Contains(':'))
                {
                    filter = filter.Substring(0, filter.IndexOf(':'));
                }

                if (filter.Contains("Link") && !filter.StartsWith("Link", StringComparison.InvariantCultureIgnoreCase))
                {
                    filter = filter.Substring(0, filter.IndexOf("Link"));
                }

                this.mainRichTextBox.ShowPopUp(filter);
            }
        }

        private void InitializeImages()
        {
            importToolStripSplitButton.Image = Resources.Resources.Import;
            exportToolStripSplitButton.Image = Resources.Resources.Export;
            cutToolStripButton.Image = Resources.Resources.Cut;
            copyToolStripButton.Image = Resources.Resources.Copy;
            pasteToolStripButton.Image = Resources.Resources.Paste;
            decreaseIndentToolStripButton.Image = Resources.Resources.Back;
            increaseIndentToolStripButton.Image = Resources.Resources.Forward;

            savePathToolStripButton.Image = Resources.Resources.Save;
            cancelPathToolStripButton.Image = Resources.Resources.Delete;
        }

        private void InitializeEvents()
        {
            mainRichTextBox.MouseWheel += this.richTextBoxMouseWheel;
        }

        private void Cut(object sender, EventArgs e)
        {
            mainRichTextBox.Cut();
        }

        private void Copy(object sender, EventArgs e)
        {
            mainRichTextBox.Copy();
        }

        private void Paste(object sender, EventArgs e)
        {
            mainRichTextBox.Paste();
        }

        private void ImportANSI(object sender, EventArgs e)
        {
            this.Open(Encoding.Default);
        }

        private void ImportUTF8(object sender, EventArgs e)
        {
            this.Open(Encoding.UTF8);
        }

        private void Open(Encoding Encoding)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            mainRichTextBox.Text = IO.File.ReadAllText(mainOpenFileDialog.FileName, Encoding);
        }

        private void ExportANSI(object sender, EventArgs e)
        {
            this.Save(Encoding.Default);
        }

        private void ExportUTF8(object sender, EventArgs e)
        {
            this.Save(Encoding.UTF8);
        }

        private void Save(Encoding Encoding)
        {
            mainSaveFileDialog.FileName = string.Empty;
            mainSaveFileDialog.ShowDialog();
            if (mainSaveFileDialog.FileName == string.Empty)
            {
                return;
            }

            IO.File.WriteAllText(mainSaveFileDialog.FileName, mainRichTextBox.Text, Encoding);
        }

        private void DecreaseIndent(object sender, EventArgs e)
        {
            this.mainRichTextBox.DecreaseIndent();
        }

        private void IncreaseIndent(object sender, EventArgs e)
        {
            this.mainRichTextBox.IncreaseIndent();
        }

        private void mainRichTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                this.mainRichTextBox.Revert();
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.Right)
            {
                this.mainRichTextBox.IncreaseIndent();
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.Left)
            {
                this.mainRichTextBox.DecreaseIndent();
                e.Handled = true;
            }
        }

        public int SelectedWorkSpace { get; set; }
        public int SelectedTemplate { get; set; }
        public int SelectedItem { get; set; }

        protected bool CanExecuteAction
        {
            get { return (this.SelectedWorkSpace != -1) && (this.SelectedTemplate != -1); }
        }

        private void SaveItemPath(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            if (pathTextBox.Text == string.Empty || IO.Path.IsPathRooted(pathTextBox.Text) || string.IsNullOrEmpty(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Path))
            {
                this.CancelItemPath(sender, EventArgs.Empty);
            }
            else
            {
                try
                {
                    string newPath = IO.Path.Combine(IO.Path.Combine(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Path, "Files"), pathTextBox.Text);

                    // Create folder
                    IOHelper.CreateDirectory(newPath.Substring(0, newPath.LastIndexOf("\\") + 1));

                    // Moving file
                    if (IO.Path.IsPathRooted(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path))
                    {
                        IO.File.Move(
                            IO.Path.Combine(IO.Path.Combine(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Path, "Files"),
                                            Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path), newPath);
                    }
                    else
                    {
                        IO.File.Move(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path, newPath);
                    }

                    // Saving path
                    (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem] as File).Path = newPath;
                }
                catch (Exception)
                {
                    this.CancelItemPath(sender, EventArgs.Empty);
                }
            }
        }

        private void CancelItemPath(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            this.ShowItemPath();
        }

        private void ShowItemPath()
        {
            if (!string.IsNullOrEmpty(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Path) && Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path.StartsWith(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Path))
            {
                pathTextBox.Text = Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path.Substring(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Path.Length + "Files\\".Length).Trim(new char[] { ' ', '\\', '/' });
            }
            else
            {
                pathTextBox.Text = Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path;
            }
        }

        public void SaveContent()
        {
            if (this.CanExecuteAction)
            {
                (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem] as File).Content = mainRichTextBox.Text;
            }
        }

        public void ReloadContent()
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            if (IO.Path.IsPathRooted(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path) &&
                IO.File.Exists(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path))
            {
                Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem] = new File(
                    Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Type,
                    Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path,
                    Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Encoding);

                this.mainRichTextBox.Text = Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Content;
            }
        }

        public void CancelContent()
        {
            if (this.CanExecuteAction)
            {
                this.mainRichTextBox.Text = Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Content;
            }
        }
    }
}
