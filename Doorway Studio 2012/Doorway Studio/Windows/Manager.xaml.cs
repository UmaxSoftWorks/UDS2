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
using System.Windows.Interop;
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
using Umax.Windows.Enums;
using Umax.Windows.Interfaces;
using WindowsHelper = Umax.Windows.Helpers.Helper;
using Umax.WPF.Helpers;

namespace DoorwayStudio.Windows
{
    /// <summary>
    /// Interaction logic for Manager.xaml
    /// </summary>
    public partial class Manager : Window, IExitableWindow
    {
        private TrayIcon trayIcon;
        private Timer updateTimer;

        public Manager()
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

            // Subscribe wo Windows messages
            HwndSource.FromHwnd(new WindowInteropHelper(this).Handle).AddHook(new HwndSourceHook(WndProc));

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
                GuiOptions.Instanse.ManagerPinChanged -= this.ManagerPinChanged;
                GuiOptions.Instanse.ManagerLocationChanged -= this.ManagerLocationChanged;

                this.trayIcon.DoubleClick -= this.IconDoubleClick;

                this.mainMenu.DeInitializeEvents();
                this.trayIcon.DeInitializeEvents();


                // Notify Icon
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

        private void IconDoubleClick()
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
            GuiOptions.Instanse.ManagerPinChanged += this.ManagerPinChanged;
            GuiOptions.Instanse.ManagerLocationChanged += this.ManagerLocationChanged;

            this.trayIcon.DoubleClick += this.IconDoubleClick;
            this.updateTimer.Tick += this.updateTimerTick;
        }

        void updateTimerTick(object sender, EventArgs e)
        {

        }

        protected void ManagerPinChanged()
        {
            this.Topmost = GuiOptions.Instanse.ManagerPin;
        }

        protected void ManagerLocationChanged()
        {
            switch (GuiOptions.Instanse.ManagerLocation)
            {
                case ManagerLocationType.Custom:
                    {
                        this.Width = 300;
                        this.Height = 500;

                        this.Left = (SystemParameters.WorkArea.Width - this.Width) / 2;
                        this.Top = (SystemParameters.WorkArea.Height - this.Height) / 2;
                        break;
                    }

                case ManagerLocationType.Left:
                    {
                        this.Top = SystemParameters.WorkArea.Top;
                        this.Left = SystemParameters.WorkArea.Left;
                        this.Height = SystemParameters.WorkArea.Height;
                        break;
                    }

                case ManagerLocationType.Right:
                    {
                        this.Top = SystemParameters.WorkArea.Top;
                        this.Left = SystemParameters.WorkArea.Width - this.Width;
                        this.Height = SystemParameters.WorkArea.Height;
                        break;
                    }
            }
        }

        private void WindowLocationChanged(object sender, EventArgs e)
        {
            if (GuiOptions.Instanse.ManagerLocation != ManagerLocationType.Custom)
            {
                this.ManagerLocationChanged();
            }
        }

        private void WindowStateChanged(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case WindowState.Maximized:
                    if (this.Width > 300)
                    {
                        this.Width = 300;
                    }

                    if (GuiOptions.Instanse.ManagerLocation != ManagerLocationType.Custom)
                    {
                        this.ManagerLocationChanged();
                    }

                    break;
            }
        }

        private void WindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.Width > 300)
            {
                this.Width = 300;
            }

            if (GuiOptions.Instanse.ManagerLocation != ManagerLocationType.Custom)
            {
                this.ManagerLocationChanged();
            }
        }

        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MINIMIZE = 0xF020;

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch (msg)
            {
                // Do not allow minimize window
                case WM_SYSCOMMAND:
                    {
                        int command = wParam.ToInt32() & 0xfff0;
                        if (command == SC_MINIMIZE)
                        {
                            this.Visible = false;
                        }

                        handled = true;
                        break;
                    }
            }

            return IntPtr.Zero;
        }
    }
}
