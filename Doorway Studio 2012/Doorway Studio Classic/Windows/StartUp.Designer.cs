namespace DoorwayStudio.Windows
{
    partial class StartUp
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
            this.actionLabel = new System.Windows.Forms.Label();
            this.actionTextLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateTextLabel = new System.Windows.Forms.Label();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.startDemoButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(12, 9);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(43, 13);
            this.actionLabel.TabIndex = 0;
            this.actionLabel.Text = "Action: ";
            // 
            // actionTextLabel
            // 
            this.actionTextLabel.AutoSize = true;
            this.actionTextLabel.Location = new System.Drawing.Point(61, 9);
            this.actionTextLabel.Name = "actionTextLabel";
            this.actionTextLabel.Size = new System.Drawing.Size(10, 13);
            this.actionTextLabel.TabIndex = 1;
            this.actionTextLabel.Text = "-";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(12, 34);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "State:";
            // 
            // stateTextLabel
            // 
            this.stateTextLabel.AutoSize = true;
            this.stateTextLabel.Location = new System.Drawing.Point(61, 34);
            this.stateTextLabel.Name = "stateTextLabel";
            this.stateTextLabel.Size = new System.Drawing.Size(10, 13);
            this.stateTextLabel.TabIndex = 3;
            this.stateTextLabel.Text = "-";
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Location = new System.Drawing.Point(15, 54);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(450, 12);
            this.mainProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressBar.TabIndex = 4;
            // 
            // startDemoButton
            // 
            this.startDemoButton.Location = new System.Drawing.Point(15, 74);
            this.startDemoButton.Name = "startDemoButton";
            this.startDemoButton.Size = new System.Drawing.Size(115, 23);
            this.startDemoButton.TabIndex = 5;
            this.startDemoButton.Text = "Start Demo";
            this.startDemoButton.UseVisualStyleBackColor = true;
            this.startDemoButton.Click += new System.EventHandler(this.StartDemoButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(390, 72);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // mainBackgroundWorker
            // 
            this.mainBackgroundWorker.WorkerSupportsCancellation = true;
            this.mainBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.mainBackgroundWorkerDoWork);
            this.mainBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.mainBackgroundWorkerRunWorkerCompleted);
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 104);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startDemoButton);
            this.Controls.Add(this.mainProgressBar);
            this.Controls.Add(this.stateTextLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.actionTextLabel);
            this.Controls.Add(this.actionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StartUp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doorway Studio 2012";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartUpFormClosing);
            this.Load += new System.EventHandler(this.StartUpLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label actionLabel;
        protected System.Windows.Forms.Label actionTextLabel;
        protected System.Windows.Forms.Label stateLabel;
        protected System.Windows.Forms.Label stateTextLabel;
        protected System.Windows.Forms.ProgressBar mainProgressBar;
        protected System.Windows.Forms.Button startDemoButton;
        protected System.Windows.Forms.Button exitButton;
        protected System.ComponentModel.BackgroundWorker mainBackgroundWorker;

    }
}

