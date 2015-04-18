namespace WebParser.Windows.Tasks
{
    partial class TaskEditor
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.taskTabPage = new System.Windows.Forms.TabPage();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.taskTabPage.SuspendLayout();
            this.generalGroupBox.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.taskTabPage);
            this.mainTabControl.Controls.Add(this.settingsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(684, 439);
            this.mainTabControl.TabIndex = 0;
            // 
            // taskTabPage
            // 
            this.taskTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.taskTabPage.Controls.Add(this.generalGroupBox);
            this.taskTabPage.Location = new System.Drawing.Point(4, 22);
            this.taskTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.taskTabPage.Name = "taskTabPage";
            this.taskTabPage.Size = new System.Drawing.Size(676, 413);
            this.taskTabPage.TabIndex = 0;
            this.taskTabPage.Text = "Task";
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.dateTimePicker);
            this.generalGroupBox.Controls.Add(this.timeLabel);
            this.generalGroupBox.Controls.Add(this.nameTextBox);
            this.generalGroupBox.Controls.Add(this.nameLabel);
            this.generalGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.generalGroupBox.Location = new System.Drawing.Point(0, 0);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(676, 73);
            this.generalGroupBox.TabIndex = 0;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dddd, MMMM dd, yyyy hh:mm:ss tt";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(47, 45);
            this.dateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(291, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(6, 51);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(30, 13);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "Time";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(47, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(623, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(676, 413);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "Settings";
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.cancelButton);
            this.actionPanel.Controls.Add(this.okButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 439);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(684, 23);
            this.actionPanel.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(609, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButtonClick);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(532, 0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButtonClick);
            // 
            // TaskEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.actionPanel);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "TaskEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Parser 2012: Task";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskEditorFormClosing);
            this.Load += new System.EventHandler(this.TaskEditorLoad);
            this.mainTabControl.ResumeLayout(false);
            this.taskTabPage.ResumeLayout(false);
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage taskTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}