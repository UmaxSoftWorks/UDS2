using System;
using System.Diagnostics;
using System.Windows.Forms;
using Monitor.Classes;
using Monitor.Windows;
using Umax.Brand;
using Umax.Classes.Helpers;

namespace Monitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] Arguments)
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                //Parameters
                for (int i = 0; i < Arguments.Length; i++)
                {
                    switch (Arguments[i])
                    {
                        case "-update":
                            RunTime.Update = true;
                            break;
                        case "-quiet":
                            RunTime.QuietStart = true;
                            break;
                    }
                }

                //Options
                Options options = Options.Instance;
                if (!options.Allowed && !RunTime.Update)
                {
                    return;
                }

                //Check if already started
                Process[] processes = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);

                //Запуск
                if (processes.Length > 1)
                {
                    if (!RunTime.QuietStart)
                    {
                        WinHelper.MessageBox("Program is already running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return;
                }

                if (WinHelper.FindWindow(null, Brand.Name + " Doorway Studio 2012 Monitor") != 0)
                {
                    if (!RunTime.QuietStart)
                    {
                        WinHelper.MessageBox("Program is already running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return;
                }

                processes = null;
                Application.Run(new Main());
            }
            catch (Exception) { }
        }
    }

    struct RunTime
    {
        public static bool Exit;
        public static bool Update;
        public static bool QuietStart;
    }
}
