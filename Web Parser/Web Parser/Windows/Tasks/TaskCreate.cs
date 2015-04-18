using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Umax.Brand;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Tasks;
using Umax.Interfaces.Text;
using Umax.Interfaces.WebParser;
using Umax.Resources;
using WebParser.Core.Classes.Containers;

namespace WebParser.Windows.Tasks
{
    public partial class TaskCreate : Form
    {
        public TaskCreate()
        {
            InitializeComponent();
        }

        private void TaskCreateLoad(object sender, EventArgs e)
        {
            this.Text = Brand.Name + " " + this.Text;
            this.InitializeImages();

        }

        protected void InitializeImages()
        {
            this.Icon = Resources.IconGrey;

            this.ShowAllTasks();
        }

        private void ShowAllTasks()
        {
            // Icons
            tasksListView.Items.Clear();
            mainImageList.Images.Clear();

            for (int i = 0; i < Core.Core.Instanse.Tasks.Elements.Count; i++)
            {
                mainImageList.Images.Add(Core.Core.Instanse.Tasks.Elements[i].Image);
                tasksListView.Items.Add(Core.Core.Instanse.Tasks.Elements[i].GUIName, i);
            }

            tasksListView.Sort();
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

            for (int i = 0; i < Core.Core.Instanse.Tasks.Executors.Count; i++)
            {
                if (Core.Core.Instanse.Tasks.Executors[i].Name == Core.Core.Instanse.Tasks.Controls[tasksListView.SelectedItems[0].Index].ExecutorName)
                {
                    TaskEditor window = new TaskEditor();

                    window.EditType = TaskEditType.None;
                    window.ParserControl = Core.Core.Instanse.Tasks.Controls[i].NewInstance() as IWebParserControl;

                    // Invoke
                    window.Show();
                    return;
                }
            }
        }
    }
}
