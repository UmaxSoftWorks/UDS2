using System;
using ITaskExecutorHelper = Core.Helpers.ITaskExecutorHelper;
using Umax.Classes.Helpers;
using Umax.Classes.Ini;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using Umax.Interfaces.Tasks;
using IO = System.IO;

namespace Core.Classes.Containers.Items
{
    public class Task : ITask
    {
        public Task()
        {
            this.Name = string.Empty;
            this.StartTime = DateTime.Now;
        }

        public Task(string TaskPath)
            : this()
        {
            this.Path = TaskPath;
            this.Load(TaskPath);
        }

        public event SimpleEventHandler ProgressChanged;
        public event SimpleEventHandler StateChanged;

        #region Information
        /// <summary>
        /// Gets or sets task ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets task name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets task path
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// Gets or sets task start date and time
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets task state
        /// </summary>
        public TaskStateType State
        {
            get
            {
                return this.Executor.State;
            }

            protected set
            {
                this.Executor.State = value;
            }
        }

        /// <summary>
        /// Gets or sets task progress (values: 0 to 100)
        /// </summary>
        public int Progress
        {
            get
            {
                return this.Executor.Progress;
            }
        }

        /// <summary>
        /// Gets or sets task log
        /// </summary>
        public string Log
        {
            get
            {
                return this.Executor.Log;
            }
        }
        #endregion

        /// <summary>
        /// Gets or sets task executor
        /// </summary>
        public ITaskExecutor Executor { get; set; }
        #region Methods

        public void Invoke()
        {
            this.Executor.ProgressChanged += this.ProgressChanged;
            this.Executor.StateChanged += this.StateChanged;
            this.Executor.Invoke();
        }

        public void Pause()
        {
            this.Executor.Pause();
        }

        public void Stop()
        {
            this.Executor.Stop();
        }

        public void Kill()
        {
            this.Executor.Kill();
        }

        protected void Load(string TaskPath)
        {
            if (!IOHelper.CheckDirectoryExists(TaskPath))
            {
                throw new Exception("Path not found!");
            }

            if (!IO.File.Exists(IO.Path.Combine(TaskPath, "details.ini")))
            {
                throw new Exception("Ini path not found!");
            }

            // Loading ini
            IniWorker ini = new IniWorker(IO.Path.Combine(TaskPath, "details.ini"));
            this.ID = int.Parse(ini.IniReadValue("General", "ID"));
            this.Name = ini.IniReadValue("General", "Name");
            this.StartTime = DateTime.Parse(ini.IniReadValue("General", "StartTime"));
            string executorName = ini.IniReadValue("General", "Executor");

            // Loading executor
            for (int i = 0; i < Core.Instanse.Tasks.Executors.Count; i++)
            {
                if (Core.Instanse.Tasks.Executors[i].Name == executorName)
                {
                    this.Executor = Core.Instanse.Tasks.Executors[i].NewInstance() as ITaskExecutor;
                    if (this.Executor == null) continue;

                    // Out data into Executor
                    ITaskExecutorHelper.Fill(this.Executor);

                    this.Executor.Load(TaskPath);
                }
            }

            if (this.Executor == null)
            {
                throw new Exception("Task Executor not found!");
            }

            try
            {
                this.State = (TaskStateType)Enum.Parse(typeof(TaskStateType), ini.IniReadValue("General", "State"), true);
                if (this.IsNewable())
                {
                    this.State = TaskStateType.New;
                }
            }
            catch (Exception)
            {
                this.State = TaskStateType.New;
            }
        }

        public void Save(string TaskPath)
        {
            // Making directories
            if (!IOHelper.CheckDirectoryExists(TaskPath))
            {
                IOHelper.CreateDirectory(TaskPath);
            }

            // Saving
            IniWorker ini = new IniWorker(IO.Path.Combine(TaskPath, "details.ini"));
            ini.IniWriteValue("General", "ID", this.ID.ToString());
            ini.IniWriteValue("General", "Name", this.Name);
            ini.IniWriteValue("General", "StartTime", this.StartTime.ToString());
            ini.IniWriteValue("General", "State", this.State.ToString());

            if (this.Executor == null)
            {
                throw new Exception("Empty executor!");
            }

            ini.IniWriteValue("General", "Executor", this.Executor.Name);

            // Saving Settings
            this.Executor.Save(TaskPath);
        }
        #endregion

        public Task Copy(int WorkSpaceIndex, string TaskName)
        {
            string itemPath = IO.Path.Combine(this.Path,
                                              IO.Path.Combine("Data",
                                                              IO.Path.Combine(Core.Instanse.Data[WorkSpaceIndex].ID.ToLongString(),
                                                                              IO.Path.Combine("Tasks", Core.Instanse.Data[WorkSpaceIndex].Tasks.NextID().ToLongString()))));
            
            // Saving
            this.Save(itemPath);

            // Loading
            return new Task(itemPath)
            {
                Name = TaskName,
                State = TaskStateType.New,
                ID = Core.Instanse.Data[WorkSpaceIndex].Tasks.NextID(),
                StartTime = DateTime.Now.AddHours(1)
            };
        }

        public void Delete()
        {
            if (this.IsActive())
            {
                Core.Instanse.Manager.Stop(this);
            }

            // Deleting
            if (IOHelper.CheckDirectoryExists(this.Path))
            {
                try
                {
                    IO.Directory.Delete(this.Path, true);
                }
                catch (Exception) { }
            }
        }

        #region IDisposable
        public void Dispose()
        {

        }
        #endregion
    }
}
