using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Umax.Classes;
using Umax.Classes.Compression;
using Umax.Classes.Enums;

namespace Monitor.Classes
{
    public class Updater
    {
        protected Logger MainLogger { get; set; }
        public string Log
        {
            get
            {
                return MainLogger.Log;
            }
        }

        public Updater()
        {
            MainLogger = new Logger();
        }

        public bool Check()
        {
            if (File.Exists(Path.Combine(Application.StartupPath, "update.zip")))
            {
                return true;
            }
            return false;
        }

        public void Update()
        {
            if (!Check())
            {
                return;
            }

            try
            {
                string zipFileName = Path.Combine(Application.StartupPath, "update.zip");
                // Opens existing zip file
                ZipStorer zip = ZipStorer.Open(zipFileName, FileAccess.Read);

                // Read all directory contents
                List<ZipStorer.ZipFileEntry> zipFiles = zip.ReadCentralDir();

                // Extract all files in target directory
                foreach (ZipStorer.ZipFileEntry entry in zipFiles)
                {
                    if (zip.ExtractFile(entry, Path.Combine(Application.StartupPath, Path.GetFileName(entry.FilenameInZip))))
                    {
                        MainLogger.Append("Extracted: " + entry.FilenameInZip, LogMessageType.Info);
                    }
                    else
                    {
                        MainLogger.Append("Extract failed: " + entry.FilenameInZip, LogMessageType.Info);
                    }
                }

                zip.Close();

                File.Delete(zipFileName);
            }
            catch (Exception) { }
        }

        public void SaveLog()
        {
            if (Options.Instance.UpdateLog)
            {
                MainLogger.Save(Path.Combine(Options.Instance.UpdateLogDirectory, Options.Instance.UpdateLogFileName));
            }
        }
    }
}
