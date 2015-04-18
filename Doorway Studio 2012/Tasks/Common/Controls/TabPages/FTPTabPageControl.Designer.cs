namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    partial class FTPTabPageControl
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
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.generalButton = new System.Windows.Forms.Button();
            this.generalDeleteAfterUploadСheckBox = new System.Windows.Forms.CheckBox();
            this.generalExportPathTextBox = new System.Windows.Forms.TextBox();
            this.generalComboBox = new System.Windows.Forms.ComboBox();
            this.generalFTPDataGroupBox = new System.Windows.Forms.GroupBox();
            this.dataDataGridView = new System.Windows.Forms.DataGridView();
            this.ftpServerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftpAccountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftpPasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftpRemoteFolderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.generalGroupBox.SuspendLayout();
            this.generalFTPDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).BeginInit();
            this.mainToolStrip.SuspendLayout();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.generalGroupBox.Controls.Add(this.generalButton);
            this.generalGroupBox.Controls.Add(this.generalDeleteAfterUploadСheckBox);
            this.generalGroupBox.Controls.Add(this.generalExportPathTextBox);
            this.generalGroupBox.Controls.Add(this.generalComboBox);
            this.generalGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalGroupBox.Location = new System.Drawing.Point(0, 0);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(686, 70);
            this.generalGroupBox.TabIndex = 1;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // generalButton
            // 
            this.generalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generalButton.Enabled = false;
            this.generalButton.Location = new System.Drawing.Point(648, 44);
            this.generalButton.Name = "generalButton";
            this.generalButton.Size = new System.Drawing.Size(32, 23);
            this.generalButton.TabIndex = 8;
            this.generalButton.Text = "...";
            this.generalButton.UseVisualStyleBackColor = true;
            this.generalButton.Click += new System.EventHandler(this.generalButtonClick);
            // 
            // generalDeleteAfterUploadСheckBox
            // 
            this.generalDeleteAfterUploadСheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generalDeleteAfterUploadСheckBox.AutoSize = true;
            this.generalDeleteAfterUploadСheckBox.Enabled = false;
            this.generalDeleteAfterUploadСheckBox.Location = new System.Drawing.Point(543, 19);
            this.generalDeleteAfterUploadСheckBox.Name = "generalDeleteAfterUploadСheckBox";
            this.generalDeleteAfterUploadСheckBox.Size = new System.Drawing.Size(137, 17);
            this.generalDeleteAfterUploadСheckBox.TabIndex = 1;
            this.generalDeleteAfterUploadСheckBox.Text = "Delete files after upload";
            this.generalDeleteAfterUploadСheckBox.UseVisualStyleBackColor = true;
            // 
            // generalExportPathTextBox
            // 
            this.generalExportPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalExportPathTextBox.Enabled = false;
            this.generalExportPathTextBox.Location = new System.Drawing.Point(6, 46);
            this.generalExportPathTextBox.Name = "generalExportPathTextBox";
            this.generalExportPathTextBox.Size = new System.Drawing.Size(636, 20);
            this.generalExportPathTextBox.TabIndex = 7;
            // 
            // generalComboBox
            // 
            this.generalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generalComboBox.FormattingEnabled = true;
            this.generalComboBox.Items.AddRange(new object[] {
            "None",
            "Standard",
            "FileZilla"});
            this.generalComboBox.Location = new System.Drawing.Point(6, 17);
            this.generalComboBox.Name = "generalComboBox";
            this.generalComboBox.Size = new System.Drawing.Size(137, 21);
            this.generalComboBox.TabIndex = 6;
            this.generalComboBox.SelectedIndexChanged += new System.EventHandler(this.generalComboBoxSelectedIndexChanged);
            // 
            // generalFTPDataGroupBox
            // 
            this.generalFTPDataGroupBox.Controls.Add(this.dataDataGridView);
            this.generalFTPDataGroupBox.Controls.Add(this.mainToolStrip);
            this.generalFTPDataGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalFTPDataGroupBox.Location = new System.Drawing.Point(0, 0);
            this.generalFTPDataGroupBox.Name = "generalFTPDataGroupBox";
            this.generalFTPDataGroupBox.Size = new System.Drawing.Size(686, 346);
            this.generalFTPDataGroupBox.TabIndex = 4;
            this.generalFTPDataGroupBox.TabStop = false;
            this.generalFTPDataGroupBox.Text = "Data";
            // 
            // dataDataGridView
            // 
            this.dataDataGridView.AllowUserToAddRows = false;
            this.dataDataGridView.AllowUserToDeleteRows = false;
            this.dataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ftpServerColumn,
            this.ftpAccountColumn,
            this.ftpPasswordColumn,
            this.ftpRemoteFolderColumn});
            this.dataDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataDataGridView.Enabled = false;
            this.dataDataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataDataGridView.MultiSelect = false;
            this.dataDataGridView.Name = "dataDataGridView";
            this.dataDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDataGridView.Size = new System.Drawing.Size(648, 327);
            this.dataDataGridView.TabIndex = 0;
            // 
            // ftpServerColumn
            // 
            this.ftpServerColumn.HeaderText = "Host";
            this.ftpServerColumn.Name = "ftpServerColumn";
            this.ftpServerColumn.Width = 200;
            // 
            // ftpAccountColumn
            // 
            this.ftpAccountColumn.HeaderText = "Account";
            this.ftpAccountColumn.Name = "ftpAccountColumn";
            // 
            // ftpPasswordColumn
            // 
            this.ftpPasswordColumn.HeaderText = "Password";
            this.ftpPasswordColumn.Name = "ftpPasswordColumn";
            // 
            // ftpRemoteFolderColumn
            // 
            this.ftpRemoteFolderColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ftpRemoteFolderColumn.HeaderText = "Remote Dir";
            this.ftpRemoteFolderColumn.Name = "ftpRemoteFolderColumn";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainToolStrip.Enabled = false;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.clearToolStripButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.mainToolStrip.Location = new System.Drawing.Point(651, 16);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(32, 327);
            this.mainToolStrip.TabIndex = 1;
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButtonClick);
            // 
            // clearToolStripButton
            // 
            this.clearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearToolStripButton.Name = "clearToolStripButton";
            this.clearToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.clearToolStripButton.Text = "Clear";
            this.clearToolStripButton.Click += new System.EventHandler(this.clearToolStripButtonClick);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.generalGroupBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.generalFTPDataGroupBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(686, 420);
            this.mainSplitContainer.SplitterDistance = 70;
            this.mainSplitContainer.TabIndex = 5;
            // 
            // FTPTabPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FTPTabPageControl";
            this.Size = new System.Drawing.Size(686, 420);
            this.Load += new System.EventHandler(this.FTPTabPageControlLoad);
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.generalFTPDataGroupBox.ResumeLayout(false);
            this.generalFTPDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).EndInit();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox generalGroupBox;
        protected System.Windows.Forms.Button generalButton;
        protected System.Windows.Forms.GroupBox generalFTPDataGroupBox;
        protected System.Windows.Forms.DataGridView dataDataGridView;
        protected System.Windows.Forms.CheckBox generalDeleteAfterUploadСheckBox;
        protected System.Windows.Forms.TextBox generalExportPathTextBox;
        protected System.Windows.Forms.ComboBox generalComboBox;
        protected System.Windows.Forms.SplitContainer mainSplitContainer;
        protected System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        protected System.Windows.Forms.ToolStrip mainToolStrip;
        protected System.Windows.Forms.DataGridViewTextBoxColumn ftpServerColumn;
        protected System.Windows.Forms.DataGridViewTextBoxColumn ftpAccountColumn;
        protected System.Windows.Forms.DataGridViewTextBoxColumn ftpPasswordColumn;
        protected System.Windows.Forms.DataGridViewTextBoxColumn ftpRemoteFolderColumn;
        protected System.Windows.Forms.ToolStripButton clearToolStripButton;
        protected System.Windows.Forms.ToolStripButton openToolStripButton;
    }
}
