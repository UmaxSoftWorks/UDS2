using System;
using System.Reflection;
using Umax.Classes.Containers;
using Umax.Classes.Enums;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Tasks;

namespace Core.Classes.Containers
{
    public class TaskContainer : IDisposable
    {
        public TaskContainer()
        {
            this.Elements = new EventedList<ITaskElement>();
            this.Executors = new EventedList<ITaskExecutor>();
            this.Settings = new EventedList<ITaskSettings>();
            this.Windows = new EventedList<ITaskWindow>();

            // Events
            this.Elements.ItemAdded += this.ElementsItemAdded;
            this.Executors.ItemAdded += this.ExecutorsItemAdded;
            this.Settings.ItemAdded += this.SettingsItemAdded;
            this.Windows.ItemAdded += this.WindowsItemAdded;
        }

        public void Dispose()
        {
            // Events
            this.Elements.ItemAdded -= this.ElementsItemAdded;
            this.Executors.ItemAdded -= this.ExecutorsItemAdded;
            this.Settings.ItemAdded -= this.SettingsItemAdded;
            this.Windows.ItemAdded -= this.WindowsItemAdded;

            // Data
            this.Elements = null;
            this.Executors = null;
            this.Settings = null;
            this.Windows = null;
        }

        /// <summary>
        /// Loads Task classes from DLL
        /// </summary>
        /// <param name="DllPath">Path to the DLL</param>
        public void Load(string DllPath)
        {
            Assembly assembly = Assembly.Load(DllPath);
            Type[] types = assembly.GetTypes();

            for (int i = 0; i < types.Length; i++)
            {
                try
                {
                    if (types[i].Name.Contains("TaskElement") &&
                        types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Elements.Add(assembly.CreateInstance(types[i].FullName) as ITaskElement);
                    }
                    else if (types[i].Name.Contains("TaskWindow") &&
                             types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Windows.Add(assembly.CreateInstance(types[i].FullName) as ITaskWindow);
                    }
                    else if (types[i].Name.Contains("TaskSettings") &&
                             types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Settings.Add(assembly.CreateInstance(types[i].FullName) as ITaskSettings);
                    }
                    else if (types[i].Name.Contains("TaskExecutor") &&
                             types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Executors.Add(assembly.CreateInstance(types[i].FullName) as ITaskExecutor);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("Core: Failed to load {0}.", types[i].Name), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        protected void ElementsItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as ITaskElement).Name, LogMessageType.Info);
        }

        protected void ExecutorsItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as ITaskExecutor).Name, LogMessageType.Info);
        }

        protected void SettingsItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as ITaskSettings).Name, LogMessageType.Info);
        }

        protected void WindowsItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as ITaskWindow).Name, LogMessageType.Info);
        }

        public IEventedList<ITaskSettings> Settings { get; set; }
        public IEventedList<ITaskExecutor> Executors { get; set; }
        public IEventedList<ITaskElement> Elements { get; set; }
        public IEventedList<ITaskWindow> Windows { get; set; }
    }
}
