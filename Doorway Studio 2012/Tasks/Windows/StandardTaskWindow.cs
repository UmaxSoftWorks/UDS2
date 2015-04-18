using System;
using System.Windows.Forms;
using Core.Classes.Containers.Items;
using Core.Helpers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Tasks;
using Umax.Windows.Windows;

namespace Umax.Plugins.Tasks.Windows
{
    public abstract class StandardTaskWindow : StandardWindow, ITaskWindow
    {
        public abstract string GUIName { get; }

        public LanguageType Language { get; set; }

        public abstract string ExecutorName { get; }

        public bool OK { get; set; }

        public TaskEditType EditType { get; set; }

        public ITask Task { get; set; }

        public abstract object NewInstance();

        protected abstract IWorkSpace WorkSpace { get; }

        protected override void OnLoad(EventArgs e)
        {
            if (this.Task == null)
            {
                // Create task
                this.Task = new Task()
                                {
                                    ID = -1,
                                    StartTime = DateTime.Now.AddMinutes(5)
                                };

                // Executor
                for (int k = 0; k < Core.Core.Instanse.Tasks.Executors.Count; k++)
                {
                    if (Core.Core.Instanse.Tasks.Executors[k].Name == this.ExecutorName)
                    {
                        this.Task.Executor = Core.Core.Instanse.Tasks.Executors[k].NewInstance() as ITaskExecutor;
                    }
                }
            }
            else
            {
                // Save IDs for keep track of changes for statistics
            }

            if (this.Task.Executor != null)
            {
                this.Task.Executor.Fill();
            }

            base.OnLoad(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (this.OK)
            {
                if (this.EditType == TaskEditType.None)
                {
                    this.CreateTask();
                }

                // Update statistics
                this.UpdateStatistics();
            }

            base.OnFormClosed(e);
        }

        protected void CreateTask()
        {
            if (!(this.Task is Task))
            {
                return;
            }

            (this.Task as Task).ID = this.WorkSpace.Tasks.NextID();

            this.WorkSpace.Tasks.Add(this.Task);
        }

        protected void UpdateStatistics()
        {
            // Get IDs from task executor
        }
    }
}
