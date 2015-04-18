using System;
using System.IO;
using System.Windows.Forms;
using Umax.Classes.Ini;
using Umax.Interfaces.Enums;

namespace Monitor.Classes
{
    public class Options
    {
        public LanguageType Language { get; protected set; }

        public bool Notifications { get; protected set; }
        public int NotificationsTime { get; protected set; }
        public bool Log { get; protected set; }
        public string LogFileName { get; protected set; }
        public string LogDirectory { get; protected set; }
        public bool UpdateLog { get; protected set; }
        public string UpdateLogFileName { get; protected set; }
        public string UpdateLogDirectory { get; protected set; }

        public bool Allowed { get; protected set; }

        protected static Options instance { get; set; }
        public static Options Instance
        {
            get { return instance ?? (instance = new Options()); }
        }

        protected Options()
        {
            this.Update();
        }

        public void Update()
        {
            try
            {
                IniWorker ini;

                // Core
                string iniPath = Path.Combine(Application.StartupPath, "Core.ini");
                string iniGroup = "General";

                if (File.Exists(iniPath))
                {
                    ini = new IniWorker(iniPath);

                    // Language
                    this.Language = (LanguageType)Enum.Parse(typeof(LanguageType), ini.IniReadValue(iniGroup, "Language"), true);

                    // Reading maintenance time

                }

                // GUI
                iniPath = Path.Combine(Application.StartupPath, "GUI.ini");
                if (File.Exists(iniPath))
                {
                    ini = new IniWorker(iniPath);
                    iniGroup = "Monitor";

                    // Reading if Monitor allowed
                    this.Allowed = bool.Parse(ini.IniReadValue(iniGroup, "Monitor"));

                    // Monitor notifications
                    this.Notifications = bool.Parse(ini.IniReadValue(iniGroup, "Notifications"));
                    this.NotificationsTime = int.Parse(ini.IniReadValue(iniGroup, "Time"));

                    // Reading log settings
                    this.Log = bool.Parse(ini.IniReadValue(iniGroup, "Log"));
                    this.LogFileName = ini.IniReadValue(iniGroup, "LogFileName");
                    if (this.LogFileName == string.Empty)
                    {
                        this.LogFileName = "Monitor [Date].log";
                    }

                    this.LogDirectory = ini.IniReadValue(iniGroup, "LogDirectory");
                    this.UpdateLog = bool.Parse(ini.IniReadValue(iniGroup, "UpdateLog"));
                    this.UpdateLogFileName = ini.IniReadValue(iniGroup, "UpdateLogFileName");
                    if (this.UpdateLogFileName == string.Empty)
                    {
                        this.UpdateLogFileName = "Update [Date].log";
                    }

                    this.UpdateLogDirectory = ini.IniReadValue(iniGroup, "UpdateLogDirectory");
                }
                else
                {
                    this.ApplyDefaultOptions();
                }
            }
            catch (Exception)
            {
                this.ApplyDefaultOptions();
            }
        }

        protected void ApplyDefaultOptions()
        {
            // Core
            this.Language = LanguageType.English;

            // GUI
            this.Notifications = true;
            this.NotificationsTime = 15;

            // Log
            this.Log = true;
            this.LogFileName = "Monitor [Date].log";
            this.LogDirectory = "Log";

            // UpdateLog
            this.UpdateLog = true;
            this.UpdateLogFileName = "Update [Date].log";
            this.UpdateLogDirectory = "Log";
        }
    }
}
