using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Enums;
using Umax.Classes.Helpers;
using Umax.Windows.Helpers;
using Umax.Windows.Interfaces;
using Umax.Windows.Windows.Log;
using Helper = Core.Helpers.Helper;

namespace Umax.Windows.Controls.Views.Manager
{
    public partial class ActiveTasksGridManagerControl : UserControl, IEventedControl, ITasksControl
    {
        public ActiveTasksGridManagerControl()
        {
            InitializeComponent();
        }

        private void ActiveTasksGridManagerControlLoad(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            this.Initialized = true;

            this.InitializeImages();
            this.InitializeEvents();
        }

        protected virtual void InitializeImages()
        {
            startButtonColumn.Image = Resources.Resources.Start;
            pauseButtonColumn.Image = Resources.Resources.Pause;
            stopButtonColumn.Image = Resources.Resources.Stop;

            startButtonColumn.Image = Resources.Resources.Start;
            pauseButtonColumn.Image = Resources.Resources.Pause;
            stopButtonColumn.Image = Resources.Resources.Stop;
        }

        public void InitializeEvents()
        {
            Core.Core.Instanse.Manager.TasksStateChanged += this.EventHandler;
            Core.Core.Instanse.Manager.TasksProgressChanged += this.EventHandler;
            Core.Core.Instanse.Manager.TaskStarted += this.EventHandler;
            Core.Core.Instanse.Manager.TaskCompleted += this.EventHandler;
            Core.Core.Instanse.Manager.TaskFailed += this.EventHandler;
            Core.Core.Instanse.Manager.TaskKilled += this.EventHandler;

            mainTimer.Start();
        }

        public void DeInitializeEvents()
        {
            Core.Core.Instanse.Manager.TasksStateChanged -= this.EventHandler;
            Core.Core.Instanse.Manager.TasksProgressChanged -= this.EventHandler;
            Core.Core.Instanse.Manager.TaskStarted -= this.EventHandler;
            Core.Core.Instanse.Manager.TaskCompleted -= this.EventHandler;
            Core.Core.Instanse.Manager.TaskFailed -= this.EventHandler;
            Core.Core.Instanse.Manager.TaskKilled -= this.EventHandler;

            mainTimer.Stop();
        }

        protected void EventHandler(object Task)
        {
            this.EventHandler();
        }

        protected void EventHandler()
        {
            if (this.CanUpdate() && !DesignMode)
            {
                this.Invoke((MethodInvoker)delegate { this.UpdateControl(); });
            }
        }

        protected bool Initialized { get; set; }

        public void UpdateControl()
        {
            if (!this.Initialized)
            {
                this.OnLoad(EventArgs.Empty);
            }

            List<int[]> tasks = Helper.GetTasks(TaskFilterType.Active);

            List<Umax.UI.XPTable.Models.Row> rows = new List<Umax.UI.XPTable.Models.Row>();

            for (int i = 0; i < tasks.Count; i++)
            {
                Umax.UI.XPTable.Models.Row row = new Umax.UI.XPTable.Models.Row();

                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(string.Empty));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(string.Empty));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(string.Empty));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(Core.Core.Instanse.Data[tasks[i][0]].Tasks[tasks[i][1]].Name));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(Core.Core.Instanse.Data[tasks[i][0]].Tasks[tasks[i][1]].Progress));
                row.Cells.Add(new Umax.UI.XPTable.Models.Cell(string.Empty));

                rows.Add(row);
            }

            mainTModel.Rows.Clear();
            mainTModel.Rows.AddRange(rows.ToArray());
        }

        protected void mainTableCellButtonClicked(object sender, Umax.UI.XPTable.Events.CellButtonEventArgs e)
        {
            List<int[]> tasks = Helper.GetTasks(TaskFilterType.Active);

            switch (e.Cell.Index)
            {
                    // Start
                case 0:
                    {
                        Core.Core.Instanse.Manager.Start(Core.Core.Instanse.Data[tasks[e.Row][0]].Tasks[tasks[e.Row][1]]);
                        break;
                    }

                    // Pause
                case 1:
                    {
                        Core.Core.Instanse.Manager.Pause(Core.Core.Instanse.Data[tasks[e.Row][0]].Tasks[tasks[e.Row][1]]);
                        break;
                    }

                    // Stop
                case 2:
                    {
                        Core.Core.Instanse.Manager.Stop(Core.Core.Instanse.Data[tasks[e.Row][0]].Tasks[tasks[e.Row][1]]);
                        break;
                    }

                    // Log
                case 7:
                    {
                        new TaskLog()
                            {
                                Task = Core.Core.Instanse.Data[tasks[e.Row][0]].Tasks[tasks[e.Row][1]].Name,
                                Content = Core.Core.Instanse.Data[tasks[e.Row][0]].Tasks[tasks[e.Row][1]].Log
                            }.Show();
                        break;
                    }
            }
        }

        protected void mainTableCellDoubleClick(object sender, Umax.UI.XPTable.Events.CellMouseEventArgs e)
        {
            List<int[]> tasks = Helper.GetTasks(TaskFilterType.Active);
            DataHelper.EditTask(FindForm(), Core.Core.Instanse.Data[tasks[e.Row][0]].Tasks[tasks[e.Row][1]]);
        }

        private void mainTimerTick(object sender, EventArgs e)
        {
            this.EventHandler();
        }

        public void CreateTask(object sender, EventArgs e)
        {
        }

        public void CopyTask(object sender, EventArgs e)
        {
        }

        public void EditTask(object sender, EventArgs e)
        {
        }

        public void DeleteTask(object sender, EventArgs e)
        {
        }

        public void RunTask(object sender, EventArgs e)
        {
        }

        public void PauseTask(object sender, EventArgs e)
        {
        }

        public void StopTask(object sender, EventArgs e)
        {
        }
    }
}
