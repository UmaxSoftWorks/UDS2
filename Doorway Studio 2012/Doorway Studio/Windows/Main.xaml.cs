using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Core.Enums;
using Umax.Brand;
using Umax.Classes.Helpers;
using Umax.Interfaces.Events;
using Umax.Windows;
using Umax.Windows.Classes;
using Umax.Windows.Controls;
using Umax.Windows.Interfaces;
using Umax.WPF.Helpers;
using WindowsHelper = Umax.Windows.Helpers.Helper;


namespace DoorwayStudio.Windows
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window, IExitableWindow
    {
        private TrayIcon trayIcon;
        private Timer updateTimer;

        public Main()
        {
            InitializeComponent();

            this.InitializeControls();
        }

        public void InitializeControls()
        {
            this.trayIcon = new TrayIcon();

            this.trayIcon.Visible = true;
            this.trayIcon.Text = string.Empty;

            this.updateTimer = new Timer();
            this.updateTimer.Interval = 43200000;
        }

        public bool Exit { get; set; }

        public bool IsDisposed
        {
            get { return this.IsDisposed(); }
        }

        public bool Visible
        {
            get { return this.Visibility == Visibility.Visible; }
            set
            {
                if (value)
                {
                    this.Show();
                }
                else
                {
                    this.Hide();
                }
            }
        }

        public void ShowWindow()
        {
            if (!this.Visible)
            {
                this.Visible = true;
            }
            else
            {
                this.Visible = false;
            }
        }

        public void Execute()
        {
            this.ShowDialog();
        }

        public event SimpleEventHandler Dismissed;

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            this.Title = Brand.Name + " " + this.Title;

            this.InitializeImages();

            this.InitializeEvents();

            if (GuiOptions.Instanse.MinimizedStart)
            {
                this.WindowState = WindowState.Minimized;
            }

            this.Initialize();

            // Update window
            if (!GuiOptions.Instanse.UpdateCheckWhileRunning) return;

            this.updateTimer.Interval = GuiOptions.Instanse.UpdateCheckWhileRunningPeriod * 60 * 60 * 1000;
            this.updateTimer.Start();
        }

        private void WindowClosing(object sender, CancelEventArgs e)
        {
            if (this.Exit)
            {
                if (WinHelper.MessageBox("Do you really want close program?", "Exit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }

                if (!this.Visible)
                {
                    this.Visible = true;
                }

                // Log
                if (RunTime.Instance.LogWindow != null)
                {
                    RunTime.Instance.LogWindow.Close();
                    WPFApplication.DoEvents();
                }

                this.updateTimer.Stop();

                // Events
                this.trayIcon.DeInitializeEvents();
                this.mainMenu.DeInitializeEvents();

                this.trayIcon.Visible = false;
                this.trayIcon.Dispose();

                // Exit
                WindowsHelper.Exit();
            }
            else
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            if (this.Dismissed != null)
            {
                this.Dismissed();
            }
        }

        private void trayIconDoubleClick()
        {
            this.ShowWindow();
        }


        protected void Initialize()
        {
            // Updates
            if (GuiOptions.Instanse.UpdateCheckAtStartup)
            {
                WindowsHelper.Update();
            }

            // Invoking manager
            Core.Core.Instanse.Manager.Invoke();
        }

        protected void InitializeImages()
        {
            this.Icon = Umax.Resources.Resources.IconRed.ToImageSource();
            this.trayIcon.Icon = Umax.Resources.Resources.IconRed;
        }

        protected void InitializeEvents()
        {
            this.trayIcon.DoubleClick += this.trayIconDoubleClick;
            this.updateTimer.Tick += this.updateTimerTick;
        }

        void updateTimerTick(object sender, EventArgs e)
        {

        }
    }
}
