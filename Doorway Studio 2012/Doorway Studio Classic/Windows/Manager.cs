using System;
using System.Windows.Forms;
using Core.Enums;
using Umax.Brand;
using Umax.Classes.Helpers;
using Umax.Interfaces.Events;
using Umax.Resources;
using Umax.Windows;
using Umax.Windows.Classes;
using Umax.Windows.Enums;
using Umax.Windows.Helpers;
using Umax.Windows.Interfaces;
using Umax.Windows.Windows.Common;
using Umax.Windows.Windows.Data;
using WindowsOptions = Umax.Windows.Windows.Common.Options;

namespace DoorwayStudio.Windows
{
    public partial class Manager : Form, IExitableWindow
    {
        public Manager()
        {
            InitializeComponent();
        }

        public bool Exit { get; set; }

        protected void ManagerLoad(object sender, EventArgs e)
        {
            this.Text = Brand.Name + " " + this.Text;
            this.mainTrayIcon.Text = this.Text;

            this.InitializeImages();

            this.InitializeEvents();

            if (GuiOptions.Instanse.MinimizedStart)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            this.Initialize();

            // Update window
            if (!GuiOptions.Instanse.UpdateCheckWhileRunning) return;

            updateTimer.Interval = GuiOptions.Instanse.UpdateCheckWhileRunningPeriod * 60 * 60 * 1000;
            updateTimer.Start();
        }

        protected void InitializeImages()
        {
            this.Icon = Resources.IconRed;
            this.mainTrayIcon.Icon = Resources.IconRed;
        }

        protected void InitializeEvents()
        {
            GuiOptions.Instanse.ManagerPinChanged += this.ManagerPinChanged;
            GuiOptions.Instanse.ManagerLocationChanged += this.ManagerLocationChanged;

            this.mainTrayIcon.DoubleClick += this.IconDoubleClick;
        }

        protected void ManagerPinChanged()
        {
            this.TopMost = GuiOptions.Instanse.ManagerPin;
        }

        protected void ManagerLocationChanged()
        {
            switch (GuiOptions.Instanse.ManagerLocation)
            {
                case ManagerLocationType.Custom:
                    {
                        this.Width = 300;
                        this.Height = 500;

                        this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                        this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                        break;
                    }

                case ManagerLocationType.Left:
                    {
                        this.Top = Screen.PrimaryScreen.WorkingArea.Top;
                        this.Left = Screen.PrimaryScreen.WorkingArea.Left;
                        this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                        break;
                    }

                case ManagerLocationType.Right:
                    {
                        this.Top = Screen.PrimaryScreen.WorkingArea.Top;
                        this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                        this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                        break;
                    }
            }
        }

        protected void Initialize()
        {
            // Updates
            if (GuiOptions.Instanse.UpdateCheckAtStartup)
            {
                Helper.Update();
            }

            // Invoking manager
            Core.Core.Instanse.Manager.Invoke();
        }

        protected void CloseWindow(object sender, EventArgs e)
        {
            this.Exit = true;

            if (!this.Visible)
            {
                this.ShowWindow();
            }

            Close();
        }

        protected void ManagerClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Exit)
            {
                if (WinHelper.MessageBox("Do you really want close program?", "Exit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
                    Application.DoEvents();
                }

                updateTimer.Stop();

                // Events
                GuiOptions.Instanse.ManagerPinChanged -= this.ManagerPinChanged;
                GuiOptions.Instanse.ManagerLocationChanged -= this.ManagerLocationChanged;

                mainTrayIcon.DoubleClick -= this.IconDoubleClick;

                mainMenuStrip.DeInitializeEvents();
                mainTrayIcon.DeInitializeEvents();

                tasksGridManagerControl.DeInitializeEvents();
                activeTasksGridManagerControl.DeInitializeEvents();

                logContol.DeInitializeEvents();

                // Notify Icon
                mainTrayIcon.Visible = false;
                mainTrayIcon.Dispose();

                // Exit
                Helper.Exit();
            }
            else
            {
                e.Cancel = true;
                Visible = false;
            }
        }

        protected void IconDoubleClick()
        {
            this.ShowWindow();
        }

        public void ShowWindow()
        {
            if (!this.Visible)
            {
                this.Visible = true;

                this.tasksGridManagerControl.UpdateControl();
                this.activeTasksGridManagerControl.UpdateControl();

                this.Activate();
            }
            else
            {
                this.Visible = false;
            }
        }

        protected void CreateWorkSpace(object sender, EventArgs e)
        {
            DataHelper.CreateWorkSpace();
        }

        protected void ManagerKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.W)
            {
                DataHelper.CreateWorkSpace();
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                DataHelper.CreateTask();
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                this.EditTasks(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.L)
            {
                this.ShowHistory(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                new WindowsOptions().Show();
            }
            else if ((e.Control && e.KeyCode == Keys.X) || (e.KeyCode == Keys.F10))
            {
                this.Exit = true;
                Close();
            }
        }

        protected void toolStripUpdateLabelClick(object sender, EventArgs e)
        {
            Helper.Update();
        }

        protected void toolStripWebUIServiceLabelClick(object sender, EventArgs e)
        {

        }

        protected void toolStripFilesChangedLabelClick(object sender, EventArgs e)
        {
            new FileMonitor().Show();
        }

        protected void mainFileSystemWatcherChanged(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        protected void updateTimerTick(object sender, EventArgs e)
        {

        }

        protected void EditTasks(object sender, EventArgs e)
        {
            new ItemEdit()
            {
                Action = DataElementType.Tasks
            }.Show();
        }

        protected void ShowHistory(object sender, EventArgs e)
        {
            DataHelper.ShowLog();
        }

        private void ManagerMove(object sender, EventArgs e)
        {
            if (GuiOptions.Instanse.ManagerLocation != ManagerLocationType.Custom)
            {
                this.ManagerLocationChanged();
            }
        }

        private void ManagerSizeChanged(object sender, EventArgs e)
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

        private void ManagerResizeBegin(object sender, EventArgs e)
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

        private void ManagerResizeEnd(object sender, EventArgs e)
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

        private void ManagerResize(object sender, EventArgs e)
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

        private void ManagerLocationChanged(object sender, EventArgs e)
        {
            if (GuiOptions.Instanse.ManagerLocation != ManagerLocationType.Custom)
            {
                this.ManagerLocationChanged();
            }
        }

        private void ManagerClientSizeChanged(object sender, EventArgs e)
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

        public event SimpleEventHandler Dismissed;

        private void ManagerFormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Dismissed != null)
            {
                this.Dismissed();
            }
        }

        public void Execute()
        {
            this.ShowDialog();
        }

        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MINIMIZE = 0xF020;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                    // Do not allow minimize window
                case WM_SYSCOMMAND:
                    {
                        int command = m.WParam.ToInt32() & 0xfff0;
                        if (command == SC_MINIMIZE)
                        {
                            this.Visible = false;
                        }

                        return;
                    }
            }

            base.WndProc(ref m);
        }
    }
}
