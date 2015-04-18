namespace Umax.Windows.Controls.Editors
{
    partial class TextEditorControl
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
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.openUTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.exportANSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportUTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openANSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentTextBox
            // 
            this.contentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTextBox.Enabled = false;
            this.contentTextBox.Location = new System.Drawing.Point(0, 23);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.contentTextBox.Size = new System.Drawing.Size(635, 287);
            this.contentTextBox.TabIndex = 10;
            // 
            // openUTF8ToolStripMenuItem
            // 
            this.openUTF8ToolStripMenuItem.Name = "openUTF8ToolStripMenuItem";
            this.openUTF8ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openUTF8ToolStripMenuItem.Text = "UTF-8";
            this.openUTF8ToolStripMenuItem.Click += new System.EventHandler(this.OpenUTF8);
            // 
            // exportToolStripSplitButton
            // 
            this.exportToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportANSIToolStripMenuItem,
            this.exportUTF8ToolStripMenuItem});
            this.exportToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToolStripSplitButton.Name = "exportToolStripSplitButton";
            this.exportToolStripSplitButton.Size = new System.Drawing.Size(16, 4);
            this.exportToolStripSplitButton.Text = "Export";
            // 
            // exportANSIToolStripMenuItem
            // 
            this.exportANSIToolStripMenuItem.Name = "exportANSIToolStripMenuItem";
            this.exportANSIToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportANSIToolStripMenuItem.Text = "ANSI";
            this.exportANSIToolStripMenuItem.Click += new System.EventHandler(this.ExportANSI);
            // 
            // exportUTF8ToolStripMenuItem
            // 
            this.exportUTF8ToolStripMenuItem.Name = "exportUTF8ToolStripMenuItem";
            this.exportUTF8ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportUTF8ToolStripMenuItem.Text = "UTF-8";
            this.exportUTF8ToolStripMenuItem.Click += new System.EventHandler(this.ExportUTF8);
            // 
            // openANSIToolStripMenuItem
            // 
            this.openANSIToolStripMenuItem.Name = "openANSIToolStripMenuItem";
            this.openANSIToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openANSIToolStripMenuItem.Text = "ANSI";
            this.openANSIToolStripMenuItem.Click += new System.EventHandler(this.OpenANSI);
            // 
            // openToolStripSplitButton
            // 
            this.openToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openANSIToolStripMenuItem,
            this.openUTF8ToolStripMenuItem});
            this.openToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripSplitButton.Name = "openToolStripSplitButton";
            this.openToolStripSplitButton.Size = new System.Drawing.Size(16, 4);
            this.openToolStripSplitButton.Text = "Open";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.Filter = "Text|*.txt";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.cancelToolStripButton,
            this.toolStripSeparator2,
            this.openToolStripSplitButton,
            this.exportToolStripSplitButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainToolStrip.Size = new System.Drawing.Size(635, 23);
            this.mainToolStrip.TabIndex = 9;
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
            // mainSaveFileDialog
            // 
            this.mainSaveFileDialog.Filter = "Text|*.txt";
            // 
            // TextEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TextEditorControl";
            this.Size = new System.Drawing.Size(635, 310);
            this.Load += new System.EventHandler(this.TextEditorControlLoad);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.ToolStripMenuItem openUTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton exportToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem exportANSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportUTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openANSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton openToolStripSplitButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        protected System.Windows.Forms.ToolStripButton saveToolStripButton;
        protected System.Windows.Forms.ToolStripButton cancelToolStripButton;
        private System.Windows.Forms.SaveFileDialog mainSaveFileDialog;
    }
}
