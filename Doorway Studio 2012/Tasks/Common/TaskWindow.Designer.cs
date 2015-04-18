namespace Umax.Plugins.Tasks.Common
{
    partial class TaskWindow
    {

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
        protected virtual void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskWindow));
            this.taskTimeGeneralDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.taskGeneralTimeLabel = new System.Windows.Forms.Label();
            this.taskGeneralNameTextBox = new System.Windows.Forms.TextBox();
            this.taskGeneralNameLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.taskLoadFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskSaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.taskImportFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.taskExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.taskTabPage = new System.Windows.Forms.TabPage();
            this.taskSchedulerGroupBox = new System.Windows.Forms.GroupBox();
            this.taskScheduleStepLabel = new System.Windows.Forms.Label();
            this.taskScheduleComboBox = new System.Windows.Forms.ComboBox();
            this.taskScheduleStepNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.taskGeneralGroupBox = new System.Windows.Forms.GroupBox();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.generalTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.GeneralTabPageControl();
            this.imagesTabPage = new System.Windows.Forms.TabPage();
            this.imagesTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.ImagesTabPageControl();
            this.fileTokensTabPage = new System.Windows.Forms.TabPage();
            this.fileTokensTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.FileTokensTabPageControl();
            this.keywordsTabPage = new System.Windows.Forms.TabPage();
            this.keywordsTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.KeywordsTabPageControl();
            this.categoriesTabPage = new System.Windows.Forms.TabPage();
            this.categoriesTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.CategoriesTabPageControl();
            this.pagesTabPage = new System.Windows.Forms.TabPage();
            this.mapPagesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mapTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.MapTabPageControl();
            this.pagesTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.PagesTabPageControl();
            this.pagesNamingGroupBox = new System.Windows.Forms.GroupBox();
            this.pagesNamingPanel = new System.Windows.Forms.Panel();
            this.textTabPage = new System.Windows.Forms.TabPage();
            this.textTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.TextTabPageControl();
            this.entranceTabPage = new System.Windows.Forms.TabPage();
            this.entranceTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.EntranceTabPageControl();
            this.tokensTabPage = new System.Windows.Forms.TabPage();
            this.tokensTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.TokensTabPageControl();
            this.otherTabPage = new System.Windows.Forms.TabPage();
            this.otherTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.OtherTabPageControl();
            this.linksTabPage = new System.Windows.Forms.TabPage();
            this.linksTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.LinksTabPageControl();
            this.FTPTabPage = new System.Windows.Forms.TabPage();
            this.ftpTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.FTPTabPageControl();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tagsTabPage = new System.Windows.Forms.TabPage();
            this.tagsTabPageControl = new Umax.Plugins.Tasks.Common.Controls.TabPages.TagsTabPageControl();
            this.mainMenuStrip.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.taskTabPage.SuspendLayout();
            this.taskSchedulerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskScheduleStepNumericUpDown)).BeginInit();
            this.taskGeneralGroupBox.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.imagesTabPage.SuspendLayout();
            this.fileTokensTabPage.SuspendLayout();
            this.keywordsTabPage.SuspendLayout();
            this.categoriesTabPage.SuspendLayout();
            this.pagesTabPage.SuspendLayout();
            this.mapPagesSplitContainer.Panel1.SuspendLayout();
            this.mapPagesSplitContainer.Panel2.SuspendLayout();
            this.mapPagesSplitContainer.SuspendLayout();
            this.pagesNamingGroupBox.SuspendLayout();
            this.textTabPage.SuspendLayout();
            this.entranceTabPage.SuspendLayout();
            this.tokensTabPage.SuspendLayout();
            this.otherTabPage.SuspendLayout();
            this.linksTabPage.SuspendLayout();
            this.FTPTabPage.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.tagsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskTimeGeneralDateTimePicker
            // 
            this.taskTimeGeneralDateTimePicker.CustomFormat = "dddd, MMMM dd, yyyy hh:mm:ss tt";
            this.taskTimeGeneralDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.taskTimeGeneralDateTimePicker.Location = new System.Drawing.Point(46, 45);
            this.taskTimeGeneralDateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.taskTimeGeneralDateTimePicker.Name = "taskTimeGeneralDateTimePicker";
            this.taskTimeGeneralDateTimePicker.Size = new System.Drawing.Size(273, 20);
            this.taskTimeGeneralDateTimePicker.TabIndex = 20;
            // 
            // taskGeneralTimeLabel
            // 
            this.taskGeneralTimeLabel.AutoSize = true;
            this.taskGeneralTimeLabel.Location = new System.Drawing.Point(6, 51);
            this.taskGeneralTimeLabel.Name = "taskGeneralTimeLabel";
            this.taskGeneralTimeLabel.Size = new System.Drawing.Size(30, 13);
            this.taskGeneralTimeLabel.TabIndex = 19;
            this.taskGeneralTimeLabel.Text = "Time";
            // 
            // taskGeneralNameTextBox
            // 
            this.taskGeneralNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskGeneralNameTextBox.Location = new System.Drawing.Point(46, 19);
            this.taskGeneralNameTextBox.Name = "taskGeneralNameTextBox";
            this.taskGeneralNameTextBox.Size = new System.Drawing.Size(628, 20);
            this.taskGeneralNameTextBox.TabIndex = 18;
            // 
            // taskGeneralNameLabel
            // 
            this.taskGeneralNameLabel.AutoSize = true;
            this.taskGeneralNameLabel.Location = new System.Drawing.Point(6, 22);
            this.taskGeneralNameLabel.Name = "taskGeneralNameLabel";
            this.taskGeneralNameLabel.Size = new System.Drawing.Size(35, 13);
            this.taskGeneralNameLabel.TabIndex = 17;
            this.taskGeneralNameLabel.Text = "Name";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(694, 24);
            this.mainMenuStrip.TabIndex = 24;
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskNewToolStripMenuItem,
            this.toolStripSeparator1,
            this.taskLoadFromToolStripMenuItem,
            this.taskSaveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.taskImportFromToolStripMenuItem,
            this.toolStripSeparator3,
            this.taskExitToolStripMenuItem});
            this.taskToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("taskToolStripMenuItem.Image")));
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // taskNewToolStripMenuItem
            // 
            this.taskNewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("taskNewToolStripMenuItem.Image")));
            this.taskNewToolStripMenuItem.Name = "taskNewToolStripMenuItem";
            this.taskNewToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.taskNewToolStripMenuItem.Text = "New";
            this.taskNewToolStripMenuItem.Click += new System.EventHandler(this.taskNewToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // taskLoadFromToolStripMenuItem
            // 
            this.taskLoadFromToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("taskLoadFromToolStripMenuItem.Image")));
            this.taskLoadFromToolStripMenuItem.Name = "taskLoadFromToolStripMenuItem";
            this.taskLoadFromToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.taskLoadFromToolStripMenuItem.Text = "Load from...";
            // 
            // taskSaveAsToolStripMenuItem
            // 
            this.taskSaveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("taskSaveAsToolStripMenuItem.Image")));
            this.taskSaveAsToolStripMenuItem.Name = "taskSaveAsToolStripMenuItem";
            this.taskSaveAsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.taskSaveAsToolStripMenuItem.Text = "Save as...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // taskImportFromToolStripMenuItem
            // 
            this.taskImportFromToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("taskImportFromToolStripMenuItem.Image")));
            this.taskImportFromToolStripMenuItem.Name = "taskImportFromToolStripMenuItem";
            this.taskImportFromToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.taskImportFromToolStripMenuItem.Text = "Import from...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // taskExitToolStripMenuItem
            // 
            this.taskExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("taskExitToolStripMenuItem.Image")));
            this.taskExitToolStripMenuItem.Name = "taskExitToolStripMenuItem";
            this.taskExitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.taskExitToolStripMenuItem.Text = "Exit";
            this.taskExitToolStripMenuItem.Click += new System.EventHandler(this.taskExitToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAboutToolStripMenuItem});
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpAboutToolStripMenuItem
            // 
            this.helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            this.helpAboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpAboutToolStripMenuItem.Text = "About";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.taskTabPage);
            this.mainTabControl.Controls.Add(this.generalTabPage);
            this.mainTabControl.Controls.Add(this.imagesTabPage);
            this.mainTabControl.Controls.Add(this.fileTokensTabPage);
            this.mainTabControl.Controls.Add(this.keywordsTabPage);
            this.mainTabControl.Controls.Add(this.categoriesTabPage);
            this.mainTabControl.Controls.Add(this.pagesTabPage);
            this.mainTabControl.Controls.Add(this.textTabPage);
            this.mainTabControl.Controls.Add(this.entranceTabPage);
            this.mainTabControl.Controls.Add(this.tokensTabPage);
            this.mainTabControl.Controls.Add(this.otherTabPage);
            this.mainTabControl.Controls.Add(this.linksTabPage);
            this.mainTabControl.Controls.Add(this.FTPTabPage);
            this.mainTabControl.Controls.Add(this.tagsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(694, 446);
            this.mainTabControl.TabIndex = 25;
            // 
            // taskTabPage
            // 
            this.taskTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.taskTabPage.Controls.Add(this.taskSchedulerGroupBox);
            this.taskTabPage.Controls.Add(this.taskGeneralGroupBox);
            this.taskTabPage.Location = new System.Drawing.Point(4, 22);
            this.taskTabPage.Name = "taskTabPage";
            this.taskTabPage.Size = new System.Drawing.Size(686, 420);
            this.taskTabPage.TabIndex = 10;
            this.taskTabPage.Text = "Task";
            // 
            // taskSchedulerGroupBox
            // 
            this.taskSchedulerGroupBox.Controls.Add(this.taskScheduleStepLabel);
            this.taskSchedulerGroupBox.Controls.Add(this.taskScheduleComboBox);
            this.taskSchedulerGroupBox.Controls.Add(this.taskScheduleStepNumericUpDown);
            this.taskSchedulerGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskSchedulerGroupBox.Location = new System.Drawing.Point(0, 77);
            this.taskSchedulerGroupBox.Name = "taskSchedulerGroupBox";
            this.taskSchedulerGroupBox.Size = new System.Drawing.Size(686, 74);
            this.taskSchedulerGroupBox.TabIndex = 21;
            this.taskSchedulerGroupBox.TabStop = false;
            this.taskSchedulerGroupBox.Text = "Scheduler";
            // 
            // taskScheduleStepLabel
            // 
            this.taskScheduleStepLabel.AutoSize = true;
            this.taskScheduleStepLabel.Location = new System.Drawing.Point(6, 48);
            this.taskScheduleStepLabel.Name = "taskScheduleStepLabel";
            this.taskScheduleStepLabel.Size = new System.Drawing.Size(29, 13);
            this.taskScheduleStepLabel.TabIndex = 3;
            this.taskScheduleStepLabel.Text = "Step";
            // 
            // taskScheduleComboBox
            // 
            this.taskScheduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskScheduleComboBox.FormattingEnabled = true;
            this.taskScheduleComboBox.Items.AddRange(new object[] {
            "Disabled",
            "Day",
            "Week",
            "Month",
            "Year"});
            this.taskScheduleComboBox.Location = new System.Drawing.Point(9, 19);
            this.taskScheduleComboBox.Name = "taskScheduleComboBox";
            this.taskScheduleComboBox.Size = new System.Drawing.Size(147, 21);
            this.taskScheduleComboBox.TabIndex = 2;
            this.taskScheduleComboBox.SelectedIndexChanged += new System.EventHandler(this.taskScheduleComboBoxSelectedIndexChanged);
            // 
            // taskScheduleStepNumericUpDown
            // 
            this.taskScheduleStepNumericUpDown.Enabled = false;
            this.taskScheduleStepNumericUpDown.Location = new System.Drawing.Point(93, 46);
            this.taskScheduleStepNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.taskScheduleStepNumericUpDown.Name = "taskScheduleStepNumericUpDown";
            this.taskScheduleStepNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.taskScheduleStepNumericUpDown.TabIndex = 1;
            this.taskScheduleStepNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // taskGeneralGroupBox
            // 
            this.taskGeneralGroupBox.Controls.Add(this.taskGeneralNameTextBox);
            this.taskGeneralGroupBox.Controls.Add(this.taskGeneralTimeLabel);
            this.taskGeneralGroupBox.Controls.Add(this.taskTimeGeneralDateTimePicker);
            this.taskGeneralGroupBox.Controls.Add(this.taskGeneralNameLabel);
            this.taskGeneralGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskGeneralGroupBox.Location = new System.Drawing.Point(0, 0);
            this.taskGeneralGroupBox.Name = "taskGeneralGroupBox";
            this.taskGeneralGroupBox.Size = new System.Drawing.Size(686, 77);
            this.taskGeneralGroupBox.TabIndex = 22;
            this.taskGeneralGroupBox.TabStop = false;
            this.taskGeneralGroupBox.Text = "General";
            // 
            // generalTabPage
            // 
            this.generalTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.generalTabPage.Controls.Add(this.generalTabPageControl);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Size = new System.Drawing.Size(686, 420);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            // 
            // generalTabPageControl
            // 
            this.generalTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.generalTabPageControl.Name = "generalTabPageControl";
            this.generalTabPageControl.Size = new System.Drawing.Size(192, 74);
            this.generalTabPageControl.TabIndex = 0;
            // 
            // imagesTabPage
            // 
            this.imagesTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.imagesTabPage.Controls.Add(this.imagesTabPageControl);
            this.imagesTabPage.Location = new System.Drawing.Point(4, 22);
            this.imagesTabPage.Name = "imagesTabPage";
            this.imagesTabPage.Size = new System.Drawing.Size(686, 420);
            this.imagesTabPage.TabIndex = 9;
            this.imagesTabPage.Text = "Images";
            // 
            // imagesTabPageControl
            // 
            this.imagesTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.imagesTabPageControl.Margin = new System.Windows.Forms.Padding(0);
            this.imagesTabPageControl.Name = "imagesTabPageControl";
            this.imagesTabPageControl.Size = new System.Drawing.Size(192, 74);
            this.imagesTabPageControl.TabIndex = 0;
            // 
            // fileTokensTabPage
            // 
            this.fileTokensTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.fileTokensTabPage.Controls.Add(this.fileTokensTabPageControl);
            this.fileTokensTabPage.Location = new System.Drawing.Point(4, 22);
            this.fileTokensTabPage.Name = "fileTokensTabPage";
            this.fileTokensTabPage.Size = new System.Drawing.Size(686, 420);
            this.fileTokensTabPage.TabIndex = 1;
            this.fileTokensTabPage.Text = "File Tokens";
            // 
            // fileTokensTabPageControl
            // 
            this.fileTokensTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileTokensTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.fileTokensTabPageControl.Margin = new System.Windows.Forms.Padding(0);
            this.fileTokensTabPageControl.Name = "fileTokensTabPageControl";
            this.fileTokensTabPageControl.Size = new System.Drawing.Size(192, 56);
            this.fileTokensTabPageControl.TabIndex = 2;
            // 
            // keywordsTabPage
            // 
            this.keywordsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.keywordsTabPage.Controls.Add(this.keywordsTabPageControl);
            this.keywordsTabPage.Location = new System.Drawing.Point(4, 22);
            this.keywordsTabPage.Name = "keywordsTabPage";
            this.keywordsTabPage.Size = new System.Drawing.Size(686, 420);
            this.keywordsTabPage.TabIndex = 2;
            this.keywordsTabPage.Text = "Keywords";
            // 
            // keywordsTabPageControl
            // 
            this.keywordsTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keywordsTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.keywordsTabPageControl.Margin = new System.Windows.Forms.Padding(0);
            this.keywordsTabPageControl.Name = "keywordsTabPageControl";
            this.keywordsTabPageControl.Size = new System.Drawing.Size(686, 420);
            this.keywordsTabPageControl.TabIndex = 0;
            // 
            // categoriesTabPage
            // 
            this.categoriesTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.categoriesTabPage.Controls.Add(this.categoriesTabPageControl);
            this.categoriesTabPage.Location = new System.Drawing.Point(4, 22);
            this.categoriesTabPage.Name = "categoriesTabPage";
            this.categoriesTabPage.Size = new System.Drawing.Size(686, 420);
            this.categoriesTabPage.TabIndex = 12;
            this.categoriesTabPage.Text = "Categories";
            // 
            // categoriesTabPageControl
            // 
            this.categoriesTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.categoriesTabPageControl.Margin = new System.Windows.Forms.Padding(0);
            this.categoriesTabPageControl.Name = "categoriesTabPageControl";
            this.categoriesTabPageControl.Size = new System.Drawing.Size(686, 420);
            this.categoriesTabPageControl.TabIndex = 14;
            // 
            // pagesTabPage
            // 
            this.pagesTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.pagesTabPage.Controls.Add(this.mapPagesSplitContainer);
            this.pagesTabPage.Controls.Add(this.pagesNamingGroupBox);
            this.pagesTabPage.Location = new System.Drawing.Point(4, 22);
            this.pagesTabPage.Name = "pagesTabPage";
            this.pagesTabPage.Size = new System.Drawing.Size(686, 420);
            this.pagesTabPage.TabIndex = 3;
            this.pagesTabPage.Text = "Pages/Map";
            // 
            // mapPagesSplitContainer
            // 
            this.mapPagesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPagesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mapPagesSplitContainer.IsSplitterFixed = true;
            this.mapPagesSplitContainer.Location = new System.Drawing.Point(269, 0);
            this.mapPagesSplitContainer.Name = "mapPagesSplitContainer";
            this.mapPagesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mapPagesSplitContainer.Panel1
            // 
            this.mapPagesSplitContainer.Panel1.Controls.Add(this.mapTabPageControl);
            // 
            // mapPagesSplitContainer.Panel2
            // 
            this.mapPagesSplitContainer.Panel2.Controls.Add(this.pagesTabPageControl);
            this.mapPagesSplitContainer.Size = new System.Drawing.Size(417, 420);
            this.mapPagesSplitContainer.SplitterDistance = 175;
            this.mapPagesSplitContainer.TabIndex = 6;
            // 
            // mapTabPageControl
            // 
            this.mapTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.mapTabPageControl.Margin = new System.Windows.Forms.Padding(0);
            this.mapTabPageControl.Name = "mapTabPageControl";
            this.mapTabPageControl.Size = new System.Drawing.Size(417, 175);
            this.mapTabPageControl.TabIndex = 0;
            // 
            // pagesTabPageControl
            // 
            this.pagesTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.pagesTabPageControl.Margin = new System.Windows.Forms.Padding(0);
            this.pagesTabPageControl.Name = "pagesTabPageControl";
            this.pagesTabPageControl.Size = new System.Drawing.Size(417, 241);
            this.pagesTabPageControl.TabIndex = 0;
            // 
            // pagesNamingGroupBox
            // 
            this.pagesNamingGroupBox.Controls.Add(this.pagesNamingPanel);
            this.pagesNamingGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pagesNamingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.pagesNamingGroupBox.Name = "pagesNamingGroupBox";
            this.pagesNamingGroupBox.Size = new System.Drawing.Size(269, 420);
            this.pagesNamingGroupBox.TabIndex = 5;
            this.pagesNamingGroupBox.TabStop = false;
            this.pagesNamingGroupBox.Text = "Naming";
            // 
            // pagesNamingPanel
            // 
            this.pagesNamingPanel.AutoScroll = true;
            this.pagesNamingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesNamingPanel.Location = new System.Drawing.Point(3, 16);
            this.pagesNamingPanel.Name = "pagesNamingPanel";
            this.pagesNamingPanel.Size = new System.Drawing.Size(263, 401);
            this.pagesNamingPanel.TabIndex = 0;
            // 
            // textTabPage
            // 
            this.textTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.textTabPage.Controls.Add(this.textTabPageControl);
            this.textTabPage.Location = new System.Drawing.Point(4, 22);
            this.textTabPage.Name = "textTabPage";
            this.textTabPage.Size = new System.Drawing.Size(686, 420);
            this.textTabPage.TabIndex = 4;
            this.textTabPage.Text = "Text";
            // 
            // textTabPageControl
            // 
            this.textTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.textTabPageControl.Margin = new System.Windows.Forms.Padding(0);
            this.textTabPageControl.Name = "textTabPageControl";
            this.textTabPageControl.Size = new System.Drawing.Size(686, 420);
            this.textTabPageControl.TabIndex = 0;
            // 
            // entranceTabPage
            // 
            this.entranceTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.entranceTabPage.Controls.Add(this.entranceTabPageControl);
            this.entranceTabPage.Location = new System.Drawing.Point(4, 22);
            this.entranceTabPage.Name = "entranceTabPage";
            this.entranceTabPage.Size = new System.Drawing.Size(686, 420);
            this.entranceTabPage.TabIndex = 6;
            this.entranceTabPage.Text = "Entrance";
            // 
            // entranceTabPageControl
            // 
            this.entranceTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entranceTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.entranceTabPageControl.Margin = new System.Windows.Forms.Padding(0);
            this.entranceTabPageControl.Name = "entranceTabPageControl";
            this.entranceTabPageControl.Size = new System.Drawing.Size(686, 420);
            this.entranceTabPageControl.TabIndex = 0;
            // 
            // tokensTabPage
            // 
            this.tokensTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.tokensTabPage.Controls.Add(this.tokensTabPageControl);
            this.tokensTabPage.Location = new System.Drawing.Point(4, 22);
            this.tokensTabPage.Name = "tokensTabPage";
            this.tokensTabPage.Size = new System.Drawing.Size(686, 420);
            this.tokensTabPage.TabIndex = 5;
            this.tokensTabPage.Text = "Tokens";
            // 
            // tokensTabPageControl
            // 
            this.tokensTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tokensTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.tokensTabPageControl.Margin = new System.Windows.Forms.Padding(0);
            this.tokensTabPageControl.Name = "tokensTabPageControl";
            this.tokensTabPageControl.Size = new System.Drawing.Size(686, 420);
            this.tokensTabPageControl.TabIndex = 7;
            // 
            // otherTabPage
            // 
            this.otherTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.otherTabPage.Controls.Add(this.otherTabPageControl);
            this.otherTabPage.Location = new System.Drawing.Point(4, 22);
            this.otherTabPage.Name = "otherTabPage";
            this.otherTabPage.Size = new System.Drawing.Size(686, 420);
            this.otherTabPage.TabIndex = 11;
            this.otherTabPage.Text = "Other";
            // 
            // otherTabPageControl
            // 
            this.otherTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.otherTabPageControl.Margin = new System.Windows.Forms.Padding(0);
            this.otherTabPageControl.Name = "otherTabPageControl";
            this.otherTabPageControl.Size = new System.Drawing.Size(686, 420);
            this.otherTabPageControl.TabIndex = 11;
            // 
            // linksTabPage
            // 
            this.linksTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.linksTabPage.Controls.Add(this.linksTabPageControl);
            this.linksTabPage.Location = new System.Drawing.Point(4, 22);
            this.linksTabPage.Name = "linksTabPage";
            this.linksTabPage.Size = new System.Drawing.Size(686, 420);
            this.linksTabPage.TabIndex = 7;
            this.linksTabPage.Text = "Links";
            // 
            // linksTabPageControl
            // 
            this.linksTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linksTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.linksTabPageControl.Margin = new System.Windows.Forms.Padding(0);
            this.linksTabPageControl.Name = "linksTabPageControl";
            this.linksTabPageControl.Size = new System.Drawing.Size(686, 420);
            this.linksTabPageControl.TabIndex = 1;
            // 
            // FTPTabPage
            // 
            this.FTPTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.FTPTabPage.Controls.Add(this.ftpTabPageControl);
            this.FTPTabPage.Location = new System.Drawing.Point(4, 22);
            this.FTPTabPage.Name = "FTPTabPage";
            this.FTPTabPage.Size = new System.Drawing.Size(686, 420);
            this.FTPTabPage.TabIndex = 8;
            this.FTPTabPage.Text = "FTP";
            // 
            // ftpTabPageControl
            // 
            this.ftpTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ftpTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.ftpTabPageControl.Margin = new System.Windows.Forms.Padding(0);
            this.ftpTabPageControl.Name = "ftpTabPageControl";
            this.ftpTabPageControl.Size = new System.Drawing.Size(686, 420);
            this.ftpTabPageControl.TabIndex = 1;
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.okButton);
            this.actionPanel.Controls.Add(this.cancelButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 470);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(694, 23);
            this.actionPanel.TabIndex = 26;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.okButton.Location = new System.Drawing.Point(544, 0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.Location = new System.Drawing.Point(619, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButtonClick);
            // 
            // tagsTabPage
            // 
            this.tagsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.tagsTabPage.Controls.Add(this.tagsTabPageControl);
            this.tagsTabPage.Location = new System.Drawing.Point(4, 22);
            this.tagsTabPage.Name = "tagsTabPage";
            this.tagsTabPage.Size = new System.Drawing.Size(686, 420);
            this.tagsTabPage.TabIndex = 13;
            this.tagsTabPage.Text = "Tags";
            // 
            // tagsTabPageControl
            // 
            this.tagsTabPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagsTabPageControl.Location = new System.Drawing.Point(0, 0);
            this.tagsTabPageControl.Name = "tagsTabPageControl";
            this.tagsTabPageControl.Size = new System.Drawing.Size(686, 420);
            this.tagsTabPageControl.TabIndex = 0;
            // 
            // TaskWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 493);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.actionPanel);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(710, 531);
            this.Name = "TaskWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            this.Load += new System.EventHandler(this.TaskWindowLoad);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.taskTabPage.ResumeLayout(false);
            this.taskSchedulerGroupBox.ResumeLayout(false);
            this.taskSchedulerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskScheduleStepNumericUpDown)).EndInit();
            this.taskGeneralGroupBox.ResumeLayout(false);
            this.taskGeneralGroupBox.PerformLayout();
            this.generalTabPage.ResumeLayout(false);
            this.imagesTabPage.ResumeLayout(false);
            this.fileTokensTabPage.ResumeLayout(false);
            this.keywordsTabPage.ResumeLayout(false);
            this.categoriesTabPage.ResumeLayout(false);
            this.pagesTabPage.ResumeLayout(false);
            this.mapPagesSplitContainer.Panel1.ResumeLayout(false);
            this.mapPagesSplitContainer.Panel2.ResumeLayout(false);
            this.mapPagesSplitContainer.ResumeLayout(false);
            this.pagesNamingGroupBox.ResumeLayout(false);
            this.textTabPage.ResumeLayout(false);
            this.entranceTabPage.ResumeLayout(false);
            this.tokensTabPage.ResumeLayout(false);
            this.otherTabPage.ResumeLayout(false);
            this.linksTabPage.ResumeLayout(false);
            this.FTPTabPage.ResumeLayout(false);
            this.actionPanel.ResumeLayout(false);
            this.tagsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DateTimePicker taskTimeGeneralDateTimePicker;
        protected System.Windows.Forms.Label taskGeneralTimeLabel;
        protected System.Windows.Forms.TextBox taskGeneralNameTextBox;
        protected System.Windows.Forms.Label taskGeneralNameLabel;
        protected System.Windows.Forms.MenuStrip mainMenuStrip;
        protected System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem taskNewToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem taskLoadFromToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem taskSaveAsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ToolStripMenuItem taskImportFromToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        protected System.Windows.Forms.ToolStripMenuItem taskExitToolStripMenuItem;
        protected System.Windows.Forms.TabControl mainTabControl;
        protected System.Windows.Forms.TabPage generalTabPage;
        protected Umax.Plugins.Tasks.Common.Controls.TabPages.GeneralTabPageControl generalTabPageControl;
        protected System.Windows.Forms.TabPage imagesTabPage;
        protected System.Windows.Forms.TabPage keywordsTabPage;
        protected System.Windows.Forms.TabPage pagesTabPage;
        protected System.Windows.Forms.TabPage textTabPage;
        protected System.Windows.Forms.TabPage tokensTabPage;
        protected System.Windows.Forms.TabPage entranceTabPage;
        protected System.Windows.Forms.TabPage linksTabPage;
        protected System.Windows.Forms.TabPage FTPTabPage;
        protected System.Windows.Forms.TabPage taskTabPage;
        protected System.Windows.Forms.Panel actionPanel;
        protected System.Windows.Forms.Button okButton;
        protected System.Windows.Forms.Button cancelButton;
        protected System.Windows.Forms.GroupBox taskSchedulerGroupBox;
        protected System.Windows.Forms.ComboBox taskScheduleComboBox;
        protected System.Windows.Forms.NumericUpDown taskScheduleStepNumericUpDown;
        protected System.Windows.Forms.Label taskScheduleStepLabel;
        protected System.Windows.Forms.TabPage otherTabPage;
        protected System.Windows.Forms.GroupBox pagesNamingGroupBox;
        protected System.Windows.Forms.Panel pagesNamingPanel;
        protected System.Windows.Forms.GroupBox taskGeneralGroupBox;
        protected System.Windows.Forms.ToolStripMenuItem helpAboutToolStripMenuItem;
        protected System.Windows.Forms.TabPage categoriesTabPage;
        protected System.Windows.Forms.TabPage fileTokensTabPage;
        protected Controls.TabPages.FileTokensTabPageControl fileTokensTabPageControl;
        protected Controls.TabPages.OtherTabPageControl otherTabPageControl;
        protected Controls.TabPages.CategoriesTabPageControl categoriesTabPageControl;
        protected Controls.TabPages.TokensTabPageControl tokensTabPageControl;
        protected Controls.TabPages.FTPTabPageControl ftpTabPageControl;
        protected Controls.TabPages.LinksTabPageControl linksTabPageControl;
        protected Controls.TabPages.EntranceTabPageControl entranceTabPageControl;
        protected Controls.TabPages.TextTabPageControl textTabPageControl;
        protected Controls.TabPages.ImagesTabPageControl imagesTabPageControl;
        protected System.ComponentModel.IContainer components;
        private Controls.TabPages.KeywordsTabPageControl keywordsTabPageControl;
        private System.Windows.Forms.SplitContainer mapPagesSplitContainer;
        private Controls.TabPages.MapTabPageControl mapTabPageControl;
        private Controls.TabPages.PagesTabPageControl pagesTabPageControl;
        private System.Windows.Forms.TabPage tagsTabPage;
        private Controls.TabPages.TagsTabPageControl tagsTabPageControl;
    }
}