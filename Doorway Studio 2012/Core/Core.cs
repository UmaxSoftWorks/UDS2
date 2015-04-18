using System;
using System.Windows.Forms;
using Core.Classes;
using Core.Classes.Containers;
using Core.Enums;
using Umax.Classes.Enums;
using Umax.Interfaces.Containers;
using IO = System.IO;

namespace Core
{
    /// <summary>
    /// Singleton Core class, that handles user and plug-ins data, Manager and other stuff
    /// </summary>
    public class Core
    {
        /// <summary>
        /// Represents Core singleton instance
        /// </summary>
        private static Core instanse;

        /// <summary>
        /// Initializes a new instance of the Core class
        /// </summary>
        protected Core()
        {
            Logger.Instanse.Append("Core: Initializing...", LogMessageType.Info);

            // Initializing options
            this.Options = Options.Instanse;

            // Initializing lists
            this.Data = new DataContainer();
            this.Text = new TextContainer();
            this.Tokens = new TokenContainer();
            this.Tasks = new TaskContainer();
            this.Images = new ImageContainer();
        }

        /// <summary>
        /// Gets singleton of Core class
        /// </summary>
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
        /// Gets or sets application options
        /// </summary>
        public Options Options { get; set; }

        /// <summary>
        /// Gets or sets application manager
        /// </summary>
        public Manager Manager { get; set; }

        /// <summary>
        /// Gets or sets users data: WorkSpaces, etc.
        /// </summary>
        public IDataContainer Data { get; set; }

        /// <summary>
        /// Gets or sets Text plug-ins data
        /// </summary>
        public ITextContainer Text { get; set; }

        /// <summary>
        /// Gets or sets Tokens plug-ins data
        /// </summary>
        public ITokenContainer Tokens { get; set; }

        /// <summary>
        /// Gets or sets Tasks plug-ins data
        /// </summary>
        public TaskContainer Tasks { get; set; }

        /// <summary>
        /// Gets or sets Images plug-ins data
        /// </summary>
        public IImageContainer Images { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Core is initialized
        /// </summary>
        public bool Initialized { get; protected set; }

        #endregion

        /// <summary>
        /// Initializes Core data: loading plug-ins, user data, starting manager
        /// </summary>
        public void Invoke()
        {
            if (this.Initialized)
            {
                return;
            }

            this.Initialized = true;

            this.LoadComponents();

            // Load data
            (this.Data as DataContainer).Load(IO.Path.Combine(MainPath, "Data"));

            this.Manager = Manager.Instanse;

            Logger.Instanse.Append("Core: Initialized.", LogMessageType.Info);
        }

        /// <summary>
        /// Save all application data and prepare Core to application exit
        /// </summary>
        public void Close()
        {
            // Stopping manager
            this.Manager.Close();

            // Saving options
            this.Options.Save();

            // Save data
            (this.Data as DataContainer).Save(IO.Path.Combine(MainPath, "Data"));
        }

        /// <summary>
        /// Load standard plug-ins
        /// </summary>
        protected void LoadComponents()
        {
            Logger.Instanse.Append("Core: Loading components...", LogMessageType.Info);

            this.LoadDll("Images");
            this.LoadDll("Tokens");
            this.LoadDll("Text");
            this.LoadDll("Tasks");

            if (IO.File.Exists(IO.Path.Combine(MainPath, "Plus.dll")))
            {
                this.LoadDll("Plus");
            }

            Logger.Instanse.Append("Core: Components loaded.", LogMessageType.Info);

            this.LoadPlugins();
        }

        /// <summary>
        /// Load plug-in dll
        /// </summary>
        /// <param name="DllPath">Plug-in dll path</param>
        protected void LoadDll(string DllPath)
        {
            // Tokens
            (this.Tokens as TokenContainer).Load(DllPath);

            // Text Makers
            (this.Text as TextContainer).Load(DllPath);

            // Image Makers
            (this.Images as ImageContainer).Load(DllPath);

            // Tasks
            this.Tasks.Load(DllPath);
        }

        /// <summary>
        /// Load plug-ins
        /// </summary>
        protected void LoadPlugins()
        {
            if (!Options.PluginsEnabled)
            {
                return;
            }

            Logger.Instanse.Append("Core: Loading plug-ins...", LogMessageType.Info);

            for (int i = 0; i < Options.Plugins.Count; i++)
            {
                if (IO.File.Exists(Options.Plugins[i]))
                {
                    this.LoadDll(Options.Plugins[i]);
                }
            }

            Logger.Instanse.Append("Core: Plug-ins loaded.", LogMessageType.Info);
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
