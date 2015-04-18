using System;
using System.Threading;
using System.Windows.Forms;
using WebParser.Windows;

namespace WebParser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Helper.Initialize())
            {
                return;
            }

            // Events
            Application.ThreadException += ApplicationThreadException;
            AppDomain.CurrentDomain.UnhandledException += AppDomainUnhandledException;

            try
            {
                Application.Run(new StartUp());
            }
            catch (Exception) { }
        }

        private static void ApplicationThreadException(object sender, ThreadExceptionEventArgs args)
        {
            MessageBox.Show(args.Exception.ToString());
            Environment.Exit(0);
        }

        private static void AppDomainUnhandledException(object sender, UnhandledExceptionEventArgs args)
        {
            MessageBox.Show((args.ExceptionObject as Exception).ToString());
            Environment.Exit(0);
        }
    }
}
