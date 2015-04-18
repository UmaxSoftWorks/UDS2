using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Core.Classes.Containers.Items;
using Umax.Interfaces.Containers.Items;
using Umax.Windows.Classes;
using Umax.Windows.Enums;

namespace Umax.Windows.Windows.Data
{
    public partial class ItemAction : Form
    {
        public ItemAction()
        {
            InitializeComponent();
        }

        public DataElementType Element { get; set; }
        public DataActionType Action { get; set; }
        public IWorkSpace WorkSpace { get; set; }

        /// <summary>
        /// An object to work with. Needed for copy and rename operations
        /// </summary>
        public IItem Item { get; set; }

        /// <summary>
        /// Encoding for templates creation
        /// </summary>
        public Encoding Encoding { get; set; }

        private void okButtonClick(object sender, EventArgs e)
        {
            this.OK();
        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void nameTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.OK();
            }
        }

        private void OK()
        {
            if (nameTextBox.Text == string.Empty)
            {
                return;
            }

            switch (this.Action)
            {
                case DataActionType.Create:
                    {
                        this.Create();
                        break;
                    }

                case DataActionType.Copy:
                    {
                        this.Copy();
                        break;
                    }

                case DataActionType.Rename:
                    {
                        this.Rename();
                        break;
                    }
            }

            Close();
        }

        private void ItemActionLoad(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Enabled = false;
            }

            this.Icon = Resources.Resources.IconRed;
            this.Text = Brand.Brand.Name + " " + this.Text;

            switch (this.Action)
            {
                case DataActionType.Create:
                    {
                        this.Text += " " + "Create";
                        break;
                    }

                case DataActionType.Copy:
                    {
                        this.Text += " " + "Copy";
                        break;
                    }

                case DataActionType.Rename:
                    {
                        this.Text += " " + "Rename";
                        break;
                    }
            }

            switch (this.Element)
            {
                case DataElementType.WorkSpaces:
                    {
                        this.Text += " " + "WorkSpace";
                        break;
                    }

                case DataElementType.Images:
                    {
                        this.Text += " " + "Images";
                        break;
                    }

                case DataElementType.Keywords:
                    {
                        this.Text += " " + "Keywords";
                        break;
                    }

                case DataElementType.Presets:
                    {
                        this.Text += " " + "Preset";
                        break;
                    }

                case DataElementType.Tasks:
                    {
                        this.Text += " " + "Task";
                        break;
                    }

                case DataElementType.Templates:
                    {
                        this.Text += " " + "Template";
                        break;
                    }

                case DataElementType.Text:
                    {
                        this.Text += " " + "Text";
                        break;
                    }
            }

            if (this.Element == DataElementType.WorkSpaces)
            {
                wsLabel.Visible = false;
                wsComboBox.Visible = false;
                return;
            }

            if (this.Action == DataActionType.Rename || this.Element == DataElementType.Tasks)
            {
                wsComboBox.Enabled = false;
            }

            wsComboBox.Items.Clear();
            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                wsComboBox.Items.Add(new IDElement(Core.Core.Instanse.Data[i].ID, Core.Core.Instanse.Data[i].Name));
            }

            if (this.WorkSpace != null)
            {
                for (int i = 0; i < wsComboBox.Items.Count; i++)
                {
                    if ((wsComboBox.Items[i] as IDElement).ID == this.WorkSpace.ID)
                    {
                        wsComboBox.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void ItemActionFormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Enabled = true;
            }
        }

        private void Create()
        {
            switch (this.Element)
            {
                case DataElementType.WorkSpaces:
                    {
                        WorkSpace workSpace = new WorkSpace
                                                  {
                                                      Name = nameTextBox.Text,
                                                      ID = Core.Core.Instanse.Data.Items.NextID()
                                                  };

                        Core.Core.Instanse.Data.Items.Add(workSpace);
                        break;
                    }

                case DataElementType.Text:
                    {
                        if (this.CanCreateItem)
                        {
                            int index = this.WorkSpaceIndex;

                            if (index != -1)
                            {
                                Core.Core.Instanse.Data[index].Text.Add(new Text()
                                                                            {
                                                                                ID = Core.Core.Instanse.Data[index].Text.NextID(),
                                                                                Name = nameTextBox.Text
                                                                            });
                            }
                        }

                        break;
                    }

                case DataElementType.Images:
                    {
                        if (this.CanCreateItem)
                        {
                            int index = this.WorkSpaceIndex;

                            if (index != -1)
                            {
                                Core.Core.Instanse.Data[index].Images.Add(new Image()
                                                                              {
                                                                                  ID = Core.Core.Instanse.Data[index].Images.NextID(),
                                                                                  Name = nameTextBox.Text,
                                                                                  Items = new List<IFile>()
                                                                              });
                            }
                        }

                        break;
                    }

                case DataElementType.Keywords:
                    {
                        if (this.CanCreateItem)
                        {
                            int index = this.WorkSpaceIndex;

                            if (index != -1)
                            {
                                Core.Core.Instanse.Data[index].Keywords.Add(new KeyWord()
                                                                                {
                                                                                    ID = Core.Core.Instanse.Data[index].Keywords.NextID(),
                                                                                    Name = nameTextBox.Text
                                                                                });
                            }
                        }

                        break;
                    }

                case DataElementType.Templates:
                    {
                        if (this.CanCreateItem)
                        {
                            int index = this.WorkSpaceIndex;

                            if (index != -1)
                            {
                                Core.Core.Instanse.Data[index].Templates.Add(new Template()
                                                                                 {
                                                                                     ID = Core.Core.Instanse.Data[index].Keywords.NextID(),
                                                                                     Name = nameTextBox.Text,
                                                                                     Encoding = this.Encoding ?? Encoding.Default
                                                                                 });
                            }
                        }

                        break;
                    }
            }
        }

        private bool CanCreateItem
        {
            get
            {
                return this.WorkSpace != null && wsComboBox.SelectedIndex != -1;
            }
        }

        private bool CanCopyItem
        {
            get
            {
                return this.CanCreateItem && this.Item != null;
            }
        }

        /// <summary>
        /// Gets index of selected WorkSpace
        /// </summary>
        private int WorkSpaceIndex
        {
            get { return wsComboBox.SelectedIndex == -1 ? -1 : Core.Core.Instanse.Data.Items.IndexOf((wsComboBox.SelectedItem as IDElement).ID); }
        }

        private void Copy()
        {
            switch (this.Element)
            {
                case DataElementType.WorkSpaces:
                    {
                        if (this.WorkSpace != null)
                        {
                            Core.Core.Instanse.Data.Items.Add((this.WorkSpace as WorkSpace).Copy(this.nameTextBox.Text));
                        }

                        break;
                    }

                case DataElementType.Tasks:
                    {
                        if (this.CanCopyItem && this.Item is Task)
                        {
                            this.WorkSpace.Tasks.Add((this.Item as Task).Copy(this.WorkSpaceIndex, nameTextBox.Text));
                        }

                        break;
                    }

                case DataElementType.Text:
                    {
                        if (this.CanCopyItem && this.Item is Text)
                        {
                            int index = this.WorkSpaceIndex;

                            if (index != -1)
                            {
                                Core.Core.Instanse.Data[index].Text.Add(new Text()
                                                                            {
                                                                                ID = Core.Core.Instanse.Data[index].Text.NextID(),
                                                                                Name = nameTextBox.Text,
                                                                                Content = (this.Item as Text).Content
                                                                            });
                            }
                        }

                        break;
                    }

                case DataElementType.Images:
                    {
                        if (this.CanCopyItem && this.Item is Image)
                        {
                            int index = this.WorkSpaceIndex;

                            if (index != -1)
                            {
                                List<IFile> items = new List<IFile>();

                                for (int i = 0; i < (this.Item as Image).Items.Count; i++)
                                {
                                    items.Add((this.Item as Image).Items[i].Clone() as IFile);
                                }

                                Core.Core.Instanse.Data[index].Images.Add(new Image()
                                                                              {
                                                                                  ID = Core.Core.Instanse.Data[index].Images.NextID(),
                                                                                  Name = nameTextBox.Text,
                                                                                  Items = items
                                                                              });
                            }
                        }

                        break;
                    }

                case DataElementType.Keywords:
                    {
                        if (this.CanCopyItem && this.Item is KeyWord)
                        {
                            int index = this.WorkSpaceIndex;

                            if (index != -1)
                            {
                                Core.Core.Instanse.Data[index].Keywords.Add(new KeyWord()
                                                                                {
                                                                                    ID = Core.Core.Instanse.Data[index].Text.NextID(),
                                                                                    Name = nameTextBox.Text,
                                                                                    Items = (this.Item as KeyWord).Items
                                                                                });
                            }
                        }

                        break;
                    }

                case DataElementType.Templates:
                    {
                        if (this.CanCopyItem && this.Item is Template)
                        {
                            int index = this.WorkSpaceIndex;

                            if (index != -1)
                            {
                                Template item = new Template()
                                                    {
                                                        ID = Core.Core.Instanse.Data[index].Templates.NextID(),
                                                        Name = nameTextBox.Text,
                                                        Encoding = (this.Item as Template).Encoding
                                                    };

                                for (int i = 0; i < (this.Item as Template).Items.Count; i++)
                                {
                                    item.Items.Add((this.Item as Template).Items[i].Clone() as IFile);
                                }

                                Core.Core.Instanse.Data[index].Templates.Add(item);
                            }
                        }

                        break;
                    }
            }
        }

        private void Rename()
        {
            switch (this.Element)
            {
                case DataElementType.WorkSpaces:
                    {
                        if (this.WorkSpace != null)
                        {
                            (this.WorkSpace as WorkSpace).Name = this.nameTextBox.Text;
                        }

                        break;
                    }

                case DataElementType.Text:
                    {
                        if (this.CanCopyItem && this.Item is Text)
                        {
                            int index = this.WorkSpaceIndex;

                            if (index != -1)
                            {
                                (this.Item as Text).Name = nameTextBox.Text;
                            }
                        }

                        break;
                    }

                case DataElementType.Images:
                    {
                        if (this.CanCopyItem && this.Item is Image)
                        {
                            int index = this.WorkSpaceIndex;

                            if (index != -1)
                            {
                                (this.Item as Image).Name = nameTextBox.Text;
                            }
                        }

                        break;
                    }

                case DataElementType.Keywords:
                    {
                        if (this.CanCopyItem && this.Item is KeyWord)
                        {
                            int index = this.WorkSpaceIndex;

                            if (index != -1)
                            {
                                (this.Item as KeyWord).Name = nameTextBox.Text;
                            }
                        }

                        break;
                    }
            }
        }
    }
}
