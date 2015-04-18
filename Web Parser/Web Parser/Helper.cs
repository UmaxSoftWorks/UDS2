using System;
using System.Windows.Forms;
using Microsoft.Win32;
using Umax.Brand;
using Umax.Classes.Helpers;
using WebParser.Classes;
using IO = System.IO;

namespace WebParser
{
    public static class Helper
    {
        public static string CheckUpdate()
        {
            string result = string.Empty;
            try
            {
                string updatePage = String.Empty;
                switch (Brand.Name)
                {
                    case "Umax":
                        {
                            updatePage = HTTPHelper.DownloadWebPage("http://umaxsoft.com/PrivateArea/Updater/UWP");
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
                switch (Brand.Name)
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
            /*string url = CheckUpdate();
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
            }*/
        }

        /// <summary>
        /// Checks if all system files exists
        /// </summary>
        /// <returns>True - if all files exists</returns>
        public static bool CheckSystemFiles()
        {
            string[] files = new string[] {"Core.dll", "Classes.dll", "Interfaces.dll", "Resources.dll", "Parser.dll"};
            for (int i = 0; i < files.Length; i++)
            {
                if (!IOHelper.CheckFileExists(files[i]))
                {
                    WinHelper.MessageBox(string.Format("Library {0} not found!", files[i]), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        public static bool Initialize()
        {
            // Check for DLLs is exists
            if (!CheckSystemFiles())
            {
                return false;
            }

            // Starting
            if (Classes.Environment.Debbugers)
            {
                MessageBox.Show("Turn off all debuggers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Classes.Environment.Parser)
            {
                MessageBox.Show("Web Parser is already running!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Classes.Environment.HDD)
            {
                MessageBox.Show("Web Parser can be started only from regular internal HDD!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
