using System;
using System.Threading;
using System.Windows.Forms;
using DoorwayStudio.Windows;
using Umax.Windows.Helpers;
using Umax.Windows.Windows.Common;

namespace DoorwayStudio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] Arguments)
        {
            // Starting
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Helper.Initialize(Arguments))
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
            new ErrorReporter(args.Exception).ShowDialog();
            Environment.Exit(0);
        }

        private static void AppDomainUnhandledException(object sender, UnhandledExceptionEventArgs args)
        {
            new ErrorReporter(args.ExceptionObject as Exception).ShowDialog();
            Environment.Exit(0);
        }
    }
}