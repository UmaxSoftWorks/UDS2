namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    partial class GeneralTabPageControl
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.archiveGroupBox = new System.Windows.Forms.GroupBox();
            this.archiveComboBox = new System.Windows.Forms.ComboBox();
            this.archiveTextBox = new System.Windows.Forms.TextBox();
            this.saveGroupBox = new System.Windows.Forms.GroupBox();
            this.saveSubDirectoriesComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveTextBox = new System.Windows.Forms.TextBox();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.presetClearPictureBox = new System.Windows.Forms.PictureBox();
            this.presetComboBox = new System.Windows.Forms.ComboBox();
            this.presetLabel = new System.Windows.Forms.Label();
            this.templateComboBox = new System.Windows.Forms.ComboBox();
            this.templateLabel = new System.Windows.Forms.Label();
            this.wsComboBox = new System.Windows.Forms.ComboBox();
            this.wsLabel = new System.Windows.Forms.Label();
            this.generationGroupBox = new System.Windows.Forms.GroupBox();
            this.generationThreadsLabel = new System.Windows.Forms.Label();
            this.threadsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sitesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generationSitesLabel = new System.Windows.Forms.Label();
            this.urlsGroupBox = new System.Windows.Forms.GroupBox();
            this.urlsDataGridView = new System.Windows.Forms.DataGridView();
            this.UrlsUrlColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlsToolStrip = new System.Windows.Forms.ToolStrip();
            this.urlsOpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.urlsClearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dateTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimeStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStartLabel = new System.Windows.Forms.Label();
            this.dateTimeEndLabel = new System.Windows.Forms.Label();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.archiveGroupBox.SuspendLayout();
            this.saveGroupBox.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presetClearPictureBox)).BeginInit();
            this.generationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitesNumericUpDown)).BeginInit();
            this.urlsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlsDataGridView)).BeginInit();
            this.urlsToolStrip.SuspendLayout();
            this.dateTimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.archiveGroupBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.dateTimeGroupBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.saveGroupBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.dataGroupBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.generationGroupBox);
            this.mainSplitContainer.Panel1MinSize = 0;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.urlsGroupBox);
            this.mainSplitContainer.Panel2MinSize = 0;
            this.mainSplitContainer.Size = new System.Drawing.Size(686, 420);
            this.mainSplitContainer.SplitterDistance = 320;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // archiveGroupBox
            // 
            this.archiveGroupBox.Controls.Add(this.archiveComboBox);
            this.archiveGroupBox.Controls.Add(this.archiveTextBox);
            this.archiveGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.archiveGroupBox.Location = new System.Drawing.Point(0, 321);
            this.archiveGroupBox.Name = "archiveGroupBox";
            this.archiveGroupBox.Size = new System.Drawing.Size(320, 49);
            this.archiveGroupBox.TabIndex = 4;
            this.archiveGroupBox.TabStop = false;
            this.archiveGroupBox.Text = "Archiving";
            // 
            // archiveComboBox
            // 
            this.archiveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.archiveComboBox.FormattingEnabled = true;
            this.archiveComboBox.Items.AddRange(new object[] {
            "None",
            "Zip",
            "Tar.gz"});
            this.archiveComboBox.Location = new System.Drawing.Point(6, 19);
            this.archiveComboBox.Name = "archiveComboBox";
            this.archiveComboBox.Size = new System.Drawing.Size(95, 21);
            this.archiveComboBox.TabIndex = 2;
            this.archiveComboBox.SelectedIndexChanged += new System.EventHandler(this.archiveComboBoxSelectedIndexChanged);
            // 
            // archiveTextBox
            // 
            this.archiveTextBox.Enabled = false;
            this.archiveTextBox.Location = new System.Drawing.Point(149, 20);
            this.archiveTextBox.Name = "archiveTextBox";
            this.archiveTextBox.Size = new System.Drawing.Size(165, 20);
            this.archiveTextBox.TabIndex = 1;
            // 
            // saveGroupBox
            // 
            this.saveGroupBox.Controls.Add(this.saveSubDirectoriesComboBox);
            this.saveGroupBox.Controls.Add(this.saveButton);
            this.saveGroupBox.Controls.Add(this.saveTextBox);
            this.saveGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveGroupBox.Location = new System.Drawing.Point(0, 174);
            this.saveGroupBox.Name = "saveGroupBox";
            this.saveGroupBox.Size = new System.Drawing.Size(320, 74);
            this.saveGroupBox.TabIndex = 2;
            this.saveGroupBox.TabStop = false;
            this.saveGroupBox.Text = "Save";
            // 
            // saveSubDirectoriesComboBox
            // 
            this.saveSubDirectoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saveSubDirectoriesComboBox.FormattingEnabled = true;
            this.saveSubDirectoriesComboBox.Items.AddRange(new object[] {
            "None",
            "Keyword",
            "Number",
            "Keyword + Number",
            "URL"});
            this.saveSubDirectoriesComboBox.Location = new System.Drawing.Point(5, 45);
            this.saveSubDirectoriesComboBox.Name = "saveSubDirectoriesComboBox";
            this.saveSubDirectoriesComboBox.Size = new System.Drawing.Size(165, 21);
            this.saveSubDirectoriesComboBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(282, 43);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(32, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            // 
            // saveTextBox
            // 
            this.saveTextBox.Location = new System.Drawing.Point(5, 19);
            this.saveTextBox.Name = "saveTextBox";
            this.saveTextBox.Size = new System.Drawing.Size(309, 20);
            this.saveTextBox.TabIndex = 0;
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.presetClearPictureBox);
            this.dataGroupBox.Controls.Add(this.presetComboBox);
            this.dataGroupBox.Controls.Add(this.presetLabel);
            this.dataGroupBox.Controls.Add(this.templateComboBox);
            this.dataGroupBox.Controls.Add(this.templateLabel);
            this.dataGroupBox.Controls.Add(this.wsComboBox);
            this.dataGroupBox.Controls.Add(this.wsLabel);
            this.dataGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGroupBox.Location = new System.Drawing.Point(0, 72);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(320, 102);
            this.dataGroupBox.TabIndex = 1;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Data";
            // 
            // presetClearPictureBox
            // 
            this.presetClearPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.presetClearPictureBox.Location = new System.Drawing.Point(293, 46);
            this.presetClearPictureBox.Name = "presetClearPictureBox";
            this.presetClearPictureBox.Size = new System.Drawing.Size(21, 21);
            this.presetClearPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.presetClearPictureBox.TabIndex = 10;
            this.presetClearPictureBox.TabStop = false;
            this.presetClearPictureBox.Click += new System.EventHandler(this.presetClearPictureBoxClick);
            // 
            // presetComboBox
            // 
            this.presetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetComboBox.FormattingEnabled = true;
            this.presetComboBox.Location = new System.Drawing.Point(118, 46);
            this.presetComboBox.Name = "presetComboBox";
            this.presetComboBox.Size = new System.Drawing.Size(169, 21);
            this.presetComboBox.TabIndex = 5;
            this.presetComboBox.SelectedIndexChanged += new System.EventHandler(this.presetComboBoxSelectedIndexChanged);
            this.presetComboBox.Click += new System.EventHandler(this.presetComboBoxSelectedIndexChanged);
            // 
            // presetLabel
            // 
            this.presetLabel.AutoSize = true;
            this.presetLabel.Location = new System.Drawing.Point(6, 49);
            this.presetLabel.Name = "presetLabel";
            this.presetLabel.Size = new System.Drawing.Size(37, 13);
            this.presetLabel.TabIndex = 4;
            this.presetLabel.Text = "Preset";
            // 
            // templateComboBox
            // 
            this.templateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.templateComboBox.FormattingEnabled = true;
            this.templateComboBox.Location = new System.Drawing.Point(118, 73);
            this.templateComboBox.Name = "templateComboBox";
            this.templateComboBox.Size = new System.Drawing.Size(196, 21);
            this.templateComboBox.TabIndex = 3;
            this.templateComboBox.SelectedIndexChanged += new System.EventHandler(this.templateComboBoxSelectedIndexChanged);
            this.templateComboBox.Click += new System.EventHandler(this.templateComboBoxSelectedIndexChanged);
            // 
            // templateLabel
            // 
            this.templateLabel.AutoSize = true;
            this.templateLabel.Location = new System.Drawing.Point(6, 76);
            this.templateLabel.Name = "templateLabel";
            this.templateLabel.Size = new System.Drawing.Size(51, 13);
            this.templateLabel.TabIndex = 2;
            this.templateLabel.Text = "Template";
            // 
            // wsComboBox
            // 
            this.wsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wsComboBox.FormattingEnabled = true;
            this.wsComboBox.Location = new System.Drawing.Point(118, 19);
            this.wsComboBox.Name = "wsComboBox";
            this.wsComboBox.Size = new System.Drawing.Size(196, 21);
            this.wsComboBox.TabIndex = 1;
            this.wsComboBox.SelectedIndexChanged += new System.EventHandler(this.wsComboBoxSelectedIndexChanged);
            this.wsComboBox.Click += new System.EventHandler(this.wsComboBoxSelectedIndexChanged);
            // 
            // wsLabel
            // 
            this.wsLabel.AutoSize = true;
            this.wsLabel.Location = new System.Drawing.Point(6, 22);
            this.wsLabel.Name = "wsLabel";
            this.wsLabel.Size = new System.Drawing.Size(64, 13);
            this.wsLabel.TabIndex = 0;
            this.wsLabel.Text = "WorkSpace";
            // 
            // generationGroupBox
            // 
            this.generationGroupBox.Controls.Add(this.generationThreadsLabel);
            this.generationGroupBox.Controls.Add(this.threadsNumericUpDown);
            this.generationGroupBox.Controls.Add(this.sitesNumericUpDown);
            this.generationGroupBox.Controls.Add(this.generationSitesLabel);
            this.generationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.generationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.generationGroupBox.Name = "generationGroupBox";
            this.generationGroupBox.Size = new System.Drawing.Size(320, 72);
            this.generationGroupBox.TabIndex = 0;
            this.generationGroupBox.TabStop = false;
            this.generationGroupBox.Text = "Generation";
            // 
            // generationThreadsLabel
            // 
            this.generationThreadsLabel.AutoSize = true;
            this.generationThreadsLabel.Location = new System.Drawing.Point(6, 47);
            this.generationThreadsLabel.Name = "generationThreadsLabel";
            this.generationThreadsLabel.Size = new System.Drawing.Size(46, 13);
            this.generationThreadsLabel.TabIndex = 5;
            this.generationThreadsLabel.Text = "Threads";
            // 
            // threadsNumericUpDown
            // 
            this.threadsNumericUpDown.Location = new System.Drawing.Point(223, 45);
            this.threadsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.threadsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadsNumericUpDown.Name = "threadsNumericUpDown";
            this.threadsNumericUpDown.Size = new System.Drawing.Size(91, 20);
            this.threadsNumericUpDown.TabIndex = 4;
            this.threadsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sitesNumericUpDown
            // 
            this.sitesNumericUpDown.Location = new System.Drawing.Point(223, 19);
            this.sitesNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.sitesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sitesNumericUpDown.Name = "sitesNumericUpDown";
            this.sitesNumericUpDown.Size = new System.Drawing.Size(91, 20);
            this.sitesNumericUpDown.TabIndex = 3;
            this.sitesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sitesNumericUpDown.ValueChanged += new System.EventHandler(this.sitesNumericUpDownValueChanged);
            // 
            // generationSitesLabel
            // 
            this.generationSitesLabel.AutoSize = true;
            this.generationSitesLabel.Location = new System.Drawing.Point(6, 21);
            this.generationSitesLabel.Name = "generationSitesLabel";
            this.generationSitesLabel.Size = new System.Drawing.Size(30, 13);
            this.generationSitesLabel.TabIndex = 0;
            this.generationSitesLabel.Text = "Sites";
            // 
            // urlsGroupBox
            // 
            this.urlsGroupBox.Controls.Add(this.urlsDataGridView);
            this.urlsGroupBox.Controls.Add(this.urlsToolStrip);
            this.urlsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.urlsGroupBox.Name = "urlsGroupBox";
            this.urlsGroupBox.Size = new System.Drawing.Size(362, 420);
            this.urlsGroupBox.TabIndex = 0;
            this.urlsGroupBox.TabStop = false;
            this.urlsGroupBox.Text = "URLs";
            // 
            // urlsDataGridView
            // 
            this.urlsDataGridView.AllowUserToAddRows = false;
            this.urlsDataGridView.AllowUserToDeleteRows = false;
            this.urlsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urlsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrlsUrlColumn});
            this.urlsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.urlsDataGridView.MultiSelect = false;
            this.urlsDataGridView.Name = "urlsDataGridView";
            this.urlsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.urlsDataGridView.Size = new System.Drawing.Size(332, 401);
            this.urlsDataGridView.TabIndex = 0;
            // 
            // UrlsUrlColumn
            // 
            this.UrlsUrlColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrlsUrlColumn.HeaderText = "Url";
            this.UrlsUrlColumn.Name = "UrlsUrlColumn";
            this.UrlsUrlColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // urlsToolStrip
            // 
            this.urlsToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.urlsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urlsOpenToolStripButton,
            this.urlsClearToolStripButton});
            this.urlsToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.urlsToolStrip.Location = new System.Drawing.Point(335, 16);
            this.urlsToolStrip.Name = "urlsToolStrip";
            this.urlsToolStrip.Size = new System.Drawing.Size(24, 401);
            this.urlsToolStrip.TabIndex = 1;
            // 
            // urlsOpenToolStripButton
            // 
            this.urlsOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.urlsOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.urlsOpenToolStripButton.Name = "urlsOpenToolStripButton";
            this.urlsOpenToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.urlsOpenToolStripButton.Text = "Open";
            this.urlsOpenToolStripButton.Click += new System.EventHandler(this.urlsOpenToolStripButtonClick);
            // 
            // urlsClearToolStripButton
            // 
            this.urlsClearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.urlsClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.urlsClearToolStripButton.Name = "urlsClearToolStripButton";
            this.urlsClearToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.urlsClearToolStripButton.Text = "Clear";
            this.urlsClearToolStripButton.Click += new System.EventHandler(this.urlsClearToolStripButtonClick);
            // 
            // dateTimeGroupBox
            // 
            this.dateTimeGroupBox.Controls.Add(this.dateTimeEndLabel);
            this.dateTimeGroupBox.Controls.Add(this.dateTimeStartLabel);
            this.dateTimeGroupBox.Controls.Add(this.dateTimeEndDateTimePicker);
            this.dateTimeGroupBox.Controls.Add(this.dateTimeStartDateTimePicker);
            this.dateTimeGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimeGroupBox.Location = new System.Drawing.Point(0, 248);
            this.dateTimeGroupBox.Name = "dateTimeGroupBox";
            this.dateTimeGroupBox.Size = new System.Drawing.Size(320, 73);
            this.dateTimeGroupBox.TabIndex = 3;
            this.dateTimeGroupBox.TabStop = false;
            this.dateTimeGroupBox.Text = "DateTime";
            // 
            // dateTimeStartDateTimePicker
            // 
            this.dateTimeStartDateTimePicker.Location = new System.Drawing.Point(114, 19);
            this.dateTimeStartDateTimePicker.Name = "dateTimeStartDateTimePicker";
            this.dateTimeStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimeStartDateTimePicker.TabIndex = 0;
            // 
            // dateTimeEndDateTimePicker
            // 
            this.dateTimeEndDateTimePicker.Location = new System.Drawing.Point(114, 45);
            this.dateTimeEndDateTimePicker.Name = "dateTimeEndDateTimePicker";
            this.dateTimeEndDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEndDateTimePicker.TabIndex = 1;
            // 
            // dateTimeStartLabel
            // 
            this.dateTimeStartLabel.AutoSize = true;
            this.dateTimeStartLabel.Location = new System.Drawing.Point(6, 25);
            this.dateTimeStartLabel.Name = "dateTimeStartLabel";
            this.dateTimeStartLabel.Size = new System.Drawing.Size(29, 13);
            this.dateTimeStartLabel.TabIndex = 2;
            this.dateTimeStartLabel.Text = "Start";
            // 
            // dateTimeEndLabel
            // 
            this.dateTimeEndLabel.AutoSize = true;
            this.dateTimeEndLabel.Location = new System.Drawing.Point(6, 51);
            this.dateTimeEndLabel.Name = "dateTimeEndLabel";
            this.dateTimeEndLabel.Size = new System.Drawing.Size(26, 13);
            this.dateTimeEndLabel.TabIndex = 3;
            this.dateTimeEndLabel.Text = "End";
            // 
            // GeneralTabPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "GeneralTabPageControl";
            this.Size = new System.Drawing.Size(686, 420);
            this.Load += new System.EventHandler(this.GeneralTabPageControlLoad);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.archiveGroupBox.ResumeLayout(false);
            this.archiveGroupBox.PerformLayout();
            this.saveGroupBox.ResumeLayout(false);
            this.saveGroupBox.PerformLayout();
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presetClearPictureBox)).EndInit();
            this.generationGroupBox.ResumeLayout(false);
            this.generationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitesNumericUpDown)).EndInit();
            this.urlsGroupBox.ResumeLayout(false);
            this.urlsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlsDataGridView)).EndInit();
            this.urlsToolStrip.ResumeLayout(false);
            this.urlsToolStrip.PerformLayout();
            this.dateTimeGroupBox.ResumeLayout(false);
            this.dateTimeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer mainSplitContainer;
        protected System.Windows.Forms.GroupBox urlsGroupBox;
        protected System.Windows.Forms.DataGridView urlsDataGridView;
        protected System.Windows.Forms.GroupBox saveGroupBox;
        protected System.Windows.Forms.ComboBox saveSubDirectoriesComboBox;
        protected System.Windows.Forms.Button saveButton;
        protected System.Windows.Forms.TextBox saveTextBox;
        protected System.Windows.Forms.GroupBox archiveGroupBox;
        protected System.Windows.Forms.ComboBox archiveComboBox;
        protected System.Windows.Forms.TextBox archiveTextBox;
        protected System.Windows.Forms.GroupBox dataGroupBox;
        protected System.Windows.Forms.PictureBox presetClearPictureBox;
        protected System.Windows.Forms.ComboBox presetComboBox;
        protected System.Windows.Forms.Label presetLabel;
        protected System.Windows.Forms.ComboBox templateComboBox;
        protected System.Windows.Forms.Label templateLabel;
        protected System.Windows.Forms.ComboBox wsComboBox;
        protected System.Windows.Forms.Label wsLabel;
        protected System.Windows.Forms.GroupBox generationGroupBox;
        protected System.Windows.Forms.Label generationThreadsLabel;
        protected System.Windows.Forms.NumericUpDown threadsNumericUpDown;
        protected System.Windows.Forms.NumericUpDown sitesNumericUpDown;
        protected System.Windows.Forms.Label generationSitesLabel;
        protected System.Windows.Forms.FolderBrowserDialog mainFolderBrowserDialog;
        protected System.Windows.Forms.DataGridViewTextBoxColumn UrlsUrlColumn;
        protected System.Windows.Forms.ToolStripButton urlsOpenToolStripButton;
        protected System.Windows.Forms.ToolStripButton urlsClearToolStripButton;
        protected System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        protected System.Windows.Forms.ToolStrip urlsToolStrip;
        private System.Windows.Forms.GroupBox dateTimeGroupBox;
        private System.Windows.Forms.Label dateTimeEndLabel;
        private System.Windows.Forms.Label dateTimeStartLabel;
        private System.Windows.Forms.DateTimePicker dateTimeEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimeStartDateTimePicker;

    }
}
