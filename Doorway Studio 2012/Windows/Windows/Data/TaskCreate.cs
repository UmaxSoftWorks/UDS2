using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Umax.Interfaces.Tasks;

namespace Umax.Windows.Windows.Data
{
    public partial class TaskCreate : StandardWindow
    {
        public TaskCreate()
        {
            InitializeComponent();
        }

        protected void InitializeImages()
        {
            this.Icon = Resources.Resources.IconRed;

            mainImageList.Images.Add(Resources.Resources.WorkSpace);
            mainImageList.Images.Add(Resources.Resources.Item);
        }

        private void CreateTaskLoad(object sender, EventArgs e)
        {
            this.Text = Brand.Brand.Name + " " + this.Text;
            this.InitializeImages();

            // Categories
            categoriesTreeView.Nodes.Clear();

            List<string> categories = new List<string>();
            for (int i = 0; i < Core.Core.Instanse.Tasks.Elements.Count; i++)
            {
                if (!categories.Contains(Core.Core.Instanse.Tasks.Elements[i].Category))
                {
                    categories.Add(Core.Core.Instanse.Tasks.Elements[i].Category);
                }
            }

            TreeNode[] categoryTreeNode = new TreeNode[categories.Count];
            for (int i = 0; i < categories.Count; i++)
            {
                categoryTreeNode[i] = new TreeNode(categories[i], 1, 1);
            }

            TreeNode mainTreeNode = new TreeNode("All", 0, 0, categoryTreeNode);

            categoriesTreeView.Nodes.Add(mainTreeNode);
            categoriesTreeView.Sort();
            categoriesTreeView.ExpandAll();

            this.ShowAllTasks();
        }

        private void ShowAllTasks()
        {
            // Icons
            tasksListView.Items.Clear();
            itemsImageList.Images.Clear();

            for (int i = 0; i < Core.Core.Instanse.Tasks.Elements.Count; i++)
            {
                itemsImageList.Images.Add(Core.Core.Instanse.Tasks.Elements[i].Image);
                tasksListView.Items.Add(Core.Core.Instanse.Tasks.Elements[i].GUIName, i);
            }

            tasksListView.Sort();
        }

        private List<int> SelectedNodes
        {
            get
            {
                List<int> indexes = new List<int>();
                if (categoriesTreeView.SelectedNode == null)
                {
                    return indexes;
                }

                TreeNode node = categoriesTreeView.SelectedNode;
                indexes.Add(categoriesTreeView.SelectedNode.Index);

                while (node.Parent != null)
                {
                    node = node.Parent;
                    indexes.Insert(0, node.Index);
                }

                return indexes;
            }
        }

        private void okButtonClick(object sender, EventArgs e)
        {
            this.OK = true;
            Close();
        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void tasksListViewDoubleClick(object sender, EventArgs e)
        {
            this.OK = true;
            Close();
        }

        private bool OK { get; set; }

        private void categoriesTreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            // Find Category
            List<int> indexes = this.SelectedNodes;
            if (indexes.Count < 1)
            {
                return;
            }

            if (indexes.Count == 1)
            {
                this.ShowAllTasks();
            }
            else
            {
                // Icons
                tasksListView.Items.Clear();
                itemsImageList.Images.Clear();
                for (int i = 0; i < Core.Core.Instanse.Tasks.Elements.Count; i++)
                {
                    if (Core.Core.Instanse.Tasks.Elements[i].Category == categoriesTreeView.SelectedNode.Text)
                    {
                        itemsImageList.Images.Add(Core.Core.Instanse.Tasks.Elements[i].Image);
                        tasksListView.Items.Add(Core.Core.Instanse.Tasks.Elements[i].GUIName, i);
                    }
                }
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (!this.OK)
            {
                return;
            }

            if (tasksListView.SelectedItems.Count == 0)
            {
                return;
            }

            for (int i = 0; i < Core.Core.Instanse.Tasks.Windows.Count; i++)
            {
                if (Core.Core.Instanse.Tasks.Windows[i].Name == Core.Core.Instanse.Tasks.Elements[tasksListView.SelectedItems[0].Index].WindowName)
                {
                    Form window = Core.Core.Instanse.Tasks.Windows[i].NewInstance() as Form;

                    if (!(window is ITaskWindow)) return;

                    // Invoke
                    window.Show();
                    return;
                }
            }
        }
    }
}
