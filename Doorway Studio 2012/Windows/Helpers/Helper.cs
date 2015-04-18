using System;
using System.Windows.Forms;
using Core.Classes;
using Microsoft.Win32;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Windows.Classes;
using Umax.Windows.Interfaces;
using Umax.Windows.Windows.Common;
using Umax.Windows.Windows.Help;
using IO = System.IO;

namespace Umax.Windows.Helpers
{
    public static class Helper
    {
        public static void Exit()
        {
            // Closing Monitor
            WinHelper.SendMessage(Keys.F10, Brand.Brand.Name + " Doorway Studio 2012 Monitor");

            // Logging
            Logger.Instanse.Append("Exiting...", LogMessageType.Info);

            // Saving
            GuiOptions.Instanse.Save();
            Core.Core.Instanse.Close();
            Logger.Instanse.Save();
        }

        public static void PlayNoTaskSound()
        {
            if (GuiOptions.Instanse.PlaySounds && GuiOptions.Instanse.PlaySoundsAtNoTask)
            {
                // Looking for new tasks
                if (!Core.Helpers.Helper.NewTaskExist() && GuiOptions.Instanse.PlaySoundsAtNoTaskFile != String.Empty)
                {
                    Player.Instanse.Play(
                        GuiOptions.Instanse.PlaySoundsAtNoTaskFile,
                        GuiOptions.Instanse.PlaySoundsTime, false);
                }
            }
        }

        public static void PlaySounds(TaskStateType State)
        {
            if (GuiOptions.Instanse.PlaySounds)
            {
                switch (State)
                {
                    case TaskStateType.Running:
                        {
                            if (GuiOptions.Instanse.PlaySoundsAtTaskStarted && GuiOptions.Instanse.PlaySoundsAtTaskStartedFile != String.Empty)
                            {
                                Player.Instanse.Play(GuiOptions.Instanse.PlaySoundsAtTaskStartedFile, GuiOptions.Instanse.PlaySoundsTime, false);
                            }

                            break;
                        }

                    case TaskStateType.Done:
                        {
                            if (GuiOptions.Instanse.PlaySoundsAtTaskFinished && GuiOptions.Instanse.PlaySoundsAtTaskFinishedFile != String.Empty)
                            {
                                Player.Instanse.Play(GuiOptions.Instanse.PlaySoundsAtTaskFinishedFile, GuiOptions.Instanse.PlaySoundsTime, false);
                            }

                            break;
                        }

                    case TaskStateType.Error:
                        {
                            if (GuiOptions.Instanse.PlaySoundsAtTaskFailed && GuiOptions.Instanse.PlaySoundsAtTaskFailedFile != String.Empty)
                            {
                                Player.Instanse.Play(GuiOptions.Instanse.PlaySoundsAtTaskFailedFile, GuiOptions.Instanse.PlaySoundsTime, false);
                            }

                            break;
                        }
                }
            }
        }

        public static string CheckUpdate()
        {
            string result = string.Empty;
            try
            {
                string updatePage = String.Empty;
                switch (Brand.Brand.Name)
                {
                    case "Umax":
                        {
                            updatePage = HTTPHelper.DownloadWebPage("http://umaxsoft.com/PrivateArea/Updater/UDS2012");
                            break;
                        }
                }

                if (updatePage != String.Empty)
                {
                    //Parse version

                    //Parse url
                    //return true;
                }
            }
            catch (Exception)
            {
            }

            return result;
        }

        public static bool EulaCheck()
        {
            try
            {
                switch (Brand.Brand.Name)
                {
                    case "Umax":
                        {
                            return bool.Parse(WinHelper.ReadRegistryKey(@"SOFTWARE\Umax SoftWorks", "EULA"));
                        }

                    default:
                        {
                            return false;
                        }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void StartMonitor(string Arguments)
        {
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("Monitor");
            if (processes.Length != 0) return;

            if (IO.File.Exists(IO.Path.Combine(Application.StartupPath, "Monitor.exe")))
            {
                System.Diagnostics.Process.Start(IO.Path.Combine(Application.StartupPath, "Monitor.exe"), Arguments);
            }
        }

        /// <summary>
        /// Checks for installed .Net FX 3.5
        /// </summary>
        /// <returns>true - all ok; false - something wrong</returns>
        public static bool FXCheck()
        {
            if (GuiOptions.Instanse.NoFxCheck)
            {
                return true;
            }

            try
            {
                RegistryKey installedVersions = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP");
                string[] versionNames = installedVersions.GetSubKeyNames();

                // version names start with 'v', eg, 'v3.5' which needs to be trimmed off before conversion
                double version = Convert.ToDouble(versionNames[versionNames.Length - 1].Substring(1));

                // int SP = Convert.ToInt32(installed_versions.OpenSubKey(version_names[version_names.Length - 1]).GetValue("SP", 0));

                if (version >= 3.5)
                {
                    return true;
                }
            }
            catch (Exception) { }
            return false;
        }

        /// <summary>
        /// Return true if update archive is downloaded and available on disk
        /// </summary>
        /// <returns></returns>
        public static bool UpdateFilesAvailable()
        {
            if (IO.File.Exists(IO.Path.Combine(Application.StartupPath, "update.zip")))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Check if update available, asks and show window that download update
        /// </summary>
        public static void Update()
        {
            string url = CheckUpdate();
            if (url != string.Empty)
            {
                if (WinHelper.MessageBox("Update available. Do you want to update now?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Updater updaterWindow = new Updater()
                                                {
                                                    URL = url
                                                };
                    updaterWindow.ShowDialog();
                }
                else
                {
                    //toolStripUpdateLabel.Text = "Update available!";
                }
            }
        }

        /// <summary>
        /// Checks if all system files exists
        /// </summary>
        /// <returns>True - if all files exists</returns>
        public static bool CheckSystemFiles()
        {
            string[] files = new string[] {"Core.dll", "Classes.dll", "Images.dll", "Interfaces.dll", "Resources.dll", "Tasks.dll", "Text.dll", "Tokens.dll", "UI.dll", "Windows.dll"};
            for (int i = 0; i < files.Length; i++)
            {
                if (!IOHelper.CheckFileExists(files[i]))
                {
                    if (!GuiOptions.Instanse.QuietStart)
                    {
                        WinHelper.MessageBox(string.Format("Library {0} not found!", files[i]), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return false;
                }
            }

            return true;
        }

        public static bool Initialize(string[] Arguments)
        {
            // Parsing start parameters
            for (int i = 0; i < Arguments.Length; i++)
            {
                if (Arguments[i] == "-minimized")
                {
                    GuiOptions.Instanse.MinimizedStart = true;
                }
                else if (Arguments[i] == "-nofxcheck")
                {
                    GuiOptions.Instanse.NoFxCheck = true;
                }
                else if (Arguments[i] == "-quiet")
                {
                    GuiOptions.Instanse.QuietStart = true;
                }
            }

            // Check for DLLs is exists
            if (!CheckSystemFiles())
            {
                return false;
            }

            // Starting
            if (Classes.Environment.Debbugers)
            {
                if (!GuiOptions.Instanse.QuietStart)
                {
                    WinHelper.MessageBox("Turn off all debuggers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;
            }

            if (Classes.Environment.Studio)
            {
                if (!GuiOptions.Instanse.QuietStart)
                {
                    WinHelper.MessageBox("Doorway Studio is already running!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;
            }

            if (!Classes.Environment.HDD)
            {
                if (!GuiOptions.Instanse.QuietStart)
                {
                    WinHelper.MessageBox("Doorway Studio can be started only from regular internal HDD!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;
            }

            return true;
        }

        public static void Close()
        {
            RunTime.Instance.MainWindow.Exit = true;

            if (!RunTime.Instance.MainWindow.Visible)
            {
                RunTime.Instance.MainWindow.ShowWindow();
            }

            RunTime.Instance.MainWindow.Close();
        }

        public static void ShowEULA()
        {
            new EULA().Show();
        }

        public static void ShowAboutBox()
        {
            new AboutBox().Show();
        }

        public static void Show()
        {
            if (!(RunTime.Instance.MainWindow is IExitableWindow))
            {
                return;
            }

            (RunTime.Instance.MainWindow).ShowWindow();
        }
    }
}
