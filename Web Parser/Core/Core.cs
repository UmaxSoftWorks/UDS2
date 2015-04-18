using System;
using System.Windows.Forms;
using Umax.Classes.Enums;
using WebParser.Core.Classes;
using WebParser.Core.Classes.Containers;
using IO = System.IO;

namespace WebParser.Core
{
    public class Core
    {
        private static Core instanse;

        protected Core()
        {
            Logger.Instanse.Append("Core: Initializing...", LogMessageType.Info);

            // Initializing lists
            this.Data = new DataContainer();
            this.Tasks = new TaskContainer();
        }

        public static Core Instanse
        {
            get { return instanse ?? (instanse = new Core()); }
        }

        /// <summary>
        /// Gets application startup path
        /// </summary>
        public static string MainPath
        {
            get
            {
                return Application.StartupPath;
            }
        }

        #region Data

        /// <summary>
        /// Gets or sets application manager
        /// </summary>
        public Manager Manager { get; set; }

        /// <summary>
        /// Gets or sets users data: WorkSpaces, etc.
        /// </summary>
        public DataContainer Data { get; set; }

        /// <summary>
        /// Gets or sets Tasks plug-ins data
        /// </summary>
        public TaskContainer Tasks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Core is initialized
        /// </summary>
        public bool Initialized { get; protected set; }

        #endregion

        public void Invoke()
        {
            if (this.Initialized)
            {
                return;
            }

            this.Initialized = true;

            this.LoadComponents();

            // Load data
            this.Data.Load(IO.Path.Combine(MainPath, "Data"));

            this.Manager = Manager.Instanse;

            Logger.Instanse.Append("Core: Initialized.", LogMessageType.Info);
        }

        public void Close()
        {
            // Stopping manager
            this.Manager.Close();

            // Saving options
            this.Data.Save(IO.Path.Combine(MainPath, "Data"));
        }

        /// <summary>
        /// Load standard plug-ins
        /// </summary>
        protected void LoadComponents()
        {
            Logger.Instanse.Append("Core: Loading components...", LogMessageType.Info);

            this.LoadDll("Parser");

            Logger.Instanse.Append("Core: Components loaded.", LogMessageType.Info);
        }

        /// <summary>
        /// Load plug-in dll
        /// </summary>
        /// <param name="DllPath">Plug-in dll path</param>
        protected void LoadDll(string DllPath)
        {
            // Tasks
            this.Tasks.Load(DllPath);
        }

        /// <summary>
        /// Invoking Garbage Collector
        /// </summary>
        public void CollectGarbage()
        {
            GC.Collect();
        }
    }
}
