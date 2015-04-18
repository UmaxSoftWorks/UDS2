using Umax.Windows.Controls.Views.Manager;

namespace Umax.Windows.Windows.Common
{
    partial class TrayWindow
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
            this.activeTasksGridManagerControl = new ActiveTasksGridManagerControl();
            this.SuspendLayout();
            // 
            // activeTasksGridManagerControl
            // 
            this.activeTasksGridManagerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeTasksGridManagerControl.Location = new System.Drawing.Point(0, 0);
            this.activeTasksGridManagerControl.Margin = new System.Windows.Forms.Padding(0);
            this.activeTasksGridManagerControl.Name = "activeTasksGridManagerControl";
            this.activeTasksGridManagerControl.Size = new System.Drawing.Size(300, 120);
            this.activeTasksGridManagerControl.TabIndex = 0;
            // 
            // TrayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 120);
            this.Controls.Add(this.activeTasksGridManagerControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrayWindow";
            this.Opacity = 0.75D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TrayWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrayWindowFormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private ActiveTasksGridManagerControl activeTasksGridManagerControl;
    }
}