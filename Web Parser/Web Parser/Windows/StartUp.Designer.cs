namespace WebParser.Windows
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
            this.exitButton = new System.Windows.Forms.Button();
            this.startDemoButton = new System.Windows.Forms.Button();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.stateTextLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.mainBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.actionTextLabel = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(389, 71);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // startDemoButton
            // 
            this.startDemoButton.Location = new System.Drawing.Point(14, 73);
            this.startDemoButton.Name = "startDemoButton";
            this.startDemoButton.Size = new System.Drawing.Size(115, 23);
            this.startDemoButton.TabIndex = 13;
            this.startDemoButton.Text = "Start Demo";
            this.startDemoButton.UseVisualStyleBackColor = true;
            this.startDemoButton.Click += new System.EventHandler(this.StartDemoButtonClick);
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Location = new System.Drawing.Point(14, 53);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(450, 12);
            this.mainProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressBar.TabIndex = 12;
            // 
            // stateTextLabel
            // 
            this.stateTextLabel.AutoSize = true;
            this.stateTextLabel.Location = new System.Drawing.Point(60, 33);
            this.stateTextLabel.Name = "stateTextLabel";
            this.stateTextLabel.Size = new System.Drawing.Size(10, 13);
            this.stateTextLabel.TabIndex = 11;
            this.stateTextLabel.Text = "-";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(11, 33);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 10;
            this.stateLabel.Text = "State:";
            // 
            // mainBackgroundWorker
            // 
            this.mainBackgroundWorker.WorkerSupportsCancellation = true;
            this.mainBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.mainBackgroundWorkerDoWork);
            this.mainBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.mainBackgroundWorkerRunWorkerCompleted);
            // 
            // actionTextLabel
            // 
            this.actionTextLabel.AutoSize = true;
            this.actionTextLabel.Location = new System.Drawing.Point(60, 8);
            this.actionTextLabel.Name = "actionTextLabel";
            this.actionTextLabel.Size = new System.Drawing.Size(10, 13);
            this.actionTextLabel.TabIndex = 9;
            this.actionTextLabel.Text = "-";
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(11, 8);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(43, 13);
            this.actionLabel.TabIndex = 8;
            this.actionLabel.Text = "Action: ";
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
            this.Name = "StartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Parser 2012";
            this.Load += new System.EventHandler(this.StartUpLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button exitButton;
        protected System.Windows.Forms.Button startDemoButton;
        protected System.Windows.Forms.ProgressBar mainProgressBar;
        protected System.Windows.Forms.Label stateTextLabel;
        protected System.Windows.Forms.Label stateLabel;
        protected System.ComponentModel.BackgroundWorker mainBackgroundWorker;
        protected System.Windows.Forms.Label actionTextLabel;
        protected System.Windows.Forms.Label actionLabel;
    }
}

