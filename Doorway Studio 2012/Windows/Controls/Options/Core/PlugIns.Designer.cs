namespace Umax.Windows.Controls.Options.Core
{
    partial class OptionsCorePlugIns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsCorePlugIns));
            this.actionPanel = new System.Windows.Forms.Panel();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.pluginsDataGridView = new System.Windows.Forms.DataGridView();
            this.fileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluginsToolStrip = new System.Windows.Forms.ToolStrip();
            this.pluginsAddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pluginsRemoveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pluginsClearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pluginsCheckBox = new System.Windows.Forms.CheckBox();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.actionPanel.SuspendLayout();
            this.generalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pluginsDataGridView)).BeginInit();
            this.pluginsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.applyButton);
            this.actionPanel.Controls.Add(this.cancelButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 326);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(530, 23);
            this.actionPanel.TabIndex = 5;
            // 
            // applyButton
            // 
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.applyButton.Location = new System.Drawing.Point(380, 0);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.Location = new System.Drawing.Point(455, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButtonClick);
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.pluginsDataGridView);
            this.generalGroupBox.Controls.Add(this.pluginsToolStrip);
            this.generalGroupBox.Controls.Add(this.pluginsCheckBox);
            this.generalGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalGroupBox.Location = new System.Drawing.Point(0, 0);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(530, 326);
            this.generalGroupBox.TabIndex = 6;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "Plugins";
            // 
            // pluginsDataGridView
            // 
            this.pluginsDataGridView.AllowUserToAddRows = false;
            this.pluginsDataGridView.AllowUserToDeleteRows = false;
            this.pluginsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pluginsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileColumn});
            this.pluginsDataGridView.Location = new System.Drawing.Point(6, 42);
            this.pluginsDataGridView.MultiSelect = false;
            this.pluginsDataGridView.Name = "pluginsDataGridView";
            this.pluginsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pluginsDataGridView.Size = new System.Drawing.Size(494, 284);
            this.pluginsDataGridView.TabIndex = 8;
            // 
            // fileColumn
            // 
            this.fileColumn.HeaderText = "File";
            this.fileColumn.Name = "fileColumn";
            this.fileColumn.Width = 450;
            // 
            // pluginsToolStrip
            // 
            this.pluginsToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.pluginsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginsAddToolStripButton,
            this.pluginsRemoveToolStripButton,
            this.pluginsClearToolStripButton});
            this.pluginsToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.pluginsToolStrip.Location = new System.Drawing.Point(503, 16);
            this.pluginsToolStrip.Name = "pluginsToolStrip";
            this.pluginsToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.pluginsToolStrip.Size = new System.Drawing.Size(24, 307);
            this.pluginsToolStrip.TabIndex = 9;
            // 
            // pluginsAddToolStripButton
            // 
            this.pluginsAddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pluginsAddToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pluginsAddToolStripButton.Image")));
            this.pluginsAddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pluginsAddToolStripButton.Name = "pluginsAddToolStripButton";
            this.pluginsAddToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.pluginsAddToolStripButton.Text = "Add";
            this.pluginsAddToolStripButton.Click += new System.EventHandler(this.pluginsAddToolStripButtonClick);
            // 
            // pluginsRemoveToolStripButton
            // 
            this.pluginsRemoveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pluginsRemoveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pluginsRemoveToolStripButton.Image")));
            this.pluginsRemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pluginsRemoveToolStripButton.Name = "pluginsRemoveToolStripButton";
            this.pluginsRemoveToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.pluginsRemoveToolStripButton.Text = "Remove";
            this.pluginsRemoveToolStripButton.Click += new System.EventHandler(this.pluginsRemoveToolStripButtonClick);
            // 
            // pluginsClearToolStripButton
            // 
            this.pluginsClearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pluginsClearToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pluginsClearToolStripButton.Image")));
            this.pluginsClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pluginsClearToolStripButton.Name = "pluginsClearToolStripButton";
            this.pluginsClearToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.pluginsClearToolStripButton.Text = "Clear";
            this.pluginsClearToolStripButton.Click += new System.EventHandler(this.pluginsClearToolStripButtonClick);
            // 
            // pluginsCheckBox
            // 
            this.pluginsCheckBox.AutoSize = true;
            this.pluginsCheckBox.Location = new System.Drawing.Point(6, 19);
            this.pluginsCheckBox.Name = "pluginsCheckBox";
            this.pluginsCheckBox.Size = new System.Drawing.Size(65, 17);
            this.pluginsCheckBox.TabIndex = 0;
            this.pluginsCheckBox.Text = "Enabled";
            this.pluginsCheckBox.UseVisualStyleBackColor = true;
            this.pluginsCheckBox.CheckedChanged += new System.EventHandler(this.pluginsCheckBoxCheckedChanged);
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.Filter = "DLL|*.dll";
            // 
            // OptionsCorePlugIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generalGroupBox);
            this.Controls.Add(this.actionPanel);
            this.Name = "OptionsCorePlugIns";
            this.Size = new System.Drawing.Size(530, 349);
            this.Load += new System.EventHandler(this.OptionsCorePlugInsLoad);
            this.actionPanel.ResumeLayout(false);
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pluginsDataGridView)).EndInit();
            this.pluginsToolStrip.ResumeLayout(false);
            this.pluginsToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.CheckBox pluginsCheckBox;
        private System.Windows.Forms.DataGridView pluginsDataGridView;
        private System.Windows.Forms.ToolStrip pluginsToolStrip;
        protected System.Windows.Forms.ToolStripButton pluginsAddToolStripButton;
        protected System.Windows.Forms.ToolStripButton pluginsRemoveToolStripButton;
        protected System.Windows.Forms.ToolStripButton pluginsClearToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileColumn;
        private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
    }
}
