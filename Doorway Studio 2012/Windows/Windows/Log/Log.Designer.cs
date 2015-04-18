using Umax.Windows.Controls.Views;

namespace Umax.Windows.Windows.Log
{
    partial class Log
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
            this.logContol = new LogContol();
            this.SuspendLayout();
            // 
            // logContol
            // 
            this.logContol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logContol.Location = new System.Drawing.Point(0, 0);
            this.logContol.Margin = new System.Windows.Forms.Padding(0);
            this.logContol.Name = "logContol";
            this.logContol.Size = new System.Drawing.Size(584, 362);
            this.logContol.TabIndex = 0;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.logContol);
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doorway Studio 2012: History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogFormClosed);
            this.Load += new System.EventHandler(this.LogLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private LogContol logContol;
    }
}