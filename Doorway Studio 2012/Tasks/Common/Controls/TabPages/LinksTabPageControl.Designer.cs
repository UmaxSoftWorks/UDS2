namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    partial class LinksTabPageControl
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.linksColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveGroupBox = new System.Windows.Forms.GroupBox();
            this.saveEncodingComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.savePathTextBox = new System.Windows.Forms.TextBox();
            this.saveComboBox = new System.Windows.Forms.ComboBox();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.saveGroupBox.SuspendLayout();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linksColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(662, 336);
            this.dataGridView.TabIndex = 7;
            // 
            // linksColumn
            // 
            this.linksColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.linksColumn.HeaderText = "Content";
            this.linksColumn.Name = "linksColumn";
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.removeToolStripButton,
            this.openToolStripButton,
            this.clearToolStripButton});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip.Location = new System.Drawing.Point(662, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(24, 336);
            this.toolStrip.TabIndex = 8;
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButtonClick);
            // 
            // removeToolStripButton
            // 
            this.removeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeToolStripButton.Name = "removeToolStripButton";
            this.removeToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.removeToolStripButton.Text = "Remove";
            this.removeToolStripButton.Click += new System.EventHandler(this.removeToolStripButtonClick);
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
            // saveGroupBox
            // 
            this.saveGroupBox.Controls.Add(this.saveEncodingComboBox);
            this.saveGroupBox.Controls.Add(this.saveButton);
            this.saveGroupBox.Controls.Add(this.savePathTextBox);
            this.saveGroupBox.Controls.Add(this.saveComboBox);
            this.saveGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveGroupBox.Enabled = false;
            this.saveGroupBox.Location = new System.Drawing.Point(0, 0);
            this.saveGroupBox.Name = "saveGroupBox";
            this.saveGroupBox.Size = new System.Drawing.Size(686, 80);
            this.saveGroupBox.TabIndex = 6;
            this.saveGroupBox.TabStop = false;
            this.saveGroupBox.Text = "Save";
            // 
            // saveEncodingComboBox
            // 
            this.saveEncodingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveEncodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saveEncodingComboBox.Enabled = false;
            this.saveEncodingComboBox.FormattingEnabled = true;
            this.saveEncodingComboBox.Items.AddRange(new object[] {
            "ANSI",
            "UTF-8"});
            this.saveEncodingComboBox.Location = new System.Drawing.Point(531, 19);
            this.saveEncodingComboBox.Name = "saveEncodingComboBox";
            this.saveEncodingComboBox.Size = new System.Drawing.Size(149, 21);
            this.saveEncodingComboBox.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(648, 46);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(32, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            // 
            // savePathTextBox
            // 
            this.savePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savePathTextBox.Enabled = false;
            this.savePathTextBox.Location = new System.Drawing.Point(9, 48);
            this.savePathTextBox.Name = "savePathTextBox";
            this.savePathTextBox.Size = new System.Drawing.Size(633, 20);
            this.savePathTextBox.TabIndex = 4;
            // 
            // saveComboBox
            // 
            this.saveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saveComboBox.FormattingEnabled = true;
            this.saveComboBox.Items.AddRange(new object[] {
            "Don\'t save",
            "One file/Site",
            "Many files/Site",
            "One file/Sites",
            "Many files/Sites"});
            this.saveComboBox.Location = new System.Drawing.Point(9, 19);
            this.saveComboBox.Name = "saveComboBox";
            this.saveComboBox.Size = new System.Drawing.Size(149, 21);
            this.saveComboBox.TabIndex = 2;
            this.saveComboBox.SelectedIndexChanged += new System.EventHandler(this.saveComboBoxSelectedIndexChanged);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.dataGridView);
            this.mainSplitContainer.Panel1.Controls.Add(this.toolStrip);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.saveGroupBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(686, 420);
            this.mainSplitContainer.SplitterDistance = 336;
            this.mainSplitContainer.TabIndex = 9;
            // 
            // LinksTabPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LinksTabPageControl";
            this.Size = new System.Drawing.Size(686, 420);
            this.Load += new System.EventHandler(this.LinksTabPageControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.saveGroupBox.ResumeLayout(false);
            this.saveGroupBox.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView dataGridView;
        protected System.Windows.Forms.DataGridViewTextBoxColumn linksColumn;
        protected System.Windows.Forms.ToolStrip toolStrip;
        protected System.Windows.Forms.ToolStripButton addToolStripButton;
        protected System.Windows.Forms.ToolStripButton removeToolStripButton;
        protected System.Windows.Forms.ToolStripButton clearToolStripButton;
        protected System.Windows.Forms.GroupBox saveGroupBox;
        protected System.Windows.Forms.ComboBox saveEncodingComboBox;
        protected System.Windows.Forms.Button saveButton;
        protected System.Windows.Forms.TextBox savePathTextBox;
        protected System.Windows.Forms.ComboBox saveComboBox;
        protected System.Windows.Forms.SplitContainer mainSplitContainer;
        protected System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        protected System.Windows.Forms.SaveFileDialog mainSaveFileDialog;
        protected System.Windows.Forms.ToolStripButton openToolStripButton;
    }
}
