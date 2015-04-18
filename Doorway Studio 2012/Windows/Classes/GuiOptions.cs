using System;
using System.IO;
using System.Windows.Forms;
using Core.Classes;
using Umax.Classes.Ini;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using Umax.Windows.Enums;

namespace Umax.Windows.Classes
{
    public class GuiOptions
    {
        #region Data
        public LanguageType Language
        {
            get
            {
                return Options.Instanse.Language;
            }
        }

        public bool NoFxCheck { get; set; }
        public bool QuietStart { get; set; }

        #region View
        public AppearanceType Appearance { get; set; }

        protected bool appearanceNews;
        public bool AppearanceNews
        {
            get { return this.appearanceNews; }
            set
            {
                this.appearanceNews = value;
                if (this.NewsChanged != null)
                {
                    this.NewsChanged.Invoke();
                }
            }
        }
        public event SimpleEventHandler NewsChanged;

        protected bool appearanceGeneral;
        public bool AppearanceGeneral
        {
            get { return this.appearanceGeneral; }
            set
            {
                this.appearanceGeneral = value;
                if (this.AppearanceGeneralChanged != null)
                {
                    this.AppearanceGeneralChanged.Invoke();
                }
            }
        }
        public event SimpleEventHandler AppearanceGeneralChanged;

        protected bool appearanceLargeCalendar;
        public bool AppearanceLargeCalendar
        {
            get { return this.appearanceLargeCalendar; }
            set
            {
                this.appearanceLargeCalendar = value;
                if (this.AppearanceLargeCalendarChanged != null)
                {
                    this.AppearanceLargeCalendarChanged.Invoke();
                }
            }
        }
        public event SimpleEventHandler AppearanceLargeCalendarChanged;
        #endregion

        #region Manager
        public bool Manager { get; set; }
        protected bool managerPin;
        public bool ManagerPin
        {
            get { return this.managerPin; }
            set
            {
                this.managerPin = value;
                if (this.ManagerPinChanged != null)
                {
                    this.ManagerPinChanged.Invoke();
                }
            }
        }
        public event SimpleEventHandler ManagerPinChanged;

        protected ManagerLocationType managerLocation;
        public ManagerLocationType ManagerLocation
        {
            get { return this.managerLocation; }
            set
            {
                this.managerLocation = value;
                if (this.ManagerLocationChanged != null)
                {
                    this.ManagerLocationChanged.Invoke();
                }
            }
        }

        public event SimpleEventHandler ManagerLocationChanged;
        #endregion

        public bool TrayWindowPinned { get; set; }
        public int TrayWindowOpacity { get; set; }

        public bool UpdateCheckAtStartup { get; set; }
        public bool UpdateCheckWhileRunning { get; set; }
        public int UpdateCheckWhileRunningPeriod { get; set; } // In hours

        public bool AutoStart { get; set; } //Start with windows
        public bool MinimizedStart { get; set; }

        #region Notifications
        public bool Notifications { get; set; }
        public int NotificationsTime { get; set; } //Show baloons time in seconds

        public bool NotificationsAtTaskStarted { get; set; }
        public bool NotificationsAtTaskFailed { get; set; }
        public bool NotificationsAtTaskFinished { get; set; }
        public bool NotificationsAtNoTask { get; set; }
        #endregion

        #region Sounds
        public bool PlaySounds { get; set; }
        public int PlaySoundsTime { get; set; } //Maximum time for playing sounds

        public bool PlaySoundsAtTaskStarted { get; set; }
        public string PlaySoundsAtTaskStartedFile { get; set; }
        public bool PlaySoundsAtTaskFailed { get; set; }
        public string PlaySoundsAtTaskFailedFile { get; set; }
        public bool PlaySoundsAtTaskFinished { get; set; }
        public string PlaySoundsAtTaskFinishedFile { get; set; }
        public bool PlaySoundsAtNoTask { get; set; }
        public string PlaySoundsAtNoTaskFile { get; set; }
        #endregion

        #region Monitor
        public bool Monitor { get; set; }
        public bool MonitorNotifications { get; set; }
        public int MonitorNotificationsTime { get; set; }
        public bool MonitorLog { get; set; }
        public string MonitorLogFileName { get; set; }
        public string MonitorLogDirectory { get; set; }
        public bool MonitorUpdateLog { get; set; }
        public string MonitorUpdateLogFileName { get; set; }
        public string MonitorUpdateLogDirectory { get; set; }
        #endregion

        #region Reporting
        public bool Report { get; set; }
        public bool ReportRnD { get; set; }
        public string ReportTo { get; set; }
        public string ReportFrom { get; set; }
        public string ReportSubject { get; set; }
        public string ReportMessage { get; set; }
        public string ReportHost { get; set; }
        public string ReportLogin { get; set; }
        public string ReportPassword { get; set; }
        public int ReportPort { get; set; }
        public bool ReportAttachments { get; set; }
        #endregion

        #endregion

        #region Methods

        protected static GuiOptions instanse;

        public static GuiOptions Instanse
        {
            get { return instanse ?? (instanse = new GuiOptions()); }
        }

        protected GuiOptions()
        {
            // Loading Options
            if (File.Exists(Path.Combine(Application.StartupPath, "GUI.ini")))
            {
                IniWorker ini = new IniWorker(Path.Combine(Application.StartupPath, "GUI.ini"));
                try
                {
                    string iniGroup = "General";

                    // General
                    if (!this.NoFxCheck)
                    {
                        this.NoFxCheck = bool.Parse(ini.IniReadValue(iniGroup, "NoFxCheck"));
                    }
                    
                    // Appearance
                    iniGroup = "Appearance";
                    this.Appearance = (AppearanceType)Enum.Parse(typeof(AppearanceType), ini.IniReadValue(iniGroup, "Appearance"), true);
                    this.AppearanceNews = bool.Parse(ini.IniReadValue(iniGroup, "News"));
                    this.AppearanceGeneral = bool.Parse(ini.IniReadValue(iniGroup, "General"));
                    this.AppearanceLargeCalendar = bool.Parse(ini.IniReadValue(iniGroup, "LargeCalendar"));

                    // Manager
                    iniGroup = "Manager";
                    this.Manager = bool.Parse(ini.IniReadValue(iniGroup, "Manager"));
                    this.ManagerPin = bool.Parse(ini.IniReadValue(iniGroup, "PinToDesktop"));
                    this.ManagerLocation = (ManagerLocationType)Enum.Parse(typeof(ManagerLocationType), ini.IniReadValue(iniGroup, "Location"), true);

                    // Tray Window
                    iniGroup = "Tray";
                    this.TrayWindowPinned = bool.Parse(ini.IniReadValue(iniGroup, "TrayWindowPinned"));
                    this.TrayWindowOpacity = int.Parse(ini.IniReadValue(iniGroup, "TrayWindowOpacity"));
                    
                    // StartUp
                    iniGroup = "StartUp";
                    if (!this.MinimizedStart)
                    {
                        this.MinimizedStart = bool.Parse(ini.IniReadValue(iniGroup, "MinimizedStart"));
                    }

                    this.AutoStart = bool.Parse(ini.IniReadValue(iniGroup, "AutoStart"));
                    
                    // Notifications
                    iniGroup = "Notifications";
                    this.Notifications = bool.Parse(ini.IniReadValue(iniGroup, "Notifications"));
                    this.NotificationsTime = int.Parse(ini.IniReadValue(iniGroup, "Time"));
                    this.NotificationsAtTaskStarted = bool.Parse(ini.IniReadValue(iniGroup, "TaskStarted"));
                    this.NotificationsAtTaskFailed = bool.Parse(ini.IniReadValue(iniGroup, "TaskFailed"));
                    this.NotificationsAtTaskFinished = bool.Parse(ini.IniReadValue(iniGroup, "TaskFinished"));
                    this.NotificationsAtNoTask = bool.Parse(ini.IniReadValue(iniGroup, "NoTask"));

                    this.PlaySounds = bool.Parse(ini.IniReadValue(iniGroup, "Sounds"));
                    this.PlaySoundsTime = int.Parse(ini.IniReadValue(iniGroup, "SoundsTime"));
                    this.PlaySoundsAtTaskStarted = bool.Parse(ini.IniReadValue(iniGroup, "SoundsTaskStarted"));
                    this.PlaySoundsAtTaskStartedFile = ini.IniReadValue(iniGroup, "SoundsTaskStartedFile");
                    this.PlaySoundsAtTaskFailed = bool.Parse(ini.IniReadValue(iniGroup, "SoundsTaskFailed"));
                    this.PlaySoundsAtTaskFailedFile = ini.IniReadValue(iniGroup, "SoundsTaskFailedFile");
                    this.PlaySoundsAtTaskFinished = bool.Parse(ini.IniReadValue(iniGroup, "SoundsTaskFinished"));
                    this.PlaySoundsAtTaskFinishedFile = ini.IniReadValue(iniGroup, "SoundsTaskFinishedFile");
                    this.PlaySoundsAtNoTask = bool.Parse(ini.IniReadValue(iniGroup, "SoundsNoTask"));
                    this.PlaySoundsAtNoTaskFile = ini.IniReadValue(iniGroup, "SoundsNoTaskFile");

                    // Updates
                    iniGroup = "Updates";
                    this.UpdateCheckAtStartup = bool.Parse(ini.IniReadValue(iniGroup, "AtStartup"));
                    this.UpdateCheckWhileRunning = bool.Parse(ini.IniReadValue(iniGroup, "WhileRunning"));
                    this.UpdateCheckWhileRunningPeriod = int.Parse(ini.IniReadValue(iniGroup, "WhileRunningPeriod"));

                    // Monitor
                    iniGroup = "Monitor";
                    this.Monitor = bool.Parse(ini.IniReadValue(iniGroup, "Monitor"));
                    this.MonitorNotifications = bool.Parse(ini.IniReadValue(iniGroup, "Notifications"));
                    this.MonitorNotificationsTime = int.Parse(ini.IniReadValue(iniGroup, "NotificationsTime"));
                    this.MonitorLog = bool.Parse(ini.IniReadValue(iniGroup, "Log"));
                    this.MonitorLogFileName = ini.IniReadValue(iniGroup, "LogFileName");
                    if (this.MonitorLogFileName == string.Empty)
                    {
                        this.MonitorLogFileName = "Monitor [Date].log";
                    }

                    this.MonitorLogDirectory = ini.IniReadValue(iniGroup, "LogDirectory");
                    this.MonitorUpdateLog = bool.Parse(ini.IniReadValue(iniGroup, "UpdateLog"));
                    this.MonitorUpdateLogFileName = ini.IniReadValue(iniGroup, "UpdateLogFileName");
                    if (this.MonitorUpdateLogFileName == string.Empty)
                    {
                        this.MonitorUpdateLogFileName = "Update [Date].log";
                    }

                    this.MonitorUpdateLogDirectory = ini.IniReadValue(iniGroup, "UpdateLogDirectory");

                    // Reporting
                    iniGroup = "Reporting";
                    this.Report = bool.Parse(ini.IniReadValue(iniGroup, "Report"));
                    this.ReportRnD = bool.Parse(ini.IniReadValue(iniGroup, "ReportRnD"));
                    this.ReportTo = ini.IniReadValue(iniGroup, "To");
                    this.ReportFrom = ini.IniReadValue(iniGroup, "From");
                    this.ReportSubject = ini.IniReadValue(iniGroup, "Subject");
                    this.ReportMessage = ini.IniReadValue(iniGroup, "Message");
                    this.ReportHost = ini.IniReadValue(iniGroup, "Host");
                    this.ReportPort = int.Parse(ini.IniReadValue(iniGroup, "Port"));
                    this.ReportLogin = ini.IniReadValue(iniGroup, "Login");
                    this.ReportPassword = ini.IniReadValue(iniGroup, "Password");
                    this.ReportAttachments = bool.Parse(ini.IniReadValue(iniGroup, "Attachments"));
                }
                catch (Exception)
                {
                    this.ApplyDefaultOptions();
                }
            }
            else
            {
                this.ApplyDefaultOptions();
            }
        }

        protected void ApplyDefaultOptions()
        {
            // General
            this.NoFxCheck = false;

            // Appearance
            this.Appearance = AppearanceType.Classic;
            this.AppearanceNews = true;
            this.AppearanceGeneral = true;
            this.AppearanceLargeCalendar = false;

            // Manager
            this.Manager = false;
            this.ManagerPin = false;
            this.ManagerLocation = 0;

            // Tray Window
            this.TrayWindowPinned = false;
            this.TrayWindowOpacity = 75;

            // Startup
            this.MinimizedStart = false;
            this.AutoStart = false;

            // Notifications
            this.Notifications = true;
            this.NotificationsTime = 30;
            this.NotificationsAtTaskStarted = true;
            this.NotificationsAtTaskFailed = true;
            this.NotificationsAtTaskFinished = true;
            this.NotificationsAtNoTask = true;

            this.PlaySounds = false;
            this.PlaySoundsTime = 30;
            this.PlaySoundsAtTaskStarted = false;
            this.PlaySoundsAtTaskStartedFile = string.Empty;
            this.PlaySoundsAtTaskFailed = false;
            this.PlaySoundsAtTaskFailedFile = string.Empty;
            this.PlaySoundsAtTaskFinished = false;
            this.PlaySoundsAtTaskFinishedFile = string.Empty;
            this.PlaySoundsAtNoTask = false;
            this.PlaySoundsAtNoTaskFile = string.Empty;

            // Updates
            this.UpdateCheckAtStartup = true;
            this.UpdateCheckWhileRunning = true;
            this.UpdateCheckWhileRunningPeriod = 12;

            // Monitor
            this.Monitor = true;
            this.MonitorNotifications = true;
            this.MonitorNotificationsTime = 15;
            this.MonitorLog = true;
            this.MonitorLogFileName = "Monitor [Date].log";
            this.MonitorLogDirectory = string.Empty;
            this.MonitorUpdateLog = true;
            this.MonitorUpdateLogFileName = "Update [Date].log";
            this.MonitorUpdateLogDirectory = string.Empty;
           
            // Reporter
            this.Report = false;
            this.ReportRnD = true;
            this.ReportTo = string.Empty;
            this.ReportFrom = string.Empty;
            this.ReportSubject = string.Empty;
            this.ReportMessage = string.Empty;
            this.ReportHost = string.Empty;
            this.ReportPort = 25;
            this.ReportLogin = string.Empty;
            this.ReportPassword = string.Empty;
            this.ReportAttachments = false;
        }

        public void Save()
        {
            try
            {
                if (File.Exists(Path.Combine(Application.StartupPath, "GUI.ini")))
                {
                    // Removing readonly
                    FileInfo file = new FileInfo(Path.Combine(Application.StartupPath, "GUI.ini"));
                    file.Attributes = FileAttributes.Normal;
                }

                // Saving
                IniWorker ini = new IniWorker(Path.Combine(Application.StartupPath, "GUI.ini"));
                string iniGroup = string.Empty;

                // General
                iniGroup = "General";
                ini.IniWriteValue(iniGroup, "NoFxCheck", this.NoFxCheck.ToString());

                // Appearance
                iniGroup = "Appearance";
                ini.IniWriteValue(iniGroup, "Appearance", this.Appearance.ToString());
                ini.IniWriteValue(iniGroup, "News", this.AppearanceNews.ToString());
                ini.IniWriteValue(iniGroup, "General", this.AppearanceGeneral.ToString());
                ini.IniWriteValue(iniGroup, "LargeCalendar", this.AppearanceLargeCalendar.ToString());

                // Manager
                iniGroup = "Manager";
                ini.IniWriteValue(iniGroup, "Manager", this.Manager.ToString());
                ini.IniWriteValue(iniGroup, "PinToDesktop", this.ManagerPin.ToString());
                ini.IniWriteValue(iniGroup, "Location", this.ManagerLocation.ToString());

                // Tray Window
                iniGroup = "Tray";
                ini.IniWriteValue(iniGroup, "TrayWindowPinned", this.TrayWindowPinned.ToString());
                ini.IniWriteValue(iniGroup, "TrayWindowOpacity", this.TrayWindowOpacity.ToString());

                // StartUp
                iniGroup = "StartUp";
                ini.IniWriteValue(iniGroup, "MinimizedStart", this.MinimizedStart.ToString());
                ini.IniWriteValue(iniGroup, "AutoStart", this.AutoStart.ToString());

                // Notifications
                iniGroup = "Notifications";
                ini.IniWriteValue(iniGroup, "Notifications", this.Notifications.ToString());
                ini.IniWriteValue(iniGroup, "Time", this.NotificationsTime.ToString());
                ini.IniWriteValue(iniGroup, "TaskStarted", this.NotificationsAtTaskStarted.ToString());
                ini.IniWriteValue(iniGroup, "TaskFailed", this.NotificationsAtTaskFailed.ToString());
                ini.IniWriteValue(iniGroup, "TaskFinished", this.NotificationsAtTaskFinished.ToString());
                ini.IniWriteValue(iniGroup, "NoTask", this.NotificationsAtNoTask.ToString());

                ini.IniWriteValue(iniGroup, "Sounds", this.PlaySounds.ToString());
                ini.IniWriteValue(iniGroup, "SoundsTime", this.PlaySoundsTime.ToString());
                ini.IniWriteValue(iniGroup, "SoundsTaskStarted", this.PlaySoundsAtTaskStarted.ToString());
                ini.IniWriteValue(iniGroup, "SoundsTaskStartedFile", this.PlaySoundsAtTaskStartedFile);
                ini.IniWriteValue(iniGroup, "SoundsTaskFailed", this.PlaySoundsAtTaskFailed.ToString());
                ini.IniWriteValue(iniGroup, "SoundsTaskFailedFile", this.PlaySoundsAtTaskFailedFile);
                ini.IniWriteValue(iniGroup, "SoundsTaskFinished", this.PlaySoundsAtTaskFinished.ToString());
                ini.IniWriteValue(iniGroup, "SoundsTaskFinishedFile", this.PlaySoundsAtTaskFinishedFile);
                ini.IniWriteValue(iniGroup, "SoundsNoTask", this.PlaySoundsAtNoTask.ToString());
                ini.IniWriteValue(iniGroup, "SoundsNoTaskFile", this.PlaySoundsAtNoTaskFile);

                // Updates
                iniGroup = "Updates";
                ini.IniWriteValue(iniGroup, "AtStartup", this.UpdateCheckAtStartup.ToString());
                ini.IniWriteValue(iniGroup, "WhileRunning", this.UpdateCheckWhileRunning.ToString());
                ini.IniWriteValue(iniGroup, "WhileRunningPeriod", this.UpdateCheckWhileRunningPeriod.ToString());

                // Monitor
                iniGroup = "Monitor";
                ini.IniWriteValue(iniGroup, "Monitor", this.Monitor.ToString());
                ini.IniWriteValue(iniGroup, "Notifications", this.MonitorNotifications.ToString());
                ini.IniWriteValue(iniGroup, "NotificationsTime", this.MonitorNotificationsTime.ToString());
                ini.IniWriteValue(iniGroup, "Log", this.MonitorLog.ToString());
                ini.IniWriteValue(iniGroup, "LogFileName", this.MonitorLogFileName);
                ini.IniWriteValue(iniGroup, "LogDirectory", this.MonitorLogDirectory);
                ini.IniWriteValue(iniGroup, "UpdateLog", this.MonitorUpdateLog.ToString());
                ini.IniWriteValue(iniGroup, "UpdateLogFileName", this.MonitorUpdateLogFileName);
                ini.IniWriteValue(iniGroup, "UpdateLogDirectory", this.MonitorUpdateLogDirectory);

                // Reporter
                iniGroup = "Reporting";
                ini.IniWriteValue(iniGroup, "Report", this.Report.ToString());
                ini.IniWriteValue(iniGroup, "ReportRnD", this.ReportRnD.ToString());
                ini.IniWriteValue(iniGroup, "To", this.ReportTo);
                ini.IniWriteValue(iniGroup, "From", this.ReportFrom);
                ini.IniWriteValue(iniGroup, "Subject", this.ReportSubject);
                ini.IniWriteValue(iniGroup, "Message", this.ReportMessage);
                ini.IniWriteValue(iniGroup, "Host", this.ReportHost);
                ini.IniWriteValue(iniGroup, "Port", this.ReportPort.ToString());
                ini.IniWriteValue(iniGroup, "Login", this.ReportLogin);
                ini.IniWriteValue(iniGroup, "Password", this.ReportPassword);
                ini.IniWriteValue(iniGroup, "Attachments", this.ReportAttachments.ToString());
            }
            catch (Exception) { }
        }
        #endregion
    }
}
