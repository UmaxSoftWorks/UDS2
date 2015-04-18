namespace Umax.Windows.Controls.Options.GUI
{
    partial class OptionsGuiReporting
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
            this.actionPanel = new System.Windows.Forms.Panel();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mailingGroupBox = new System.Windows.Forms.GroupBox();
            this.reportRDCheckBox = new System.Windows.Forms.CheckBox();
            this.attachLogsCheckBox = new System.Windows.Forms.CheckBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.reportingCheckBox = new System.Windows.Forms.CheckBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.portNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.actionPanel.SuspendLayout();
            this.mailingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.applyButton);
            this.actionPanel.Controls.Add(this.cancelButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 326);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(530, 23);
            this.actionPanel.TabIndex = 4;
            // 
            // applyButton
            // 
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.applyButton.Location = new System.Drawing.Point(380, 0);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.Location = new System.Drawing.Point(455, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // mailingGroupBox
            // 
            this.mailingGroupBox.Controls.Add(this.portNumericUpDown);
            this.mailingGroupBox.Controls.Add(this.passwordTextBox);
            this.mailingGroupBox.Controls.Add(this.loginTextBox);
            this.mailingGroupBox.Controls.Add(this.passwordLabel);
            this.mailingGroupBox.Controls.Add(this.loginLabel);
            this.mailingGroupBox.Controls.Add(this.hostTextBox);
            this.mailingGroupBox.Controls.Add(this.messageTextBox);
            this.mailingGroupBox.Controls.Add(this.subjectTextBox);
            this.mailingGroupBox.Controls.Add(this.toTextBox);
            this.mailingGroupBox.Controls.Add(this.fromTextBox);
            this.mailingGroupBox.Controls.Add(this.reportRDCheckBox);
            this.mailingGroupBox.Controls.Add(this.attachLogsCheckBox);
            this.mailingGroupBox.Controls.Add(this.messageLabel);
            this.mailingGroupBox.Controls.Add(this.subjectLabel);
            this.mailingGroupBox.Controls.Add(this.fromLabel);
            this.mailingGroupBox.Controls.Add(this.toLabel);
            this.mailingGroupBox.Controls.Add(this.portLabel);
            this.mailingGroupBox.Controls.Add(this.hostLabel);
            this.mailingGroupBox.Controls.Add(this.reportingCheckBox);
            this.mailingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mailingGroupBox.Name = "mailingGroupBox";
            this.mailingGroupBox.Size = new System.Drawing.Size(530, 326);
            this.mailingGroupBox.TabIndex = 5;
            this.mailingGroupBox.TabStop = false;
            this.mailingGroupBox.Text = "Reporting";
            // 
            // reportRDCheckBox
            // 
            this.reportRDCheckBox.AutoSize = true;
            this.reportRDCheckBox.Location = new System.Drawing.Point(380, 19);
            this.reportRDCheckBox.Name = "reportRDCheckBox";
            this.reportRDCheckBox.Size = new System.Drawing.Size(140, 17);
            this.reportRDCheckBox.TabIndex = 9;
            this.reportRDCheckBox.Text = "Enable reporting to R&&D";
            this.reportRDCheckBox.UseVisualStyleBackColor = true;
            // 
            // attachLogsCheckBox
            // 
            this.attachLogsCheckBox.AutoSize = true;
            this.attachLogsCheckBox.Location = new System.Drawing.Point(380, 276);
            this.attachLogsCheckBox.Name = "attachLogsCheckBox";
            this.attachLogsCheckBox.Size = new System.Drawing.Size(79, 17);
            this.attachLogsCheckBox.TabIndex = 8;
            this.attachLogsCheckBox.Text = "Attach logs";
            this.attachLogsCheckBox.UseVisualStyleBackColor = true;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(6, 123);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(50, 13);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "Message";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(6, 97);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(43, 13);
            this.subjectLabel.TabIndex = 6;
            this.subjectLabel.Text = "Subject";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(6, 45);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(30, 13);
            this.fromLabel.TabIndex = 5;
            this.fromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(6, 71);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 13);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(263, 277);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Port";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(6, 277);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(62, 13);
            this.hostLabel.TabIndex = 2;
            this.hostLabel.Text = "SMTP Host";
            // 
            // reportingCheckBox
            // 
            this.reportingCheckBox.AutoSize = true;
            this.reportingCheckBox.Location = new System.Drawing.Point(6, 19);
            this.reportingCheckBox.Name = "reportingCheckBox";
            this.reportingCheckBox.Size = new System.Drawing.Size(59, 17);
            this.reportingCheckBox.TabIndex = 1;
            this.reportingCheckBox.Text = "Enable";
            this.reportingCheckBox.UseVisualStyleBackColor = true;
            this.reportingCheckBox.CheckedChanged += new System.EventHandler(this.reportingCheckBox_CheckedChanged);
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(74, 42);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(450, 20);
            this.fromTextBox.TabIndex = 10;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(74, 68);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(450, 20);
            this.toTextBox.TabIndex = 11;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(74, 94);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(450, 20);
            this.subjectTextBox.TabIndex = 12;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(74, 120);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTextBox.Size = new System.Drawing.Size(450, 148);
            this.messageTextBox.TabIndex = 13;
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(74, 274);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(183, 20);
            this.hostTextBox.TabIndex = 14;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(322, 300);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(202, 20);
            this.passwordTextBox.TabIndex = 19;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(74, 300);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(183, 20);
            this.loginTextBox.TabIndex = 18;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(263, 303);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 17;
            this.passwordLabel.Text = "Password";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(6, 303);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 16;
            this.loginLabel.Text = "Login";
            // 
            // portNumericUpDown
            // 
            this.portNumericUpDown.Location = new System.Drawing.Point(295, 275);
            this.portNumericUpDown.Name = "portNumericUpDown";
            this.portNumericUpDown.Size = new System.Drawing.Size(79, 20);
            this.portNumericUpDown.TabIndex = 20;
            this.portNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // OptionsGuiReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mailingGroupBox);
            this.Controls.Add(this.actionPanel);
            this.Name = "OptionsGuiReporting";
            this.Size = new System.Drawing.Size(530, 349);
            this.Load += new System.EventHandler(this.OptionsGuiReporting_Load);
            this.actionPanel.ResumeLayout(false);
            this.mailingGroupBox.ResumeLayout(false);
            this.mailingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox mailingGroupBox;
        private System.Windows.Forms.CheckBox attachLogsCheckBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.CheckBox reportingCheckBox;
        private System.Windows.Forms.CheckBox reportRDCheckBox;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.NumericUpDown portNumericUpDown;
    }
}
