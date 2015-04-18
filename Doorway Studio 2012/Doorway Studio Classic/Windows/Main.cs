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
    public partial class Main : Form, IExitableWindow
    {
        public Main()
        {
            InitializeComponent();
        }

        public bool Exit { get; set; }

        protected void MainLoad(object sender, EventArgs e)
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

            // ImageLists
            mainImageList.Images.Add(Resources.WorkSpace);
            mainImageList.Images.Add(Resources.History);
            mainImageList.Images.Add(Resources.Statistic);
            mainImageList.Images.Add(Resources.Start);
            mainImageList.Images.Add(Resources.ImageGreen);
            mainImageList.Images.Add(Resources.Settings);
            mainImageList.Images.Add(Resources.Calendar);

            // Tabs
            wsTabControl.ImageList = mainImageList;
            wsTabPage.ImageIndex = 0;
            treeTasksTabPage.ImageIndex = 6;

            bottomTabControl.ImageList = mainImageList;
            activeTasksTabPage.ImageIndex = 3;
            historyTabPage.ImageIndex = 1;

            tasksTabControl.ImageList = mainImageList;
            calendarTasksTabPage.ImageIndex = 6;
            allTasksTabPage.ImageIndex = 1;

            // Status
            statusUpdateToolStripLabel.Image = Resources.Update;
            statusFilesChangedToolStripLabel.Image = Resources.Update;
        }

        protected virtual void InitializeEvents()
        {
            workSpacesControl.WorkSpaceChanged += this.SelectedWorkSpaceChanged;

            GuiOptions.Instanse.NewsChanged += this.ShowNewsChanged;
            GuiOptions.Instanse.AppearanceGeneralChanged += this.ShowGeneralChanged;
            GuiOptions.Instanse.AppearanceLargeCalendarChanged += this.ShowLargeCalendarChanged;
        }

        protected void Initialize()
        {
            currentTasksControl.SelectedDate = DateTime.Now.Date;
            mainTabControl.SelectedWorkSpace = workSpacesControl.SelectedWorkSpace;

            // Updates
            if (GuiOptions.Instanse.UpdateCheckAtStartup)
            {
                Helper.Update();
            }

            // Updating appearance
            this.ShowNewsChanged();
            this.ShowGeneralChanged();
            this.ShowLargeCalendarChanged();

            // Invoking manager
            Core.Core.Instanse.Manager.Invoke();
        }

        protected void SelectedWorkSpaceChanged()
        {
            mainTabControl.SelectedWorkSpace = workSpacesControl.SelectedWorkSpace; 
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

        protected void MainClosing(object sender, FormClosingEventArgs e)
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
                GuiOptions.Instanse.NewsChanged -= this.ShowNewsChanged;
                GuiOptions.Instanse.AppearanceGeneralChanged -= this.ShowGeneralChanged;
                GuiOptions.Instanse.AppearanceLargeCalendarChanged -= this.ShowLargeCalendarChanged;

                mainTrayIcon.DeInitializeEvents();
                mainMenuStrip.DeInitializeEvents();

                workSpacesControl.WorkSpaceChanged -= this.SelectedWorkSpaceChanged;
                workSpacesControl.DeInitializeEvents();

                mainTabControl.DeInitializeEvents();

                tasksTreeControl.DeInitializeEvents();
                activeTasksControl.DeInitializeEvents();
                currentTasksControl.DeInitializeEvents();
                allTasksControl.DeInitializeEvents();

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

        public void ShowWindow()
        {
            if (!this.Visible)
            {
                this.Visible = true;

                workSpacesControl.UpdateControl();

                tasksTreeControl.UpdateControl();

                activeTasksControl.UpdateControl();

                currentTasksControl.UpdateControl();
                allTasksControl.UpdateControl();

                mainTabControl.UpdateControl();

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

        protected void ShowNewsChanged()
        {
            newsGroupBox.Visible = GuiOptions.Instanse.AppearanceNews;
        }

        protected void ShowGeneralChanged()
        {
            mainTabControl.Visible = GuiOptions.Instanse.AppearanceGeneral;
            if (GuiOptions.Instanse.AppearanceGeneral)
            {
                mainSplitContainer.Orientation = Orientation.Horizontal;
                mainSplitContainer.SplitterDistance = 366;
                mainSplitContainer.Panel1MinSize = 0;

                topSplitContainer.Orientation = Orientation.Vertical;
                topSplitContainer.Panel2Collapsed = false;
                topSplitContainer.SplitterDistance = 170;
            }
            else
            {
                topSplitContainer.Orientation = Orientation.Horizontal;
                topSplitContainer.Panel2Collapsed = true;

                mainSplitContainer.Orientation = Orientation.Vertical;
                mainSplitContainer.Panel1MinSize = topSplitContainer.Panel1MinSize;
                mainSplitContainer.SplitterDistance = topSplitContainer.SplitterDistance;
            }
        }

        protected void ShowLargeCalendarChanged()
        {
            if (GuiOptions.Instanse.AppearanceLargeCalendar)
            {
                tasksTabControl.Width = monthCalendar.Width + currentTasksControl.Width + 9;

                monthCalendar.Dock = DockStyle.Right;

                currentTasksControl.Dock = DockStyle.Left;
            }
            else
            {
                tasksTabControl.Width = currentTasksControl.Width + 9;

                monthCalendar.Dock = DockStyle.Top;

                currentTasksControl.Dock = DockStyle.Fill;
            }
        }

        protected void CalendarDateChanged(object sender, DateRangeEventArgs e)
        {
            currentTasksControl.SelectedDate = monthCalendar.SelectionStart.Date;
        }

        protected void MainKeyDown(object sender, KeyEventArgs e)
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

        protected void toolStripUpdateLabel_Click(object sender, EventArgs e)
        {
            Helper.Update();
        }

        protected void toolStripWebUIServiceLabel_Click(object sender, EventArgs e)
        {

        }

        protected void toolStripFilesChangedLabel_Click(object sender, EventArgs e)
        {
            new FileMonitor().Show();
        }

        protected void mainFileSystemWatcherMainFileSystemWatcherChanged(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        protected void updateTimerTick(object sender, EventArgs e)
        {
        }

        public event SimpleEventHandler Dismissed;

        private void MainFormClosed(object sender, FormClosedEventArgs e)
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
    }
}
