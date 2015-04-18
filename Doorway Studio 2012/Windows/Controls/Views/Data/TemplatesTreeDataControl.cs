using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Core.Classes.Containers.Items;
using Umax.Classes.Helpers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using Umax.Windows.Enums;
using Umax.Windows.Interfaces;
using Umax.Windows.Windows.Data;

namespace Umax.Windows.Controls.Views.Data
{
    public partial class TemplatesTreeDataControl : UserControl, IEventedControl
    {
        public TemplatesTreeDataControl()
        {
            InitializeComponent();
        }

        private void TemplatesControlLoad(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            this.Initialized = true;

            this.InitializeImages();

            this.InitializeEvents();

            this.UpdateControl();
        }

        private void InitializeImages()
        {
            newToolStripSplitButton.Image = Resources.Resources.PlusGreen;
            copyToolStripButton.Image = Resources.Resources.Copy;
            renameToolStripButton.Image = Resources.Resources.Edit;
            openToolStripButton.Image = Resources.Resources.Import;
            exportToolStripButton.Image = Resources.Resources.Export;
            deleteToolStripButton.Image = Resources.Resources.MinusGreen;

            mainImageList.Images.Add(Resources.Resources.WorkSpace);
            mainImageList.Images.Add(Resources.Resources.Folder);
            mainImageList.Images.Add(Resources.Resources.Item);
            mainImageList.Images.Add(Resources.Resources.Image);
            mainImageList.Images.Add(Resources.Resources.Gears);
        }

        private void Export(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            mainFolderBrowserDialog.SelectedPath = string.Empty;
            mainFolderBrowserDialog.ShowDialog();
            if (mainFolderBrowserDialog.SelectedPath == string.Empty)
            {
                return;
            }

            try
            {
                (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate] as Template).Export(mainFolderBrowserDialog.SelectedPath);
            }
            catch (Exception) { }
        }

        public void InitializeEvents()
        {
            Core.Core.Instanse.Data.Items.CountChanged += this.ReInitializeWorkSpaceEvents;

            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                Core.Core.Instanse.Data[i].Templates.CountChanged += this.EventHandler;

                for (int k = 0; k < Core.Core.Instanse.Data[i].Templates.Count; k++)
                {
                    (Core.Core.Instanse.Data[i].Templates[k] as Template).Changed += this.EventHandler;
                }
            }
        }

        protected virtual void ReInitializeWorkSpaceEvents()
        {
            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                Core.Core.Instanse.Data[i].Changed -= this.EventHandler;
                Core.Core.Instanse.Data[i].Changed += this.EventHandler;
            }
        }

        public void DeInitializeEvents()
        {
            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                Core.Core.Instanse.Data[i].Changed -= this.EventHandler;
            }

            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                Core.Core.Instanse.Data[i].Templates.CountChanged -= this.EventHandler;

                for (int k = 0; k < Core.Core.Instanse.Data[i].Templates.Count; k++)
                {
                    (Core.Core.Instanse.Data[i].Templates[k] as Template).Changed -= this.EventHandler;
                }
            }
        }


        protected void EventHandler()
        {
            if (this.CanUpdate() && !DesignMode)
            {
                this.Invoke((MethodInvoker)delegate { this.UpdateControl(); });
            }
        }

        protected bool Initialized { get; set; }

        public void UpdateControl()
        {
            if (!this.Initialized)
            {
                this.OnLoad(EventArgs.Empty);
            }

            mainTreeView.Nodes.Clear();
            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                TreeNode[] templateTreeNode = new TreeNode[Core.Core.Instanse.Data[i].Templates.Count];
                for (int k = 0; k < Core.Core.Instanse.Data[i].Templates.Count; k++)
                {
                    TreeNode[] itemsTreeNode = new TreeNode[Core.Core.Instanse.Data[i].Templates[k].Items.Count];
                    for (int n = 0; n < Core.Core.Instanse.Data[i].Templates[k].Items.Count; n++)
                    {
                        itemsTreeNode[n] = new TreeNode(Core.Core.Instanse.Data[i].Templates[k].Items[n].Type.ToString(), this.GetItemImageIndex(Core.Core.Instanse.Data[i].Templates[k].Items[n].Type),
                                                        this.GetItemImageIndex(Core.Core.Instanse.Data[i].Templates[k].Items[n].Type));
                    }

                    templateTreeNode[k] = new TreeNode(Core.Core.Instanse.Data[i].Templates[k].Name, 1, 1, itemsTreeNode);
                }

                TreeNode mainTreeNode = new TreeNode(Core.Core.Instanse.Data[i].Name, 0, 0, templateTreeNode)
                {
                    Name = Core.Core.Instanse.Data[i].Name
                };
                mainTreeView.Nodes.Add(mainTreeNode);
                mainTreeNode.ExpandAll();
            }

            if (this.SelectedWorkSpace != -1)
            {
                this.SelectNode();
            }
            else
            {
                this.mainTreeViewAfterSelect(null, null);
            }
        }

        private int GetItemImageIndex(FileType Type)
        {
            switch (Type)
            {
                case FileType.Image:
                    {
                        return 3;
                    }

                case FileType.File:
                    {
                        return 4;
                    }

                default:
                    {
                        return 2;
                    }
            }
        }

        public int SelectedWorkSpace { get; set; }

        public int SelectedTemplate { get; set; }

        public int SelectedItem { get; set; }

        protected bool CanExecuteAction
        {
            get { return (this.SelectedWorkSpace != -1) && (this.SelectedTemplate != -1); }
        }

        /// <summary>
        /// Select node specified in Select properties
        /// </summary>
        private void SelectNode()
        {
            if (this.SelectedWorkSpace == -1)
            {
                return;
            }

            TreeNode node = this.mainTreeView.Nodes[this.SelectedWorkSpace];

            if (this.SelectedTemplate != -1 && this.SelectedTemplate < node.Nodes.Count)
            {
                node = node.Nodes[this.SelectedTemplate];
            }

            if (this.SelectedItem != -1 && this.SelectedItem < node.Nodes.Count)
            {
                node = node.Nodes[this.SelectedItem];
            }

            if (node != null)
            {
                this.mainTreeView.SelectedNode = node;
            }
        }

        private void mainTreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            this.SelectedWorkSpace = -1;
            this.SelectedTemplate = -1;
            this.SelectedItem = -1;

            if (mainTreeView.SelectedNode != null)
            {
                List<int> indexes = new List<int>();

                TreeNode node = mainTreeView.SelectedNode;
                indexes.Add(mainTreeView.SelectedNode.Index);

                while (node.Parent != null)
                {
                    node = node.Parent;
                    indexes.Insert(0, node.Index);
                }

                if (indexes.Count > 0)
                {
                    this.SelectedWorkSpace = indexes[0];
                }

                if (indexes.Count > 1)
                {
                    this.SelectedTemplate = indexes[1];
                }

                if (indexes.Count > 2)
                {
                    this.SelectedItem = indexes[2];
                }
            }

            if (this.TemplateChanged != null)
            {
                this.TemplateChanged();
            }
        }

        public event SimpleEventHandler TemplateChanged;

        private void Delete(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            if (WinHelper.MessageBox("Do you really want to delete this Template?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate] as Template).Changed -= this.EventHandler;

            (Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates[this.SelectedTemplate] as Template).Delete();
            Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates.RemoveAt(this.SelectedTemplate);

            if (this.TemplateChanged != null)
            {
                this.TemplateChanged();
            }
        }

        private void CreateANSI(object sender, EventArgs e)
        {
            this.Create(Encoding.Default);
        }

        private void CreateUTF(object sender, EventArgs e)
        {
            this.Create(Encoding.UTF8);
        }

        private void Create(Encoding Encoding)
        {
            if (this.SelectedWorkSpace == -1)
            {
                return;
            }

            new ItemAction()
                {
                    Action = DataActionType.Create,
                    Element = DataElementType.Images,
                    WorkSpace = Core.Core.Instanse.Data[this.SelectedWorkSpace],
                    Encoding = Encoding
                }.Show(FindForm());
        }

        private void Open(object sender, EventArgs e)
        {
            if (this.SelectedWorkSpace == -1)
            {
                return;
            }

            mainFolderBrowserDialog.SelectedPath = string.Empty;
            mainFolderBrowserDialog.ShowDialog();
            if (mainFolderBrowserDialog.SelectedPath == string.Empty)
            {
                return;
            }

            try
            {
                Core.Core.Instanse.Data[this.SelectedWorkSpace].Templates.Add(new Template(mainFolderBrowserDialog.SelectedPath));
            }
            catch (Exception) { }
        }

        private void Copy(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            new ItemAction()
            {
                Action = DataActionType.Copy,
                Element = DataElementType.Templates,
                WorkSpace = Core.Core.Instanse.Data[this.SelectedWorkSpace],
                Item = Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedTemplate]
            }.Show(FindForm());
        }

        private void Rename(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            ItemAction window = new ItemAction()
                                    {
                                        Action = DataActionType.Rename,
                                        Element = DataElementType.Templates,
                                        WorkSpace = Core.Core.Instanse.Data[this.SelectedWorkSpace],
                                        Item = Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedTemplate],
                                    };

            window.FormClosed += this.ItemRenamed;

            window.Show(FindForm());
        }

        private void ItemRenamed(object sender, FormClosedEventArgs e)
        {
            if (sender is Form)
            {
                (sender as Form).FormClosed -= this.ItemRenamed;
            }

            this.UpdateControl();
        }
    }
}
