namespace Umax.Windows.Controls.Views
{
    partial class LogContol
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
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearMemoryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyListBox
            // 
            this.historyListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.Location = new System.Drawing.Point(0, 23);
            this.historyListBox.Margin = new System.Windows.Forms.Padding(0);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.ScrollAlwaysVisible = true;
            this.historyListBox.Size = new System.Drawing.Size(100, 77);
            this.historyListBox.TabIndex = 3;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.clearToolStripButton,
            this.toolStripSeparator2,
            this.clearMemoryToolStripButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(100, 23);
            this.mainToolStrip.TabIndex = 2;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "zzzToolStripSeparator116";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // clearToolStripButton
            // 
            this.clearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearToolStripButton.Name = "clearToolStripButton";
            this.clearToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.clearToolStripButton.Text = "Clear";
            this.clearToolStripButton.Click += new System.EventHandler(this.Clear);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "zzzToolStripSeparator117";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // clearMemoryToolStripButton
            // 
            this.clearMemoryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearMemoryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearMemoryToolStripButton.Name = "clearMemoryToolStripButton";
            this.clearMemoryToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.clearMemoryToolStripButton.Text = "Free memory";
            this.clearMemoryToolStripButton.Click += new System.EventHandler(this.ClearMemory);
            // 
            // LogContol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LogContol";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.LogContolLoad);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ListBox historyListBox;
        protected System.Windows.Forms.ToolStrip mainToolStrip;
        protected System.Windows.Forms.ToolStripButton saveToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton clearToolStripButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ToolStripButton clearMemoryToolStripButton;
    }
}
