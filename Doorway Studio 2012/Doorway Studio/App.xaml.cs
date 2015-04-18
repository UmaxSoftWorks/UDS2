using System;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using DoorwayStudio.Windows;
using Umax.Windows.Windows.Common;
using Helper = Umax.Windows.Helpers.Helper;

namespace DoorwayStudio
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            if (!Helper.Initialize(e.Args))
            {
                Environment.Exit(0);
                return;
            }

            // Events
            Application.Current.DispatcherUnhandledException += AppDispatcherUnhandledException;
            AppDomain.CurrentDomain.UnhandledException += AppDomainUnhandledException;

            System.Windows.Forms.Application.ThreadException += ApplicationThreadException;

            try
            {
                Application.Current.Run(new StartUp());
            }
            catch (Exception) { }
        }

        private static void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            new ErrorReporter(e.Exception).ShowDialog();
            Environment.Exit(0);
        }

        private static void AppDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            new ErrorReporter(e.Exception).ShowDialog();
            Environment.Exit(0);
        }

        private static void AppDomainUnhandledException(object sender, UnhandledExceptionEventArgs args)
        {
            new ErrorReporter(args.ExceptionObject as Exception).ShowDialog();
            Environment.Exit(0);
        }
    }
}
