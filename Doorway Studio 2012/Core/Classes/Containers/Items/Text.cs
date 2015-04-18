using System;
using System.Text;
using Umax.Classes.Helpers;
using Umax.Classes.Ini;
using Umax.Interfaces.Containers.Items;
using IO = System.IO;

namespace Core.Classes.Containers.Items
{
    public class Text : IText
    {
        public Text()
        {
            this.Name = string.Empty;
            this.Path = string.Empty;
            this.Content = string.Empty;
        }
        #region Information
        /// <summary>
        /// Gets or sets text ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets text name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets text path
        /// </summary>
        public string Path { get; protected set; }
        #endregion
        /// <summary>
        /// Gets or sets text content
        /// </summary>
        public string Content { get; set; }

        public Text(string TextPath)
            : this()
        {
            this.Path = TextPath;
            this.Load(TextPath);
        }

        protected void Load(string TextPath)
        {
            // Loading ini
            IniWorker ini = new IniWorker(IO.Path.Combine(TextPath, "details.ini"));
            this.ID = int.Parse(ini.IniReadValue("General", "ID"));
            this.Name = ini.IniReadValue("General", "Name");

            // Loading Items
            this.Content = IO.File.Exists(IO.Path.Combine(TextPath, "text.txt")) ?
                IO.File.ReadAllText(IO.Path.Combine(TextPath, "text.txt"), Encoding.UTF8) : string.Empty;
        }

        public void Save(string TextPath)
        {
            // Saving details
            if (!IOHelper.CheckDirectoryExists(TextPath))
            {
                IOHelper.CreateDirectory(TextPath);
            }

            // Saving ini
            IniWorker ini = new IniWorker(IO.Path.Combine(TextPath, "details.ini"));
            ini.IniWriteValue("General", "ID", this.ID.ToString());
            ini.IniWriteValue("General", "Name", this.Name);

            // Saving Items
            IO.File.WriteAllText(IO.Path.Combine(TextPath, "text.txt"), this.Content, Encoding.UTF8);
        }

        public void Delete()
        {
            if (IO.File.Exists(IO.Path.Combine(this.Path, "text.txt")))
            {
                IO.File.Delete(IO.Path.Combine(this.Path, "text.txt"));
            }

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
            this.Content = string.Empty;
        }
        #endregion
    }
}
