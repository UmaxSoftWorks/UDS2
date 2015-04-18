namespace Umax.Windows.Tools.TemplateEditor.Controls
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.reloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openEditorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openIEToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openBrowserToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.removeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 23);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(300, 277);
            this.mainTabControl.TabIndex = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripSplitButton,
            this.toolStripSeparator1,
            this.saveToolStripButton,
            this.reloadToolStripButton,
            this.cancelToolStripButton,
            this.toolStripSeparator4,
            this.openEditorToolStripButton,
            this.openIEToolStripButton,
            this.openBrowserToolStripButton,
            this.toolStripSeparator2,
            this.removeToolStripButton});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(300, 23);
            this.toolStrip.TabIndex = 0;
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
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.indexToolStripMenuItem.Text = "Index";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.AddIndex);
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pageToolStripMenuItem.Text = "Page";
            this.pageToolStripMenuItem.Click += new System.EventHandler(this.AddPage);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.AddCategory);
            // 
            // staticToolStripMenuItem
            // 
            this.staticToolStripMenuItem.Name = "staticToolStripMenuItem";
            this.staticToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.staticToolStripMenuItem.Text = "Static";
            this.staticToolStripMenuItem.Click += new System.EventHandler(this.AddStatic);
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mapToolStripMenuItem.Text = "Map";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.AddMap);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.AddCustom);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.AddImage);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.AddFile);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
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
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.Filter = "Text|*.txt|HTML|*.html|All|*.*";
            // 
            // TemplateEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.toolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TemplateEditorControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.TemplateEditorControlLoad);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.ToolStrip toolStrip;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton openBrowserToolStripButton;
        protected System.Windows.Forms.ToolStripButton openIEToolStripButton;
        protected System.Windows.Forms.ToolStripButton openEditorToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ToolStripButton cancelToolStripButton;
        protected System.Windows.Forms.ToolStripButton reloadToolStripButton;
        protected System.Windows.Forms.ToolStripButton saveToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        protected System.Windows.Forms.ToolStripButton removeToolStripButton;
        private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;

    }
}
