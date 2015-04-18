using System;
using System.Threading;
using Core.Classes;
using Core.Enums;
using Core.Helpers;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Compatibility.Tasks;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;

namespace Core
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
            ThreadPool.SetMaxThreads(Core.Instanse.Options.MaximumConcurentTasks, Core.Instanse.Options.MaximumConcurentTasks * 10);

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
        /// Fires on task killed by timeout
        /// </summary>
        public event SimpleSenderEventHandler TaskKilled;

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
                    for (int k = 0; k < Core.Instanse.Data[i].Tasks.Count; k++)
                    {
                        if (Core.Instanse.Data[i].Tasks[k].IsActive())
                        {
                            tasksCount++;
                        }
                    }
                }

                if (Options.Instanse.LogDebugMode)
                {
                    Logger.Instanse.Append(string.Format("Manager: Active tasks {0}.", tasksCount), LogMessageType.Info);
                }

                return tasksCount;
            }
        }

        /// <summary>
        /// Starts task
        /// </summary>
        /// <param name="Task">Task to start</param>
        public void Start(ITask Task)
        {
            if (this.ActiveTasksCount < Core.Instanse.Options.MaximumConcurentTasks)
            {
                if (Task.IsRunable())
                {
                    // Put data into executor
                    Task.Executor.Fill();

                    // Start
                    Task.ProgressChanged += this.TasksProgressChanged;
                    ThreadPool.QueueUserWorkItem(this.Starter, Task);
                }
                else if (Task.State == TaskStateType.Paused)
                {
                    this.Pause(Task);
                }
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
        public void Pause(ITask Task)
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
        public void Stop(ITask Task)
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
                // Kill tasks by timeout
                if (Options.Instanse.TimeoutEnabled)
                {
                    for (int i = 0; i < Core.Instanse.Data.Count; i++)
                    {
                        for (int k = 0; k < Core.Instanse.Data[i].Tasks.Count; k++)
                        {
                            if (Core.Instanse.Data[i].Tasks[k].IsActive() && (DateTime.Now - Core.Instanse.Data[i].Tasks[k].StartTime == new TimeSpan(0, 0, Options.Instanse.Timeout)))
                            {
                                this.Kill(Core.Instanse.Data[i].Tasks[k]);
                            }
                        }
                    }
                }

                // Start new tasks
                for (int i = 0; i < Core.Instanse.Data.Count; i++)
                {
                    for (int k = 0; k < Core.Instanse.Data[i].Tasks.Count; k++)
                    {
                        if (Core.Instanse.Data[i].Tasks[k].State == TaskStateType.New && Core.Instanse.Data[i].Tasks[k].StartTime < DateTime.Now)
                        {
                            this.Start(Core.Instanse.Data[i].Tasks[k]);
                        }
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
                if ((Task as ITask) == null)
                {
                    return;
                }

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

                // Scheduler
                if (Task is ITaskMultiRunCompatible)
                {
                    // Start time
                    switch ((Task as ITaskMultiRunCompatible).Schedule)
                    {
                        case TaskScheduleType.Day:
                            {
                                (Task as ITask).StartTime.AddDays((Task as ITaskMultiRunCompatible).ScheduleStep);
                                break;
                            }

                        case TaskScheduleType.Week:
                            {
                                (Task as ITask).StartTime.AddDays((Task as ITaskMultiRunCompatible).ScheduleStep * 7);
                                break;
                            }

                        case TaskScheduleType.Month:
                            {
                                (Task as ITask).StartTime.AddMonths((Task as ITaskMultiRunCompatible).ScheduleStep);
                                break;
                            }

                        case TaskScheduleType.Year:
                            {
                                (Task as ITask).StartTime.AddYears((Task as ITaskMultiRunCompatible).ScheduleStep);
                                break;
                            }
                    }

                    if ((Task as ITaskMultiRunCompatible).Schedule != TaskScheduleType.None)
                    {
                        // State
                        (Task as ITask).Executor.State = TaskStateType.New;
                    }
                }
            }
            catch (Exception ex)
            {
                (Task as ITask).Executor.State = TaskStateType.Error;

                if (this.TaskFailed != null)
                {
                    this.TaskFailed.Invoke(Task);
                }

                Logger.Instanse.Append(string.Format("Manager: Task (Name: {0}, ID: {1}) failed.", (Task as ITask).Name, (Task as ITask).ID), LogMessageType.Warning);
                if (Options.Instanse.LogDebugMode)
                {
                    Logger.Instanse.Append(ex);
                }
            }
            finally
            {
                Core.Instanse.CollectGarbage();
            }
        }

        /// <summary>
        /// Kill task
        /// </summary>
        /// <param name="Task"></param>
        protected void Kill(ITask Task)
        {
            if (Task.IsActive())
            {
                Logger.Instanse.Append(string.Format("Manager: Task (Name: {0}, ID: {1}) killed.", Task.Name, Task.ID.ToString()), LogMessageType.Info);
                Task.Kill();

                if (this.TaskKilled != null)
                {
                    this.TaskKilled.Invoke(Task);
                }
            }
        }
    }
}
