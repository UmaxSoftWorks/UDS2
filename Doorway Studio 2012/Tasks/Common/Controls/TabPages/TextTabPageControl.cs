using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Umax.Interfaces.Compatibility.Tasks;
using Umax.Interfaces.Compatibility.Text;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Text;
using Umax.Plugins.Tasks.Enums;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class TextTabPageControl : UserControl
    {
        public TextTabPageControl()
        {
            InitializeComponent();
        }

        private UserControl TextMakerControl { get; set; }

        public ITextMaker TextMaker
        {
            get
            {
                return (this.TextMakerControl as ITextControl).TextMaker;
            }
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

        private IWorkSpace workSpace;
        public IWorkSpace WorkSpace
        {
            protected get { return this.workSpace; }
            set
            {
                this.workSpace = value;

                if (this.TextMakerControl != null)
                {
                    if (this.TextMakerControl is ITextDataCompatible)
                    {
                        (this.TextMakerControl as ITextDataCompatible).TextData = this.WorkSpace.Text;
                    }
                }
            }
        }

        public virtual void ValidateSettings()
        {
            // Text
            if (makersTreeView.SelectedNode == null)
            {
                throw new Exception("Please select Text Maker!");
            }

            if (makersTreeView.SelectedNode.Parent == null)
            {
                throw new Exception("Please select Text Maker!");
            }

            if (makersTreeView.SelectedNode.Nodes.Count != 0)
            {
                throw new Exception("Please select Text Maker!");
            }
        }

        protected virtual void linksСomboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (linksСomboBox.SelectedIndex)
            {
                // None
                case 0:
                    {
                        linksNumberMinNumericUpDown.Enabled = false;
                        linksNumberMaxNumericUpDown.Enabled = false;
                        linksLengthMinNumericUpDown.Enabled = false;
                        linksLengthMaxNumericUpDown.Enabled = false;
                        break;
                    }

                // Keywords
                case 1:
                    {
                        linksNumberMinNumericUpDown.Enabled = true;
                        linksNumberMaxNumericUpDown.Enabled = true;
                        linksLengthMinNumericUpDown.Enabled = false;
                        linksLengthMaxNumericUpDown.Enabled = false;
                        break;
                    }

                // Text
                case 2:
                // Keywords+Text
                case 3:
                    {
                        linksNumberMinNumericUpDown.Enabled = true;
                        linksNumberMaxNumericUpDown.Enabled = true;
                        linksLengthMinNumericUpDown.Enabled = true;
                        linksLengthMaxNumericUpDown.Enabled = true;
                        break;
                    }
            }
        }

        private void makersTreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            makerPanel.Controls.Clear();
            this.TextMakerControl = null;

            if (makersTreeView.SelectedNode == null)
            {
                return;
            }

            // Find
            string textControlName = string.Empty;
            for (int i = 0; i < (this.Task.Executor as ITaskTextCompatible).Text.Makers.Count; i++)
            {
                if ((this.Task.Executor as ITaskTextCompatible).Text.Makers[i].GUIName == makersTreeView.SelectedNode.Text)
                {
                    textControlName = (this.Task.Executor as ITaskTextCompatible).Text.Makers[i].ControlName;
                    break;
                }
            }

            if (textControlName == string.Empty)
            {
                return;
            }

            // Place text control
            for (int i = 0; i < (this.Task.Executor as ITaskTextCompatible).Text.Controls.Count; i++)
            {
                if ((this.Task.Executor as ITaskTextCompatible).Text.Controls[i].Name == textControlName)
                {
                    this.TextMakerControl = (this.Task.Executor as ITaskTextCompatible).Text.Controls[i].NewInstance() as UserControl;
                    this.TextMakerControl.Dock = DockStyle.Fill;
                    break;
                }
            }

            if ((this.Task.Executor as TaskExecutor).TextMaker != null)
            {
                (this.TextMakerControl as ITextControl).TextMaker = (this.Task.Executor as TaskExecutor).TextMaker;
            }

            if (this.TextMakerControl != null)
            {
                makerPanel.Controls.Add(this.TextMakerControl);

                // Text
                if (this.TextMakerControl is ITextDataCompatible && this.WorkSpace != null)
                {
                    (this.TextMakerControl as ITextDataCompatible).TextData = this.WorkSpace.Text;

                }
            }
        }

        public virtual void CollectSettings()
        {
            for (int i = 0; i < (this.Task.Executor as ITaskTextCompatible).Text.Makers.Count; i++)
            {
                if ((this.Task.Executor as ITaskTextCompatible).Text.Makers[i].GUIName == makersTreeView.SelectedNode.Text)
                {
                    (this.Task.Executor.Settings as TaskSettings).TextMakerName = (this.Task.Executor as ITaskTextCompatible).Text.Makers[i].Name;
                    break;
                }
            }

            switch (linksСomboBox.SelectedIndex)
            {
                // None
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).TextLinks = TextLinksType.None;
                        break;
                    }

                // Keywords
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).TextLinks = TextLinksType.Keywords;
                        break;
                    }

                // Text
                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).TextLinks = TextLinksType.Text;
                        break;
                    }

                // Keywords+Text
                case 3:
                    {
                        (this.Task.Executor.Settings as TaskSettings).TextLinks = TextLinksType.KeywordsText;
                        break;
                    }
            }

            (this.Task.Executor.Settings as TaskSettings).TextLinksNumberMin = (int)linksNumberMinNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).TextLinksNumberMax = (int)linksNumberMaxNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).TextLinksLengthMin = (int)linksLengthMinNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).TextLinksLengthMax = (int)linksLengthMaxNumericUpDown.Value;
        }

        public virtual void UpdateControl()
        {

            // TextMakers
            makersTreeView.Nodes.Clear();
            List<TreeNode> nodes = new List<TreeNode>();

            for (int i = 0; i < (this.Task.Executor as ITaskTextCompatible).Text.Makers.Count; i++)
            {
                if ((this.Task.Executor as ITaskTextCompatible).Text.Makers[i].Category != string.Empty)
                {
                    // Search for category
                    int categoryIndex = -1;
                    for (int k = 0; k < nodes.Count; k++)
                    {
                        if (nodes[k].Text == (this.Task.Executor as ITaskTextCompatible).Text.Makers[i].Category)
                        {
                            categoryIndex = k;
                            break;
                        }
                    }

                    // Create category
                    if (categoryIndex == -1)
                    {
                        nodes.Add(new TreeNode((this.Task.Executor as ITaskTextCompatible).Text.Makers[i].Category, 0, 0));
                        categoryIndex = nodes.Count - 1;
                    }

                    // Add node
                    nodes[categoryIndex].Nodes.Add(new TreeNode((this.Task.Executor as ITaskTextCompatible).Text.Makers[i].GUIName, 1, 1));
                }
            }

            // Text makers w/o category
            for (int i = 0; i < (this.Task.Executor as ITaskTextCompatible).Text.Makers.Count; i++)
            {
                if ((this.Task.Executor as ITaskTextCompatible).Text.Makers[i].Category == string.Empty)
                {
                    // Add node
                    nodes.Add(new TreeNode((this.Task.Executor as ITaskTextCompatible).Text.Makers[i].GUIName, 1, 1));
                }
            }

            makersTreeView.Nodes.AddRange(nodes.ToArray());
            makersTreeView.Sort();
            makersTreeView.ExpandAll();

            // Selected
            for (int i = 0; i < (this.Task.Executor as ITaskTextCompatible).Text.Makers.Count; i++)
            {
                if ((this.Task.Executor as ITaskTextCompatible).Text.Makers[i].Name == (this.Task.Executor.Settings as TaskSettings).TextMakerName)
                {
                    for (int k = 0; k < makersTreeView.Nodes.Count; k++)
                    {
                        if (makersTreeView.Nodes[k].Nodes.Count > 0)
                        {
                            for (int l = 0; l < makersTreeView.Nodes[k].Nodes.Count; l++)
                            {
                                if (makersTreeView.Nodes[k].Nodes[l].Text == (this.Task.Executor as ITaskTextCompatible).Text.Makers[i].GUIName)
                                {
                                    makersTreeView.SelectedNode = makersTreeView.Nodes[k].Nodes[l];
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (makersTreeView.Nodes[k].Text == (this.Task.Executor as ITaskTextCompatible).Text.Makers[i].GUIName)
                            {
                                makersTreeView.SelectedNode = makersTreeView.Nodes[k];
                                break;
                            }
                        }
                    }
                }
            }

            switch ((this.Task.Executor.Settings as TaskSettings).TextLinks)
            {
                case TextLinksType.None:
                    {
                        linksСomboBox.SelectedIndex = 0;
                        break;
                    }

                case TextLinksType.Keywords:
                    {
                        linksСomboBox.SelectedIndex = 1;
                        break;
                    }

                case TextLinksType.Text:
                    {
                        linksСomboBox.SelectedIndex = 2;
                        break;
                    }

                case TextLinksType.KeywordsText:
                    {
                        linksСomboBox.SelectedIndex = 3;
                        break;
                    }
            }

            linksNumberMinNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).TextLinksNumberMin;
            linksNumberMaxNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).TextLinksNumberMax;
            linksLengthMinNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).TextLinksLengthMin;
            linksLengthMaxNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).TextLinksLengthMax;
        }

        private void TextTabPageControlLoad(object sender, EventArgs e)
        {
            mainImageList.Images.Add(Resources.Resources.Folder);
            mainImageList.Images.Add(Resources.Resources.Preset);
        }
    }
}
