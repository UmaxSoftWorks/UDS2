using System.ComponentModel;
using System.Reflection;
using System.Resources;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using Core.Enums;
using Umax.Brand;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Windows;
using Umax.Windows.Classes;
using Umax.Windows.Interfaces;
using Umax.Windows.Windows.Help;
using Umax.WPF.Helpers;
using WindowsHelper = Umax.Windows.Helpers.Helper;

namespace DoorwayStudio.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StartUp : Window
    {
        private BackgroundWorker mainBackgroundWorker;

        public StartUp()
        {
            InitializeComponent();

            this.mainBackgroundWorker = new BackgroundWorker();

            this.mainBackgroundWorker.WorkerSupportsCancellation = true;
            this.mainBackgroundWorker.DoWork += this.mainBackgroundWorkerDoWork;
            this.mainBackgroundWorker.RunWorkerCompleted += this.mainBackgroundWorkerRunWorkerCompleted;
        }

        protected void InitializeImages()
        {
            this.Icon = Umax.Resources.Resources.IconRed.ToImageSource();
        }

        private void StartUpLoaded(object sender, RoutedEventArgs e)
        {
            this.InitializeImages();
            this.InitializeOptions();

            // UI Language
            switch (Core.Core.Instanse.Options.Language)
            {
                case LanguageType.English:
                    {
                        RunTime.Instance.Localization = new ResourceManager("Umax.Resources.Localization.UI.Classic.English", typeof(Umax.Resources.Localization.UI.Classic.English).Assembly);
                        break;
                    }

                case LanguageType.Russian:
                    {
                        RunTime.Instance.Localization = new ResourceManager("Umax.Resources.Localization.UI.Classic.Russian", typeof(Umax.Resources.Localization.UI.Classic.Russian).Assembly);
                        break;
                    }
            }

            this.InitializeUI();

            // Checking .Net FX
            if (!WindowsHelper.FXCheck())
            {
                if (WinHelper.MessageBox("Microsoft .Net Framework 3.5 isn't installed. Please install it!\r\nDo you like to ignore and continue?", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.No)
                {
                    WPFApplication.Current.Shutdown();
                }
            }

            // Update check
            if (WindowsHelper.UpdateFilesAvailable())
            {
                WindowsHelper.StartMonitor("-update -quiet");
                Close();
            }

            // Initializing Core
            this.InitializeCore();

            // Monitor
            if (GuiOptions.Instanse.Monitor)
            {
                WindowsHelper.StartMonitor("-quiet");
            }

            // Checking accepting EULA
            if (!WindowsHelper.EulaCheck())
            {
                using (EULA eulaWindow = new EULA())
                {
                    eulaWindow.ShowDialog();

                    if (!eulaWindow.Accepted)
                    {
                        this.Close();
                    }
                }
            }

            this.ShowMainWindow();
        }

        private void closeLabelMouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void startDemoLabelMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.ShowMainWindow();
        }

        protected void InitializeOptions()
        {
            GuiOptions options = GuiOptions.Instanse;
        }

        protected void InitializeCore()
        {
            Core.Core core = Core.Core.Instanse;
        }

        protected void InitializeUI()
        {
            this.Title = Brand.Name + " " + this.Title;
            companyLabel.Content = new AssemblyInfoHelper(Assembly.GetExecutingAssembly()).Company;
            nameLabel.Text = Brand.Name + " Doorway Studio";
        }

        protected void ShowMainWindow()
        {
            // Loading data
            this.stateLabel.Content = "Loading data...";
            WPFApplication.DoEvents();

            mainBackgroundWorker.RunWorkerAsync();
        }

        protected void mainBackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            Core.Core.Instanse.Invoke();
        }

        protected void mainBackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Hide StartUp Window
            this.Hide();
            this.UpdateLayout();

            WPFApplication.DoEvents();

            // Show main window
            RunTime.Instance.MainWindow = (GuiOptions.Instanse.Manager ? (IExitableWindow)new Manager() : (IExitableWindow)new Main());

            RunTime.Instance.MainWindow.Dismissed += this.mainWindowFormClosed;
            RunTime.Instance.MainWindow.Execute();
        }


        protected void mainWindowFormClosed()
        {
            Close();
        }

        private void StartUpClosing(object sender, CancelEventArgs e)
        {
            if (this.mainBackgroundWorker.IsBusy)
            {
                this.mainBackgroundWorker.CancelAsync();
            }
        }
    }
}
