using System;
using System.Text;
using Umax.Classes.Helpers;
using Umax.Classes.Ini;
using Umax.Interfaces.Containers.Items;
using IO = System.IO;

namespace Core.Classes.Containers.Items
{
    public class KeyWord : IKeyWord
    {
        public KeyWord()
        {
            this.Name = string.Empty;
            this.Path = string.Empty;
            this.Items = new string[0];
        }

        public KeyWord(string KeyWordPath)
        {
            this.Path = KeyWordPath;
            this.Load(KeyWordPath);
        }

        #region Information
        public int ID { get; set; }
        public string Name { get; set; }
        public string Path { get; protected set; }
        #endregion

        public string[] Items { get; set; }

        protected void Load(string KeyWordPath)
        {
            // Loading ini
            IniWorker ini = new IniWorker(IO.Path.Combine(KeyWordPath, "details.ini"));
            this.ID = int.Parse(ini.IniReadValue("General", "ID"));
            this.Name = ini.IniReadValue("General", "Name");

            // Loading Items
            this.Items = IO.File.Exists(IO.Path.Combine(KeyWordPath, "keywords.txt")) ?
                IO.File.ReadAllLines(IO.Path.Combine(KeyWordPath, "keywords.txt"), Encoding.UTF8) : new string[0];
        }

        /// <summary>
        /// Saves keywords to specified directory
        /// </summary>
        /// <param name="KeyWordPath">Path to directory, where keywords will be saved</param>
        public void Save(string KeyWordPath)
        {
            // Saving details
            if (!IOHelper.CheckDirectoryExists(KeyWordPath))
            {
                IOHelper.CreateDirectory(KeyWordPath);
            }

            // Saving ini
            IniWorker ini = new IniWorker(IO.Path.Combine(KeyWordPath, "details.ini"));
            ini.IniWriteValue("General", "ID", this.ID.ToString());
            ini.IniWriteValue("General", "Name", this.Name);

            // Saving
            IO.File.WriteAllLines(IO.Path.Combine(KeyWordPath, "keywords.txt"), this.Items, Encoding.UTF8);
        }

        public void Delete()
        {
            if (IO.File.Exists(IO.Path.Combine(this.Path, "keywords.txt")))
            {
                IO.File.Delete(IO.Path.Combine(this.Path, "keywords.txt"));
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
            this.Items = null;
        }
        #endregion
    }
}
