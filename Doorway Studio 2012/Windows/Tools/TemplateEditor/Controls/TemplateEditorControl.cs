using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Core.Classes.Containers.Items;
using Umax.Classes.Helpers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Tokens;
using IO = System.IO;

namespace Umax.Windows.Tools.TemplateEditor.Controls
{
    public partial class TemplateEditorControl : UserControl
    {
        public TemplateEditorControl()
        {
            InitializeComponent();

            this.CurrentWorkSpace = -1;
            this.CurrentTemplate = -1;
            this.CurrentItem = -1;
        }

        private void TemplateEditorControlLoad(object sender, EventArgs e)
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
        }

        private void InitializeEvents()
        {
            if (this.CanExecuteAction)
            {
                Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items.ItemAdded -= this.ItemAdded;
            }

            Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items.ItemAdded += this.ItemAdded;
        }

        void ItemAdded(object Sender)
        {
            if ((Sender as IFile).Type == FileType.File || (Sender as IFile).Type == FileType.Image || (Sender as IFile).Type == FileType.Other)
            {
                return;
            }

            mainTabControl.TabPages.Add(this.CreateTabPage(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items.ToList().IndexOf(Sender as IFile)));
        }

        public int SelectedWorkSpace { get; set; }
        public int SelectedTemplate { get; set; }
        public int SelectedItem { get; set; }

        protected bool CanExecuteAction
        {
            get { return (this.SelectedWorkSpace != -1) && (this.SelectedTemplate != -1); }
        }

        protected bool Initialized { get; set; }

        public void UpdateControl()
        {
            if (!this.Initialized)
            {
                this.OnLoad(EventArgs.Empty);
            }

            if (!this.CanExecuteAction)
            {
                return;
            }

            if ((this.CurrentWorkSpace != this.SelectedWorkSpace || this.CurrentTemplate != this.SelectedTemplate) && (this.CurrentWorkSpace != -1 && this.CurrentTemplate != -1))
            {
                if (WinHelper.MessageBox("Do you want to proceed? Unsaved data will be lost.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            if (this.CurrentWorkSpace == this.SelectedWorkSpace && this.CurrentTemplate == this.SelectedTemplate)
            {
                mainTabControl.SelectedIndex = this.SelectedIndex;
            }
            else
            {
                this.mainTabControl.TabPages.Clear();

                bool canSelect = false;
                for (int i = 0; i < Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items.Count; i++)
                {
                    if (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[i].Type == FileType.File ||
                        Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[i].Type == FileType.Image ||
                        Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[i].Type == FileType.Other)
                    {
                        continue;
                    }

                    if (this.SelectedItem == i)
                    {
                        canSelect = true;
                    }

                    mainTabControl.TabPages.Add(this.CreateTabPage(i));
                }

                if (canSelect)
                {
                    mainTabControl.SelectedIndex = this.SelectedIndex;
                }
            }

            this.CurrentItem = this.SelectedItem;
            this.CurrentTemplate = this.SelectedTemplate;
            this.CurrentWorkSpace = this.SelectedWorkSpace;

            this.InitializeEvents();
        }

        private int SelectedIndex
        {
            get
            {
                int index = this.SelectedItem;
                for (int i = 0; i < this.SelectedItem; i++)
                {
                    if (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[i].Type == FileType.File ||
                        Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[i].Type == FileType.Image ||
                        Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[i].Type == FileType.Other)
                    {
                        index--;
                    }
                }

                return index;
            }
        }

        public int CurrentWorkSpace { get; set; }
        public int CurrentTemplate { get; set; }
        public int CurrentItem { get; set; }

        private TabPage CreateTabPage(int ItemIndex)
        {
            TabPage page = new TabPage(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[ItemIndex].Type.ToString());

            page.Controls.Add(new TextEditorControl()
                                  {
                                      SelectedWorkSpace = this.SelectedWorkSpace,
                                      SelectedTemplate = this.SelectedTemplate,
                                      SelectedItem = ItemIndex,
                                      Tokens = this.Tokens,
                                      Location = new Point(0, 0),
                                      Dock = DockStyle.Fill
                                  });

            return page;
        }

        public List<IToken> Tokens { get; set; }

        public IToken SelectedToken
        {
            set
            {
                if (this.mainTabControl.TabPages.Count == 0)
                {
                    return;
                }

                foreach (Control control in this.mainTabControl.TabPages[this.mainTabControl.SelectedIndex].Controls)
                {
                    if (control is TextEditorControl)
                    {
                        (control as TextEditorControl).SelectedToken = value;
                    }
                }

            }
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

        private void AddCustom(object sender, EventArgs e)
        {
            this.AddItem(FileType.Custom);
        }

        private void AddImage(object sender, EventArgs e)
        {
            this.AddItem(FileType.Image);
        }

        private void AddFile(object sender, EventArgs e)
        {
            this.AddItem(FileType.File);
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

        private void Save(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            foreach (Control control in this.mainTabControl.TabPages[this.mainTabControl.SelectedIndex].Controls)
            {
                if (control is TextEditorControl)
                {
                    (control as TextEditorControl).SaveContent();
                }
            }
        }

        private void Reload(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            foreach (Control control in this.mainTabControl.TabPages[this.mainTabControl.SelectedIndex].Controls)
            {
                if (control is TextEditorControl)
                {
                    (control as TextEditorControl).ReloadContent();
                }
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            foreach (Control control in this.mainTabControl.TabPages[this.mainTabControl.SelectedIndex].Controls)
            {
                if (control is TextEditorControl)
                {
                    (control as TextEditorControl).CancelContent();
                }
            }
        }

        private void OpenEditor(object sender, EventArgs e)
        {
            this.RunExecutable("notepad.exe");
        }

        private void OpenIE(object sender, EventArgs e)
        {
            this.RunExecutable(@"iexplore.exe");
        }

        private void OpenBrowser(object sender, EventArgs e)
        {
            this.RunExecutable();
        }

        private void RunExecutable()
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            if (IO.Path.IsPathRooted(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path) &&
                IO.File.Exists(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path))
            {
                foreach (Control control in this.mainTabControl.TabPages[this.mainTabControl.SelectedIndex].Controls)
                {
                    if (control is TextEditorControl)
                    {
                        System.Diagnostics.Process.Start(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[(control as TextEditorControl).SelectedItem].Path);
                    }
                }
            }
        }

        private void RunExecutable(string ExePath)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            if (IO.Path.IsPathRooted(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path) &&
                IO.File.Exists(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[this.SelectedItem].Path))
            {
                foreach (Control control in this.mainTabControl.TabPages[this.mainTabControl.SelectedIndex].Controls)
                {
                    if (control is TextEditorControl)
                    {
                        System.Diagnostics.Process.Start(ExePath, Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[(control as TextEditorControl).SelectedItem].Path);
                    }
                }
            }
        }

        private void Remove(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            int index = 0;
            foreach (Control control in this.mainTabControl.TabPages[this.mainTabControl.SelectedIndex].Controls)
            {
                if (control is TextEditorControl)
                {
                    index = (control as TextEditorControl).SelectedItem;
                }
            }

            this.mainTabControl.TabPages.RemoveAt(this.mainTabControl.SelectedIndex);

            if (IO.File.Exists(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[index].Path))
            {
                IO.File.Delete(Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items[index].Path);
            }

            Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate].Items.RemoveAt(index);
        }
    }
}
