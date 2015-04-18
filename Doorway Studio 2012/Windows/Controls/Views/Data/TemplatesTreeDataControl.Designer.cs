namespace Umax.Windows.Controls.Views.Data
{
    partial class TemplatesTreeDataControl
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.newANSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.renameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripSplitButton,
            this.toolStripSeparator1,
            this.copyToolStripButton,
            this.renameToolStripButton,
            this.toolStripSeparator3,
            this.openToolStripButton,
            this.exportToolStripButton,
            this.toolStripSeparator2,
            this.deleteToolStripButton});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(150, 42);
            this.toolStrip.TabIndex = 0;
            // 
            // newToolStripSplitButton
            // 
            this.newToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newANSIToolStripMenuItem,
            this.newUTF8ToolStripMenuItem});
            this.newToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripSplitButton.Name = "newToolStripSplitButton";
            this.newToolStripSplitButton.Size = new System.Drawing.Size(16, 4);
            this.newToolStripSplitButton.Text = "New";
            // 
            // newANSIToolStripMenuItem
            // 
            this.newANSIToolStripMenuItem.Name = "newANSIToolStripMenuItem";
            this.newANSIToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newANSIToolStripMenuItem.Text = "ANSI";
            this.newANSIToolStripMenuItem.Click += new System.EventHandler(this.CreateANSI);
            // 
            // newUTF8ToolStripMenuItem
            // 
            this.newUTF8ToolStripMenuItem.Name = "newUTF8ToolStripMenuItem";
            this.newUTF8ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newUTF8ToolStripMenuItem.Text = "UTF-8";
            this.newUTF8ToolStripMenuItem.Click += new System.EventHandler(this.CreateUTF);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.copyToolStripButton.Text = "Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.Copy);
            // 
            // renameToolStripButton
            // 
            this.renameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.renameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.renameToolStripButton.Name = "renameToolStripButton";
            this.renameToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.renameToolStripButton.Text = "Rename";
            this.renameToolStripButton.Click += new System.EventHandler(this.Rename);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.Open);
            // 
            // exportToolStripButton
            // 
            this.exportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToolStripButton.Name = "exportToolStripButton";
            this.exportToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.exportToolStripButton.Text = "Export";
            this.exportToolStripButton.Click += new System.EventHandler(this.Export);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.Click += new System.EventHandler(this.Delete);
            // 
            // mainTreeView
            // 
            this.mainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTreeView.ImageIndex = 0;
            this.mainTreeView.ImageList = this.mainImageList;
            this.mainTreeView.Location = new System.Drawing.Point(0, 42);
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.SelectedImageIndex = 0;
            this.mainTreeView.Size = new System.Drawing.Size(150, 258);
            this.mainTreeView.TabIndex = 1;
            this.mainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.mainTreeViewAfterSelect);
            // 
            // mainImageList
            // 
            this.mainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TemplatesTreeDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTreeView);
            this.Controls.Add(this.toolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TemplatesTreeDataControl";
            this.Size = new System.Drawing.Size(150, 300);
            this.Load += new System.EventHandler(this.TemplatesControlLoad);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.ToolStripSplitButton newToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem newANSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton exportToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ImageList mainImageList;
        protected System.Windows.Forms.FolderBrowserDialog mainFolderBrowserDialog;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton renameToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}
