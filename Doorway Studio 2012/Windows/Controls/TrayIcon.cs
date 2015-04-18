using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using Umax.Windows.Classes;
using Umax.Windows.Helpers;
using Umax.Windows.Interfaces;
using Umax.Windows.Windows.Common;

namespace Umax.Windows.Controls
{
    public partial class TrayIcon : Component, IEventedControl
    {
        public TrayIcon()
        {
            InitializeComponent();

            this.Initialize();
        }

        public TrayIcon(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.Initialize();
        }

        /// <summary>
        /// Gets or sets a value indicating whether menu is Initialized.
        /// </summary>
        protected bool Initialized { get; set; }

        protected virtual void Initialize()
        {
            if (this.Initialized || this.DesignMode)
            {
                return;
            }

            this.Initialized = true;

            this.InitializeImages();
            this.InitializeEvents();
        }

        public string Text
        {
            get { return this.mainNotifyIcon.Text; }
            set { this.mainNotifyIcon.Text = value; }
        }

        public Icon Icon
        {
            get { return this.mainNotifyIcon.Icon; }
            set { this.mainNotifyIcon.Icon = value; }
        }

        public bool Visible
        {
            get { return this.mainNotifyIcon.Visible; }
            set { this.mainNotifyIcon.Visible = value; }
        }

        public void ShowBalloonTip(int TimeOut, string BalloonTitle, string BalloonText, ToolTipIcon BalloonIcon)
        {
            this.mainNotifyIcon.ShowBalloonTip(TimeOut, BalloonTitle, BalloonText, BalloonIcon);
        }

        public event SimpleEventHandler DoubleClick;

        protected void IconDoubleClick(object sender, EventArgs e)
        {
            if (this.DoubleClick != null)
            {
                this.DoubleClick.Invoke();
            }
        }

        private TrayWindow Window { get; set; }

        protected void IconClick(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                if ((e as MouseEventArgs).Button == MouseButtons.Right)
                {
                    return;
                }
            }

            if (this.Window == null)
            {
                this.Window = new TrayWindow();
            }

            if (this.Window.IsDisposed)
            {
                this.Window = new TrayWindow();
            }

            if (this.Window.Visible)
            {
                this.Window.Close();
            }
            else
            {
                this.Window.Show();
            }
        }

        protected void InitializeImages()
        {
            workSpaceToolStripMenuItem.Image = Resources.Resources.WorkSpace;
            workSpaceNewToolStripMenuItem.Image = Resources.Resources.PlusGreen;
            workSpaceEditToolStripMenuItem.Image = Resources.Resources.Edit;
            tasksToolStripMenuItem.Image = Resources.Resources.Task;
            tasksNewToolStripMenuItem.Image = Resources.Resources.PlusBlue;
            tasksEditToolStripMenuItem.Image = Resources.Resources.Edit;
            tasksDeleteToolStripMenuItem.Image = Resources.Resources.Delete;
            tasksDeleteNewToolStripMenuItem.Image = Resources.Resources.ImageGreen;
            tasksDeleteCompletedToolStripMenuItem.Image = Resources.Resources.Ok;
            tasksDeleteFailedToolStripMenuItem.Image = Resources.Resources.Delete;
            dataToolStripMenuItem.Image = Resources.Resources.Folder;
            dataKeywordsToolStripMenuItem.Image = Resources.Resources.Item;
            dataTextToolStripMenuItem.Image = Resources.Resources.Item;
            dataImagesToolStripMenuItem.Image = Resources.Resources.Image;
            dataTemplatesToolStripMenuItem.Image = Resources.Resources.Folder;
            dataPresetsToolStripMenuItem.Image = Resources.Resources.Preset;
            historyToolStripMenuItem.Image = Resources.Resources.History;

            toolsToolStripMenuItem.Image = Resources.Resources.Tools;
            toolsInternalToolStripMenuItem.Image = Resources.Resources.Tools;
            toolsInternalTemplateEditorToolStripMenuItem.Image = Resources.Resources.Folder;
            toolsInternalAutomatorToolStripMenuItem.Image = Resources.Resources.Automator;
            toolsInternalAutomatorProToolStripMenuItem.Image = Resources.Resources.AutomatorPro;
            toolsExternalToolStripMenuItem.Image = Resources.Resources.Tools;
            toolsHistoryToolStripMenuItem.Image = Resources.Resources.History;
            toolsHistoryWorkSpacesToolStripMenuItem.Image = Resources.Resources.WorkSpace;
            toolsHistoryKeywordsToolStripMenuItem.Image = Resources.Resources.Item;
            toolsHistoryTextToolStripMenuItem.Image = Resources.Resources.Item;
            toolsHistoryImagesToolStripMenuItem.Image = Resources.Resources.Image;
            toolsHistoryTemplatesToolStripMenuItem.Image = Resources.Resources.Folder;
            toolsHistoryPresetsToolStripMenuItem.Image = Resources.Resources.Preset;
            toolsOptionsToolStripMenuItem.Image = Resources.Resources.Settings;

            // Windows
            windowsToolStripMenuItem.Image = Resources.Resources.Windows;

            exitToolStripMenuItem.Image = Resources.Resources.Delete;
        }

        public void InitializeEvents()
        {
            if (Core.Core.Instanse == null)
            {
                return;
            }
            if (Core.Core.Instanse.Manager == null)
            {
                return;
            }

            Core.Core.Instanse.Manager.TaskStarted += this.TaskStarted;
            Core.Core.Instanse.Manager.TaskCompleted += this.TaskCompleted;
            Core.Core.Instanse.Manager.TaskFailed += this.TaskFailed;

            RunTime.Instance.Windows.CountChanged += this.WindowsCountChanged;
        }

        public void DeInitializeEvents()
        {
            Core.Core.Instanse.Manager.TaskStarted -= this.TaskStarted;
            Core.Core.Instanse.Manager.TaskCompleted -= this.TaskCompleted;
            Core.Core.Instanse.Manager.TaskFailed -= this.TaskFailed;

            RunTime.Instance.Windows.CountChanged += this.WindowsCountChanged;
        }

        public void UpdateControl()
        {
        }

        protected void ShowNotificationNoNewTask()
        {
            if (GuiOptions.Instanse.Notifications && GuiOptions.Instanse.NotificationsAtNoTask)
            {
                mainNotifyIcon.ShowBalloonTip(GuiOptions.Instanse.NotificationsTime * 1000, this.Text, "No new tasks!", ToolTipIcon.Info);
            }
        }

        protected void ShowNotification(string Name, TaskStateType State)
        {
            if (GuiOptions.Instanse.Notifications)
            {
                switch (State)
                {
                    case TaskStateType.Running:
                        {
                            if (GuiOptions.Instanse.NotificationsAtTaskStarted)
                            {
                                mainNotifyIcon.ShowBalloonTip(GuiOptions.Instanse.NotificationsTime * 1000, this.Text, "Task started: " + Name, ToolTipIcon.Info);
                            }

                            break;
                        }

                    case TaskStateType.Done:
                        {
                            if (GuiOptions.Instanse.NotificationsAtTaskFinished)
                            {
                                mainNotifyIcon.ShowBalloonTip(GuiOptions.Instanse.NotificationsTime * 1000, this.Text, "Task completed: " + Name, ToolTipIcon.Info);
                            }

                            break;
                        }

                    case TaskStateType.Error:
                        {
                            if (GuiOptions.Instanse.NotificationsAtTaskFailed)
                            {
                                mainNotifyIcon.ShowBalloonTip(GuiOptions.Instanse.NotificationsTime * 1000, this.Text, "Task failed: " + Name, ToolTipIcon.Error);
                            }

                            break;
                        }
                }
            }
        }

        protected void PlaySounds(TaskStateType State)
        {
            Helper.PlaySounds(State);
        }

        protected void PlayNoTaskSound()
        {
            Helper.PlayNoTaskSound();
        }

        protected void TaskStarted(object Sender)
        {
            this.ShowNotification((Sender as ITask).Name, TaskStateType.Running);
            this.PlaySounds(TaskStateType.Running);
            
            this.UpdateControl();
        }

        protected void TaskCompleted(object Sender)
        {
            if (Core.Helpers.Helper.NewTaskExist())
            {
                this.ShowNotificationNoNewTask();
                this.PlayNoTaskSound();
            }
            else
            {
                this.ShowNotification((Sender as ITask).Name, TaskStateType.Done);
                this.PlaySounds(TaskStateType.Done);
            }

            this.UpdateControl();
        }

        protected void TaskFailed(object Sender)
        {
            if (Core.Helpers.Helper.NewTaskExist())
            {
                this.ShowNotificationNoNewTask();
                this.PlayNoTaskSound();
            }
            else
            {
                this.ShowNotification((Sender as ITask).Name,
                                      TaskStateType.Error);
                this.PlaySounds(TaskStateType.Error);
            }

            this.UpdateControl();
        }

        protected void CreateTask(object sender, EventArgs e)
        {
            DataHelper.CreateTask();
        }

        protected void DeleteNewTasks(object sender, EventArgs e)
        {
            Core.Helpers.Helper.DeleteTasks(TaskStateType.New);
        }

        protected void DeleteCompletedTasks(object sender, EventArgs e)
        {
            Core.Helpers.Helper.DeleteTasks(TaskStateType.Done);
        }

        protected void DeleteFailedTasks(object sender, EventArgs e)
        {
            Core.Helpers.Helper.DeleteTasks(TaskStateType.Error);
        }

        protected void DeleteAllTasks(object sender, EventArgs e)
        {
            Core.Helpers.Helper.DeleteTasks();
        }

        protected void EditTasks(object sender, EventArgs e)
        {
            DataHelper.EditTasks();
        }

        protected void ShowHistory(object sender, EventArgs e)
        {
            DataHelper.ShowLog();
        }

        protected void EditKeywords(object sender, EventArgs e)
        {
            DataHelper.EditKeywords();
        }

        protected void EditText(object sender, EventArgs e)
        {
            DataHelper.EditText();
        }

        protected void EditImages(object sender, EventArgs e)
        {
            DataHelper.EditImages();
        }

        protected void EditTemplates(object sender, EventArgs e)
        {
            DataHelper.EditTemplates();
        }

        protected void EditPresets(object sender, EventArgs e)
        {
            DataHelper.EditPresets();
        }

        protected void EditWorkSpaces(object sender, EventArgs e)
        {
            DataHelper.EditWorkSpaces();
        }

        protected void EditOptions(object sender, EventArgs e)
        {
            DataHelper.EditOptions();
        }

        protected void CloseWindow(object sender, EventArgs e)
        {
            Helper.Close();
        }

        protected void ShowWindow(object sender, EventArgs e)
        {
            Helper.Show();
        }

        protected void CreateWorkSpace(object sender, EventArgs e)
        {
            DataHelper.CreateWorkSpace();
        }

        protected void OpenTemplateEditor(object sender, EventArgs e)
        {
            ToolsHelper.OpenTemplateEditor();
        }

        protected void OpenAutomator(object sender, EventArgs e)
        {
            ToolsHelper.OpenAutomator();
        }

        protected void OpenAutomatorPro(object sender, EventArgs e)
        {
            ToolsHelper.OpenAutomatorPro();
        }

        protected void OpenKeywordMixer(object sender, EventArgs e)
        {
        }

        protected void OpenKeywordMaker(object sender, EventArgs e)
        {
        }

        protected void OpenKeywordSelector(object sender, EventArgs e)
        {
        }

        protected void OpenTextCleaner(object sender, EventArgs e)
        {
        }

        protected void OpenTextFilter(object sender, EventArgs e)
        {
        }

        protected void OpenDetailsIniGenerator(object sender, EventArgs e)
        {
        }

        protected void OpenWorkSpacesHistory(object sender, EventArgs e)
        {
        }

        protected void OpenKeywordsHistory(object sender, EventArgs e)
        {
        }

        protected void OpenTextHistory(object sender, EventArgs e)
        {
        }

        protected void OpenImagesHistory(object sender, EventArgs e)
        {
        }

        protected void OpenTemplatesHistory(object sender, EventArgs e)
        {
        }

        protected void OpenPresetsHistory(object sender, EventArgs e)
        {
        }

        private void WindowsCountChanged()
        {
            this.RebuildWindowsMenu();
        }

        private void RebuildWindowsMenu()
        {
            // Unsubscribe events
            for (int i = 0; i < this.windowsToolStripMenuItem.DropDownItems.Count; i++)
            {
                this.windowsToolStripMenuItem.DropDownItems[i].Click -= this.WindowsClick;
            }

            // Rebuild menu
            this.windowsToolStripMenuItem.DropDownItems.Clear();
            for (int i = 0; i < RunTime.Instance.Windows.Count; i++)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();

                item.Text = RunTime.Instance.Windows[i].Title;
                item.Click += this.WindowsClick;

                this.windowsToolStripMenuItem.DropDownItems.Add(item);
            }

        }

        private void WindowsClick(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                RunTime.Instance.Windows[(sender as ToolStripMenuItem).Owner.Items.IndexOf(sender as ToolStripMenuItem)].Restore();
            }
        }
    }
}
