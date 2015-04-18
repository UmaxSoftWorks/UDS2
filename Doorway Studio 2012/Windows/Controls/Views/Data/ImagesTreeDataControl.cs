using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Classes.Containers.Items;
using Umax.Classes.Helpers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Events;
using Umax.Windows.Enums;
using Umax.Windows.Windows.Data;

namespace Umax.Windows.Controls.Views.Data
{
    public partial class ImagesTreeDataControl : UserControl
    {
        public ImagesTreeDataControl()
        {
            InitializeComponent();
        }

        public int SelectedWorkSpace { get; set; }
        public int SelectedImages { get; set; }

        protected bool CanExecuteAction
        {
            get { return (this.SelectedWorkSpace != -1) && (this.SelectedImages != -1); }
        }

        private void ImagesTreeDataControlLoad(object sender, EventArgs e)
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
            newToolStripButton.Image = Resources.Resources.PlusGreen;
            copyToolStripButton.Image = Resources.Resources.Copy;
            renameToolStripButton.Image = Resources.Resources.Edit;
            deleteToolStripButton.Image = Resources.Resources.MinusGreen;

            mainImageList.Images.Add(Resources.Resources.WorkSpace);
            mainImageList.Images.Add(Resources.Resources.Image);
        }

        public void InitializeEvents()
        {
            Core.Core.Instanse.Data.Items.CountChanged += this.ReInitializeWorkSpaceEvents;

            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                Core.Core.Instanse.Data[i].Images.CountChanged += this.EventHandler;
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
            Core.Core.Instanse.Data.Items.CountChanged -= this.ReInitializeWorkSpaceEvents;

            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                Core.Core.Instanse.Data[i].Changed -= this.EventHandler;
            }

            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                Core.Core.Instanse.Data[i].Images.CountChanged -= this.EventHandler;
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
                TreeNode[] itemTreeNode = new TreeNode[Core.Core.Instanse.Data[i].Images.Count];
                for (int k = 0; k < Core.Core.Instanse.Data[i].Images.Count; k++)
                {
                    itemTreeNode[k] = new TreeNode(Core.Core.Instanse.Data[i].Images[k].Name, 1, 1);
                }

                TreeNode mainTreeNode = new TreeNode(Core.Core.Instanse.Data[i].Name, 0, 0, itemTreeNode)
                {
                    Name = Core.Core.Instanse.Data[i].Name
                };
                mainTreeView.Nodes.Add(mainTreeNode);
                mainTreeNode.ExpandAll();
            }

            this.mainTreeViewAfterSelect(null, null);
        }

        protected void mainTreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            this.SelectedWorkSpace = -1;
            this.SelectedImages = -1;

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
                    this.SelectedImages = indexes[1];
                }
            }

            if (this.ImagesChanged != null)
            {
                this.ImagesChanged();
            }
        }

        protected void Delete(object sender, EventArgs e)
        {
            if (this.SelectedWorkSpace == -1)
            {
                return;
            }

            if (WinHelper.MessageBox("Do you really want to delete this Images?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            (Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedImages] as Image).Delete();
            Core.Core.Instanse.Data[this.SelectedWorkSpace].Images.RemoveAt(this.SelectedImages);

            if (this.ImagesChanged != null)
            {
                this.ImagesChanged();
            }
        }

        public event SimpleEventHandler ImagesChanged;

        protected void Create(object sender, EventArgs e)
        {
            if (this.SelectedWorkSpace == -1)
            {
                return;
            }

            new ItemAction()
                {
                    Action = DataActionType.Create,
                    Element = DataElementType.Images,
                    WorkSpace = Core.Core.Instanse.Data[this.SelectedWorkSpace]
                }.Show(FindForm());
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
                    Element = DataElementType.Images,
                    WorkSpace = Core.Core.Instanse.Data[this.SelectedWorkSpace],
                    Item = Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedImages]
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
                Element = DataElementType.Images,
                WorkSpace = Core.Core.Instanse.Data[this.SelectedWorkSpace],
                Item = Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedImages],
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
