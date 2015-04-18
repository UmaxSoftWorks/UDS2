using System.Windows.Forms;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    partial class TokensTabPageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainLinkTabPage = new System.Windows.Forms.TabPage();
            this.mainLinkSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainLinkComboBox = new System.Windows.Forms.ComboBox();
            this.mainLinkDataGridView = new System.Windows.Forms.DataGridView();
            this.mainLinkContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainLinkToolStrip = new System.Windows.Forms.ToolStrip();
            this.mainLinkOpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainLinkClearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.titleTabPage = new System.Windows.Forms.TabPage();
            this.titleDataGridView = new System.Windows.Forms.DataGridView();
            this.titleContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleToolStrip = new System.Windows.Forms.ToolStrip();
            this.titleOpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.titleClearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.siteTabPage = new System.Windows.Forms.TabPage();
            this.siteDataGridView = new System.Windows.Forms.DataGridView();
            this.siteContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteToolStrip = new System.Windows.Forms.ToolStrip();
            this.siteOpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.siteClearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.counterTabPage = new System.Windows.Forms.TabPage();
            this.counterDataGridView = new System.Windows.Forms.DataGridView();
            this.counterContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterToolStrip = new System.Windows.Forms.ToolStrip();
            this.counterOpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.counterClearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.externalLinksTabPage = new System.Windows.Forms.TabPage();
            this.externalLinksTabControl = new System.Windows.Forms.TabControl();
            this.externalLinksInternalTabPage = new System.Windows.Forms.TabPage();
            this.internalLinksDataGridView = new System.Windows.Forms.DataGridView();
            this.externalLinksInternalContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internalLinksToolStrip = new System.Windows.Forms.ToolStrip();
            this.internalLinksOpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.internalLinksClearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.externalLinksExternalTabPage = new System.Windows.Forms.TabPage();
            this.externalLinksDataGridView = new System.Windows.Forms.DataGridView();
            this.ExternalLinksUrlColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.externalLinksContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.externalLinksToolStrip = new System.Windows.Forms.ToolStrip();
            this.externalLinksAddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.externalLinksRemoveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.externalLinksOpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.externalLinksClearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl.SuspendLayout();
            this.mainLinkTabPage.SuspendLayout();
            this.mainLinkSplitContainer.Panel1.SuspendLayout();
            this.mainLinkSplitContainer.Panel2.SuspendLayout();
            this.mainLinkSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLinkDataGridView)).BeginInit();
            this.mainLinkToolStrip.SuspendLayout();
            this.titleTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleDataGridView)).BeginInit();
            this.titleToolStrip.SuspendLayout();
            this.siteTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siteDataGridView)).BeginInit();
            this.siteToolStrip.SuspendLayout();
            this.counterTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.counterDataGridView)).BeginInit();
            this.counterToolStrip.SuspendLayout();
            this.externalLinksTabPage.SuspendLayout();
            this.externalLinksTabControl.SuspendLayout();
            this.externalLinksInternalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internalLinksDataGridView)).BeginInit();
            this.internalLinksToolStrip.SuspendLayout();
            this.externalLinksExternalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.externalLinksDataGridView)).BeginInit();
            this.externalLinksToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.mainLinkTabPage);
            this.mainTabControl.Controls.Add(this.titleTabPage);
            this.mainTabControl.Controls.Add(this.siteTabPage);
            this.mainTabControl.Controls.Add(this.counterTabPage);
            this.mainTabControl.Controls.Add(this.externalLinksTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(686, 420);
            this.mainTabControl.TabIndex = 7;
            // 
            // mainLinkTabPage
            // 
            this.mainLinkTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.mainLinkTabPage.Controls.Add(this.mainLinkSplitContainer);
            this.mainLinkTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainLinkTabPage.Name = "mainLinkTabPage";
            this.mainLinkTabPage.Size = new System.Drawing.Size(678, 394);
            this.mainLinkTabPage.TabIndex = 0;
            this.mainLinkTabPage.Text = "[MainLink]";
            // 
            // mainLinkSplitContainer
            // 
            this.mainLinkSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLinkSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainLinkSplitContainer.IsSplitterFixed = true;
            this.mainLinkSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainLinkSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainLinkSplitContainer.Name = "mainLinkSplitContainer";
            this.mainLinkSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainLinkSplitContainer.Panel1
            // 
            this.mainLinkSplitContainer.Panel1.Controls.Add(this.mainLinkComboBox);
            // 
            // mainLinkSplitContainer.Panel2
            // 
            this.mainLinkSplitContainer.Panel2.Controls.Add(this.mainLinkDataGridView);
            this.mainLinkSplitContainer.Panel2.Controls.Add(this.mainLinkToolStrip);
            this.mainLinkSplitContainer.Size = new System.Drawing.Size(678, 394);
            this.mainLinkSplitContainer.SplitterDistance = 25;
            this.mainLinkSplitContainer.TabIndex = 3;
            // 
            // mainLinkComboBox
            // 
            this.mainLinkComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainLinkComboBox.FormattingEnabled = true;
            this.mainLinkComboBox.Items.AddRange(new object[] {
            "Full URL",
            "/",
            "index",
            "Other"});
            this.mainLinkComboBox.Location = new System.Drawing.Point(3, 3);
            this.mainLinkComboBox.Name = "mainLinkComboBox";
            this.mainLinkComboBox.Size = new System.Drawing.Size(188, 21);
            this.mainLinkComboBox.TabIndex = 0;
            this.mainLinkComboBox.SelectedIndexChanged += new System.EventHandler(this.mainLinkComboBoxSelectedIndexChanged);
            // 
            // mainLinkDataGridView
            // 
            this.mainLinkDataGridView.AllowUserToAddRows = false;
            this.mainLinkDataGridView.AllowUserToDeleteRows = false;
            this.mainLinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainLinkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mainLinkContentColumn});
            this.mainLinkDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLinkDataGridView.Location = new System.Drawing.Point(0, 0);
            this.mainLinkDataGridView.MultiSelect = false;
            this.mainLinkDataGridView.Name = "mainLinkDataGridView";
            this.mainLinkDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainLinkDataGridView.Size = new System.Drawing.Size(654, 365);
            this.mainLinkDataGridView.TabIndex = 2;
            // 
            // mainLinkContentColumn
            // 
            this.mainLinkContentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mainLinkContentColumn.HeaderText = "Content";
            this.mainLinkContentColumn.Name = "mainLinkContentColumn";
            // 
            // mainLinkToolStrip
            // 
            this.mainLinkToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainLinkToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainLinkOpenToolStripButton,
            this.mainLinkClearToolStripButton});
            this.mainLinkToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.mainLinkToolStrip.Location = new System.Drawing.Point(654, 0);
            this.mainLinkToolStrip.Name = "mainLinkToolStrip";
            this.mainLinkToolStrip.Size = new System.Drawing.Size(24, 365);
            this.mainLinkToolStrip.TabIndex = 3;
            // 
            // mainLinkOpenToolStripButton
            // 
            this.mainLinkOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainLinkOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainLinkOpenToolStripButton.Name = "mainLinkOpenToolStripButton";
            this.mainLinkOpenToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.mainLinkOpenToolStripButton.Text = "Open";
            this.mainLinkOpenToolStripButton.Click += new System.EventHandler(this.mainLinkOpenToolStripButtonClick);
            // 
            // mainLinkClearToolStripButton
            // 
            this.mainLinkClearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainLinkClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainLinkClearToolStripButton.Name = "mainLinkClearToolStripButton";
            this.mainLinkClearToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.mainLinkClearToolStripButton.Text = "Clear";
            this.mainLinkClearToolStripButton.Click += new System.EventHandler(this.mainLinkClearToolStripButtonClick);
            // 
            // titleTabPage
            // 
            this.titleTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.titleTabPage.Controls.Add(this.titleDataGridView);
            this.titleTabPage.Controls.Add(this.titleToolStrip);
            this.titleTabPage.Location = new System.Drawing.Point(4, 22);
            this.titleTabPage.Name = "titleTabPage";
            this.titleTabPage.Size = new System.Drawing.Size(678, 394);
            this.titleTabPage.TabIndex = 1;
            this.titleTabPage.Text = "[Title]";
            // 
            // titleDataGridView
            // 
            this.titleDataGridView.AllowUserToAddRows = false;
            this.titleDataGridView.AllowUserToDeleteRows = false;
            this.titleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.titleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleContentColumn});
            this.titleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.titleDataGridView.MultiSelect = false;
            this.titleDataGridView.Name = "titleDataGridView";
            this.titleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.titleDataGridView.Size = new System.Drawing.Size(654, 394);
            this.titleDataGridView.TabIndex = 3;
            // 
            // titleContentColumn
            // 
            this.titleContentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleContentColumn.HeaderText = "Content";
            this.titleContentColumn.Name = "titleContentColumn";
            // 
            // titleToolStrip
            // 
            this.titleToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.titleToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleOpenToolStripButton,
            this.titleClearToolStripButton});
            this.titleToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.titleToolStrip.Location = new System.Drawing.Point(654, 0);
            this.titleToolStrip.Name = "titleToolStrip";
            this.titleToolStrip.Size = new System.Drawing.Size(24, 394);
            this.titleToolStrip.TabIndex = 4;
            // 
            // titleOpenToolStripButton
            // 
            this.titleOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.titleOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.titleOpenToolStripButton.Name = "titleOpenToolStripButton";
            this.titleOpenToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.titleOpenToolStripButton.Text = "Open";
            this.titleOpenToolStripButton.Click += new System.EventHandler(this.titleOpenToolStripButtonClick);
            // 
            // titleClearToolStripButton
            // 
            this.titleClearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.titleClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.titleClearToolStripButton.Name = "titleClearToolStripButton";
            this.titleClearToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.titleClearToolStripButton.Text = "Clear";
            this.titleClearToolStripButton.Click += new System.EventHandler(this.titleClearToolStripButtonClick);
            // 
            // siteTabPage
            // 
            this.siteTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.siteTabPage.Controls.Add(this.siteDataGridView);
            this.siteTabPage.Controls.Add(this.siteToolStrip);
            this.siteTabPage.Location = new System.Drawing.Point(4, 22);
            this.siteTabPage.Name = "siteTabPage";
            this.siteTabPage.Size = new System.Drawing.Size(678, 394);
            this.siteTabPage.TabIndex = 2;
            this.siteTabPage.Text = "[Site]";
            // 
            // siteDataGridView
            // 
            this.siteDataGridView.AllowUserToAddRows = false;
            this.siteDataGridView.AllowUserToDeleteRows = false;
            this.siteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siteContentColumn});
            this.siteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siteDataGridView.Location = new System.Drawing.Point(0, 0);
            this.siteDataGridView.MultiSelect = false;
            this.siteDataGridView.Name = "siteDataGridView";
            this.siteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.siteDataGridView.Size = new System.Drawing.Size(654, 394);
            this.siteDataGridView.TabIndex = 5;
            // 
            // siteContentColumn
            // 
            this.siteContentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.siteContentColumn.HeaderText = "Content";
            this.siteContentColumn.Name = "siteContentColumn";
            // 
            // siteToolStrip
            // 
            this.siteToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.siteToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siteOpenToolStripButton,
            this.siteClearToolStripButton});
            this.siteToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.siteToolStrip.Location = new System.Drawing.Point(654, 0);
            this.siteToolStrip.Name = "siteToolStrip";
            this.siteToolStrip.Size = new System.Drawing.Size(24, 394);
            this.siteToolStrip.TabIndex = 6;
            // 
            // siteOpenToolStripButton
            // 
            this.siteOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.siteOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.siteOpenToolStripButton.Name = "siteOpenToolStripButton";
            this.siteOpenToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.siteOpenToolStripButton.Text = "Open";
            this.siteOpenToolStripButton.Click += new System.EventHandler(this.siteOpenToolStripButtonClick);
            // 
            // siteClearToolStripButton
            // 
            this.siteClearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.siteClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.siteClearToolStripButton.Name = "siteClearToolStripButton";
            this.siteClearToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.siteClearToolStripButton.Text = "toolStripButton2";
            this.siteClearToolStripButton.Click += new System.EventHandler(this.siteClearToolStripButtonClick);
            // 
            // counterTabPage
            // 
            this.counterTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.counterTabPage.Controls.Add(this.counterDataGridView);
            this.counterTabPage.Controls.Add(this.counterToolStrip);
            this.counterTabPage.Location = new System.Drawing.Point(4, 22);
            this.counterTabPage.Name = "counterTabPage";
            this.counterTabPage.Size = new System.Drawing.Size(678, 394);
            this.counterTabPage.TabIndex = 3;
            this.counterTabPage.Text = "[Counter]";
            // 
            // counterDataGridView
            // 
            this.counterDataGridView.AllowUserToAddRows = false;
            this.counterDataGridView.AllowUserToDeleteRows = false;
            this.counterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.counterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.counterContentColumn});
            this.counterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.counterDataGridView.Location = new System.Drawing.Point(0, 0);
            this.counterDataGridView.MultiSelect = false;
            this.counterDataGridView.Name = "counterDataGridView";
            this.counterDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.counterDataGridView.Size = new System.Drawing.Size(654, 394);
            this.counterDataGridView.TabIndex = 5;
            // 
            // counterContentColumn
            // 
            this.counterContentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.counterContentColumn.HeaderText = "Content";
            this.counterContentColumn.Name = "counterContentColumn";
            // 
            // counterToolStrip
            // 
            this.counterToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.counterToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.counterOpenToolStripButton,
            this.counterClearToolStripButton});
            this.counterToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.counterToolStrip.Location = new System.Drawing.Point(654, 0);
            this.counterToolStrip.Name = "counterToolStrip";
            this.counterToolStrip.Size = new System.Drawing.Size(24, 394);
            this.counterToolStrip.TabIndex = 6;
            // 
            // counterOpenToolStripButton
            // 
            this.counterOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.counterOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.counterOpenToolStripButton.Name = "counterOpenToolStripButton";
            this.counterOpenToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.counterOpenToolStripButton.Text = "Open";
            this.counterOpenToolStripButton.Click += new System.EventHandler(this.counterOpenToolStripButtonClick);
            // 
            // counterClearToolStripButton
            // 
            this.counterClearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.counterClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.counterClearToolStripButton.Name = "counterClearToolStripButton";
            this.counterClearToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.counterClearToolStripButton.Text = "Clear";
            this.counterClearToolStripButton.Click += new System.EventHandler(this.counterClearToolStripButtonClick);
            // 
            // externalLinksTabPage
            // 
            this.externalLinksTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.externalLinksTabPage.Controls.Add(this.externalLinksTabControl);
            this.externalLinksTabPage.Location = new System.Drawing.Point(4, 22);
            this.externalLinksTabPage.Name = "externalLinksTabPage";
            this.externalLinksTabPage.Size = new System.Drawing.Size(678, 394);
            this.externalLinksTabPage.TabIndex = 4;
            this.externalLinksTabPage.Text = "External Links";
            // 
            // externalLinksTabControl
            // 
            this.externalLinksTabControl.Controls.Add(this.externalLinksInternalTabPage);
            this.externalLinksTabControl.Controls.Add(this.externalLinksExternalTabPage);
            this.externalLinksTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.externalLinksTabControl.Location = new System.Drawing.Point(0, 0);
            this.externalLinksTabControl.Name = "externalLinksTabControl";
            this.externalLinksTabControl.SelectedIndex = 0;
            this.externalLinksTabControl.Size = new System.Drawing.Size(678, 394);
            this.externalLinksTabControl.TabIndex = 0;
            // 
            // externalLinksInternalTabPage
            // 
            this.externalLinksInternalTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.externalLinksInternalTabPage.Controls.Add(this.internalLinksDataGridView);
            this.externalLinksInternalTabPage.Controls.Add(this.internalLinksToolStrip);
            this.externalLinksInternalTabPage.Location = new System.Drawing.Point(4, 22);
            this.externalLinksInternalTabPage.Name = "externalLinksInternalTabPage";
            this.externalLinksInternalTabPage.Size = new System.Drawing.Size(670, 368);
            this.externalLinksInternalTabPage.TabIndex = 0;
            this.externalLinksInternalTabPage.Text = "InTask";
            // 
            // internalLinksDataGridView
            // 
            this.internalLinksDataGridView.AllowUserToAddRows = false;
            this.internalLinksDataGridView.AllowUserToDeleteRows = false;
            this.internalLinksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.internalLinksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.externalLinksInternalContentColumn});
            this.internalLinksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.internalLinksDataGridView.Location = new System.Drawing.Point(0, 0);
            this.internalLinksDataGridView.MultiSelect = false;
            this.internalLinksDataGridView.Name = "internalLinksDataGridView";
            this.internalLinksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.internalLinksDataGridView.Size = new System.Drawing.Size(646, 368);
            this.internalLinksDataGridView.TabIndex = 6;
            // 
            // externalLinksInternalContentColumn
            // 
            this.externalLinksInternalContentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.externalLinksInternalContentColumn.HeaderText = "Content";
            this.externalLinksInternalContentColumn.Name = "externalLinksInternalContentColumn";
            // 
            // internalLinksToolStrip
            // 
            this.internalLinksToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.internalLinksToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internalLinksOpenToolStripButton,
            this.internalLinksClearToolStripButton});
            this.internalLinksToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.internalLinksToolStrip.Location = new System.Drawing.Point(646, 0);
            this.internalLinksToolStrip.Name = "internalLinksToolStrip";
            this.internalLinksToolStrip.Size = new System.Drawing.Size(24, 368);
            this.internalLinksToolStrip.TabIndex = 7;
            // 
            // internalLinksOpenToolStripButton
            // 
            this.internalLinksOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.internalLinksOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.internalLinksOpenToolStripButton.Name = "internalLinksOpenToolStripButton";
            this.internalLinksOpenToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.internalLinksOpenToolStripButton.Text = "Open";
            this.internalLinksOpenToolStripButton.Click += new System.EventHandler(this.internalLinksOpenToolStripButtonClick);
            // 
            // internalLinksClearToolStripButton
            // 
            this.internalLinksClearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.internalLinksClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.internalLinksClearToolStripButton.Name = "internalLinksClearToolStripButton";
            this.internalLinksClearToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.internalLinksClearToolStripButton.Text = "Clear";
            this.internalLinksClearToolStripButton.Click += new System.EventHandler(this.internalLinksClearToolStripButtonClick);
            // 
            // externalLinksExternalTabPage
            // 
            this.externalLinksExternalTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.externalLinksExternalTabPage.Controls.Add(this.externalLinksDataGridView);
            this.externalLinksExternalTabPage.Controls.Add(this.externalLinksToolStrip);
            this.externalLinksExternalTabPage.Location = new System.Drawing.Point(4, 22);
            this.externalLinksExternalTabPage.Name = "externalLinksExternalTabPage";
            this.externalLinksExternalTabPage.Size = new System.Drawing.Size(670, 368);
            this.externalLinksExternalTabPage.TabIndex = 1;
            this.externalLinksExternalTabPage.Text = "External";
            // 
            // externalLinksDataGridView
            // 
            this.externalLinksDataGridView.AllowUserToAddRows = false;
            this.externalLinksDataGridView.AllowUserToDeleteRows = false;
            this.externalLinksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.externalLinksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExternalLinksUrlColumn,
            this.externalLinksContentColumn});
            this.externalLinksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.externalLinksDataGridView.Location = new System.Drawing.Point(0, 0);
            this.externalLinksDataGridView.MultiSelect = false;
            this.externalLinksDataGridView.Name = "externalLinksDataGridView";
            this.externalLinksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.externalLinksDataGridView.Size = new System.Drawing.Size(646, 368);
            this.externalLinksDataGridView.TabIndex = 6;
            // 
            // ExternalLinksUrlColumn
            // 
            this.ExternalLinksUrlColumn.HeaderText = "URL";
            this.ExternalLinksUrlColumn.Name = "ExternalLinksUrlColumn";
            this.ExternalLinksUrlColumn.Width = 200;
            // 
            // externalLinksContentColumn
            // 
            this.externalLinksContentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.externalLinksContentColumn.HeaderText = "Content";
            this.externalLinksContentColumn.Name = "externalLinksContentColumn";
            // 
            // externalLinksToolStrip
            // 
            this.externalLinksToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.externalLinksToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.externalLinksAddToolStripButton,
            this.externalLinksRemoveToolStripButton,
            this.externalLinksOpenToolStripButton,
            this.externalLinksClearToolStripButton});
            this.externalLinksToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.externalLinksToolStrip.Location = new System.Drawing.Point(646, 0);
            this.externalLinksToolStrip.Name = "externalLinksToolStrip";
            this.externalLinksToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.externalLinksToolStrip.Size = new System.Drawing.Size(24, 368);
            this.externalLinksToolStrip.TabIndex = 7;
            // 
            // externalLinksAddToolStripButton
            // 
            this.externalLinksAddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.externalLinksAddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.externalLinksAddToolStripButton.Name = "externalLinksAddToolStripButton";
            this.externalLinksAddToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.externalLinksAddToolStripButton.Text = "Add";
            this.externalLinksAddToolStripButton.Click += new System.EventHandler(this.externalLinksAddToolStripButtonClick);
            // 
            // externalLinksRemoveToolStripButton
            // 
            this.externalLinksRemoveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.externalLinksRemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.externalLinksRemoveToolStripButton.Name = "externalLinksRemoveToolStripButton";
            this.externalLinksRemoveToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.externalLinksRemoveToolStripButton.Text = "Remove";
            this.externalLinksRemoveToolStripButton.Click += new System.EventHandler(this.externalLinksRemoveToolStripButtonClick);
            // 
            // externalLinksOpenToolStripButton
            // 
            this.externalLinksOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.externalLinksOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.externalLinksOpenToolStripButton.Name = "externalLinksOpenToolStripButton";
            this.externalLinksOpenToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.externalLinksOpenToolStripButton.Text = "Open";
            this.externalLinksOpenToolStripButton.Click += new System.EventHandler(this.externalLinksOpenToolStripButtonClick);
            // 
            // externalLinksClearToolStripButton
            // 
            this.externalLinksClearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.externalLinksClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.externalLinksClearToolStripButton.Name = "externalLinksClearToolStripButton";
            this.externalLinksClearToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.externalLinksClearToolStripButton.Text = "Clear";
            this.externalLinksClearToolStripButton.Click += new System.EventHandler(this.externalLinksClearToolStripButtonClick);
            // 
            // TokensTabPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTabControl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TokensTabPageControl";
            this.Size = new System.Drawing.Size(686, 420);
            this.Load += new System.EventHandler(this.TokensTabPageControlLoad);
            this.mainTabControl.ResumeLayout(false);
            this.mainLinkTabPage.ResumeLayout(false);
            this.mainLinkSplitContainer.Panel1.ResumeLayout(false);
            this.mainLinkSplitContainer.Panel2.ResumeLayout(false);
            this.mainLinkSplitContainer.Panel2.PerformLayout();
            this.mainLinkSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainLinkDataGridView)).EndInit();
            this.mainLinkToolStrip.ResumeLayout(false);
            this.mainLinkToolStrip.PerformLayout();
            this.titleTabPage.ResumeLayout(false);
            this.titleTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleDataGridView)).EndInit();
            this.titleToolStrip.ResumeLayout(false);
            this.titleToolStrip.PerformLayout();
            this.siteTabPage.ResumeLayout(false);
            this.siteTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siteDataGridView)).EndInit();
            this.siteToolStrip.ResumeLayout(false);
            this.siteToolStrip.PerformLayout();
            this.counterTabPage.ResumeLayout(false);
            this.counterTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.counterDataGridView)).EndInit();
            this.counterToolStrip.ResumeLayout(false);
            this.counterToolStrip.PerformLayout();
            this.externalLinksTabPage.ResumeLayout(false);
            this.externalLinksTabControl.ResumeLayout(false);
            this.externalLinksInternalTabPage.ResumeLayout(false);
            this.externalLinksInternalTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internalLinksDataGridView)).EndInit();
            this.internalLinksToolStrip.ResumeLayout(false);
            this.internalLinksToolStrip.PerformLayout();
            this.externalLinksExternalTabPage.ResumeLayout(false);
            this.externalLinksExternalTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.externalLinksDataGridView)).EndInit();
            this.externalLinksToolStrip.ResumeLayout(false);
            this.externalLinksToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl mainTabControl;
        protected System.Windows.Forms.TabPage mainLinkTabPage;
        protected System.Windows.Forms.DataGridView mainLinkDataGridView;
        protected System.Windows.Forms.DataGridViewTextBoxColumn mainLinkColumn;
        protected System.Windows.Forms.ComboBox mainLinkComboBox;
        protected System.Windows.Forms.TabPage titleTabPage;
        protected System.Windows.Forms.DataGridView titleDataGridView;
        protected System.Windows.Forms.DataGridViewTextBoxColumn titleColumn;
        protected System.Windows.Forms.TabPage siteTabPage;
        protected System.Windows.Forms.DataGridView siteDataGridView;
        protected System.Windows.Forms.DataGridViewTextBoxColumn siteColumn;
        protected System.Windows.Forms.TabPage counterTabPage;
        protected System.Windows.Forms.DataGridView counterDataGridView;
        protected System.Windows.Forms.DataGridViewTextBoxColumn counterColumn;
        protected System.Windows.Forms.TabPage externalLinksTabPage;
        protected System.Windows.Forms.TabControl externalLinksTabControl;
        protected System.Windows.Forms.TabPage externalLinksInternalTabPage;
        protected System.Windows.Forms.DataGridView internalLinksDataGridView;
        protected System.Windows.Forms.TabPage externalLinksExternalTabPage;
        protected System.Windows.Forms.DataGridView externalLinksDataGridView;
        protected System.Windows.Forms.ToolStrip externalLinksToolStrip;
        protected System.Windows.Forms.ToolStripButton externalLinksAddToolStripButton;
        protected System.Windows.Forms.ToolStripButton externalLinksRemoveToolStripButton;
        protected System.Windows.Forms.ToolStripButton externalLinksClearToolStripButton;
        protected System.Windows.Forms.DataGridViewTextBoxColumn mainLinkContentColumn;
        protected System.Windows.Forms.DataGridViewTextBoxColumn titleContentColumn;
        protected System.Windows.Forms.DataGridViewTextBoxColumn siteContentColumn;
        protected System.Windows.Forms.DataGridViewTextBoxColumn counterContentColumn;
        protected System.Windows.Forms.SplitContainer mainLinkSplitContainer;
        protected DataGridViewTextBoxColumn externalLinksInternalContentColumn;
        protected DataGridViewTextBoxColumn externalLinksUrlColumn;
        protected DataGridViewTextBoxColumn externalLinksContentColumn;
        protected ToolStrip mainLinkToolStrip;
        protected ToolStripButton mainLinkOpenToolStripButton;
        protected ToolStripButton mainLinkClearToolStripButton;
        protected ToolStrip titleToolStrip;
        protected ToolStripButton titleOpenToolStripButton;
        protected ToolStripButton titleClearToolStripButton;
        protected ToolStrip siteToolStrip;
        protected ToolStripButton siteOpenToolStripButton;
        protected ToolStripButton siteClearToolStripButton;
        protected ToolStrip counterToolStrip;
        protected ToolStripButton counterOpenToolStripButton;
        protected ToolStripButton counterClearToolStripButton;
        protected ToolStrip internalLinksToolStrip;
        protected ToolStripButton internalLinksOpenToolStripButton;
        protected ToolStripButton internalLinksClearToolStripButton;
        protected ToolStripButton externalLinksOpenToolStripButton;
        protected OpenFileDialog mainOpenFileDialog;
        protected DataGridViewTextBoxColumn ExternalLinksUrlColumn;
    }
}
