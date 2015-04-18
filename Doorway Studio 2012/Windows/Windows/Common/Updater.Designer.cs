namespace Umax.Windows.Windows.Common
{
    partial class Updater
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
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.updateCheckBox = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusTextLabel = new System.Windows.Forms.Label();
            this.RunTimeTimeLabel = new System.Windows.Forms.Label();
            this.RunTimeLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPictureBox.Location = new System.Drawing.Point(12, 12);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(128, 128);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 1;
            this.mainPictureBox.TabStop = false;
            // 
            // updateCheckBox
            // 
            this.updateCheckBox.AutoSize = true;
            this.updateCheckBox.Location = new System.Drawing.Point(146, 114);
            this.updateCheckBox.Name = "updateCheckBox";
            this.updateCheckBox.Size = new System.Drawing.Size(151, 17);
            this.updateCheckBox.TabIndex = 3;
            this.updateCheckBox.Text = "Update when downloaded";
            this.updateCheckBox.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(146, 56);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(422, 15);
            this.progressBar1.TabIndex = 5;
            // 
            // statusTextLabel
            // 
            this.statusTextLabel.AutoSize = true;
            this.statusTextLabel.Location = new System.Drawing.Point(205, 12);
            this.statusTextLabel.Name = "statusTextLabel";
            this.statusTextLabel.Size = new System.Drawing.Size(10, 13);
            this.statusTextLabel.TabIndex = 11;
            this.statusTextLabel.Text = "-";
            // 
            // RunTimeTimeLabel
            // 
            this.RunTimeTimeLabel.AutoSize = true;
            this.RunTimeTimeLabel.Location = new System.Drawing.Point(205, 36);
            this.RunTimeTimeLabel.Name = "RunTimeTimeLabel";
            this.RunTimeTimeLabel.Size = new System.Drawing.Size(10, 13);
            this.RunTimeTimeLabel.TabIndex = 10;
            this.RunTimeTimeLabel.Text = "-";
            // 
            // RunTimeLabel
            // 
            this.RunTimeLabel.AutoSize = true;
            this.RunTimeLabel.Location = new System.Drawing.Point(146, 36);
            this.RunTimeLabel.Name = "RunTimeLabel";
            this.RunTimeLabel.Size = new System.Drawing.Size(53, 13);
            this.RunTimeLabel.TabIndex = 9;
            this.RunTimeLabel.Text = "RunTime:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(146, 12);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(493, 110);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 145);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.statusTextLabel);
            this.Controls.Add(this.RunTimeTimeLabel);
            this.Controls.Add(this.RunTimeLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.updateCheckBox);
            this.Controls.Add(this.mainPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Updater";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doorway Studio 2012: Updater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Updater_FormClosing);
            this.Load += new System.EventHandler(this.UpdaterLoad);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox mainPictureBox;
        protected System.Windows.Forms.CheckBox updateCheckBox;
        protected System.Windows.Forms.ProgressBar progressBar1;
        protected System.Windows.Forms.Label statusTextLabel;
        protected System.Windows.Forms.Label RunTimeTimeLabel;
        protected System.Windows.Forms.Label RunTimeLabel;
        protected System.Windows.Forms.Label statusLabel;
        protected System.Windows.Forms.Button closeButton;

    }
}