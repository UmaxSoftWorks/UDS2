using System;
using System.Reflection;
using Core.Enums;
using Umax.Classes.Containers;
using Umax.Classes.Enums;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Images;

namespace Core.Classes.Containers
{
    public class ImageContainer : IImageContainer
    {
        public ImageContainer()
        {
            this.Makers = new EventedList<IImageMaker>();
            this.Controls = new EventedList<IImageControl>();
            this.Settings = new EventedList<IImageSettings>();

            // Events
            this.Makers.ItemAdded += this.MakersItemAdded;
            this.Controls.ItemAdded += this.ControlsItemAdded;
            this.Settings.ItemAdded += this.SettingsItemAdded;
        }

        #region IImageConnector

        public IEventedList<IImageControl> Controls { get; set; }

        public IEventedList<IImageSettings> Settings { get; set; }

        public IEventedList<IImageMaker> Makers { get; set; }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            // Events
            this.Makers.ItemAdded -= this.MakersItemAdded;
            this.Controls.ItemAdded -= this.ControlsItemAdded;
            this.Settings.ItemAdded -= this.SettingsItemAdded;

            // Data
            this.Makers = null;
            this.Controls = null;
            this.Settings = null;
        }

        #endregion

        /// <summary>
        /// Loads Image classes from DLL
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
                    if (types[i].Name.Contains("ImageControl") &&
                        types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Controls.Add(assembly.CreateInstance(types[i].FullName) as IImageControl);
                    }
                    else if (types[i].Name.Contains("ImageSettings") &&
                             types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Settings.Add(assembly.CreateInstance(types[i].FullName) as IImageSettings);
                    }
                    else if (types[i].Name.Contains("ImageMaker") &&
                             types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Makers.Add(assembly.CreateInstance(types[i].FullName) as IImageMaker);
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
            Logger.Instanse.Append("Core: Loaded " + (Sender as IImageMaker).Name, LogMessageType.Info);
        }

        protected void ControlsItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as IImageControl).Name, LogMessageType.Info);
        }

        protected void SettingsItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as IImageSettings).Name, LogMessageType.Info);
        }
    }
}
