using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Windows.Enums;
using Umax.Windows.Helpers;
using Umax.Windows.Interfaces;
using Umax.Windows.Windows.Log;
using Helper = Core.Helpers.Helper;

namespace Umax.Windows.Controls.Views.Data
{
    public partial class TasksGridDataControl : UserControl, IEventedControl, ITasksControl
    {
        public TasksGridDataControl()
        {
            InitializeComponent();
        }

        private void TasksGridDataControlLoad(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            this.Initialized = true;

            this.selectedDate = DateTime.Now;

            this.InitializeImages();
            this.InitializeEvents();

            this.UpdateControl();
        }

        public void InitializeImages()
        {
            newToolStripButton.Image = Resources.Resources.PlusBlue;
            copyToolStripButton.Image = Resources.Resources.Copy;
            editToolStripButton.Image = Resources.Resources.Edit;
            runToolStripButton.Image = Resources.Resources.Start;
            pauseToolStripButton.Image = Resources.Resources.Pause;
            stopToolStripButton.Image = Resources.Resources.Stop;
            deleteToolStripButton.Image = Resources.Resources.MinusBlue;
            filterToolStripButton.Image = Resources.Resources.Update;

            workSpaceTextColumn.Image = Resources.Resources.WorkSpace;

            mainImageList.Images.Add(Resources.Resources.WorkSpace);
            mainImageList.Images.Add(Resources.Resources.ImageGreen);
            mainImageList.Images.Add(Resources.Resources.Start);
            mainImageList.Images.Add(Resources.Resources.Pause);
            mainImageList.Images.Add(Resources.Resources.Stop);
            mainImageList.Images.Add(Resources.Resources.Upload);
            mainImageList.Images.Add(Resources.Resources.ImageRed);
            mainImageList.Images.Add(Resources.Resources.Ok);
            mainImageList.Images.Add(Resources.Resources.Kill);
        }

        public virtual void InitializeEvents()
        {
            Core.Core.Instanse.Manager.TasksStateChanged += this.EventHandler;
            Core.Core.Instanse.Manager.TasksProgressChanged += this.EventHandler;
            Core.Core.Instanse.Manager.TaskStarted += this.EventHandler;
            Core.Core.Instanse.Manager.TaskCompleted += this.EventHandler;
            Core.Core.Instanse.Manager.TaskFailed += this.EventHandler;
            Core.Core.Instanse.Manager.TaskKilled += this.EventHandler;

            Core.Core.Instanse.Data.Items.CountChanged += this.ReInitializeWorkSpaceEvents;

            this.ReInitializeWorkSpaceEvents();

            mainTimer.Start();
        }

        protected virtual void ReInitializeWorkSpaceEvents()
        {
            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                Core.Core.Instanse.Data[i].Changed -= this.EventHandler;
                Core.Core.Instanse.Data[i].Changed += this.EventHandler;
            }
        }

        public virtual void DeInitializeEvents()
        {
            Core.Core.Instanse.Manager.TasksStateChanged -= this.EventHandler;
            Core.Core.Instanse.Manager.TasksProgressChanged -= this.EventHandler;
            Core.Core.Instanse.Manager.TaskStarted -= this.EventHandler;
            Core.Core.Instanse.Manager.TaskCompleted -= this.EventHandler;
            Core.Core.Instanse.Manager.TaskFailed -= this.EventHandler;
            Core.Core.Instanse.Manager.TaskKilled -= this.EventHandler;

            Core.Core.Instanse.Data.Items.CountChanged -= this.ReInitializeWorkSpaceEvents;

            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                Core.Core.Instanse.Data[i].Changed -= this.EventHandler;
            }

            mainTimer.Stop();
        }

        protected void EventHandler(object Task)
        {
            this.EventHandler();
        }

        protected void EventHandler()
        {
            if (this.CanUpdate(true) && !DesignMode && this.Created && this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker) delegate { this.UpdateControl(); });
            }
        }

        protected bool Initialized { get; set; }

        public void UpdateControl()
        {
            if (!this.Initialized)
            {
                this.OnLoad(EventArgs.Empty);
            }

            List<int[]> tasks = this.GetTasks(this.FilterType);

            List<Umax.UI.XPTable.Models.Row> rows = new List<Umax.UI.XPTable.Models.Row>();

            for (int i = 0; i < tasks.Count; i++)
            {
                if (filterToolStripTextBox.Text == string.Empty || Core.Core.Instanse.Data[tasks[i][0]].Tasks[tasks[i][1]].Name.Contains(filterToolStripTextBox.Text))
                {
                    Umax.UI.XPTable.Models.Row row = new Umax.UI.XPTable.Models.Row();

                    row.Cells.Add(new Umax.UI.XPTable.Models.Cell(string.Empty, mainImageList.Images[this.GetTaskImageListIndex(Core.Core.Instanse.Data[tasks[i][0]].Tasks[tasks[i][1]].State)],
                                                                  new Umax.UI.XPTable.Models.CellStyle()));
                    row.Cells.Add(new Umax.UI.XPTable.Models.Cell(Core.Core.Instanse.Data[tasks[i][0]].Name));
                    row.Cells.Add(new Umax.UI.XPTable.Models.Cell(Core.Core.Instanse.Data[tasks[i][0]].Tasks[tasks[i][1]].Name));
                    row.Cells.Add(new Umax.UI.XPTable.Models.Cell(string.Empty));

                    rows.Add(row);
                }
            }

            mainTModel.Rows.Clear();
            mainTModel.Rows.AddRange(rows.ToArray());
        }

        protected void FilterAll(object sender, EventArgs e)
        {
            filterAllToolStripMenuItem.Checked = true;
            filterNewToolStripMenuItem.Checked = false;
            filterActiveToolStripMenuItem.Checked = false;
            filterCompletedToolStripMenuItem.Checked = false;

            this.UpdateControl();
        }

        protected void FilterNew(object sender, EventArgs e)
        {
            filterAllToolStripMenuItem.Checked = false;
            filterNewToolStripMenuItem.Checked = true;
            filterActiveToolStripMenuItem.Checked = false;
            filterCompletedToolStripMenuItem.Checked = false;

            this.UpdateControl();
        }

        protected void FilterActive(object sender, EventArgs e)
        {
            filterAllToolStripMenuItem.Checked = false;
            filterNewToolStripMenuItem.Checked = false;
            filterActiveToolStripMenuItem.Checked = true;
            filterCompletedToolStripMenuItem.Checked = false;

            this.UpdateControl();
        }

        protected void FilterCompleted(object sender, EventArgs e)
        {
            filterAllToolStripMenuItem.Checked = false;
            filterNewToolStripMenuItem.Checked = false;
            filterActiveToolStripMenuItem.Checked = false;
            filterCompletedToolStripMenuItem.Checked = true;

            this.UpdateControl();
        }

        protected void FilterTextChanged(object sender, EventArgs e)
        {
            this.UpdateControl();
        }

        public TasksDateFilterType FilterType { get; set; }

        public void CopyTask(object sender, EventArgs e)
        {
            if (mainTable.SelectedItems.Length == 0)
            {
                return;
            }

            List<int[]> tasks = this.GetTasks(this.FilterType);

            DataHelper.CopyTask(FindForm(), Core.Core.Instanse.Data[tasks[mainTable.SelectedIndicies[0]][0]],
                                Core.Core.Instanse.Data[tasks[mainTable.SelectedIndicies[0]][0]].Tasks[tasks[mainTable.SelectedIndicies[0]][1]]);
        }

        public void EditTask(object sender, EventArgs e)
        {
            if (mainTable.SelectedIndicies.Length == 0)
            {
                return;
            }

            List<int[]> tasks = this.GetTasks(this.FilterType);

            DataHelper.EditTask(FindForm(), Core.Core.Instanse.Data[tasks[mainTable.SelectedIndicies[0]][0]].Tasks[tasks[mainTable.SelectedIndicies[0]][1]]);
        }

        public void PauseTask(object sender, EventArgs e)
        {
            if (mainTable.SelectedIndicies.Length == 0)
            {
                return;
            }

            List<int[]> tasks = this.GetTasks(this.FilterType);

            Core.Core.Instanse.Manager.Pause(Core.Core.Instanse.Data[tasks[mainTable.SelectedIndicies[0]][0]].Tasks[tasks[mainTable.SelectedIndicies[0]][1]]);
        }

        public void CreateTask(object sender, EventArgs e)
        {
            DataHelper.CreateTask();
        }

        public void StopTask(object sender, EventArgs e)
        {
            if (mainTable.SelectedIndicies.Length == 0)
            {
                return;
            }

            List<int[]> tasks = this.GetTasks(this.FilterType);

            Core.Core.Instanse.Manager.Stop(Core.Core.Instanse.Data[tasks[mainTable.SelectedIndicies[0]][0]].Tasks[tasks[mainTable.SelectedIndicies[0]][1]]);
        }

        private void mainTimerTick(object sender, EventArgs e)
        {
            this.EventHandler();
        }

        private DateTime selectedDate;
        public DateTime SelectedDate
        {
            get { return this.selectedDate; }
            set
            {
                this.selectedDate = value;
                this.EventHandler();
            }
        }

        public void DeleteTask(object sender, EventArgs e)
        {
            if (mainTModel.Table.SelectedIndicies.Length == 0)
            {
                return;
            }

            List<int[]> tasks = this.GetTasks(this.FilterType);

            Helper.DeleteTask(tasks[mainTModel.Table.SelectedIndicies[0]][0], tasks[mainTModel.Table.SelectedIndicies[0]][1]);
        }

        public void RunTask(object sender, EventArgs e)
        {
            if (mainTable.SelectedIndicies.Length == 0)
            {
                return;
            }

            List<int[]> tasks = this.GetTasks(this.FilterType);

            Core.Core.Instanse.Manager.Start(Core.Core.Instanse.Data[tasks[mainTable.SelectedIndicies[0]][0]].Tasks[tasks[mainTable.SelectedIndicies[0]][1]]);
        }

        protected List<int[]> GetTasks(TasksDateFilterType FilterType)
        {
            if (filterNewToolStripMenuItem.Checked)
            {
                // New
                switch (FilterType)
                {
                    case TasksDateFilterType.Date:
                        {
                            return Helper.GetTasks(TaskFilterType.New, this.SelectedDate);
                        }

                    case TasksDateFilterType.None:
                        {
                            return Helper.GetTasks(TaskFilterType.New);
                        }
                }

                return Helper.GetTasks(TaskFilterType.New);
            }

            if (filterActiveToolStripMenuItem.Checked)
            {
                // Active
                switch (FilterType)
                {
                    case TasksDateFilterType.Date:
                        {
                            return Helper.GetTasks(TaskFilterType.Active, this.SelectedDate);
                        }

                    case TasksDateFilterType.None:
                        {
                            return Helper.GetTasks(TaskFilterType.Active);
                        }
                }

                return Helper.GetTasks(TaskFilterType.Active);
            }

            if (filterCompletedToolStripMenuItem.Checked)
            {
                // Completed
                switch (FilterType)
                {
                    case TasksDateFilterType.Date:
                        {
                            return Helper.GetTasks(TaskFilterType.Completed, this.SelectedDate);
                        }

                    case TasksDateFilterType.None:
                        {
                            return Helper.GetTasks(TaskFilterType.Completed);
                        }
                }

                return Helper.GetTasks(TaskFilterType.Completed);
            }

            switch (FilterType)
            {
                case TasksDateFilterType.Date:
                    {
                        return Helper.GetTasks(TaskFilterType.None, this.SelectedDate);
                    }

                case TasksDateFilterType.None:
                    {
                        return Helper.GetTasks(TaskFilterType.None);
                    }
            }

            return Helper.GetTasks(TaskFilterType.None);
        }


        protected void mainTableCellButtonClicked(object sender, Umax.UI.XPTable.Events.CellButtonEventArgs e)
        {
            List<int[]> tasks = this.GetTasks(this.FilterType);

            TaskLog taskLogWindow = new TaskLog()
            {
                Task = Core.Core.Instanse.Data[tasks[e.Row][0]].Tasks[tasks[e.Row][1]].Name,
                Content = Core.Core.Instanse.Data[tasks[e.Row][0]].Tasks[tasks[e.Row][1]].Log
            };
            taskLogWindow.ShowDialog();
        }

        private void mainTableCellDoubleClick(object sender, Umax.UI.XPTable.Events.CellMouseEventArgs e)
        {
            List<int[]> tasks = this.GetTasks(this.FilterType);
            if (tasks.Count == 0)
            {
                return;
            }

            DataHelper.EditTask(FindForm(), Core.Core.Instanse.Data[tasks[e.Row][0]].Tasks[tasks[e.Row][1]]);
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
    }
}
