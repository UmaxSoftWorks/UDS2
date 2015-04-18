using System;
using System.Reflection;
using Umax.Classes.Containers;
using Umax.Classes.Enums;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Text;

namespace Core.Classes.Containers
{
    public class TextContainer : ITextContainer
    {
        public TextContainer()
        {
            this.Makers = new EventedList<ITextMaker>();
            this.Controls = new EventedList<ITextControl>();
            this.Settings = new EventedList<ITextSettings>();

            // Events
            this.Makers.ItemAdded += this.MakersItemAdded;
            this.Controls.ItemAdded += this.ControlsItemAdded;
            this.Settings.ItemAdded += this.SettingsItemAdded;
        }

        #region ITextConnector

        public IEventedList<ITextControl> Controls { get; set; }

        public IEventedList<ITextSettings> Settings { get; set; }

        public IEventedList<ITextMaker> Makers { get; set; }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            // Events
            this.Makers.ItemAdded -= this.MakersItemAdded;
            this.Controls.ItemAdded -= this.ControlsItemAdded;
            this.Settings.ItemAdded -= this.SettingsItemAdded;

            // Data
            this.Controls = null;
            this.Makers = null;
            this.Settings = null;
        }

        #endregion

        /// <summary>
        /// Loads Text classes from DLL
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
                    if (types[i].Name.Contains("TextControl") &&
                        types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Controls.Add(assembly.CreateInstance(types[i].FullName) as ITextControl);
                    }
                    else if (types[i].Name.Contains("TextSettings") &&
                             types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Settings.Add(assembly.CreateInstance(types[i].FullName) as ITextSettings);
                    }
                    else if (types[i].Name.Contains("TextMaker") &&
                             types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Makers.Add(assembly.CreateInstance(types[i].FullName) as ITextMaker);
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

        protected void MakersItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as ITextMaker).Name, LogMessageType.Info);
        }

        protected void ControlsItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as ITextControl).Name, LogMessageType.Info);
        }

        protected void SettingsItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as ITextSettings).Name, LogMessageType.Info);
        }
    }
}
