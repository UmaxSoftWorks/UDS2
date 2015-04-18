using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Umax.Interfaces.Compatibility.Images;
using Umax.Interfaces.Compatibility.Tasks;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Images;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class ImagesTabPageControl : UserControl
    {
        public ImagesTabPageControl()
        {
            InitializeComponent();
        }

        private UserControl ImageMakerControl { get; set; }

        protected ITask task;

        /// <summary>
        /// Sets task executor
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

        protected virtual void makersTreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            makerPanel.Controls.Clear();
            this.ImageMakerControl = null;

            if (makersTreeView.SelectedNode == null)
            {
                return;
            }

            // Find
            string controlName = string.Empty;
            for (int i = 0; i < (this.Task.Executor as ITaskImageCompatible).Images.Makers.Count; i++)
            {
                if ((this.Task.Executor as ITaskImageCompatible).Images.Makers[i].GUIName == makersTreeView.SelectedNode.Text)
                {
                    controlName = (this.Task.Executor as ITaskImageCompatible).Images.Makers[i].ControlName;
                    break;
                }
            }

            if (controlName == string.Empty)
            {
                return;
            }

            // Place image control
            for (int i = 0; i < (this.Task.Executor as ITaskImageCompatible).Images.Controls.Count; i++)
            {
                if ((this.Task.Executor as ITaskImageCompatible).Images.Controls[i].Name == controlName)
                {
                    this.ImageMakerControl = (this.Task.Executor as ITaskImageCompatible).Images.Controls[i].NewInstance() as UserControl;
                    this.ImageMakerControl.Dock = DockStyle.Fill;
                    break;
                }
            }

            if ((this.Task.Executor as TaskExecutor).ImageMaker != null)
            {
                (this.ImageMakerControl as IImageControl).ImageMaker = (this.Task.Executor as TaskExecutor).ImageMaker;
            }

            if (this.ImageMakerControl != null)
            {
                makerPanel.Controls.Add(this.ImageMakerControl);

                // Images
                if (this.ImageMakerControl is IImageDataCompatible && this.WorkSpace != null)
                {
                    (this.ImageMakerControl as IImageDataCompatible).ImageData = this.WorkSpace.Images;
                }
            }
        }

        private IWorkSpace workSpace;
        public IWorkSpace WorkSpace
        {
            protected get { return this.workSpace; }
            set
            {
                this.workSpace = value;

                if (this.ImageMakerControl != null)
                {
                    if (this.ImageMakerControl is IImageDataCompatible)
                    {
                        (this.ImageMakerControl as IImageDataCompatible).ImageData = this.WorkSpace.Images;
                    }
                }
            }
        }

        public virtual void UpdateControl()
        {
            // Image makers
            makersTreeView.Nodes.Clear();
            List<TreeNode> nodes = new List<TreeNode>();

            for (int i = 0; i < (this.Task.Executor as ITaskImageCompatible).Images.Makers.Count; i++)
            {
                if ((this.Task.Executor as ITaskImageCompatible).Images.Makers[i].Category != string.Empty)
                {
                    // Search for category
                    int categoryIndex = -1;
                    for (int k = 0; k < nodes.Count; k++)
                    {
                        if (nodes[k].Text == (this.Task.Executor as ITaskImageCompatible).Images.Makers[i].Category)
                        {
                            categoryIndex = k;
                            break;
                        }
                    }

                    // Create category
                    if (categoryIndex == -1)
                    {
                        nodes.Add(new TreeNode((this.Task.Executor as ITaskImageCompatible).Images.Makers[i].Category, 0, 0));
                        categoryIndex = nodes.Count - 1;
                    }

                    // Add node
                    nodes[categoryIndex].Nodes.Add(new TreeNode((this.Task.Executor as ITaskImageCompatible).Images.Makers[i].GUIName, 1, 1));
                }
            }

            // Image makers w/o category
            for (int i = 0; i < (this.Task.Executor as ITaskImageCompatible).Images.Makers.Count; i++)
            {
                if ((this.Task.Executor as ITaskImageCompatible).Images.Makers[i].Category == string.Empty)
                {
                    // Add node
                    nodes.Add(new TreeNode((this.Task.Executor as ITaskImageCompatible).Images.Makers[i].GUIName, 1, 1));
                }
            }

            makersTreeView.Nodes.AddRange(nodes.ToArray());
            makersTreeView.Sort();
            makersTreeView.ExpandAll();

            // Selected
            for (int i = 0; i < (this.Task.Executor as ITaskImageCompatible).Images.Makers.Count; i++)
            {
                if ((this.Task.Executor as ITaskImageCompatible).Images.Makers[i].Name == (this.Task.Executor.Settings as TaskSettings).ImageMakerName)
                {
                    for (int k = 0; k < makersTreeView.Nodes.Count; k++)
                    {
                        if (makersTreeView.Nodes[k].Nodes.Count > 0)
                        {
                            for (int l = 0; l < makersTreeView.Nodes[k].Nodes.Count; l++)
                            {
                                if (makersTreeView.Nodes[k].Nodes[l].Text == (this.Task.Executor as ITaskImageCompatible).Images.Makers[i].GUIName)
                                {
                                    makersTreeView.SelectedNode = makersTreeView.Nodes[k].Nodes[l];
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (makersTreeView.Nodes[k].Text == (this.Task.Executor as ITaskImageCompatible).Images.Makers[i].GUIName)
                            {
                                makersTreeView.SelectedNode = makersTreeView.Nodes[k];
                                break;
                            }
                        }
                    }
                }
            }

            this.imagesCheckBoxCheckedChanged(this, EventArgs.Empty);
            this.makersTreeViewAfterSelect(this, null);
        }

        public virtual void CollectSettings()
        {
            (this.Task.Executor.Settings as TaskSettings).Images = imagesCheckBox.Checked;

            if ((this.Task.Executor.Settings as TaskSettings).Images)
            {
                for (int i = 0; i < (this.Task.Executor as ITaskImageCompatible).Images.Makers.Count; i++)
                {
                    if ((this.Task.Executor as ITaskImageCompatible).Images.Makers[i].GUIName == makersTreeView.SelectedNode.Text)
                    {
                        (this.Task.Executor.Settings as TaskSettings).ImageMakerName = (this.Task.Executor as ITaskImageCompatible).Images.Makers[i].Name;
                        break;
                    }
                }
            }
        }

        protected virtual void imagesCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            makersTreeView.Enabled = imagesCheckBox.Checked;
            makerPanel.Enabled = imagesCheckBox.Checked;
        }

        public virtual void ValidateSettings()
        {
            if (imagesCheckBox.Checked)
            {
                if (makersTreeView.SelectedNode == null)
                {
                    throw new Exception("Please select Image Maker!");
                }

                if (makersTreeView.SelectedNode.Parent == null)
                {
                    throw new Exception("Please select Image Maker!");
                }

                if (makersTreeView.SelectedNode.Nodes.Count != 0)
                {
                    throw new Exception("Please select Image Maker!");
                }
            }
        }

        public IImageMaker ImageMaker { get { return imagesCheckBox.Checked ? (this.ImageMakerControl as IImageControl).ImageMaker : null; } }

        private void ImagesTabPageControlLoad(object sender, EventArgs e)
        {
            mainImageList.Images.Add(Resources.Resources.Folder);
            mainImageList.Images.Add(Resources.Resources.Preset);
        }
    }
}