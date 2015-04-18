using Umax.UI.XPTab;
using Umax.UI.XPTable;

using Umax.Resources;
using Umax.Windows.Controls;
using Umax.Windows.Controls.Views;
using Umax.Windows.Enums;

namespace DoorwayStudio.Windows
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStateToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSpaceToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUpdateToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFilesChangedToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tasksTabControl = new Umax.UI.XPTab.XPTabControl();
            this.calendarTasksTabPage = new System.Windows.Forms.TabPage();
            this.currentTasksControl = new TasksGridControl();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.allTasksTabPage = new System.Windows.Forms.TabPage();
            this.allTasksControl = new TasksGridControl();
            this.mainFileSystemWatcher = new System.IO.FileSystemWatcher();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.topSplitContainer = new System.Windows.Forms.SplitContainer();
            this.wsTabControl = new Umax.UI.XPTab.XPTabControl();
            this.wsTabPage = new System.Windows.Forms.TabPage();
            this.workSpacesControl = new WorkSpacesGridControl();
            this.treeTasksTabPage = new System.Windows.Forms.TabPage();
            this.tasksTreeControl = new TasksTreeControl();
            this.mainTabControl = new Umax.Windows.Controls.TabsControl();
            this.newsGroupBox = new System.Windows.Forms.GroupBox();
            this.newsWebBrowser = new System.Windows.Forms.WebBrowser();
            this.bottomTabControl = new Umax.UI.XPTab.XPTabControl();
            this.activeTasksTabPage = new System.Windows.Forms.TabPage();
            this.activeTasksControl = new ActiveTasksGridControl();
            this.historyTabPage = new System.Windows.Forms.TabPage();
            this.logContol = new LogContol();
            this.mainMenuStrip = new Umax.Windows.Controls.MenuStrip(this.components);
            this.mainTrayIcon = new Umax.Windows.Controls.TrayIcon(this.components);
            this.mainStatusStrip.SuspendLayout();
            this.tasksTabControl.SuspendLayout();
            this.calendarTasksTabPage.SuspendLayout();
            this.allTasksTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFileSystemWatcher)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.topSplitContainer.Panel1.SuspendLayout();
            this.topSplitContainer.Panel2.SuspendLayout();
            this.topSplitContainer.SuspendLayout();
            this.wsTabControl.SuspendLayout();
            this.wsTabPage.SuspendLayout();
            this.treeTasksTabPage.SuspendLayout();
            this.newsGroupBox.SuspendLayout();
            this.bottomTabControl.SuspendLayout();
            this.activeTasksTabPage.SuspendLayout();
            this.historyTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStateToolStripLabel,
            this.statusSpaceToolStripLabel,
            this.statusUpdateToolStripLabel,
            this.statusFilesChangedToolStripLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 525);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainStatusStrip.Size = new System.Drawing.Size(882, 24);
            this.mainStatusStrip.TabIndex = 1;
            // 
            // statusStateToolStripLabel
            // 
            this.statusStateToolStripLabel.Name = "statusStateToolStripLabel";
            this.statusStateToolStripLabel.Size = new System.Drawing.Size(74, 19);
            this.statusStateToolStripLabel.Text = "State: Ready.";
            // 
            // statusSpaceToolStripLabel
            // 
            this.statusSpaceToolStripLabel.Name = "statusSpaceToolStripLabel";
            this.statusSpaceToolStripLabel.Size = new System.Drawing.Size(656, 19);
            this.statusSpaceToolStripLabel.Spring = true;
            // 
            // statusUpdateToolStripLabel
            // 
            this.statusUpdateToolStripLabel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 2);
            this.statusUpdateToolStripLabel.Name = "statusUpdateToolStripLabel";
            this.statusUpdateToolStripLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusUpdateToolStripLabel.Size = new System.Drawing.Size(48, 19);
            this.statusUpdateToolStripLabel.Text = "Update!";
            this.statusUpdateToolStripLabel.Click += new System.EventHandler(this.toolStripUpdateLabel_Click);
            // 
            // statusFilesChangedToolStripLabel
            // 
            this.statusFilesChangedToolStripLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusFilesChangedToolStripLabel.Name = "statusFilesChangedToolStripLabel";
            this.statusFilesChangedToolStripLabel.Size = new System.Drawing.Size(86, 19);
            this.statusFilesChangedToolStripLabel.Text = "Files changed:";
            this.statusFilesChangedToolStripLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.statusFilesChangedToolStripLabel.Click += new System.EventHandler(this.toolStripFilesChangedLabel_Click);
            // 
            // tasksTabControl
            // 
            this.tasksTabControl.Controls.Add(this.calendarTasksTabPage);
            this.tasksTabControl.Controls.Add(this.allTasksTabPage);
            this.tasksTabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.tasksTabControl.Location = new System.Drawing.Point(647, 24);
            this.tasksTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tasksTabControl.Name = "tasksTabControl";
            this.tasksTabControl.SelectedIndex = 0;
            this.tasksTabControl.Size = new System.Drawing.Size(235, 501);
            this.tasksTabControl.TabIndex = 3;
            // 
            // calendarTasksTabPage
            // 
            this.calendarTasksTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.calendarTasksTabPage.Controls.Add(this.currentTasksControl);
            this.calendarTasksTabPage.Controls.Add(this.monthCalendar);
            this.calendarTasksTabPage.ImageIndex = 6;
            this.calendarTasksTabPage.Location = new System.Drawing.Point(4, 4);
            this.calendarTasksTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.calendarTasksTabPage.Name = "calendarTasksTabPage";
            this.calendarTasksTabPage.Size = new System.Drawing.Size(227, 475);
            this.calendarTasksTabPage.TabIndex = 0;
            this.calendarTasksTabPage.Text = "Calendar + Tasks";
            // 
            // currentTasksControl
            // 
            this.currentTasksControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentTasksControl.FilterType = Umax.Windows.Enums.TasksDateFilterType.Date;
            this.currentTasksControl.Location = new System.Drawing.Point(0, 162);
            this.currentTasksControl.Margin = new System.Windows.Forms.Padding(0);
            this.currentTasksControl.Name = "currentTasksControl";
            this.currentTasksControl.SelectedDate = new System.DateTime(((long)(0)));
            this.currentTasksControl.Size = new System.Drawing.Size(227, 313);
            this.currentTasksControl.TabIndex = 14;
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.Control;
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 13;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarDateChanged);
            // 
            // allTasksTabPage
            // 
            this.allTasksTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.allTasksTabPage.Controls.Add(this.allTasksControl);
            this.allTasksTabPage.ImageIndex = 1;
            this.allTasksTabPage.Location = new System.Drawing.Point(4, 4);
            this.allTasksTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.allTasksTabPage.Name = "allTasksTabPage";
            this.allTasksTabPage.Size = new System.Drawing.Size(227, 475);
            this.allTasksTabPage.TabIndex = 1;
            this.allTasksTabPage.Text = "All Tasks";
            // 
            // allTasksControl
            // 
            this.allTasksControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allTasksControl.FilterType = Umax.Windows.Enums.TasksDateFilterType.None;
            this.allTasksControl.Location = new System.Drawing.Point(0, 0);
            this.allTasksControl.Margin = new System.Windows.Forms.Padding(0);
            this.allTasksControl.Name = "allTasksControl";
            this.allTasksControl.SelectedDate = new System.DateTime(((long)(0)));
            this.allTasksControl.Size = new System.Drawing.Size(227, 475);
            this.allTasksControl.TabIndex = 0;
            // 
            // mainFileSystemWatcher
            // 
            this.mainFileSystemWatcher.EnableRaisingEvents = true;
            this.mainFileSystemWatcher.SynchronizingObject = this;
            this.mainFileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.mainFileSystemWatcherMainFileSystemWatcherChanged);
            // 
            // mainImageList
            // 
            this.mainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.topSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.bottomTabControl);
            this.mainSplitContainer.Size = new System.Drawing.Size(647, 501);
            this.mainSplitContainer.SplitterDistance = 363;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // topSplitContainer
            // 
            this.topSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.topSplitContainer.Name = "topSplitContainer";
            // 
            // topSplitContainer.Panel1
            // 
            this.topSplitContainer.Panel1.Controls.Add(this.wsTabControl);
            this.topSplitContainer.Panel1MinSize = 170;
            // 
            // topSplitContainer.Panel2
            // 
            this.topSplitContainer.Panel2.Controls.Add(this.mainTabControl);
            this.topSplitContainer.Panel2.Controls.Add(this.newsGroupBox);
            this.topSplitContainer.Size = new System.Drawing.Size(647, 363);
            this.topSplitContainer.SplitterDistance = 170;
            this.topSplitContainer.TabIndex = 0;
            // 
            // wsTabControl
            // 
            this.wsTabControl.Controls.Add(this.wsTabPage);
            this.wsTabControl.Controls.Add(this.treeTasksTabPage);
            this.wsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsTabControl.Location = new System.Drawing.Point(0, 0);
            this.wsTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.wsTabControl.Name = "wsTabControl";
            this.wsTabControl.Padding = new System.Drawing.Point(4, 3);
            this.wsTabControl.SelectedIndex = 0;
            this.wsTabControl.Size = new System.Drawing.Size(170, 363);
            this.wsTabControl.TabIndex = 5;
            // 
            // wsTabPage
            // 
            this.wsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.wsTabPage.Controls.Add(this.workSpacesControl);
            this.wsTabPage.ImageIndex = 0;
            this.wsTabPage.Location = new System.Drawing.Point(4, 4);
            this.wsTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.wsTabPage.Name = "wsTabPage";
            this.wsTabPage.Size = new System.Drawing.Size(162, 337);
            this.wsTabPage.TabIndex = 0;
            this.wsTabPage.Text = "WorkSpaces";
            // 
            // workSpacesControl
            // 
            this.workSpacesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workSpacesControl.Location = new System.Drawing.Point(0, 0);
            this.workSpacesControl.Margin = new System.Windows.Forms.Padding(0);
            this.workSpacesControl.Name = "workSpacesControl";
            this.workSpacesControl.Size = new System.Drawing.Size(162, 337);
            this.workSpacesControl.TabIndex = 0;
            // 
            // treeTasksTabPage
            // 
            this.treeTasksTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.treeTasksTabPage.Controls.Add(this.tasksTreeControl);
            this.treeTasksTabPage.ImageIndex = 1;
            this.treeTasksTabPage.Location = new System.Drawing.Point(4, 4);
            this.treeTasksTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.treeTasksTabPage.Name = "treeTasksTabPage";
            this.treeTasksTabPage.Size = new System.Drawing.Size(162, 337);
            this.treeTasksTabPage.TabIndex = 1;
            this.treeTasksTabPage.Text = "Tasks";
            // 
            // tasksTreeControl
            // 
            this.tasksTreeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksTreeControl.Location = new System.Drawing.Point(0, 0);
            this.tasksTreeControl.Margin = new System.Windows.Forms.Padding(0);
            this.tasksTreeControl.Name = "tasksTreeControl";
            this.tasksTreeControl.Size = new System.Drawing.Size(162, 337);
            this.tasksTreeControl.TabIndex = 0;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 68);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Size = new System.Drawing.Size(473, 295);
            this.mainTabControl.TabIndex = 1;
            // 
            // newsGroupBox
            // 
            this.newsGroupBox.Controls.Add(this.newsWebBrowser);
            this.newsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.newsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.newsGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.newsGroupBox.Name = "newsGroupBox";
            this.newsGroupBox.Size = new System.Drawing.Size(473, 68);
            this.newsGroupBox.TabIndex = 0;
            this.newsGroupBox.TabStop = false;
            this.newsGroupBox.Text = "News";
            // 
            // newsWebBrowser
            // 
            this.newsWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.newsWebBrowser.Location = new System.Drawing.Point(3, 16);
            this.newsWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.newsWebBrowser.Name = "newsWebBrowser";
            this.newsWebBrowser.ScrollBarsEnabled = false;
            this.newsWebBrowser.Size = new System.Drawing.Size(467, 49);
            this.newsWebBrowser.TabIndex = 0;
            // 
            // bottomTabControl
            // 
            this.bottomTabControl.Alignment = System.Windows.Forms.TabAlignment.Top;
            this.bottomTabControl.Controls.Add(this.activeTasksTabPage);
            this.bottomTabControl.Controls.Add(this.historyTabPage);
            this.bottomTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTabControl.Location = new System.Drawing.Point(0, 0);
            this.bottomTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.bottomTabControl.Name = "bottomTabControl";
            this.bottomTabControl.SelectedIndex = 0;
            this.bottomTabControl.Size = new System.Drawing.Size(647, 134);
            this.bottomTabControl.TabIndex = 3;
            // 
            // activeTasksTabPage
            // 
            this.activeTasksTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.activeTasksTabPage.Controls.Add(this.activeTasksControl);
            this.activeTasksTabPage.ImageIndex = 3;
            this.activeTasksTabPage.Location = new System.Drawing.Point(4, 22);
            this.activeTasksTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.activeTasksTabPage.Name = "activeTasksTabPage";
            this.activeTasksTabPage.Size = new System.Drawing.Size(639, 108);
            this.activeTasksTabPage.TabIndex = 0;
            this.activeTasksTabPage.Text = "Active Tasks";
            // 
            // activeTasksControl
            // 
            this.activeTasksControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeTasksControl.Location = new System.Drawing.Point(0, 0);
            this.activeTasksControl.Margin = new System.Windows.Forms.Padding(0);
            this.activeTasksControl.Name = "activeTasksControl";
            this.activeTasksControl.Size = new System.Drawing.Size(639, 108);
            this.activeTasksControl.TabIndex = 0;
            // 
            // historyTabPage
            // 
            this.historyTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.historyTabPage.Controls.Add(this.logContol);
            this.historyTabPage.ImageIndex = 1;
            this.historyTabPage.Location = new System.Drawing.Point(4, 22);
            this.historyTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Size = new System.Drawing.Size(639, 108);
            this.historyTabPage.TabIndex = 1;
            this.historyTabPage.Text = "History";
            // 
            // logContol
            // 
            this.logContol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logContol.Location = new System.Drawing.Point(0, 0);
            this.logContol.Margin = new System.Windows.Forms.Padding(0);
            this.logContol.Name = "logContol";
            this.logContol.Size = new System.Drawing.Size(639, 108);
            this.logContol.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.MenuType = Umax.Windows.Enums.MainMenuType.None;
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(882, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // mainTrayIcon
            // 
            this.mainTrayIcon.Icon = null;
            this.mainTrayIcon.Text = "";
            this.mainTrayIcon.Visible = true;
            this.mainTrayIcon.DoubleClick += new Umax.Interfaces.Events.SimpleEventHandler(this.ShowWindow);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 549);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.tasksTabControl);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(890, 576);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doorway Studio 2012";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosed);
            this.Load += new System.EventHandler(this.MainLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainKeyDown);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.tasksTabControl.ResumeLayout(false);
            this.calendarTasksTabPage.ResumeLayout(false);
            this.allTasksTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFileSystemWatcher)).EndInit();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.topSplitContainer.Panel1.ResumeLayout(false);
            this.topSplitContainer.Panel2.ResumeLayout(false);
            this.topSplitContainer.ResumeLayout(false);
            this.wsTabControl.ResumeLayout(false);
            this.wsTabPage.ResumeLayout(false);
            this.treeTasksTabPage.ResumeLayout(false);
            this.newsGroupBox.ResumeLayout(false);
            this.bottomTabControl.ResumeLayout(false);
            this.activeTasksTabPage.ResumeLayout(false);
            this.historyTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.StatusStrip mainStatusStrip;
        protected System.Windows.Forms.SplitContainer mainSplitContainer;
        protected System.Windows.Forms.SplitContainer topSplitContainer;
        protected System.Windows.Forms.ToolStripStatusLabel statusStateToolStripLabel;
        protected System.Windows.Forms.ToolStripStatusLabel statusUpdateToolStripLabel;
        protected System.Windows.Forms.GroupBox newsGroupBox;
        protected System.Windows.Forms.WebBrowser newsWebBrowser;
        protected XPTabControl bottomTabControl;
        protected System.Windows.Forms.TabPage activeTasksTabPage;
        protected System.Windows.Forms.TabPage historyTabPage;
        protected XPTabControl wsTabControl;
        protected System.Windows.Forms.TabPage wsTabPage;
        protected System.Windows.Forms.TabPage treeTasksTabPage;
        protected XPTabControl tasksTabControl;
        protected System.Windows.Forms.TabPage calendarTasksTabPage;
        protected System.Windows.Forms.MonthCalendar monthCalendar;
        protected System.Windows.Forms.TabPage allTasksTabPage;
        protected System.IO.FileSystemWatcher mainFileSystemWatcher;
        protected System.Windows.Forms.ToolStripStatusLabel statusFilesChangedToolStripLabel;
        protected System.Windows.Forms.Timer updateTimer;
        protected System.Windows.Forms.ImageList mainImageList;
        protected System.Windows.Forms.ToolStripStatusLabel statusSpaceToolStripLabel;
        protected LogContol logContol;
        protected ActiveTasksGridControl activeTasksControl;
        private TasksGridControl currentTasksControl;
        private TasksGridControl allTasksControl;
        private WorkSpacesGridControl workSpacesControl;
        private TasksTreeControl tasksTreeControl;
        private TabsControl mainTabControl;
        private MenuStrip mainMenuStrip;
        private TrayIcon mainTrayIcon;
    }
}