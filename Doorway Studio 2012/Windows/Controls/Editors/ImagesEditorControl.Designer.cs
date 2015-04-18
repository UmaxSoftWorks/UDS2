namespace Umax.Windows.Controls.Editors
{
    partial class ImagesEditorControl
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
            this.components = new System.ComponentModel.Container();
            this.mainFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.addToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.exportAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.imagesImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainListView = new System.Windows.Forms.ListView();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripSplitButton,
            this.toolStripSeparator2,
            this.saveToolStripButton,
            this.cancelToolStripButton,
            this.toolStripSeparator3,
            this.exportToolStripSplitButton,
            this.toolStripSeparator1,
            this.removeToolStripButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainToolStrip.Size = new System.Drawing.Size(635, 23);
            this.mainToolStrip.TabIndex = 5;
            // 
            // addToolStripSplitButton
            // 
            this.addToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.addDirectoryToolStripMenuItem});
            this.addToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripSplitButton.Name = "addToolStripSplitButton";
            this.addToolStripSplitButton.Size = new System.Drawing.Size(16, 4);
            this.addToolStripSplitButton.Text = "Add";
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addFileToolStripMenuItem.Text = "File";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.AddFile);
            // 
            // addDirectoryToolStripMenuItem
            // 
            this.addDirectoryToolStripMenuItem.Name = "addDirectoryToolStripMenuItem";
            this.addDirectoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addDirectoryToolStripMenuItem.Text = "Directory";
            this.addDirectoryToolStripMenuItem.Click += new System.EventHandler(this.AddDirectory);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
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
            // cancelToolStripButton
            // 
            this.cancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelToolStripButton.Name = "cancelToolStripButton";
            this.cancelToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.cancelToolStripButton.Text = "Cancel";
            this.cancelToolStripButton.Click += new System.EventHandler(this.Cancel);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // exportToolStripSplitButton
            // 
            this.exportToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAllToolStripMenuItem,
            this.exportSelectedToolStripMenuItem});
            this.exportToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToolStripSplitButton.Name = "exportToolStripSplitButton";
            this.exportToolStripSplitButton.Size = new System.Drawing.Size(16, 4);
            this.exportToolStripSplitButton.Text = "Export";
            // 
            // exportAllToolStripMenuItem
            // 
            this.exportAllToolStripMenuItem.Name = "exportAllToolStripMenuItem";
            this.exportAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportAllToolStripMenuItem.Text = "All";
            this.exportAllToolStripMenuItem.Click += new System.EventHandler(this.ExportAll);
            // 
            // exportSelectedToolStripMenuItem
            // 
            this.exportSelectedToolStripMenuItem.Name = "exportSelectedToolStripMenuItem";
            this.exportSelectedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportSelectedToolStripMenuItem.Text = "Selected";
            this.exportSelectedToolStripMenuItem.Click += new System.EventHandler(this.ExportSelected);
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.Filter = "All|*.*";
            this.mainOpenFileDialog.Multiselect = true;
            // 
            // imagesImageList
            // 
            this.imagesImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imagesImageList.ImageSize = new System.Drawing.Size(48, 48);
            this.imagesImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // mainListView
            // 
            this.mainListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainListView.Enabled = false;
            this.mainListView.LargeImageList = this.imagesImageList;
            this.mainListView.Location = new System.Drawing.Point(0, 23);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(635, 307);
            this.mainListView.SmallImageList = this.imagesImageList;
            this.mainListView.TabIndex = 6;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainListViewKeyDown);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // ImagesEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainListView);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ImagesEditorControl";
            this.Size = new System.Drawing.Size(635, 330);
            this.Load += new System.EventHandler(this.ImagesEditorControlLoad);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.FolderBrowserDialog mainFolderBrowserDialog;
        protected System.Windows.Forms.ToolStrip mainToolStrip;
        protected System.Windows.Forms.ToolStripSplitButton addToolStripSplitButton;
        protected System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem addDirectoryToolStripMenuItem;
        protected System.Windows.Forms.ToolStripButton removeToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ToolStripButton saveToolStripButton;
        protected System.Windows.Forms.ToolStripButton cancelToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        protected System.Windows.Forms.ToolStripSplitButton exportToolStripSplitButton;
        protected System.Windows.Forms.ToolStripMenuItem exportAllToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem exportSelectedToolStripMenuItem;
        protected System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        protected System.Windows.Forms.ImageList imagesImageList;
        protected System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
