using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core.Enums;
using Umax.Classes.Enums;
using Umax.Classes.Ini;
using Umax.Interfaces.Enums;

namespace Core.Classes
{
    public class Options
    {
        private static Options instanse;

        public static Options Instanse
        {
            get { return instanse ?? (instanse = new Options()); }
        }

        protected Options()
        {
            Logger.Instanse.Append("Options: Loading...", LogMessageType.Info);
            this.Plugins = new List<string>();

            // Loading Options
            if (File.Exists(Path.Combine(Core.MainPath, "Core.ini")))
            {
                Logger.Instanse.Append("Options: Applying...", LogMessageType.Info);
                IniWorker ini = new IniWorker(Path.Combine(Core.MainPath, "Core.ini"));
                try
                {
                    // General
                    string iniGroup = "General";
                    try
                    {
                        this.Language = (LanguageType)Enum.Parse(typeof(LanguageType), ini.IniReadValue(iniGroup, "Language"), true);
                    }
                    catch (Exception)
                    {
                        this.Language = LanguageType.English;
                    }

                    this.MaximumConcurentTasks = int.Parse(ini.IniReadValue(iniGroup, "MaximumConcurentTasks"));
                    this.TimeoutEnabled = bool.Parse(ini.IniReadValue(iniGroup, "TimeoutEnabled"));
                    this.Timeout = int.Parse(ini.IniReadValue(iniGroup, "Timeout"));

                    // Plugins
                    iniGroup = "Plugins";
                    this.PluginsEnabled = bool.Parse(ini.IniReadValue(iniGroup, "Enabled"));
                    this.Plugins = ini.IniReadValue(iniGroup, "Plugins").Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    
                    // Log
                    iniGroup = "Log";
                    this.LogSave = bool.Parse(ini.IniReadValue(iniGroup, "Log"));
                    this.LogMaxSize = int.Parse(ini.IniReadValue(iniGroup, "MaxSize"));
                    this.LogFileName = ini.IniReadValue(iniGroup, "FileName");
                    if (this.LogFileName == string.Empty)
                    {
                        this.LogFileName = "Log [Date].log";
                    }

                    this.LogDirectory = ini.IniReadValue(iniGroup, "Directory");
                    this.LogDebugMode = bool.Parse(ini.IniReadValue(iniGroup, "DebugMode"));

                    // Web UI

                    // Maintenance

                    Logger.Instanse.Append("Options: Applied.", LogMessageType.Info);
                }
                catch (Exception)
                {
                    Logger.Instanse.Append("Options: Failed to load.", LogMessageType.Info);
                    this.ApplyDefaultOptions();
                }

                Logger.Instanse.Append("Options: Loaded.", LogMessageType.Info);
            }
            else
            {
                this.ApplyDefaultOptions();
            }

            Logger.Instanse.UseOptions = true;
        }

        protected void ApplyDefaultOptions()
        {
            Logger.Instanse.Append("Options: Applying default options...", LogMessageType.Info);

            // General
            this.Language = LanguageType.English;
            this.MaximumConcurentTasks = 3;
            this.TimeoutEnabled = false;
            this.Timeout = 1000;

            // Log
            this.LogSave = true;
            this.LogMaxSize = 1000;
            this.LogFileName = "Log [Date].log";
            this.LogDirectory = "Log";
            this.LogDebugMode = true;

            // Plugins
            this.PluginsEnabled = false;
            this.Plugins = new List<string>();

            // Maintenance

            Logger.Instanse.Append("Options: Default options applied...", LogMessageType.Info);
        }

        public void Save()
        {
            try
            {
                Logger.Instanse.Append("Options: Saving...", LogMessageType.Info);
                if (File.Exists(Path.Combine(Core.MainPath, "Core.ini")))
                {
                    // Removing read-only
                    new FileInfo(Path.Combine(Core.MainPath, "Core.ini"))
                        {Attributes = FileAttributes.Normal};
                }

                // Saving
                IniWorker ini = new IniWorker(Path.Combine(Core.MainPath, "Core.ini"));
                string iniGroup = "General";

                // General
                ini.IniWriteValue(iniGroup, "Language", this.Language.ToString());
                ini.IniWriteValue(iniGroup, "MaximumConcurentTasks", this.MaximumConcurentTasks.ToString());
                ini.IniWriteValue(iniGroup, "TimeoutEnabled", this.TimeoutEnabled.ToString());
                ini.IniWriteValue(iniGroup, "Timeout", this.Timeout.ToString());

                // Plugins
                iniGroup = "Plugins";
                ini.IniWriteValue(iniGroup, "Enabled", this.PluginsEnabled.ToString());
                string temp = string.Empty;
                for (int i = 0; i < this.Plugins.Count; i++)
                {
                    temp += this.Plugins[i] + "|";
                }

                ini.IniWriteValue(iniGroup, "Plugins", temp);

                // Log
                iniGroup = "Log";
                ini.IniWriteValue(iniGroup, "Log", this.LogSave.ToString());
                ini.IniWriteValue(iniGroup, "MaxSize", this.LogMaxSize.ToString());
                ini.IniWriteValue(iniGroup, "FileName", this.LogFileName);
                ini.IniWriteValue(iniGroup, "Directory", this.LogDirectory);
                ini.IniWriteValue(iniGroup, "DebugMode", this.LogDebugMode.ToString());

                // Maintenance

                Logger.Instanse.Append("Options: Saved successfully.", LogMessageType.Info);
            }
            catch (Exception)
            {
                Logger.Instanse.Append("Options: Saving failed.", LogMessageType.Info);
            }
        }

        #region Data
        public LanguageType Language { get; set; }

        public int MaximumConcurentTasks { get; set; }

        public bool TimeoutEnabled { get; set; }
        public int Timeout { get; set; }

        public bool LogSave { get; set; }
        public int LogMaxSize { get; set; }
        public string LogFileName { get; set; }
        public string LogDirectory { get; set; }
        public bool LogDebugMode { get; set; }
        public bool PluginsEnabled { get; set; }
        public List<string> Plugins { get; set; }

        #endregion
    }
}
