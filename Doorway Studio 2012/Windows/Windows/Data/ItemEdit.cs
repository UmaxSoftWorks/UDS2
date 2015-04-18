using System;
using System.Windows.Forms;
using Umax.Windows.Controls.Data;
using Umax.Windows.Enums;
using Umax.Windows.Interfaces;

namespace Umax.Windows.Windows.Data
{
    public partial class ItemEdit : StandardWindow
    {
        public ItemEdit()
        {
            InitializeComponent();
        }

        public DataElementType Action { get; set; }
        private UserControl control;

        private void ItemEditLoad(object sender, EventArgs e)
        {
            this.Icon = Resources.Resources.IconRed;

            this.InitializeCaption();

            switch (this.Action)
            {
                case DataElementType.WorkSpaces:
                    {
                        mainComboBox.SelectedIndex = 0;
                        break;
                    }

                case DataElementType.Tasks:
                    {
                        mainComboBox.SelectedIndex = 1;
                        break;
                    }

                case DataElementType.Keywords:
                    {
                        mainComboBox.SelectedIndex = 2;
                        break;
                    }

                case DataElementType.Text:
                    {
                        mainComboBox.SelectedIndex = 3;
                        break;
                    }

                case DataElementType.Images:
                    {
                        mainComboBox.SelectedIndex = 4;
                        break;
                    }

                case DataElementType.Templates:
                    {
                        mainComboBox.SelectedIndex = 5;
                        break;
                    }

                case DataElementType.Presets:
                    {
                        mainComboBox.SelectedIndex = 6;
                        break;
                    }
            }
        }

        protected void InitializeCaption()
        {
            this.Text = Brand.Brand.Name + " Doorway Studio 2012: ";
        }

        protected void InitializeCaption(string Item)
        {
            this.Text += Item;
        }

        private void mainComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            this.InitializeCaption();

            for (int i = 0; i < mainPanel.Controls.Count; i++)
            {
                if (mainPanel.Controls[i] is IEventedControl)
                {
                    (mainPanel.Controls[i] as IEventedControl).DeInitializeEvents();
                }
            }

            mainPanel.Controls.Clear();
            this.control = null;

            switch (mainComboBox.SelectedIndex)
            {
                case 0:
                    {
                        this.InitializeCaption("WorkSpaces");
                        this.control = new WorkSpacesDataControl();
                        break;
                    }

                case 1:
                    {
                        this.InitializeCaption("Tasks");
                        this.control = new TasksDataControl();
                        break;
                    }

                case 2:
                    {
                        this.InitializeCaption("Keywords");
                        this.control = new KeywordsDataControl();
                        break;
                    }

                case 3:
                    {
                        this.InitializeCaption("Text");
                        this.control = new TextDataControl();
                        break;
                    }

                case 4:
                    {
                        this.InitializeCaption("Images");
                        this.control = new ImagesDataControl();
                        break;
                    }

                case 5:
                    {
                        this.InitializeCaption("Templates");
                        this.control = new TemplatesDataControl();
                        break;
                    }

                case 6:
                    {
                        this.InitializeCaption("Presets");
                        this.control = new PresetsDataContol();
                        break;
                    }
            }

            this.ClearControls();
        }

        protected void ClearControls()
        {
            if (this.control != null)
            {
                this.control.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(this.control);
            }
        }

        private void ItemEditFormClosing(object sender, FormClosingEventArgs e)
        {
            this.ClearControls();
        }
    }
}
