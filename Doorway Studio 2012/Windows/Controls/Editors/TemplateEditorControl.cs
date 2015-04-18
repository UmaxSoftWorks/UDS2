using System;
using System.IO;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using File = Core.Classes.Containers.Items.File;

namespace Umax.Windows.Controls.Editors
{
    public partial class TemplateEditorControl : UserControl
    {
        public TemplateEditorControl()
        {
            InitializeComponent();
        }

        public int SelectedWorkSpace { get; set; }

        public int SelectedTemplate { get; set; }

        public int SelectedItem { get; set; }

        protected bool CanExecuteAction
        {
            get { return (this.SelectedWorkSpace != -1) && (this.SelectedTemplate != -1) && (this.SelectedItem != -1); }
        }

        private void TemplateContentDataEditorControlLoad(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            this.Initialized = true;

            this.InitializeImages();
        }

        private void InitializeImages()
        {
            addToolStripSplitButton.Image = Resources.Resources.PlusBlue;
            removeToolStripButton.Image = Resources.Resources.MinusBlue;
            saveToolStripButton.Image = Resources.Resources.Save;
            reloadToolStripButton.Image = Resources.Resources.Update;
            cancelToolStripButton.Image = Resources.Resources.Delete;
            openEditorToolStripButton.Image = Resources.Resources.Edit;
            openIEToolStripButton.Image = Resources.Resources.InternetExplorer;
            openBrowserToolStripButton.Image = Resources.Resources.InternetExplorer;

            savePathToolStripButton.Image = Resources.Resources.Save;
            cancelPathToolStripButton.Image = Resources.Resources.Delete;
        }

        protected bool Initialized { get; set; }

        public void UpdateControl()
        {
            if (!this.Initialized)
            {
                this.OnLoad(EventArgs.Empty);
            }

            contentTextBox.Enabled = pathTextBox.Enabled = this.CanExecuteAction;

            if (!this.CanExecuteAction || Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items.Count <= this.SelectedItem)
            {
                contentTextBox.Text = pathTextBox.Text = string.Empty;
                return;
            }

            contentTextBox.Text = (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem] as File).Content;
            this.ShowItemPath();
        }

        private void Save(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            if (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Type != FileType.Image &&
                Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Type != FileType.File)
            {
                (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem] as File).Content = contentTextBox.Text;
            }
        }

        private void AddItem(FileType Type)
        {
            if (this.SelectedWorkSpace == -1 || this.SelectedTemplate == -1)
            {
                return;
            }

            if (Type == FileType.Image || Type == FileType.File)
            {
                mainOpenFileDialog.FileName = string.Empty;
                mainOpenFileDialog.ShowDialog();

                if (mainOpenFileDialog.FileName == string.Empty)
                {
                    return;
                }

                for (int i = 0; i < mainOpenFileDialog.FileNames.Length; i++)
                {
                    Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items.Add(new File()
                                                                                                                   {
                                                                                                                       Type = Type,
                                                                                                                       Path = mainOpenFileDialog.FileNames[i],
                                                                                                                   });
                }
            }
            else
            {
                if (Type == FileType.Index)
                {
                    for (int i = 0; i < Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items.Count; i++)
                    {
                        if (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[i].Type == FileType.Index)
                        {
                            return;
                        }
                    }
                }

                Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items.Add(new File()
                                                                                                               {
                                                                                                                   Type = Type,
                                                                                                                   Path = IOHelper.MakeFileName() + ".html"
                                                                                                               });
            }

            this.UpdateControl();
        }

        private void AddIndex(object sender, EventArgs e)
        {
            this.AddItem(FileType.Index);
        }

        private void AddPage(object sender, EventArgs e)
        {
            this.AddItem(FileType.Page);
        }

        private void AddCategory(object sender, EventArgs e)
        {
            this.AddItem(FileType.Category);
        }

        private void AddStatic(object sender, EventArgs e)
        {
            this.AddItem(FileType.Static);
        }

        private void AddMap(object sender, EventArgs e)
        {
            this.AddItem(FileType.Map);
        }

        private void AddImage(object sender, EventArgs e)
        {
            this.AddItem(FileType.Image);
        }

        private void AddFile(object sender, EventArgs e)
        {
            this.AddItem(FileType.File);
        }

        private void Remove(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            if (System.IO.File.Exists(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path))
            {
                System.IO.File.Delete(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path);
            }

            Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items.RemoveAt(this.SelectedItem);

            this.UpdateControl();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.UpdateControl();
        }

        private void RunExecutable(string ExePath)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            if (Path.IsPathRooted(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path) &&
                System.IO.File.Exists(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path))
            {
                if (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Type != FileType.File &&
                    Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Type != FileType.Image)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(ExePath, Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void RunExecutable()
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            if (Path.IsPathRooted(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path) &&
                System.IO.File.Exists(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path))
            {
                if (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Type != FileType.File &&
                    Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Type != FileType.Image)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path);
                    }
                    catch (Exception) { }
                }
            }
        }

        private void OpenIE(object sender, EventArgs e)
        {
            this.RunExecutable(@"iexplore.exe");
        }

        private void OpenBrowser(object sender, EventArgs e)
        {
            this.RunExecutable();
        }

        private void AddCustom(object sender, EventArgs e)
        {
            this.AddItem(FileType.Custom);
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

        private void SaveItemPath(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            if (pathTextBox.Text == string.Empty || Path.IsPathRooted(pathTextBox.Text) || string.IsNullOrEmpty(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Path))
            {
                this.CancelItemPath(sender, EventArgs.Empty);
            }
            else
            {
                try
                {
                    string newPath = Path.Combine(Path.Combine(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Path, "Files"), pathTextBox.Text);

                    // Create folder
                    IOHelper.CreateDirectory(newPath.Substring(0, newPath.LastIndexOf("\\") + 1));

                    // Moving file
                    if (Path.IsPathRooted(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path))
                    {
                        System.IO.File.Move(
                            Path.Combine(Path.Combine(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Path, "Files"),
                                            Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path), newPath);
                    }
                    else
                    {
                        System.IO.File.Move(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path, newPath);
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

        private void OpenEditor(object sender, EventArgs e)
        {
            this.RunExecutable("notepad.exe");
        }

        private void Reload(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            if (Path.IsPathRooted(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path) &&
                System.IO.File.Exists(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path))
            {
                if (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Type != FileType.File &&
                    Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Type != FileType.Image)
                {
                    Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem] = new File(
                        Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Type,
                        Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path,
                        Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Encoding);

                    this.UpdateControl();
                }
            }
        }

        private void contentTextBoxKeyDown(object sender, KeyEventArgs e)
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
    }
}
