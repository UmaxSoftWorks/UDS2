namespace WebParser.Windows.Tools
{
    partial class MainLog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mainListBox
            // 
            this.mainListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainListBox.FormattingEnabled = true;
            this.mainListBox.Location = new System.Drawing.Point(0, 0);
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(644, 292);
            this.mainListBox.TabIndex = 0;
            // 
            // MainLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 292);
            this.Controls.Add(this.mainListBox);
            this.Name = "MainLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Parser 2012: History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainLogFormClosing);
            this.Load += new System.EventHandler(this.MainLogLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mainListBox;
    }
}