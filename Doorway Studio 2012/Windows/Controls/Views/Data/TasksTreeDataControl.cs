using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Windows.Classes;
using Umax.Windows.Helpers;
using Umax.Windows.Interfaces;
using WindowsHelper = Umax.Windows.Helpers.Helper;

namespace Umax.Windows.Controls.Views.Data
{
    public partial class TasksTreeDataControl : UserControl, IEventedControl, ITasksControl
    {
        public TasksTreeDataControl()
        {
            InitializeComponent();
        }

        private void TasksTreeDataControlLoad(object sender, EventArgs e)
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

        protected void InitializeImages()
        {
            newTaskTreeToolStripButton.Image = Resources.Resources.PlusBlue;
            copyTaskTreeToolStripButton.Image = Resources.Resources.Copy;
            editTaskTreeToolStripButton.Image = Resources.Resources.Edit;
            runTaskTreeToolStripButton.Image = Resources.Resources.Start;
            pauseTaskTreeToolStripButton.Image = Resources.Resources.Pause;
            stopTaskTreeToolStripButton.Image = Resources.Resources.Stop;
            deleteTaskTreeToolStripButton.Image = Resources.Resources.MinusBlue;
            filterTreeToolStripButton.Image = Resources.Resources.Calendar;

            mainImageList.Images.Add(Resources.Resources.WorkSpace);
            mainImageList.Images.Add(Resources.Resources.Calendar);
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

            mainTreeView.Nodes.Clear();

            List<DateNode> nodes = new List<DateNode>();
            for (int i = 0; i < Core.Core.Instanse.Data.Count; i++)
            {
                if (Core.Core.Instanse.Data[i].Tasks.Count == 0)
                {
                    continue;
                }

                for (int k = 0; k < Core.Core.Instanse.Data[i].Tasks.Count; k++)
                {
                    if (nodes.Count != 0)
                    {
                        bool found = false;

                        // Поиск  и добавление
                        for (int l = 0; l < nodes.Count; l++)
                        {
                            if (nodes[l].Date == Core.Core.Instanse.Data[i].Tasks[k].StartTime.Date)
                            {
                                nodes[l].Nodes.Add(new TreeNode(Core.Core.Instanse.Data[i].Tasks[k].Name, this.GetTaskImageListIndex(Core.Core.Instanse.Data[i].Tasks[k].State),
                                                                this.GetTaskImageListIndex(Core.Core.Instanse.Data[i].Tasks[k].State)));
                                found = true;
                                break;
                            }
                        }

                        // Добавление новой даты
                        if (!found)
                        {
                            nodes.Add(new DateNode(Core.Core.Instanse.Data[i].Tasks[k].StartTime.Date));
                            nodes[nodes.Count - 1].Nodes.Add(new TreeNode(Core.Core.Instanse.Data[i].Tasks[k].Name, this.GetTaskImageListIndex(Core.Core.Instanse.Data[i].Tasks[k].State),
                                                                          this.GetTaskImageListIndex(Core.Core.Instanse.Data[i].Tasks[k].State)));
                        }
                    }
                    else
                    {
                        // Добавление новой даты
                        nodes.Add(new DateNode(Core.Core.Instanse.Data[i].Tasks[k].StartTime.Date));
                        nodes[nodes.Count - 1].Nodes.Add(new TreeNode(Core.Core.Instanse.Data[i].Tasks[k].Name, this.GetTaskImageListIndex(Core.Core.Instanse.Data[i].Tasks[k].State),
                                                                      this.GetTaskImageListIndex(Core.Core.Instanse.Data[i].Tasks[k].State)));
                    }
                }

                TreeNode mainTreeNode = new TreeNode(Core.Core.Instanse.Data[i].Name, 0, 0);
                for (int k = 0; k < nodes.Count; k++)
                {
                    mainTreeNode.Nodes.Add(new TreeNode(nodes[k].Date.ToString().Substring(0, nodes[k].Date.ToString().IndexOf(" ")), 1, 1, nodes[k].Nodes.ToArray()));
                }

                mainTreeView.Nodes.Add(mainTreeNode);
            }

            mainTreeView.ExpandAll();
        }

        protected int GetTaskImageListIndex(TaskStateType State)
        {
            switch (State)
            {
                case TaskStateType.New:
                    {
                        return 2;
                    }

                case TaskStateType.Running:
                    {
                        return 3;
                    }

                case TaskStateType.Paused:
                    {
                        return 4;
                    }

                case TaskStateType.Stopped:
                    {
                        return 5;
                    }

                case TaskStateType.Uploading:
                    {
                        return 6;
                    }
                case TaskStateType.Error:
                    {
                        return 7;
                    }

                case TaskStateType.Done:
                    {
                        return 8;
                    }

                case TaskStateType.Killed:
                    {
                        return 9;
                    }

                default:
                    {
                        return 0;
                    }
            }
        }

        public void CreateTask(object sender, EventArgs e)
        {
            DataHelper.CreateTask();
        }

        public void CopyTask(object sender, EventArgs e)
        {
            if (!this.CheckSelectedNode())
            {
                return;
            }

            List<int[]> task = this.GetTasks();

            DataHelper.CopyTask(FindForm(), Core.Core.Instanse.Data[task[0][0]], Core.Core.Instanse.Data[task[0][0]].Tasks[task[0][1]]);
        }

        public void EditTask(object sender, EventArgs e)
        {
            if (!this.CheckSelectedNode())
            {
                return;
            }

            List<int[]> task = this.GetTasks();

            DataHelper.EditTask(FindForm(), Core.Core.Instanse.Data[task[0][0]].Tasks[task[0][1]]);
        }

        public void RunTask(object sender, EventArgs e)
        {
            if (!this.CheckSelectedNode())
            {
                return;
            }

            List<int[]> task = this.GetTasks();

            Core.Core.Instanse.Manager.Start(Core.Core.Instanse.Data[task[0][0]].Tasks[task[0][1]]);
        }

        public void PauseTask(object sender, EventArgs e)
        {
            if (!this.CheckSelectedNode())
            {
                return;
            }

            List<int[]> task = this.GetTasks();

            Core.Core.Instanse.Manager.Pause(Core.Core.Instanse.Data[task[0][0]].Tasks[task[0][1]]);
        }

        public void StopTask(object sender, EventArgs e)
        {
            if (!this.CheckSelectedNode())
            {
                return;
            }

            List<int[]> task = this.GetTasks();

            Core.Core.Instanse.Manager.Stop(Core.Core.Instanse.Data[task[0][0]].Tasks[task[0][1]]);
        }

        /// <summary>
        /// true - can continue; false - break;
        /// </summary>
        /// <returns></returns>
        protected bool CheckSelectedNode()
        {
            if (mainTreeView.SelectedNode == null)
            {
                return false;
            }

            if (mainTreeView.SelectedNode.Parent == null)
            {
                return false;
            }

            if (mainTreeView.SelectedNode.Parent.Parent == null)
            {
                return false;
            }

            return true;
        }

        protected List<int[]> GetTasks()
        {
            List<int[]> tasks = Core.Helpers.Helper.GetTasks(TaskFilterDateType.None);

            // Shift
            int shift = 0;
            for (int i = 0; i < mainTreeView.SelectedNode.Parent.Parent.Index; i++)
            {
                for (int k = 0; k < mainTreeView.Nodes[i].Nodes.Count; k++)
                {
                    shift += mainTreeView.Nodes[i].Nodes[k].Nodes.Count;
                }
            }

            if (mainTreeView.SelectedNode.Parent.Parent.Index == 0 && mainTreeView.SelectedNode.Parent.Parent.Nodes.Count != 0)
            {
                for (int i = 0; i < mainTreeView.SelectedNode.Parent.Index; i++)
                {
                    shift += mainTreeView.Nodes[0].Nodes[i].Nodes.Count;
                }
            }

            return tasks;
        }

        public void DeleteTask(object sender, EventArgs e)
        {
            if (!this.CheckSelectedNode())
            {
                return;
            }

            List<int[]> tasks = this.GetTasks();

            Core.Helpers.Helper.DeleteTask(tasks[0][0], tasks[0][1]);
        }

        protected void mainTreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            this.EditTask(sender, EventArgs.Empty);
        }

        private void FilterAll(object sender, EventArgs e)
        {
            filterAllTreeToolStripMenuItem.Checked = true;
            filterDayTreeToolStripMenuItem.Checked = false;
            filterMonthTreeToolStripMenuItem.Checked = false;
            filterYearTreeToolStripMenuItem.Checked = false;

            this.UpdateControl();
        }

        private void FilterDay(object sender, EventArgs e)
        {
            filterAllTreeToolStripMenuItem.Checked = false;
            filterDayTreeToolStripMenuItem.Checked = true;
            filterMonthTreeToolStripMenuItem.Checked = false;
            filterYearTreeToolStripMenuItem.Checked = false;

            this.UpdateControl();
        }

        private void FilterMonth(object sender, EventArgs e)
        {
            filterAllTreeToolStripMenuItem.Checked = false;
            filterDayTreeToolStripMenuItem.Checked = false;
            filterMonthTreeToolStripMenuItem.Checked = true;
            filterYearTreeToolStripMenuItem.Checked = false;

            this.UpdateControl();
        }

        private void FilterYear(object sender, EventArgs e)
        {
            filterAllTreeToolStripMenuItem.Checked = false;
            filterDayTreeToolStripMenuItem.Checked = false;
            filterMonthTreeToolStripMenuItem.Checked = false;
            filterYearTreeToolStripMenuItem.Checked = true;

            this.UpdateControl();
        }

        private void mainTimerTick(object sender, EventArgs e)
        {
            this.EventHandler();
        }
    }
}
