using System;
using System.Collections.Generic;
using System.Text;
using Umax.Classes.Helpers;
using Umax.Classes.Ini;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using IO = System.IO;

namespace Core.Classes.Containers.Items
{
    public class Image : IImage
    {
        #region Information
        public int ID { get; set; }
        public string Name { get; set; }
        public string Path { get; protected set; }
        #endregion

        public List<IFile> Items { get; set; }

        public Image()
        {
            this.Name = string.Empty;
            this.Path = string.Empty;
            this.Items = new List<IFile>();
        }

        public Image(string ImagePath)
            : this()
        {
            this.Path = ImagePath;
            this.Load(ImagePath);
        }

        protected void Load(string ImagePath)
        {
            // Loading ini
            IniWorker ini = new IniWorker(IO.Path.Combine(ImagePath, "details.ini"));
            this.ID = int.Parse(ini.IniReadValue("General", "ID"));
            this.Name = ini.IniReadValue("General", "Name");

            // Loading Items
            string imageDirectory = IO.Path.Combine(ImagePath, "Images");
            if (!IO.Directory.Exists(imageDirectory))
            {
                return;
            }

            if (!IO.File.Exists(IO.Path.Combine(imageDirectory, "details.ini")))
            {
                return;
            }

            string[] images = IO.File.ReadAllLines(IO.Path.Combine(imageDirectory, "details.ini"), Encoding.UTF8);

            for (int i = 0; i < images.Length; i++)
            {
                try
                {
                    if (!images[i].ToLower().StartsWith("http"))
                    {
                        if (!IO.Path.IsPathRooted(images[i]))
                        {
                            images[i] = IO.Path.Combine(imageDirectory, images[i]);
                        }

                        if (!IO.File.Exists(images[i]))
                        {
                            continue;
                        }
                    }

                    this.Items.Add(new File(FileType.Image, images[i]));
                }
                catch (Exception) { }
            }
        }

        public void Save(string ImagePath)
        {
            // Saving details
            if (!IO.Directory.Exists(ImagePath))
            {
                IOHelper.CreateDirectory(ImagePath);
            }

            // Saving ini
            IniWorker ini = new IniWorker(IO.Path.Combine(ImagePath, "details.ini"));
            ini.IniWriteValue("General", "ID", this.ID.ToString());
            ini.IniWriteValue("General", "Name", this.Name);

            // Actual files
            string imageDirectory = IO.Path.Combine(ImagePath, "Images");

            if (!IO.Directory.Exists(imageDirectory))
            {
                IOHelper.CreateDirectory(imageDirectory);
            }

            string[] details = new string[this.Items.Count];
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.Items[i].Path.ToLower().StartsWith("http"))
                {
                    details[i] = this.Items[i].Path;
                    continue;
                }

                string itemPath = string.Empty;
                if (!string.IsNullOrEmpty(this.Path))
                {
                    if (!this.Items[i].Path.ToLower().StartsWith(this.Path))
                    {
                        itemPath = IO.Path.Combine(imageDirectory,
                                                   IO.Path.IsPathRooted(this.Items[i].Path)
                                                       ? this.Items[i].Path.Substring(
                                                           this.Items[i].Path.LastIndexOf(@"\") + 1)
                                                       : this.Items[i].Path);
                    }
                }
                else
                {
                    itemPath = IO.Path.Combine(imageDirectory,
                                               this.Items[i].Path.Substring(this.Items[i].Path.LastIndexOf(@"\") + 1));
                }

                details[i] = itemPath.Substring(imageDirectory.Length).Trim(new char[] {'\\'});
                (this.Items[i] as File).Save(itemPath);
            }

            // Saving info.ini
            string iniPath = IO.Path.Combine(imageDirectory, "details.ini");
            IO.File.WriteAllLines(iniPath, details, Encoding.UTF8);
        }

        public void Delete()
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.Items[i].Path.ToLower().StartsWith(this.Path.ToLower()))
                {
                    this.Items[i].Delete();
                }
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
