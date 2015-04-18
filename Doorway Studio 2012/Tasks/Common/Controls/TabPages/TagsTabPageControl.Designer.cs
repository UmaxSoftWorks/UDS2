namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    partial class TagsTabPageControl
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
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.pathContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encodingColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pathContentColumn,
            this.encodingColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(654, 420);
            this.dataGridView.TabIndex = 5;
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Image = Umax.Resources.Resources.Folder;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButtonClick);
            // 
            // clearToolStripButton
            // 
            this.clearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearToolStripButton.Image = Umax.Resources.Resources.Delete;
            this.clearToolStripButton.Name = "clearToolStripButton";
            this.clearToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.clearToolStripButton.Text = "Clear";
            this.clearToolStripButton.Click += new System.EventHandler(this.clearToolStripButtonClick);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.clearToolStripButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.mainToolStrip.Location = new System.Drawing.Point(654, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(32, 420);
            this.mainToolStrip.TabIndex = 6;
            // 
            // pathContentColumn
            // 
            this.pathContentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pathContentColumn.HeaderText = "File Path";
            this.pathContentColumn.Name = "filePathContentColumn";
            this.pathContentColumn.ReadOnly = true;
            // 
            // encodingColumn
            // 
            this.encodingColumn.HeaderText = "Encoding";
            this.encodingColumn.Items.AddRange(new object[] {
            "ANSI",
            "UTF-8"});
            this.encodingColumn.Name = "encodingColumn";
            // 
            // TagsTabPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TagsTabPageControl";
            this.Size = new System.Drawing.Size(686, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView dataGridView;
        protected System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        protected System.Windows.Forms.ToolStripButton openToolStripButton;
        protected System.Windows.Forms.ToolStripButton clearToolStripButton;
        protected System.Windows.Forms.ToolStrip mainToolStrip;
        protected System.Windows.Forms.DataGridViewTextBoxColumn pathContentColumn;
        protected System.Windows.Forms.DataGridViewComboBoxColumn encodingColumn;
    }
}
