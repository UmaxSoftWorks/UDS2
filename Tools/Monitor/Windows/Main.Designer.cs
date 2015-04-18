namespace Monitor.Windows
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusPictureBox = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.RunTimeLabel = new System.Windows.Forms.Label();
            this.RestartLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainFileSystemWatcher = new System.IO.FileSystemWatcher();
            this.RestartCountLabel = new System.Windows.Forms.Label();
            this.RunTimeTimeLabel = new System.Windows.Forms.Label();
            this.statusTextLabel = new System.Windows.Forms.Label();
            this.updateLogButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 10000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.Visible = true;
            // 
            // statusPictureBox
            // 
            this.statusPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusPictureBox.Location = new System.Drawing.Point(12, 12);
            this.statusPictureBox.Name = "statusPictureBox";
            this.statusPictureBox.Size = new System.Drawing.Size(128, 128);
            this.statusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusPictureBox.TabIndex = 0;
            this.statusPictureBox.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(146, 12);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status:";
            // 
            // RunTimeLabel
            // 
            this.RunTimeLabel.AutoSize = true;
            this.RunTimeLabel.Location = new System.Drawing.Point(146, 36);
            this.RunTimeLabel.Name = "RunTimeLabel";
            this.RunTimeLabel.Size = new System.Drawing.Size(53, 13);
            this.RunTimeLabel.TabIndex = 2;
            this.RunTimeLabel.Text = "RunTime:";
            // 
            // RestartLabel
            // 
            this.RestartLabel.AutoSize = true;
            this.RestartLabel.Location = new System.Drawing.Point(146, 59);
            this.RestartLabel.Name = "RestartLabel";
            this.RestartLabel.Size = new System.Drawing.Size(49, 13);
            this.RestartLabel.TabIndex = 3;
            this.RestartLabel.Text = "Restarts:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(448, 117);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainFileSystemWatcher
            // 
            this.mainFileSystemWatcher.EnableRaisingEvents = true;
            this.mainFileSystemWatcher.Filter = "config.ini";
            this.mainFileSystemWatcher.NotifyFilter = ((System.IO.NotifyFilters)((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.LastWrite)));
            this.mainFileSystemWatcher.SynchronizingObject = this;
            this.mainFileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.mainFileSystemWatcher_AllActions);
            this.mainFileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.mainFileSystemWatcher_AllActions);
            this.mainFileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.mainFileSystemWatcher_AllActions);
            this.mainFileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.mainFileSystemWatcher_Renamed);
            // 
            // RestartCountLabel
            // 
            this.RestartCountLabel.AutoSize = true;
            this.RestartCountLabel.Location = new System.Drawing.Point(205, 59);
            this.RestartCountLabel.Name = "RestartCountLabel";
            this.RestartCountLabel.Size = new System.Drawing.Size(13, 13);
            this.RestartCountLabel.TabIndex = 5;
            this.RestartCountLabel.Text = "0";
            // 
            // RunTimeTimeLabel
            // 
            this.RunTimeTimeLabel.AutoSize = true;
            this.RunTimeTimeLabel.Location = new System.Drawing.Point(205, 36);
            this.RunTimeTimeLabel.Name = "RunTimeTimeLabel";
            this.RunTimeTimeLabel.Size = new System.Drawing.Size(10, 13);
            this.RunTimeTimeLabel.TabIndex = 6;
            this.RunTimeTimeLabel.Text = "-";
            // 
            // statusTextLabel
            // 
            this.statusTextLabel.AutoSize = true;
            this.statusTextLabel.Location = new System.Drawing.Point(205, 12);
            this.statusTextLabel.Name = "statusTextLabel";
            this.statusTextLabel.Size = new System.Drawing.Size(10, 13);
            this.statusTextLabel.TabIndex = 7;
            this.statusTextLabel.Text = "-";
            // 
            // updateLogButton
            // 
            this.updateLogButton.Location = new System.Drawing.Point(149, 117);
            this.updateLogButton.Name = "updateLogButton";
            this.updateLogButton.Size = new System.Drawing.Size(75, 23);
            this.updateLogButton.TabIndex = 8;
            this.updateLogButton.Text = "Update Log";
            this.updateLogButton.UseVisualStyleBackColor = true;
            this.updateLogButton.Click += new System.EventHandler(this.updateLogButton_Click);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(367, 117);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(75, 23);
            this.logButton.TabIndex = 9;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 149);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.updateLogButton);
            this.Controls.Add(this.statusTextLabel);
            this.Controls.Add(this.RunTimeTimeLabel);
            this.Controls.Add(this.RestartCountLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.RestartLabel);
            this.Controls.Add(this.RunTimeLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doorway Studio 2012 Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.NotifyIcon mainNotifyIcon;
        private System.Windows.Forms.PictureBox statusPictureBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label RunTimeLabel;
        private System.Windows.Forms.Label RestartLabel;
        private System.Windows.Forms.Button exitButton;
        private System.IO.FileSystemWatcher mainFileSystemWatcher;
        private System.Windows.Forms.Label RestartCountLabel;
        private System.Windows.Forms.Label RunTimeTimeLabel;
        private System.Windows.Forms.Label statusTextLabel;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button updateLogButton;
    }
}

