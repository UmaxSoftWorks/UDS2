using System;
using System.ComponentModel;
using System.Resources;
using System.Windows.Forms;
using Core.Enums;
using Umax.Brand;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Resources;
using Umax.Windows;
using Umax.Windows.Classes;
using Umax.Windows.Helpers;
using Umax.Windows.Interfaces;
using Umax.Windows.Windows.Help;

namespace DoorwayStudio.Windows
{
    internal partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        protected void InitializeOptions()
        {
            GuiOptions options = GuiOptions.Instanse;
        }

        protected void InitializeCore()
        {
            Core.Core core = Core.Core.Instanse;
        }

        protected void InitializeImages()
        {
            this.Icon = Resources.IconRed;
        }

        protected void InitializeUI()
        {
            this.Text = Brand.Name + " " + this.Text;
        }

        protected void StartUpLoad(object sender, EventArgs e)
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
            if (!Helper.FXCheck())
            {
                if (WinHelper.MessageBox("Microsoft .Net Framework 3.5 isn't installed. Please install it!\r\nDo you like to ignore and continue?", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                {
                    Application.Exit();
                }
            }

            // Update check
            if (Helper.UpdateFilesAvailable())
            {
                Helper.StartMonitor("-update -quiet");
                Close();
            }

            // Initializing Core
            this.InitializeCore();

            // Monitor
            if (GuiOptions.Instanse.Monitor)
            {
                Helper.StartMonitor("-quiet");
            }

            // Checking accepting EULA
            if (!Helper.EulaCheck())
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

        protected void ShowMainWindow()
        {
            // Loading data
            actionTextLabel.Text = "Loading data...";
            stateTextLabel.Text = "Loading...";
            Application.DoEvents();

            mainBackgroundWorker.RunWorkerAsync();
        }


        protected void StartDemoButtonClick(object sender, EventArgs e)
        {
            this.ShowMainWindow();
        }

        protected void ExitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void StartUpFormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainBackgroundWorker.IsBusy)
            {
                mainBackgroundWorker.CancelAsync();
            }
        }

        protected void mainBackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            // Loading data
            Core.Core.Instanse.Invoke();
        }

        protected void mainBackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Hide StartUp Window
            this.Hide();
            this.Update();

            Application.DoEvents();

            // Show main window
            RunTime.Instance.MainWindow = (GuiOptions.Instanse.Manager ? (IExitableWindow)new Manager() : (IExitableWindow)new Main());

            RunTime.Instance.MainWindow.Dismissed += this.mainWindowFormClosed;
            RunTime.Instance.MainWindow.Execute();
        }


        protected void mainWindowFormClosed()
        {
            Close();
        }
    }
}
