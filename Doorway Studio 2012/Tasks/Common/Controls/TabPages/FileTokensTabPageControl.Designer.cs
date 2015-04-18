namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    partial class FileTokensTabPageControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileTokensTabPageControl));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.fileTokenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileTokenPathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileTokenEncodingColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fileTokenTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileTokenColumn,
            this.fileTokenPathColumn,
            this.fileTokenEncodingColumn,
            this.fileTokenTypeColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(662, 420);
            this.dataGridView.TabIndex = 2;
            // 
            // fileTokenColumn
            // 
            this.fileTokenColumn.HeaderText = "Token";
            this.fileTokenColumn.Name = "fileTokenColumn";
            this.fileTokenColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fileTokenPathColumn
            // 
            this.fileTokenPathColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileTokenPathColumn.HeaderText = "File Path";
            this.fileTokenPathColumn.Name = "fileTokenPathColumn";
            this.fileTokenPathColumn.ReadOnly = true;
            this.fileTokenPathColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fileTokenEncodingColumn
            // 
            this.fileTokenEncodingColumn.HeaderText = "Encoding";
            this.fileTokenEncodingColumn.Items.AddRange(new object[] {
            "ANSI",
            "UTF-8"});
            this.fileTokenEncodingColumn.Name = "fileTokenEncodingColumn";
            // 
            // fileTokenTypeColumn
            // 
            this.fileTokenTypeColumn.HeaderText = "Type";
            this.fileTokenTypeColumn.Items.AddRange(new object[] {
            "Random line",
            "Line after line",
            "One line/Site",
            "Random line/Site"});
            this.fileTokenTypeColumn.Name = "fileTokenTypeColumn";
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.removeToolStripButton,
            this.clearToolStripButton,
            this.editToolStripButton});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip.Location = new System.Drawing.Point(662, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(24, 420);
            this.toolStrip.TabIndex = 3;
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButtonClick);
            // 
            // removeToolStripButton
            // 
            this.removeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeToolStripButton.Name = "removeToolStripButton";
            this.removeToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.removeToolStripButton.Text = "Remove";
            this.removeToolStripButton.Click += new System.EventHandler(this.removeToolStripButtonClick);
            // 
            // clearToolStripButton
            // 
            this.clearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearToolStripButton.Name = "clearToolStripButton";
            this.clearToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.clearToolStripButton.Text = "Clear";
            this.clearToolStripButton.Click += new System.EventHandler(this.clearToolStripButtonClick);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.editToolStripButton.Text = "Select file";
            this.editToolStripButton.Click += new System.EventHandler(this.editToolStripButtonClick);
            // 
            // FileTokensTabPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FileTokensTabPageControl";
            this.Size = new System.Drawing.Size(686, 420);
            this.Load += new System.EventHandler(this.FileTokensTabPageControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView dataGridView;
        protected System.Windows.Forms.DataGridViewTextBoxColumn tokenColumn;
        protected System.Windows.Forms.DataGridViewTextBoxColumn pathColumn;
        protected System.Windows.Forms.DataGridViewComboBoxColumn encodingColumn;
        protected System.Windows.Forms.DataGridViewComboBoxColumn typeColumn;
        protected System.Windows.Forms.ToolStrip toolStrip;
        protected System.Windows.Forms.ToolStripButton addToolStripButton;
        protected System.Windows.Forms.ToolStripButton removeToolStripButton;
        protected System.Windows.Forms.ToolStripButton clearToolStripButton;
        protected System.Windows.Forms.ToolStripButton editToolStripButton;
        protected System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        protected System.Windows.Forms.DataGridViewTextBoxColumn fileTokenColumn;
        protected System.Windows.Forms.DataGridViewTextBoxColumn fileTokenPathColumn;
        protected System.Windows.Forms.DataGridViewComboBoxColumn fileTokenEncodingColumn;
        protected System.Windows.Forms.DataGridViewComboBoxColumn fileTokenTypeColumn;
    }
}
