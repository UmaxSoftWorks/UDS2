namespace Umax.Windows.Windows.Common
{
    partial class ErrorReporter
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
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.timeToCloseLabel = new System.Windows.Forms.Label();
            this.timeToCloseCountLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(12, 12);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(48, 48);
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(12, 79);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.ReadOnly = true;
            this.detailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detailsTextBox.Size = new System.Drawing.Size(570, 191);
            this.detailsTextBox.TabIndex = 2;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(12, 63);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(42, 13);
            this.detailsLabel.TabIndex = 2;
            this.detailsLabel.Text = "Details:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(507, 409);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButtonClick);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(66, 12);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(53, 13);
            this.messageLabel.TabIndex = 6;
            this.messageLabel.Text = "Message:";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(12, 289);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(570, 114);
            this.logTextBox.TabIndex = 3;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(9, 273);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(28, 13);
            this.logLabel.TabIndex = 7;
            this.logLabel.Text = "Log:";
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerTick);
            // 
            // timeToCloseLabel
            // 
            this.timeToCloseLabel.AutoSize = true;
            this.timeToCloseLabel.Location = new System.Drawing.Point(12, 414);
            this.timeToCloseLabel.Name = "timeToCloseLabel";
            this.timeToCloseLabel.Size = new System.Drawing.Size(73, 13);
            this.timeToCloseLabel.TabIndex = 9;
            this.timeToCloseLabel.Text = "Time to close:";
            this.timeToCloseLabel.Click += new System.EventHandler(this.TimeToCloseLabel);
            // 
            // timeToCloseCountLabel
            // 
            this.timeToCloseCountLabel.AutoSize = true;
            this.timeToCloseCountLabel.Location = new System.Drawing.Point(91, 414);
            this.timeToCloseCountLabel.Name = "timeToCloseCountLabel";
            this.timeToCloseCountLabel.Size = new System.Drawing.Size(19, 13);
            this.timeToCloseCountLabel.TabIndex = 10;
            this.timeToCloseCountLabel.Text = "60";
            this.timeToCloseCountLabel.Click += new System.EventHandler(this.timeToCloseCountLabelClick);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(66, 28);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTextBox.Size = new System.Drawing.Size(516, 45);
            this.messageTextBox.TabIndex = 1;
            // 
            // CriticalErrorReporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 432);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.timeToCloseCountLabel);
            this.Controls.Add(this.timeToCloseLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.mainPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CriticalErrorReporter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doorway Studio 2012: Critical Error!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CriticalErrorReporterFormClosing);
            this.Load += new System.EventHandler(this.CriticalErrorReporterLoad);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox mainPictureBox;
        protected System.Windows.Forms.TextBox detailsTextBox;
        protected System.Windows.Forms.Label detailsLabel;
        protected System.Windows.Forms.Button okButton;
        protected System.Windows.Forms.Label messageLabel;
        protected System.Windows.Forms.TextBox logTextBox;
        protected System.Windows.Forms.Label logLabel;
        protected System.Windows.Forms.Timer mainTimer;
        protected System.Windows.Forms.Label timeToCloseLabel;
        protected System.Windows.Forms.Label timeToCloseCountLabel;
        protected System.Windows.Forms.TextBox messageTextBox;

    }
}