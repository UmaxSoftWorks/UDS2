namespace Umax.Windows.Controls.Editors
{
    partial class TemplateEditorControl
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
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.mainFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.bottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.savePathToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelPathToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.addToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.reloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openEditorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openIEToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openBrowserToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bottomPanel.SuspendLayout();
            this.bottomToolStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.Filter = "All|*.*";
            this.mainOpenFileDialog.Multiselect = true;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTextBox.Enabled = false;
            this.contentTextBox.Location = new System.Drawing.Point(0, 23);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.contentTextBox.Size = new System.Drawing.Size(635, 267);
            this.contentTextBox.TabIndex = 10;
            this.contentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contentTextBoxKeyDown);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.pathTextBox);
            this.bottomPanel.Controls.Add(this.bottomToolStrip);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 290);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(635, 20);
            this.bottomPanel.TabIndex = 11;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathTextBox.Enabled = false;
            this.pathTextBox.Location = new System.Drawing.Point(0, 0);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(588, 20);
            this.pathTextBox.TabIndex = 1;
            // 
            // bottomToolStrip
            // 
            this.bottomToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.bottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePathToolStripButton,
            this.cancelPathToolStripButton});
            this.bottomToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.bottomToolStrip.Location = new System.Drawing.Point(588, 0);
            this.bottomToolStrip.Name = "bottomToolStrip";
            this.bottomToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bottomToolStrip.Size = new System.Drawing.Size(47, 20);
            this.bottomToolStrip.TabIndex = 0;
            // 
            // savePathToolStripButton
            // 
            this.savePathToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savePathToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savePathToolStripButton.Name = "savePathToolStripButton";
            this.savePathToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.savePathToolStripButton.Text = "Save";
            this.savePathToolStripButton.Click += new System.EventHandler(this.SaveItemPath);
            // 
            // cancelPathToolStripButton
            // 
            this.cancelPathToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelPathToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelPathToolStripButton.Name = "cancelPathToolStripButton";
            this.cancelPathToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.cancelPathToolStripButton.Text = "Cancel";
            this.cancelPathToolStripButton.Click += new System.EventHandler(this.CancelItemPath);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripSplitButton,
            this.toolStripSeparator4,
            this.saveToolStripButton,
            this.reloadToolStripButton,
            this.cancelToolStripButton,
            this.toolStripSeparator2,
            this.openEditorToolStripButton,
            this.openIEToolStripButton,
            this.openBrowserToolStripButton,
            this.toolStripSeparator1,
            this.removeToolStripButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainToolStrip.Size = new System.Drawing.Size(635, 23);
            this.mainToolStrip.TabIndex = 9;
            // 
            // addToolStripSplitButton
            // 
            this.addToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.pageToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.staticToolStripMenuItem,
            this.mapToolStripMenuItem,
            this.customToolStripMenuItem,
            this.toolStripSeparator5,
            this.imageToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.addToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripSplitButton.Name = "addToolStripSplitButton";
            this.addToolStripSplitButton.Size = new System.Drawing.Size(16, 4);
            this.addToolStripSplitButton.Text = "Add";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "Index";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.AddIndex);
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pageToolStripMenuItem.Text = "Page";
            this.pageToolStripMenuItem.Click += new System.EventHandler(this.AddPage);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.AddCategory);
            // 
            // staticToolStripMenuItem
            // 
            this.staticToolStripMenuItem.Name = "staticToolStripMenuItem";
            this.staticToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.staticToolStripMenuItem.Text = "Static";
            this.staticToolStripMenuItem.Click += new System.EventHandler(this.AddStatic);
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.mapToolStripMenuItem.Text = "Map";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.AddMap);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.AddCustom);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.AddImage);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.AddFile);
            // 
            // removeToolStripButton
            // 
            this.removeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeToolStripButton.Name = "removeToolStripButton";
            this.removeToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.removeToolStripButton.Text = "Remove";
            this.removeToolStripButton.Click += new System.EventHandler(this.Remove);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.Save);
            // 
            // reloadToolStripButton
            // 
            this.reloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadToolStripButton.Name = "reloadToolStripButton";
            this.reloadToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.reloadToolStripButton.Text = "Reload";
            this.reloadToolStripButton.Click += new System.EventHandler(this.Reload);
            // 
            // cancelToolStripButton
            // 
            this.cancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelToolStripButton.Name = "cancelToolStripButton";
            this.cancelToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.cancelToolStripButton.Text = "Cancel";
            this.cancelToolStripButton.Click += new System.EventHandler(this.Cancel);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // openEditorToolStripButton
            // 
            this.openEditorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openEditorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openEditorToolStripButton.Name = "openEditorToolStripButton";
            this.openEditorToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.openEditorToolStripButton.Text = "Open in Editor";
            this.openEditorToolStripButton.Click += new System.EventHandler(this.OpenEditor);
            // 
            // openIEToolStripButton
            // 
            this.openIEToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openIEToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openIEToolStripButton.Name = "openIEToolStripButton";
            this.openIEToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.openIEToolStripButton.Text = "Open in Internet Explorer";
            this.openIEToolStripButton.Click += new System.EventHandler(this.OpenIE);
            // 
            // openBrowserToolStripButton
            // 
            this.openBrowserToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openBrowserToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openBrowserToolStripButton.Name = "openBrowserToolStripButton";
            this.openBrowserToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.openBrowserToolStripButton.Text = "Open in Default Browser";
            this.openBrowserToolStripButton.Click += new System.EventHandler(this.OpenBrowser);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // TemplateContentDataEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TemplateContentDataEditorControl";
            this.Size = new System.Drawing.Size(635, 310);
            this.Load += new System.EventHandler(this.TemplateContentDataEditorControlLoad);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.bottomToolStrip.ResumeLayout(false);
            this.bottomToolStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        protected System.Windows.Forms.TextBox contentTextBox;
        protected System.Windows.Forms.FolderBrowserDialog mainFolderBrowserDialog;
        protected System.Windows.Forms.Panel bottomPanel;
        protected System.Windows.Forms.TextBox pathTextBox;
        protected System.Windows.Forms.ToolStrip bottomToolStrip;
        protected System.Windows.Forms.ToolStripButton savePathToolStripButton;
        protected System.Windows.Forms.ToolStripButton cancelPathToolStripButton;
        protected System.Windows.Forms.ToolStrip mainToolStrip;
        protected System.Windows.Forms.ToolStripSplitButton addToolStripSplitButton;
        protected System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem staticToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        protected System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        protected System.Windows.Forms.ToolStripButton removeToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        protected System.Windows.Forms.ToolStripButton saveToolStripButton;
        protected System.Windows.Forms.ToolStripButton reloadToolStripButton;
        protected System.Windows.Forms.ToolStripButton cancelToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ToolStripButton openEditorToolStripButton;
        protected System.Windows.Forms.ToolStripButton openIEToolStripButton;
        protected System.Windows.Forms.ToolStripButton openBrowserToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
