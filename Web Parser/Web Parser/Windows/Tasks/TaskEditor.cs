using System;
using System.Windows.Forms;
using Umax.Brand;
using Umax.Classes.Enums;
using Umax.Classes.Windows;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.WebParser;
using Umax.Resources;
using WebParser.Core.Classes.Containers;

namespace WebParser.Windows.Tasks
{
    public partial class TaskEditor : Form
    {
        public TaskEditor()
        {
            InitializeComponent();
        }

        public IWebParserControl ParserControl { get; set; }

        public ITask Task { get { return this.ParserControl.Task; } set { this.ParserControl.Task = value; } }

        private void TaskEditorLoad(object sender, EventArgs e)
        {
            this.Icon = Resources.IconGrey;

            this.Text = Brand.Name + " " + this.Text;

            if (this.EditType == TaskEditType.None)
            {
                this.Task = new Task();
            }

            settingsTabPage.Controls.Add(this.ParserControl as Control);
            (this.ParserControl as Control).Dock = DockStyle.Fill;
        }

        private bool OK { get; set; }

        private void okButtonClick(object sender, EventArgs e)
        {
            this.OK = true;
            Close();
        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void TaskEditorFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.OK)
            {
                return;
            }

            // Collect settings
            (this.Task as Task).StartTime = dateTimePicker.Value;

            try
            {
                this.ParserControl.Collect();
            }
            catch (Exception ex)
            {
                new MessageReporter(ex, MessageType.Error).ShowDialog();
                e.Cancel = true;
                return;
            }

            // Create task
            if (this.EditType == TaskEditType.None)
            {
                (this.Task as Task).ID = Core.Core.Instanse.Data.Items.NextID();
                (this.Task as Task).Name = nameTextBox.Text;

                // Add task to data
                Core.Core.Instanse.Data.Items.Add(this.Task as Task);
            }
        }

        public TaskEditType EditType { get; set; }
    }
}
