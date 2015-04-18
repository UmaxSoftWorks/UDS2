using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Monitor.Classes;
using Monitor.Enums;
using Umax.Classes;
using Umax.Classes.Enums;
using Umax.Resources;

namespace Monitor.Windows
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //protected event ChangeStatus OnChangeStatus;
        //protected delegate void ChangeStatus(ColorType Color);

        protected int RestartCount { get; set; }
        protected Process MainProcess { get; set; }
        protected ProcessStartInfo MainProcessStartInfo { get; set; }

        protected Options MainOptions { get; set; }
        protected Updater MainUpdater { get; set; }
        protected Logger MainLogger { get; set; }


        private void mainTimer_Tick(object sender, EventArgs e)
        {
            UpdateUI();
        }

        protected void UpdateUI()
        {
            RestartCountLabel.Text = this.RestartCount.ToString();
            if (this.MainProcess == null)
            {
                this.Invoke((MethodInvoker) delegate { RunTimeTimeLabel.Text = "00:00:00"; });
            }
            else
            {
                this.Invoke(
                    (MethodInvoker)
                    delegate { RunTimeTimeLabel.Text = (DateTime.Now - MainProcess.StartTime).ToString(); });
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = Umax.Brand.Brand.Name + " " + this.Text;
            mainNotifyIcon.Text = this.Text;
            // Logger
            this.MainLogger = new Logger();

            // Prepare data
            mainFileSystemWatcher.Path = Application.StartupPath;

            this.MainProcessStartInfo = new ProcessStartInfo(
                Path.Combine(Application.StartupPath, "Doorway Studio.exe"), "-quiet");

            //OnChangeStatus += new ChangeStatus(Main_OnChangeStatus);

            // Read configuration
            this.MainOptions = Options.Instance;

            // Check update
            this.MainUpdater = new Updater();

            // Check status
            this.CheckStatus(null, null);
            mainTimer.Start();
        }

        private void ChangeColor(ColorType Color)
        {
            switch (Color)
            {
                case ColorType.Green:
                    {
                        this.SetGreen();
                        break;
                    }
                case ColorType.Yellow:
                    {
                        this.SetYellow();
                        break;
                    }
                case ColorType.Grey:
                    {
                        this.SetGrey();
                        break;
                    }
                case ColorType.Update:
                    {
                        this.SetUpdate();
                        break;
                    }
                default:
                    {
                        this.SetRed();
                        break;
                    }
            }
            this.Invoke((MethodInvoker) delegate { Update(); });
        }

        private void CheckStatus(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("Doorway Studio");

            // Maintenance

            // General flow
            if (processes.Length == 0)
            {
                // Update
                if (this.MainUpdater.Check())
                {
                    this.ChangeColor(ColorType.Update);
                    //OnChangeStatus.Invoke(ColorType.Update);

                    this.MainUpdater.Update();
                }

                // Starting
                if (File.Exists(MainProcessStartInfo.FileName))
                {
                    // Restarting
                    this.ChangeColor(ColorType.Yellow);
                    //OnChangeStatus.Invoke(ColorType.Yellow);

                    this.MainProcess = Process.Start(MainProcessStartInfo);
                    this.MainProcess.EnableRaisingEvents = true;
                    this.MainProcess.Exited += new EventHandler(CheckStatus);
                    this.RestartCount++;

                    DateTime startTime = DateTime.Now;
                    while (DateTime.Now < startTime.AddSeconds(5))
                    {
                        Application.DoEvents();
                    }

                    // All ok
                    this.ChangeColor(ColorType.Green);
                    //OnChangeStatus.Invoke(ColorType.Green);
                    if (!Options.Instance.Allowed && RunTime.Update)
                    {
                        RunTime.Exit = true;
                        Close();
                    }
                }
                else
                {
                    // All bad
                    this.ChangeColor(ColorType.Red);
                    //OnChangeStatus.Invoke(ColorType.Red);
                }
            }
            else
            {
                if (this.MainProcess == null)
                {
                    MainProcess = processes[0];
                    MainProcess.EnableRaisingEvents = true;
                    MainProcess.Exited += new EventHandler(CheckStatus);
                    UpdateUI();
                    ChangeColor(ColorType.Green);
                    //OnChangeStatus.Invoke(ColorType.Green);
                }
            }
            //Update UI
            this.Invoke((MethodInvoker) delegate { UpdateUI(); });
        }

        private void ShowNotification(string Title, string Message, ToolTipIcon Icon)
        {
            if (this.MainOptions.Notifications)
            {
                mainNotifyIcon.ShowBalloonTip(this.MainOptions.NotificationsTime * 1000, Title, Message, Icon);
            }
        }

        private void SetGreen()
        {
            this.Invoke((MethodInvoker) delegate
                                            {
                                                this.Icon = Resources.IconGreen;
                                                statusTextLabel.Text = "Working...";
                                                mainNotifyIcon.Icon = Resources.IconGreen;
                                                statusPictureBox.Image = Resources.ImageGreen;
                                                ShowNotification(Umax.Brand.Brand.Name + " Doorway Studio 2012",
                                                                 Umax.Brand.Brand.Name +
                                                                 " Doorway Studio 2012 working...", ToolTipIcon.Info);
                                            });
        }

        private void SetRed()
        {
            MainLogger.Append("File not found!", LogMessageType.Info);
            this.Invoke((MethodInvoker) delegate
                                            {
                                                this.Icon = Resources.IconRed;
                                                mainNotifyIcon.Icon = Resources.IconRed;
                                                statusPictureBox.Image = Resources.ImageRed;
                                                statusTextLabel.Text = "File not found!";
                                                ShowNotification(Umax.Brand.Brand.Name + " Doorway Studio 2012",
                                                                 "Failed to start " + Umax.Brand.Brand.Name +
                                                                 " Doorway Studio 2012!", ToolTipIcon.Error);
                                            });
        }

        private void SetYellow()
        {
            MainLogger.Append("Restarting...", LogMessageType.Info);
            this.Invoke((MethodInvoker) delegate
                                            {
                                                this.Icon = Resources.IconYellow; // runs on UI thread
                                                statusTextLabel.Text = "Restarting...";
                                                mainNotifyIcon.Icon = Resources.IconYellow;
                                                statusPictureBox.Image = Resources.ImageYellow;
                                                ShowNotification(Umax.Brand.Brand.Name + " Doorway Studio 2012",
                                                                 "Restarting " + Umax.Brand.Brand.Name +
                                                                 " Doorway Studio 2012...", ToolTipIcon.Info);
                                            });
        }

        private void SetGrey()
        {
            MainLogger.Append("Maintenance...", LogMessageType.Info);
            this.Invoke((MethodInvoker) delegate
                                            {
                                                this.Icon = Resources.IconGrey;
                                                mainNotifyIcon.Icon = Resources.IconGrey;
                                                statusPictureBox.Image = Resources.ImageGrey;
                                                statusTextLabel.Text = "Maintenance...";
                                                this.ShowNotification(Umax.Brand.Brand.Name + " Doorway Studio 2012",
                                                                 "Maintenance " + Umax.Brand.Brand.Name +
                                                                 " Doorway Studio 2012...", ToolTipIcon.Info);
                                            });
        }

        private void SetUpdate()
        {
            MainLogger.Append("Updating...", LogMessageType.Info);
            this.Invoke((MethodInvoker) delegate
                                            {
                                                this.Icon = Resources.IconUpdate;
                                                mainNotifyIcon.Icon = Resources.IconUpdate;
                                                statusPictureBox.Image = Resources.ImageUpdate;
                                                statusTextLabel.Text = "Updating...";
                                                this.ShowNotification(Umax.Brand.Brand.Name + " Doorway Studio 2012",
                                                                 "Updating " + Umax.Brand.Brand.Name +
                                                                 " Doorway Studio 2012...", ToolTipIcon.Info);
                                            });
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RunTime.Exit)
            {
                mainTimer.Stop();

                mainNotifyIcon.Visible = false;
                mainNotifyIcon.Dispose();

                // Saving logs
                this.MainUpdater.SaveLog();
                this.MainLogger.Save();
            }
            else
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            RunTime.Exit = true;
            Close();
        }

        private void ShowWindow()
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            //this.TopMost = true;
            this.Show();
            //this.Focus();
            this.Update();
            //this.TopMost = false;
        }

        private void mainFileSystemWatcher_AllActions(object sender, FileSystemEventArgs e)
        {
            this.MainOptions.Update();
        }


        private void mainFileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            this.MainOptions.Update();
        }

        private bool FirstTime { get; set; }

        private void Main_Shown(object sender, EventArgs e)
        {
            if (this.FirstTime) return;

            // UI
            this.Visible = false;
            this.FirstTime = true;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                RunTime.Exit = true;
                Close();
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Visible = false;
            }
        }

        private void updateLogButton_Click(object sender, EventArgs e)
        {
            using (Log logWindow = new Log())
            {
                logWindow.Content = this.MainUpdater.Log;
                logWindow.ShowDialog();
            }
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            using (Log logWindow = new Log())
            {
                logWindow.Content = this.MainLogger.Log;
                logWindow.ShowDialog();
            }
        }
    }
}