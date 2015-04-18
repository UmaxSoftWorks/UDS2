using System;
using System.Windows.Forms;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Events;
using Umax.Interfaces.Tasks;
using Umax.Plugins.Tasks.Enums;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class MapTabPageControl : UserControl
    {
        public MapTabPageControl()
        {
            InitializeComponent();
        }

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

        public virtual void ValidateSettings()
        {
            if (mapComboBox.SelectedIndex == 1 || mapComboBox.SelectedIndex == 3)
            {
                if (mapXMLNameTextBox.Text == string.Empty)
                {
                    throw new Exception("Please specify XML map name!");
                }
            }
            else if (mapComboBox.SelectedIndex == 2 || mapComboBox.SelectedIndex == 3)
            {
                if (mapHTMLNameTextBox.Text == string.Empty)
                {
                    throw new Exception("Please specify HTML map name!");
                }
            }
        }

        public virtual void CollectSettings()
        {
            switch (mapComboBox.SelectedIndex)
            {
                // None
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).Map = MapType.None;
                        break;
                    }

                // XML
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).Map = MapType.XML;
                        break;
                    }

                // HTML
                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).Map = MapType.HTML;
                        break;
                    }

                // XML+HTML
                case 3:
                    {
                        (this.Task.Executor.Settings as TaskSettings).Map = MapType.XMLHTML;
                        break;
                    }

                // Auto HTML
                case 4:
                    {
                        (this.Task.Executor.Settings as TaskSettings).Map = MapType.AutoHTML;
                        break;
                    }

                // XML+Auto HTML
                case 5:
                    {
                        (this.Task.Executor.Settings as TaskSettings).Map = MapType.XMLAutoHTML;
                        break;
                    }
            }

            // Include
            (this.Task.Executor.Settings as TaskSettings).MapIncludeIndex = mapIncludeCheckedListBox.GetSelected(0);
            (this.Task.Executor.Settings as TaskSettings).MapIncludeRegularPages = mapIncludeCheckedListBox.GetSelected(1);
            (this.Task.Executor.Settings as TaskSettings).MapIncludeStaticPages = mapIncludeCheckedListBox.GetSelected(2);
            (this.Task.Executor.Settings as TaskSettings).MapIncludeCategories = mapIncludeCheckedListBox.GetSelected(3);
            (this.Task.Executor.Settings as TaskSettings).MapIncludeCustomPages = mapIncludeCheckedListBox.GetSelected(4);

            // HTML
            switch (mapHTMLComboBox.SelectedIndex)
            {
                // Single page
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).MapHTML = MapHTMLType.SinglePage;
                        break;
                    }

                // Multi page
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).MapHTML = MapHTMLType.MultiPage;
                        break;
                    }
            }

            (this.Task.Executor.Settings as TaskSettings).MapHTMLName = mapHTMLNameTextBox.Text;
            (this.Task.Executor.Settings as TaskSettings).MapHTMLLinksOnPageMin = (int)mapHTMLLinksMinNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).MapHTMLLinksOnPageMax = (int)mapHTMLLinksMaxNumericUpDown.Value;

            // XML
            (this.Task.Executor.Settings as TaskSettings).MapXMLName = mapXMLNameTextBox.Text;
        }

        public event SimpleEventHandler SiteMapTypeChanged;

        public MapType SiteMapType
        {
            get
            {
                switch (mapComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            return MapType.None;
                        }

                    case 1:
                        {
                            return MapType.XML;
                        }

                    case 2:
                        {
                            return MapType.HTML;
                        }

                    case 3:
                        {
                            return MapType.XMLHTML;
                        }
                }

                return MapType.None;
            }
        }

        protected virtual void mapComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mapComboBox.SelectedIndex)
            {
                case 0:
                    {
                        mapIncludeCheckedListBox.Enabled = false;
                        mapHTMLComboBox.Enabled = false;
                        mapHTMLNameTextBox.Enabled = false;
                        mapHTMLLinksMinNumericUpDown.Enabled = false;
                        mapHTMLLinksMaxNumericUpDown.Enabled = false;
                        mapXMLNameTextBox.Enabled = false;
                        break;
                    }

                case 1:
                    {
                        mapIncludeCheckedListBox.Enabled = true;
                        mapHTMLComboBox.Enabled = false;
                        mapHTMLNameTextBox.Enabled = false;
                        mapHTMLLinksMinNumericUpDown.Enabled = false;
                        mapHTMLLinksMaxNumericUpDown.Enabled = false;
                        mapXMLNameTextBox.Enabled = true;
                        break;
                    }

                case 2:
                    {
                        mapIncludeCheckedListBox.Enabled = true;
                        mapHTMLComboBox.Enabled = true;
                        mapHTMLNameTextBox.Enabled = true;
                        mapHTMLLinksMinNumericUpDown.Enabled = true;
                        mapHTMLLinksMaxNumericUpDown.Enabled = true;
                        mapXMLNameTextBox.Enabled = false;
                        break;
                    }

                case 3:
                    {
                        mapIncludeCheckedListBox.Enabled = true;
                        mapHTMLComboBox.Enabled = true;
                        mapHTMLNameTextBox.Enabled = true;
                        mapHTMLLinksMinNumericUpDown.Enabled = true;
                        mapHTMLLinksMaxNumericUpDown.Enabled = true;
                        mapXMLNameTextBox.Enabled = true;
                        break;
                    }
            }

            if (this.SiteMapTypeChanged != null)
            {
                this.SiteMapTypeChanged.Invoke();
            }
        }

        private void UpdateControl()
        {
            switch ((this.Task.Executor.Settings as TaskSettings).Map)
            {
                case MapType.None:
                    {
                        mapComboBox.SelectedIndex = 0;
                        break;
                    }

                case MapType.XML:
                    {
                        mapComboBox.SelectedIndex = 1;
                        break;
                    }

                case MapType.HTML:
                    {
                        mapComboBox.SelectedIndex = 2;
                        break;
                    }

                case MapType.XMLHTML:
                    {
                        mapComboBox.SelectedIndex = 3;
                        break;
                    }

                case MapType.AutoHTML:
                    {
                        mapComboBox.SelectedIndex = 4;
                        break;
                    }

                case MapType.XMLAutoHTML:
                    {
                        mapComboBox.SelectedIndex = 5;
                        break;
                    }
            }

            mapIncludeCheckedListBox.SetItemChecked(0, (this.Task.Executor.Settings as TaskSettings).MapIncludeIndex);
            mapIncludeCheckedListBox.SetItemChecked(1, (this.Task.Executor.Settings as TaskSettings).MapIncludeRegularPages);
            mapIncludeCheckedListBox.SetItemChecked(2, (this.Task.Executor.Settings as TaskSettings).MapIncludeStaticPages);
            mapIncludeCheckedListBox.SetItemChecked(3, (this.Task.Executor.Settings as TaskSettings).MapIncludeCategories);
            mapIncludeCheckedListBox.SetItemChecked(4, (this.Task.Executor.Settings as TaskSettings).MapIncludeCustomPages);

            switch ((this.Task.Executor.Settings as TaskSettings).MapHTML)
            {
                case MapHTMLType.SinglePage:
                    {
                        mapHTMLComboBox.SelectedIndex = 0;
                        break;
                    }

                case MapHTMLType.MultiPage:
                    {
                        mapHTMLComboBox.SelectedIndex = 1;
                        break;
                    }
            }

            mapHTMLNameTextBox.Text = (this.Task.Executor.Settings as TaskSettings).MapHTMLName;
            mapHTMLLinksMinNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).MapHTMLLinksOnPageMin;
            mapHTMLLinksMaxNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).MapHTMLLinksOnPageMax;

            mapXMLNameTextBox.Text = (this.Task.Executor.Settings as TaskSettings).MapXMLName;
        }
    }
}
