using System;
using System.IO;
using System.Text;
using Umax.Classes.Enums;

namespace Umax.Classes.Helpers
{
    public static class IOHelper
    {
        public static void CreateDirectory(string DirectoryPath)
        {
            CreateDirectory(DirectoryPath, DateTime.Now);
        }

        public static void CreateDirectory(string DirectoryPath, DateTime Time)
        {
            // Taken from http://www.extensionmethod.net/Details.aspx?ID=108
            DirectoryInfo directoryInfo = new DirectoryInfo(DirectoryPath);

            if (directoryInfo.Parent != null)
            {
                CreateDirectory(directoryInfo.Parent.FullName, Time);
            }

            if (!CheckDirectoryExists(directoryInfo.FullName))
            {
                directoryInfo.Create();
                TouchDirectory(directoryInfo.FullName, Time, IOTouchType.None);
            }
        }

        /// <summary>
        /// Checks if file exists
        /// </summary>
        /// <param name="Path">Path to the file</param>
        /// <returns>True if file exists</returns>
        public static bool CheckFileExists(string Path)
        {
            return File.Exists(Path);
        }

        /// <summary>
        /// Checks if directory exists
        /// </summary>
        /// <param name="Path">Path to the file</param>
        /// <returns>True if file exists</returns>
        public static bool CheckDirectoryExists(string Path)
        {
            return Directory.Exists(Path);
        }

        public static void CopyFile(string SourcePath, string DestinationPath)
        {
            CopyFile(SourcePath, DestinationPath, DateTime.Now);
        }

        public static void CopyFile(string SourcePath, string DestinationPath, DateTime Time)
        {
            if (!CheckFileExists(SourcePath))
            {
                return;
            }

            // Create directories
            if (DestinationPath.Contains("\\"))
            {
                CreateDirectory(DestinationPath.Substring(0, DestinationPath.LastIndexOf("\\")));
            }

            // Copy
            File.Copy(SourcePath, DestinationPath, true);

            TouchFile(DestinationPath, Time);
        }

        public static void WriteText(string Path, string Content, Encoding Encoding)
        {
            WriteText(Path, Content, Encoding, DateTime.Now);
        }

        public static void WriteText(string Path, string Content, Encoding Encoding, DateTime Time)
        {
            // Create directories
            if (Path.Contains("\\"))
            {
                CreateDirectory(Path.Substring(0, Path.LastIndexOf("\\")));
            }

            // Write content
            File.WriteAllText(Path, Content, Encoding);

        }

        public static void TouchDirectory(string Path, DateTime Time, IOTouchType TouchType)
        {
            if (!CheckDirectoryExists(Path))
            {
                return;
            }

            switch (TouchType)
            {
                case IOTouchType.None:
                    {
                        DirectoryInfo info = new DirectoryInfo(Path);
                        if (info.Root.FullName == info.FullName)
                        {
                            return;
                        }

                        try
                        {
                            info.Attributes = FileAttributes.Normal;
                            info.CreationTime = Time;
                            info.LastAccessTime = Time;
                        }
                        catch (Exception){}

                        break;
                    }

                case IOTouchType.Items:
                    {
                        TouchFile(Directory.GetFiles(Path), Time);
                        TouchDirectory(Path, Time, IOTouchType.None);
                        break;
                    }

                case IOTouchType.All:
                    {
                        string[] directories = Directory.GetDirectories(Path, "*", SearchOption.AllDirectories);

                        for (int i = 0; i < directories.Length; i++)
                        {
                            TouchDirectory(directories[i], Time, IOTouchType.All);
                        }

                        TouchDirectory(Path, Time, IOTouchType.Items);

                        break;
                    }
            }
        }

        public static void TouchFile(string[] Items, DateTime Time)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                TouchFile(Items[i], Time);
            }
        }

        public static void TouchFile(string Path, DateTime Time)
        {
            if (CheckFileExists(Path))
            {
                FileInfo info = new FileInfo(Path);
                info.Attributes = FileAttributes.Normal;
                info.CreationTime = Time;
                info.LastAccessTime = Time;
            }
        }

        public static string MakeFileName()
        {
            Random random = new Random();
            string name = string.Empty;
            int length = random.Next(5, 8);

            for (int i = 0; i < length; i++)
            {
                name += ((char)random.Next((int)'A', (int)'Z')).ToString();
            }

            return name;
        }
    }
}
