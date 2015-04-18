using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Interfaces.WebParser;
using Umax.Resources;
using WebParser.Windows.Tasks;

namespace WebParser.Controls
{
    public partial class AllTasksGridControl : UserControl
    {
        public AllTasksGridControl()
        {
            InitializeComponent();
        }

        private void AllTasksGridControlLoad(object sender, EventArgs e)
        {
            this.InitializeImages();
            this.InitializeEvents();

            this.UpdateControl();
        }

        private void InitializeImages()
        {
            addToolStripButton.Image = Resources.PlusGreen;

            startToolStripButton.Image = Resources.Start;
            pauseToolStripButton.Image = Resources.Pause;
            stopToolStripButton.Image = Resources.Stop;

            editToolStripButton.Image = Resources.Edit;
            deleteToolStripButton.Image = Resources.MinusGreen;

            filterToolStripSplitButton.Image = Resources.History;

            mainImageList.Images.Add(Resources.WorkSpace);
            mainImageList.Images.Add(Resources.ImageGreen);
            mainImageList.Images.Add(Resources.Start);
            mainImageList.Images.Add(Resources.Pause);
            mainImageList.Images.Add(Resources.Stop);
            mainImageList.Images.Add(Resources.Upload);
            mainImageList.Images.Add(Resources.ImageRed);
            mainImageList.Images.Add(Resources.Ok);
            mainImageList.Images.Add(Resources.Kill);
        }
        
        private void InitializeEvents()
        {
            if (DesignMode)
            {
                return;
            }

            Core.Core.Instanse.Data.Items.CountChanged += this.UpdateControl;
            Core.Core.Instanse.Manager.TasksStateChanged += this.UpdateControl;
        }

        public void DeInitializeEvents()
        {
            if (DesignMode)
            {
                return;
            }

            Core.Core.Instanse.Data.Items.CountChanged -= this.UpdateControl;
            Core.Core.Instanse.Manager.TasksStateChanged -= this.UpdateControl;
        }

        protected List<int> TaskIndexes()
        {
            List<int> indexes = new List<int>();

            if (todayToolStripMenuItem.Checked)
            {
                for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
                {
                    if (Core.Core.Instanse.Data[i].StartTime.Date == DateTime.Now.Date)
                    {
                        indexes.Add(i);
                    }
                }
            }
            else if (weekToolStripMenuItem.Checked)
            {
                DateTime start = DateTimeHelper.WeekStartDate;
                DateTime end = DateTimeHelper.WeekEndDate;

                for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
                {
                    if (start <= Core.Core.Instanse.Data[i].StartTime.Date && Core.Core.Instanse.Data[i].StartTime.Date <= end)
                    {
                        indexes.Add(i);
                    }
                }
            }
            else if (monthToolStripMenuItem.Checked)
            {
                for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
                {
                    if (Core.Core.Instanse.Data[i].StartTime.Year == DateTime.Now.Year && Core.Core.Instanse.Data[i].StartTime.Month == DateTime.Now.Month)
                    {
                        indexes.Add(i);
                    }
                }
            }
            else if (yearToolStripMenuItem.Checked)
            {
                for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
                {
                    if (Core.Core.Instanse.Data[i].StartTime.Year == DateTime.Now.Year)
                    {
                        indexes.Add(i);
                    }
                }
            }
            else
            {
                for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
                {
                    indexes.Add(i);
                }
            }

            return indexes;
        }

        public void UpdateControl()
        {
            List<int> indexes = this.TaskIndexes();

            // Update rows
            mainTModel.Rows.Clear();
            for (int i = 0; i < indexes.Count; i++)
            {
                Umax.UI.XPTable.Models.Row row = new Umax.UI.XPTable.Models.Row();

                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(string.Empty, mainImageList.Images[this.GetTaskImageListIndex(Core.Core.Instanse.Data[indexes[i]].State)],
                                                              new Umax.UI.XPTable.Models.CellStyle()));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(Core.Core.Instanse.Data[indexes[i]].Name));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(Core.Core.Instanse.Data[indexes[i]].StartTime.ToString()));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(string.Empty));

                mainTModel.Rows.Add(row);
            }
        }

        protected int GetTaskImageListIndex(TaskStateType State)
        {
            switch (State)
            {
                case TaskStateType.New:
                    {
                        return 1;
                    }

                case TaskStateType.Running:
                    {
                        return 2;
                    }

                case TaskStateType.Paused:
                    {
                        return 3;
                    }

                case TaskStateType.Stopped:
                    {
                        return 4;
                    }

                case TaskStateType.Uploading:
                    {
                        return 5;
                    }

                case TaskStateType.Error:
                    {
                        return 6;
                    }

                case TaskStateType.Done:
                    {
                        return 7;
                    }

                case TaskStateType.Killed:
                    {
                        return 8;
                    }

                default:
                    {
                        return 0;
                    }
            }
        }

        private void mainTableCellButtonClicked(object sender, Umax.UI.XPTable.Events.CellButtonEventArgs e)
        {
            // Handle table button clicks
            List<int> indexes = this.TaskIndexes();

            new TaskLog()
                {
                    Content = Core.Core.Instanse.Data[indexes[e.Row]].Log
                }.Show();
        }

        private void addToolStripButtonClick(object sender, EventArgs e)
        {
            new TaskCreate().Show();
        }

        private void todayToolStripMenuItemClick(object sender, EventArgs e)
        {
            todayToolStripMenuItem.Checked = true;
            weekToolStripMenuItem.Checked = false;
            monthToolStripMenuItem.Checked = false;
            yearToolStripMenuItem.Checked = false;
            allToolStripMenuItem.Checked = false;

            this.UpdateControl();
        }

        private void weekToolStripMenuItemClick(object sender, EventArgs e)
        {
            todayToolStripMenuItem.Checked = false;
            weekToolStripMenuItem.Checked = true;
            monthToolStripMenuItem.Checked = false;
            yearToolStripMenuItem.Checked = false;
            allToolStripMenuItem.Checked = false;

            this.UpdateControl();
        }

        private void monthToolStripMenuItemClick(object sender, EventArgs e)
        {
            todayToolStripMenuItem.Checked = false;
            weekToolStripMenuItem.Checked = false;
            monthToolStripMenuItem.Checked = true;
            yearToolStripMenuItem.Checked = false;
            allToolStripMenuItem.Checked = false;

            this.UpdateControl();
        }

        private void yearToolStripMenuItemClick(object sender, EventArgs e)
        {
            todayToolStripMenuItem.Checked = false;
            weekToolStripMenuItem.Checked = false;
            monthToolStripMenuItem.Checked = false;
            yearToolStripMenuItem.Checked = true;
            allToolStripMenuItem.Checked = false;

            this.UpdateControl();
        }

        private void allToolStripMenuItemClick(object sender, EventArgs e)
        {
            todayToolStripMenuItem.Checked = false;
            weekToolStripMenuItem.Checked = false;
            monthToolStripMenuItem.Checked = false;
            yearToolStripMenuItem.Checked = false;
            allToolStripMenuItem.Checked = true;

            this.UpdateControl();
        }

        private void deleteToolStripButtonClick(object sender, EventArgs e)
        {
            int index = mainTModel.Selections.SelectedItems.Length == 0 ? -1 : mainTModel.Selections.SelectedItems[0].Index;

            if (index != -1)
            {
                List<int> indexes = this.TaskIndexes();

                Core.Core.Instanse.Data[indexes[index]].Delete();
                Core.Core.Instanse.Data.Items.RemoveAt(indexes[index]);
            }
        }

        private void stopToolStripButtonClick(object sender, EventArgs e)
        {
            int index = mainTModel.Selections.SelectedItems.Length == 0 ? -1 : mainTModel.Selections.SelectedItems[0].Index;

            if (index != -1)
            {
                List<int> indexes = this.TaskIndexes();

                Core.Core.Instanse.Manager.Stop(Core.Core.Instanse.Data[indexes[index]]);
            }
        }

        private void pauseToolStripButtonClick(object sender, EventArgs e)
        {
            int index = mainTModel.Selections.SelectedItems.Length == 0 ? -1 : mainTModel.Selections.SelectedItems[0].Index;

            if (index != -1)
            {
                List<int> indexes = this.TaskIndexes();

                Core.Core.Instanse.Manager.Pause(Core.Core.Instanse.Data[indexes[index]]);
            }
        }

        private void startToolStripButton_Click(object sender, EventArgs e)
        {
            int index = mainTModel.Selections.SelectedItems.Length == 0 ? -1 : mainTModel.Selections.SelectedItems[0].Index;

            if (index != -1)
            {
                List<int> indexes = this.TaskIndexes();

                Core.Core.Instanse.Manager.Start(Core.Core.Instanse.Data[indexes[index]]);
            }
        }

        private void editToolStripButtonClick(object sender, EventArgs e)
        {
            int index = mainTModel.Selections.SelectedItems.Length == 0 ? -1 : mainTModel.Selections.SelectedItems[0].Index;

            if (index != -1)
            {
                List<int> indexes = this.TaskIndexes();

                for (int i = 0; i < Core.Core.Instanse.Tasks.Executors.Count; i++)
                {
                    if (Core.Core.Instanse.Data[indexes[index]].Executor.Name == Core.Core.Instanse.Tasks.Executors[i].Name)
                    {
                        TaskEditor window = new TaskEditor();
                        window.EditType = TaskEditType.Edit;
                        window.ParserControl = Core.Core.Instanse.Tasks.Controls[i].NewInstance() as IWebParserControl;
                        window.Task = Core.Core.Instanse.Data[indexes[index]];

                        window.Show();
                        return;
                    }
                }
            }
        }
    }
}
