using System;
using System.Reflection;
using Umax.Classes.Containers;
using Umax.Classes.Enums;
using Umax.Interfaces.Containers;
using Umax.Interfaces.WebParser;

namespace WebParser.Core.Classes.Containers
{
    public class TaskContainer : IDisposable
    {
        public TaskContainer()
        {
            this.Elements = new EventedList<IWebParserElement>();
            this.Executors = new EventedList<IWebParserExecutor>();
            this.Settings = new EventedList<IWebParserSettings>();
            this.Controls = new EventedList<IWebParserControl>();

            // Events
            this.Elements.ItemAdded += this.ElementsItemAdded;
            this.Executors.ItemAdded += this.ExecutorsItemAdded;
            this.Settings.ItemAdded += this.SettingsItemAdded;
            this.Controls.ItemAdded += this.WindowsItemAdded;
        }

        public void Dispose()
        {
            // Events
            this.Elements.ItemAdded -= this.ElementsItemAdded;
            this.Executors.ItemAdded -= this.ExecutorsItemAdded;
            this.Settings.ItemAdded -= this.SettingsItemAdded;
            this.Controls.ItemAdded -= this.WindowsItemAdded;

            // Data
            this.Elements = null;
            this.Executors = null;
            this.Settings = null;
            this.Controls = null;
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
                    if (types[i].Name.Contains("ParserElement") &&
                        types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Elements.Add(assembly.CreateInstance(types[i].FullName) as IWebParserElement);
                    }
                    else if (types[i].Name.Contains("ParserControl") &&
                             types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Controls.Add(assembly.CreateInstance(types[i].FullName) as IWebParserControl);
                    }
                    else if (types[i].Name.Contains("ParserSettings") &&
                             types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Settings.Add(assembly.CreateInstance(types[i].FullName) as IWebParserSettings);
                    }
                    else if (types[i].Name.Contains("ParserExecutor") &&
                             types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Executors.Add(assembly.CreateInstance(types[i].FullName) as IWebParserExecutor);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("Core: Failed to load {0}.", types[i].Name), LogMessageType.Info);
                }
            }
        }

        protected void ElementsItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as IWebParserElement).Name, LogMessageType.Info);
        }

        protected void ExecutorsItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as IWebParserExecutor).Name, LogMessageType.Info);
        }

        protected void SettingsItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as IWebParserSettings).Name, LogMessageType.Info);
        }

        protected void WindowsItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as IWebParserControl).Name, LogMessageType.Info);
        }

        public IEventedList<IWebParserSettings> Settings { get; set; }
        public IEventedList<IWebParserExecutor> Executors { get; set; }
        public IEventedList<IWebParserElement> Elements { get; set; }
        public IEventedList<IWebParserControl> Controls { get; set; }
    }
}
