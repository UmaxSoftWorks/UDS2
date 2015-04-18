using System;
using System.Threading;
using Core.Enums;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using WebParser.Core.Classes;
using WebParser.Core.Classes.Containers;

namespace WebParser.Core
{
    /// <summary>
    /// Singleton Manager class that handles running, stopping, etc of scheduled tasks
    /// </summary>
    public class Manager
    {
        /// <summary>
        /// Represents Manager Singleton instance
        /// </summary>
        private static Manager instanse;

        /// <summary>
        /// Initializes a new instance of the Manager class
        /// </summary>
        protected Manager()
        {
            Logger.Instanse.Append("Manager: Starting...", LogMessageType.Info);
            
            ThreadPool.SetMaxThreads(10, 50);

            Logger.Instanse.Append("Manager: Started.", LogMessageType.Info);
        }

        /// <summary>
        /// Fires on any task state is changed
        /// </summary>
        public event SimpleEventHandler TasksStateChanged;

        /// <summary>
        /// Fires on any task progress is changed
        /// </summary>
        public event SimpleEventHandler TasksProgressChanged;

        /// <summary>
        /// Fires on task is started
        /// </summary>
        public event SimpleSenderEventHandler TaskStarted;

        /// <summary>
        /// Fires on task is failed, or error occurred during execution
        /// </summary>
        public event SimpleSenderEventHandler TaskFailed;

        /// <summary>
        /// Fires on task completed successfully
        /// </summary>
        public event SimpleSenderEventHandler TaskCompleted;

        /// <summary>
        /// Gets singleton of Manager class
        /// </summary>
        public static Manager Instanse
        {
            get { return instanse ?? (instanse = new Manager()); }
        }

        /// <summary>
        /// Gets or sets main thread of Manager, where method Worker running
        /// </summary>
        protected Thread MainThread { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether that Manager should stop all running tasks, and be ready to application exit
        /// </summary>
        protected bool Exit { get; set; }

        /// <summary>
        /// Gets active tasks count
        /// </summary>
        protected int ActiveTasksCount
        {
            get
            {
                // Searching running tasks
                int tasksCount = 0;
                for (int i = 0; i < Core.Instanse.Data.Count; i++)
                {
                    if (Core.Instanse.Data[i].IsActive())
                    {
                        tasksCount++;
                    }
                }

                return tasksCount;
            }
        }

        /// <summary>
        /// Starts task
        /// </summary>
        /// <param name="Task">Task to start</param>
        public void Start(Task Task)
        {
            if (Task.IsRunable())
            {
                // Start
                Task.ProgressChanged += this.TasksProgressChanged;
                ThreadPool.QueueUserWorkItem(this.Starter, Task);
            }
            else if (Task.State == TaskStateType.Paused)
            {
                this.Pause(Task);
            }
        }

        /// <summary>
        /// Starts manager
        /// </summary>
        public void Invoke()
        {
            if (this.MainThread == null) return;

            this.MainThread = new Thread(this.Worker);
            this.MainThread.Start();
        }

        /// <summary>
        /// Shut down all active tasks
        /// </summary>
        public void Close()
        {
            this.Exit = true;

            if (this.MainThread == null) return;

            while (this.MainThread.ThreadState == ThreadState.Running)
            {
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Pause task
        /// </summary>
        /// <param name="Task">Task to pause</param>
        public void Pause(Task Task)
        {
            if (Task.IsActive())
            {
                Logger.Instanse.Append(string.Format("Manager: Task (Name: {0}, ID: {1}) paused/resumed.", Task.Name, Task.ID.ToString()), LogMessageType.Info);
                Task.Pause();

                if (this.TasksStateChanged != null)
                {
                    this.TasksStateChanged.Invoke();
                }
            }
        }

        /// <summary>
        /// Stops task
        /// </summary>
        /// <param name="Task">Task to stop</param>
        public void Stop(Task Task)
        {
            if (Task.IsActive())
            {
                Logger.Instanse.Append(string.Format("Manager: Task (Name: {0}, ID: {1}) stopped.", Task.Name, Task.ID.ToString()), LogMessageType.Info);
                Task.Stop();

                if (this.TasksStateChanged != null)
                {
                    this.TasksStateChanged.Invoke();
                }
            }
        }

        /// <summary>
        /// Main method that start scheduled tasks automatically
        /// </summary>
        protected void Worker()
        {
            Logger.Instanse.Append("Manager: Running...", LogMessageType.Info);

            Thread.Sleep(1000);

            while (!this.Exit)
            {
                // Start new tasks
                for (int i = 0; i < Core.Instanse.Data.Items.Count; i++)
                {
                    if (Core.Instanse.Data.Items[i].State == TaskStateType.New && Core.Instanse.Data.Items[i].StartTime < DateTime.Now)
                    {
                        this.Start(Core.Instanse.Data.Items[i]);
                    }
                }

                Thread.Sleep(1000);
            }

            Logger.Instanse.Append("Manager: Stopping...", LogMessageType.Info);

            // Stop all running tasks
            Logger.Instanse.Append("Manager: Stopped.", LogMessageType.Info);
        }

        /// <summary>
        /// Starting task
        /// </summary>
        /// <param name="Task">Task to be started</param>
        protected void Starter(object Task)
        {
            try
            {
                Logger.Instanse.Append(string.Format("Manager: Task (Name: {0}, ID: {1}) started.", (Task as ITask).Name, (Task as ITask).ID.ToString()), LogMessageType.Info);

                if (this.TaskStarted != null)
                {
                    this.TaskStarted.Invoke(Task);
                }

                (Task as ITask).Invoke();

                if ((Task as ITask).State != TaskStateType.Done)
                {
                    Logger.Instanse.Append(string.Format("Manager: Task (Name: {0}, ID: {1}) failed.", (Task as ITask).Name, (Task as ITask).ID.ToString()), LogMessageType.Info);
                    return;
                }

                if (this.TaskCompleted != null)
                {
                    this.TaskCompleted.Invoke(Task);
                }

                Logger.Instanse.Append(string.Format("Manager: Task (Name: {0}, ID: {1}) finished.", (Task as ITask).Name, (Task as ITask).ID.ToString()), LogMessageType.Info);
            }
            catch (Exception)
            {
                (Task as ITask).Executor.State = TaskStateType.Error;

                if (this.TaskFailed != null)
                {
                    this.TaskFailed.Invoke(Task);
                }

                Logger.Instanse.Append(string.Format("Manager: Task (Name: {0}, ID: {1}) failed.", (Task as ITask).Name, (Task as ITask).ID), LogMessageType.Warning);
            }
            finally
            {
                Core.Instanse.CollectGarbage();
            }
        }
    }
}
