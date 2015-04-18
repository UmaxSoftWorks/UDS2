using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Umax.Classes.Containers;
using Umax.Classes.Helpers;
using Umax.Classes.Ini;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using IO = System.IO;

namespace Core.Classes.Containers.Items
{
    public class Template : ITemplate
    {
        #region Information
        public int ID { get; set; }
        public string Name { get; set; }
        public string Path { get; protected set; }
        public Encoding Encoding { get; set; }

        public IEventedList<IFile> Items { get; set; }
        #endregion

        public Template()
        {
            this.Name = string.Empty;
            this.Path = string.Empty;
            this.Encoding = Encoding.Default;
            this.Items = new EventedList<IFile>();

            this.Items.CountChanged += this.OnChanged;
        }

        public Template(string TemplatePath)
            : this()
        {
            this.Path = TemplatePath;
            this.Load(TemplatePath);
        }

        protected void Load(string TemplatePath)
        {
            // Loading ini
            IniWorker ini = new IniWorker(IO.Path.Combine(this.Path, "details.ini"));
            this.ID = int.Parse(ini.IniReadValue("General", "ID"));
            this.Name = ini.IniReadValue("General", "Name");

            try
            {
                Encoding = Encoding.GetEncoding(ini.IniReadValue("General", "Encoding"));
            }
            catch (Exception)
            {
                Encoding = Encoding.Default;
            }

            // Loading Items
            this.Import(IO.Path.Combine(this.Path, "Files"), this.Encoding);
        }

        public void Import(string TemplatePath, Encoding Encoding)
        {
            string iniPath = IO.Path.Combine(TemplatePath, "details.ini");

            string[] details = IO.File.ReadAllLines(iniPath, Encoding.UTF8);

            for (int i = 0; i < details.Length; i++)
            {
                try
                {
                    FileType fileType = (FileType)Enum.Parse(typeof(FileType), details[i].Substring(0, details[i].IndexOf("=")), true);

                    string filePath = details[i].Substring(fileType.ToString().Length + 1);

                    if (!filePath.ToLower().StartsWith("http"))
                    {
                        if (!IO.Path.IsPathRooted(filePath))
                        {
                            filePath = IO.Path.Combine(TemplatePath, filePath);
                        }

                        if (!IO.File.Exists(filePath))
                        {
                            continue;
                        }
                    }

                    File file = new File(fileType, filePath, Encoding);

                    if (fileType == FileType.Custom)
                    {
                        if (details[i].Contains("|"))
                        {
                            file.Items = details[i].Substring(details[i].IndexOf("|") + 1).Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        }
                    }

                    this.Items.Add(file);
                }
                catch (Exception) { }
            }

            // Statistics
        }

        public void Save(string TemplatePath)
        {
            // Saving details
            if (!IOHelper.CheckDirectoryExists(TemplatePath))
            {
                IOHelper.CreateDirectory(TemplatePath);
            }

            // Saving ini
            IniWorker ini = new IniWorker(IO.Path.Combine(TemplatePath, "details.ini"));
            ini.IniWriteValue("General", "ID", this.ID.ToString());
            ini.IniWriteValue("General", "Name", this.Name);
            ini.IniWriteValue("General", "Encoding", Encoding.EncodingName);

            // Saving Items
            this.Export(IO.Path.Combine(TemplatePath, "Files"));
        }

        public void Export(string TemplatePath)
        {
            if (!IOHelper.CheckDirectoryExists(TemplatePath))
            {
                IOHelper.CreateDirectory(TemplatePath);
            }

            string[] details = new string[this.Items.Count];
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.Items[i].Path.ToLower().StartsWith("http"))
                {
                    details[i] = this.Items[i].Type.ToString() + "=" + this.Items[i].Path;
                    continue;
                }

                string itemPath = string.Empty;
                if (!string.IsNullOrEmpty(this.Path))
                {
                    if (!this.Items[i].Path.ToLower().StartsWith(this.Path))
                    {
                        itemPath = IO.Path.Combine(TemplatePath, IO.Path.IsPathRooted(this.Items[i].Path)
                                                                     ? this.Items[i].Path.Substring(
                                                                         this.Items[i].Path.LastIndexOf(@"\") + 1)
                                                                     : this.Items[i].Path);
                    }
                }
                else
                {
                    itemPath = IO.Path.Combine(TemplatePath, this.Items[i].Path.Substring(this.Items[i].Path.LastIndexOf(@"\") + 1));
                }

                details[i] = this.Items[i].Type.ToString() + "=" +
                          itemPath.Substring(TemplatePath.Length).Trim(new char[] {'\\'});
                (this.Items[i] as File).Save(itemPath, Encoding);
            }

            // Saving info.ini
            string iniPath = IO.Path.Combine(TemplatePath, "details.ini");
            IO.File.WriteAllLines(iniPath, details, Encoding.UTF8);
        }

        public List<IFile> Select(FileType Type)
        {
            return (from IFile item in this.Items.ToList()
                    where item.Type == FileType.Index
                    select item).ToList();
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

        private void OnChanged()
        {
            if (this.Changed != null)
            {
                this.Changed();
            }
        }

        public event SimpleEventHandler Changed;
    }
}
