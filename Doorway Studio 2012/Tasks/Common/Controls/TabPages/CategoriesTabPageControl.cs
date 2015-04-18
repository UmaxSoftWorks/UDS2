using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Umax.Classes.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Plugins.Tasks.Enums;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class CategoriesTabPageControl : UserControl
    {
        public CategoriesTabPageControl()
        {
            InitializeComponent();
        }

        protected ITask task;

        /// <summary>
        /// Sets task
        /// </summary>
        public ITask Task
        {
            get { return this.task; }
            set
            {
                this.task = value;

                this.UpdateControl();
            }
        }

        protected virtual List<Category> CategoriesTreeViewToCategoriesTree(TreeNode[] Nodes)
        {
            List<Category> nodes = new List<Category>();

            for (int i = 0; i < Nodes.Length; i++)
            {
                nodes.Add(new Category { Name = Nodes[i].Text });

                if (Nodes[i].Nodes.Count != 0)
                {
                    TreeNode[] subNodes = new TreeNode[Nodes[i].Nodes.Count];
                    Nodes[i].Nodes.CopyTo(subNodes, 0);

                    nodes[i].Categories.AddRange(
                        this.CategoriesTreeViewToCategoriesTree(subNodes).ToArray());
                }
            }

            return nodes;
        }

        protected virtual TreeNode[] CategoriesTreeToCategoriesTreeView(List<ICategory> CategoriesTreeList)
        {
            if (CategoriesTreeList == null) return null;

            TreeNode[] nodes = new TreeNode[CategoriesTreeList.Count];
            for (int i = 0; i < CategoriesTreeList.Count; i++)
            {
                nodes[i] = new TreeNode(CategoriesTreeList[i].Name);

                TreeNode[] subNodes = this.CategoriesTreeToCategoriesTreeView(CategoriesTreeList[i].Categories);
                if (subNodes != null)
                {
                    nodes[i].Nodes.AddRange(subNodes);
                }
            }

            return nodes;
        }

        public virtual void CollectSettings()
        {
            (this.Task.Executor.Settings as TaskSettings).Categories = new List<ICategory>();

            TreeNode[] nodes = new TreeNode[mainTreeView.Nodes.Count];
            mainTreeView.Nodes.CopyTo(nodes, 0);
            (this.Task.Executor.Settings as TaskSettings).Categories.AddRange(this.CategoriesTreeViewToCategoriesTree(nodes).ToArray());

            switch (distributionComboBox.SelectedIndex)
            {
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).CategoriesDistribution = CategoriesDistributionType.Random;
                        break;
                    }

                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).CategoriesDistribution = CategoriesDistributionType.Contains;
                        break;
                    }
            }
        }

        protected virtual void addToolStripButtonClick(object sender, EventArgs e)
        {
            if (mainTreeView.Nodes.Count == 0)
            {
                mainTreeView.Nodes.Add("[RBWORD]");
                return;
            }

            if (mainTreeView.SelectedNode == null)
            {
                mainTreeView.Nodes.Add("[RBWORD]");
                return;
            }

            mainTreeView.SelectedNode.Nodes.Add("[RBWORD]");

            mainTreeView.ExpandAll();
        }

        protected virtual void removeToolStripButtonClick(object sender, EventArgs e)
        {
            if (mainTreeView.SelectedNode != null)
            {
                mainTreeView.Nodes.Remove(mainTreeView.SelectedNode);
            }

            mainTreeView.ExpandAll();
        }

        protected virtual void clearToolStripButtonClick(object sender, EventArgs e)
        {
            mainTreeView.Nodes.Clear();
            nameTextBox.Text = string.Empty;
        }

        protected virtual void generateToolStripButtonClick(object sender, EventArgs e)
        {
            mainTreeView.Nodes.Clear();
            Random random = new Random();
            TreeNode[] mainNodes = new TreeNode[random.Next(3, 9)];
            for (int i = 0; i < mainNodes.Length; i++)
            {
                mainNodes[i] = new TreeNode("[RBWORD]");
                TreeNode[] subNodes = new TreeNode[random.Next(2, 7)];
                for (int k = 0; k < subNodes.Length; k++)
                {
                    subNodes[k] = new TreeNode("[RBWORD]");
                    TreeNode[] subSubNodes = new TreeNode[random.Next(2, 5)];
                    for (int l = 0; l < subSubNodes.Length; l++)
                    {
                        subSubNodes[l] = new TreeNode("[RBWORD]");
                    }

                    subNodes[k].Nodes.AddRange(subSubNodes);
                }

                mainNodes[i].Nodes.AddRange(subNodes);
            }

            mainTreeView.Nodes.AddRange(mainNodes);
            mainTreeView.ExpandAll();
        }

        protected void categoriesTreeViewClick(object sender, EventArgs e)
        {
            nameTextBox.Text = string.Empty;
        }

        protected virtual void categoriesTreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            nameTextBox.Text = mainTreeView.SelectedNode != null
                                             ? mainTreeView.SelectedNode.Text
                                             : string.Empty;
        }

        protected virtual void categoriesPictureBoxClick(object sender, EventArgs e)
        {
            if (mainTreeView.SelectedNode != null)
            {
                if (nameTextBox.Text == string.Empty) return;

                mainTreeView.SelectedNode.Text = nameTextBox.Text;
                nameTextBox.Text = string.Empty;
            }
        }

        protected virtual void categoriesNameTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.categoriesPictureBoxClick(null, null);
            }
        }

        private void CategoriesTabPageControlLoad(object sender, EventArgs e)
        {
            this.addToolStripButton.Image = Resources.Resources.PlusBlue;
            this.clearToolStripButton.Image = Resources.Resources.Delete;
            this.generateToolStripButton.Image = Resources.Resources.Gears;
            this.removeToolStripButton.Image = Resources.Resources.MinusBlue;
        }

        private void UpdateControl()
        {
            mainTreeView.Nodes.Clear();
            mainTreeView.Nodes.AddRange(this.CategoriesTreeToCategoriesTreeView((this.Task.Executor.Settings as TaskSettings).Categories));
            mainTreeView.ExpandAll();


            switch ((this.Task.Executor.Settings as TaskSettings).CategoriesDistribution)
            {
                case CategoriesDistributionType.Random:
                    {
                        distributionComboBox.SelectedIndex = 0;
                        break;
                    }

                case CategoriesDistributionType.Contains:
                    {
                        distributionComboBox.SelectedIndex = 1;
                        break;
                    }
            }
        }
    }
}
