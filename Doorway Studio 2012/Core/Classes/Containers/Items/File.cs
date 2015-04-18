using System;
using System.Text;
using Core.Enums;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using IO = System.IO;

namespace Core.Classes.Containers.Items
{
    public class File : IFile
    {
        public FileType Type { get; set; }

        public string Path { get; set; }

        public string Content { get; set; }

        public string[] Items { get; set; }

        public File()
        {
            this.Type = FileType.File;
            this.Path = string.Empty;
            this.Content = string.Empty;
            this.Items = new string[0];
        }

        public File(FileType FileType, string FilePath)
            : this()
        {
            this.Type = FileType;
            this.Path = FilePath;

            this.Load(FilePath, Encoding.Default);
        }

        public File(FileType FileType, string FilePath, Encoding Encoding)
            : this()
        {
            this.Type = FileType;
            this.Path = FilePath;

            this.Load(FilePath, Encoding);
        }

        protected void Load(string FilePath, Encoding Encoding)
        {
            if (!FilePath.ToLower().StartsWith("http"))
            {
                if (!IO.File.Exists(FilePath))
                {
                    throw new Exception("File not found!");
                }

                if (this.Type == FileType.File || this.Type == FileType.Image)
                {
                    return;
                }

                this.Content = IO.File.ReadAllText(FilePath, Encoding);
            }
        }

        public void Save(string FilePath)
        {
            this.Save(FilePath, Encoding.Default);
        }

        public void Save(string FilePath, Encoding Encoding)
        {
            if (FilePath.ToLower().StartsWith("http"))
            {
                return;
            }

            IOHelper.CreateDirectory(FilePath.Substring(0, FilePath.LastIndexOf(@"\") + 1));

            if (IO.File.Exists(FilePath))
            {
                IO.File.SetAttributes(FilePath, IO.FileAttributes.Normal);
            }

            if (this.Type == FileType.File || this.Type == FileType.Image)
            {
                if (this.Path != FilePath)
                {
                    try
                    {
                        IO.File.Copy(this.Path, FilePath, true);
                    }
                    catch (Exception)
                    {
                        Logger.Instanse.Append(string.Format("File: Error occurred while saving to {0}.", FilePath), LogMessageType.Info);
                    }
                }

                return;
            }

            IO.File.WriteAllText(FilePath, this.Content, Encoding);
        }

        public void Delete()
        {
            if (this.Path.ToLower().StartsWith("http"))
            {
                return;
            }

            if (IO.File.Exists(this.Path))
            {
                IO.File.SetAttributes(this.Path, IO.FileAttributes.Normal);
                IO.File.Delete(this.Path);
            }
        }

        public object Clone()
        {
            return new File()
                       {
                           Type = this.Type,
                           Path = this.Path,
                           Items = this.Items,
                           Content = this.Content
                       };
        }
    }
}
