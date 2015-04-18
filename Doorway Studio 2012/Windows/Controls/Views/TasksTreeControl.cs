using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Windows.Helpers;
using Umax.Windows.Interfaces;
using Helper = Core.Helpers.Helper;

namespace Umax.Windows.Controls.Views
{
    public partial class TasksTreeControl : UserControl, IEventedControl, ITasksControl
    {
        public TasksTreeControl()
        {
            InitializeComponent();
        }

        public virtual void InitializeImages()
        {
            newToolStripButton.Image = Resources.Resources.PlusBlue;
            copyToolStripButton.Image = Resources.Resources.Copy;
            editToolStripButton.Image = Resources.Resources.Edit;
            deleteToolStripButton.Image = Resources.Resources.MinusBlue;
            filterToolStripButton.Image = Resources.Resources.Calendar;

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

        public void InitializeEvents()
        {
            Core.Core.Instanse.Manager.TasksStateChanged += this.EventHandler;
            Core.Core.Instanse.Manager.TasksProgressChanged += this.EventHandler;
            Core.Core.Instanse.Manager.TaskStarted += this.EventHandler;
            Core.Core.Instanse.Manager.TaskCompleted += this.EventHandler;
            Core.Core.Instanse.Manager.TaskFailed += this.EventHandler;
            Core.Core.Instanse.Manager.TaskKilled += this.EventHandler;

            Core.Core.Instanse.Data.Items.CountChanged += this.ReInitializeWorkSpaceEvents;

            this.ReInitializeWorkSpaceEvents();
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
            if (this.CanUpdate() && !DesignMode)
            {
                this.Invoke((MethodInvoker)delegate { this.UpdateControl(); });
            }
        }

        public void UpdateControl()
        {
            if (!this.Initialized)
            {
                this.OnLoad(EventArgs.Empty);
            }

            mainTasksTreeView.Nodes.Clear();

            // Adding new ones
            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                TreeNode workSpace = new TreeNode();
                for (int k = 0; k < Core.Core.Instanse.Data[i].Tasks.Count; k++)
                {
                    bool show = false;

                    // Filter
                    if (filterDayToolStripMenuItem.Checked)
                    {
                        // Day
                        if (Core.Core.Instanse.Data[i].Tasks[k].StartTime.Date == DateTime.Now.Date)
                        {
                            show = true;
                        }
                    }
                    else if (filterMonthToolStripMenuItem.Checked)
                    {
                        // Month
                        if (Core.Core.Instanse.Data[i].Tasks[k].StartTime.Date.Month == DateTime.Now.Date.Month)
                        {
                            show = true;
                        }
                    }
                    else if (filterYearToolStripMenuItem.Checked)
                    {
                        // Year
                        if (Core.Core.Instanse.Data[i].Tasks[k].StartTime.Date.Year == DateTime.Now.Date.Year)
                        {
                            show = true;
                        }
                    }
                    else
                    {
                        show = true;
                    }

                    if (show)
                    {
                        workSpace.Nodes.Add(new TreeNode(Core.Core.Instanse.Data[i].Tasks[k].Name, this.GetTaskImageListIndex(Core.Core.Instanse.Data[i].Tasks[k].State), this.GetTaskImageListIndex(Core.Core.Instanse.Data[i].Tasks[k].State)));
                    }
                }

                if (workSpace.Nodes.Count > 0)
                {
                    workSpace.ImageIndex = 0;
                    workSpace.SelectedImageIndex = 0;
                    workSpace.Text = Core.Core.Instanse.Data[i].Name;

                    mainTasksTreeView.Nodes.Add(workSpace);
                }
            }

            // Expand all
            mainTasksTreeView.ExpandAll();
        }

        protected bool Initialized { get; set; }

        private void TasksTreeControlLoad(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            this.Initialized = true;

            this.InitializeImages();
            this.InitializeEvents();

            this.UpdateControl();

            mainTimer.Start();
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

        protected void FilterDay(object sender, EventArgs e)
        {
            filterDayToolStripMenuItem.Checked = true;
            filterMonthToolStripMenuItem.Checked = false;
            filterYearToolStripMenuItem.Checked = false;
            filterAllToolStripMenuItem.Checked = false;

            this.UpdateControl();
        }

        protected void FilterMonth(object sender, EventArgs e)
        {
            filterDayToolStripMenuItem.Checked = false;
            filterMonthToolStripMenuItem.Checked = true;
            filterYearToolStripMenuItem.Checked = false;
            filterAllToolStripMenuItem.Checked = false;

            this.UpdateControl();
        }

        protected void FilterYear(object sender, EventArgs e)
        {
            filterDayToolStripMenuItem.Checked = false;
            filterMonthToolStripMenuItem.Checked = false;
            filterYearToolStripMenuItem.Checked = true;
            filterAllToolStripMenuItem.Checked = false;

            this.UpdateControl();
        }

        protected void FilterAll(object sender, EventArgs e)
        {
            filterDayToolStripMenuItem.Checked = false;
            filterMonthToolStripMenuItem.Checked = false;
            filterYearToolStripMenuItem.Checked = false;
            filterAllToolStripMenuItem.Checked = true;

            this.UpdateControl();
        }

        public void DeleteTask(object sender, EventArgs e)
        {
            if (mainTasksTreeView.SelectedNode.Parent == null)
            {
                return;
            }

            List<int[]> tasks = this.GetTreeTasks();

            // Shift
            int shift = 0;
            for (int i = 0; i < mainTasksTreeView.SelectedNode.Parent.Index; i++)
            {
                shift += mainTasksTreeView.Nodes[i].Nodes.Count;
            }

            Helper.DeleteTask(tasks[shift + mainTasksTreeView.SelectedNode.Index][0], tasks[shift + mainTasksTreeView.SelectedNode.Index][1]);
        }

        protected List<int[]> GetTreeTasks()
        {
            if (filterDayToolStripMenuItem.Checked)
            {
                // Day
                return Helper.GetTasks(TaskFilterDateType.Day);
            }

            if (filterMonthToolStripMenuItem.Checked)
            {
                // Month
                return Helper.GetTasks(TaskFilterDateType.Month);
            }

            if (filterYearToolStripMenuItem.Checked)
            {
                // Year
                return Helper.GetTasks(TaskFilterDateType.Year);
            }

            return Helper.GetTasks(TaskFilterDateType.None);
        }

        public void mainTreeViewNodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                return;
            }

            List<int[]> tasks = this.GetTreeTasks();

            // Shift
            int shift = 0;
            for (int i = 0; i < e.Node.Parent.Index; i++)
            {
                shift += mainTasksTreeView.Nodes[i].Nodes.Count;
            }

            DataHelper.EditTask(FindForm(), Core.Core.Instanse.Data[tasks[shift + e.Node.Index][0]].Tasks[tasks[shift + e.Node.Index][1]]);
        }

        public void CopyTask(object sender, EventArgs e)
        {
            if (mainTasksTreeView.SelectedNode.Parent == null)
            {
                return;
            }

            List<int[]> tasks = this.GetTreeTasks();

            // Shift
            int shift = 0;
            for (int i = 0; i < mainTasksTreeView.SelectedNode.Parent.Index; i++)
            {
                shift += mainTasksTreeView.Nodes[i].Nodes.Count;
            }

            DataHelper.CopyTask(FindForm(), Core.Core.Instanse.Data[tasks[shift + mainTasksTreeView.SelectedNode.Index][0]],
                                Core.Core.Instanse.Data[tasks[shift + mainTasksTreeView.SelectedNode.Index][0]].Tasks[tasks[shift + mainTasksTreeView.SelectedNode.Index][1]]);
        }

        public void EditTask(object sender, EventArgs e)
        {
            if (mainTasksTreeView.SelectedNode.Parent == null)
            {
                return;
            }

            List<int[]> tasks = this.GetTreeTasks();

            // Shift
            int shift = 0;
            for (int i = 0; i < mainTasksTreeView.SelectedNode.Parent.Index; i++)
            {
                shift += mainTasksTreeView.Nodes[i].Nodes.Count;
            }

            DataHelper.EditTask(FindForm(), Core.Core.Instanse.Data[tasks[shift + mainTasksTreeView.SelectedNode.Index][0]].Tasks[tasks[shift + mainTasksTreeView.SelectedNode.Index][1]]);
        }

        public void CreateTask(object sender, EventArgs e)
        {
            DataHelper.CreateTask();
        }

        private void mainTimerTick(object sender, EventArgs e)
        {
            this.EventHandler();
        }

        public void RunTask(object sender, EventArgs e){}
        public void PauseTask(object sender, EventArgs e) { }
        public void StopTask(object sender, EventArgs e) { }
    }
}
