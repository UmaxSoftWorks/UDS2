using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Umax.Classes.Helpers;

namespace Umax.Windows.Classes
{
    public static class Environment
    {
        /// <summary>
        /// Checking if sniffers running
        /// </summary>
        /// <returns>true - sniffers running; false - all ok</returns>
        public static bool Debbugers
        {
            get
            {
                // Wireshark
                Process[] processes = Process.GetProcessesByName("wireshark");
                if (processes.Length > 0)
                {
                    return true;
                }

                // Wireshark
                processes = Process.GetProcessesByName("netmon");
                if (processes.Length > 0)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Checking if doorway studio running
        /// </summary>
        /// <returns>true - doorway studio running; false - all ok</returns>
        public static bool Studio
        {
            get
            {
                // Processes
                Process[] processes = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
                if (processes.Length > 1)
                {
                    return true;
                }

                // Titles
                string title = Brand.Brand.Name + " Doorway Studio 2012";
                if (WinHelper.FindWindow(null, title) != 0)
                {
                    return true;
                }

                if (WinHelper.FindWindow(null, title + " [Demo]") != 0)
                {
                    return true;
                }

                if (WinHelper.FindWindow(null, title + " [Evaluation]") != 0)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// True if Studio runs on regular hdd; false - if no
        /// </summary>
        public static bool HDD
        {
            get
            {
                string drive = string.Empty;
                foreach (DriveInfo compDrive in DriveInfo.GetDrives())
                {
                    if (compDrive.IsReady && Application.StartupPath.StartsWith(compDrive.Name))
                    {
                        if (compDrive.DriveType == DriveType.Fixed)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
        }
    }
}
