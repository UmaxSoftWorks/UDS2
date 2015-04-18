namespace Umax.Windows.Controls.Options.GUI
{
    partial class OptionsGuiMonitor
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
            this.monitorGoupBox = new System.Windows.Forms.GroupBox();
            this.baloonsGroupBox = new System.Windows.Forms.GroupBox();
            this.baloonsShowTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.baloonsShowTimeLabel = new System.Windows.Forms.Label();
            this.baloonsShowBaloonsCheckBox = new System.Windows.Forms.CheckBox();
            this.monitorCheckBox = new System.Windows.Forms.CheckBox();
            this.generalLogGroupBox = new System.Windows.Forms.GroupBox();
            this.generalLogFileTextBox = new System.Windows.Forms.TextBox();
            this.generalLogFileLabel = new System.Windows.Forms.Label();
            this.generalLogDirectoryButton = new System.Windows.Forms.Button();
            this.generalLogDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.generalLogDirectoryLabel = new System.Windows.Forms.Label();
            this.generalLogSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.mainFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.generalTabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.loggingTabPage = new System.Windows.Forms.TabPage();
            this.updateLogGroupBox = new System.Windows.Forms.GroupBox();
            this.updateLogFileTextBox = new System.Windows.Forms.TextBox();
            this.updateLogFileLabel = new System.Windows.Forms.Label();
            this.updateLogDirectoryButton = new System.Windows.Forms.Button();
            this.updateLogDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.updateLogDirectoryLabel = new System.Windows.Forms.Label();
            this.updateLogSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.actionPanel.SuspendLayout();
            this.monitorGoupBox.SuspendLayout();
            this.baloonsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baloonsShowTimeNumericUpDown)).BeginInit();
            this.generalLogGroupBox.SuspendLayout();
            this.generalTabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.loggingTabPage.SuspendLayout();
            this.updateLogGroupBox.SuspendLayout();
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
            this.actionPanel.TabIndex = 3;
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
            // monitorGoupBox
            // 
            this.monitorGoupBox.Controls.Add(this.baloonsGroupBox);
            this.monitorGoupBox.Controls.Add(this.monitorCheckBox);
            this.monitorGoupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.monitorGoupBox.Location = new System.Drawing.Point(3, 3);
            this.monitorGoupBox.Name = "monitorGoupBox";
            this.monitorGoupBox.Size = new System.Drawing.Size(516, 130);
            this.monitorGoupBox.TabIndex = 4;
            this.monitorGoupBox.TabStop = false;
            this.monitorGoupBox.Text = "Monitor";
            // 
            // baloonsGroupBox
            // 
            this.baloonsGroupBox.Controls.Add(this.baloonsShowTimeNumericUpDown);
            this.baloonsGroupBox.Controls.Add(this.baloonsShowTimeLabel);
            this.baloonsGroupBox.Controls.Add(this.baloonsShowBaloonsCheckBox);
            this.baloonsGroupBox.Location = new System.Drawing.Point(6, 38);
            this.baloonsGroupBox.Name = "baloonsGroupBox";
            this.baloonsGroupBox.Size = new System.Drawing.Size(507, 88);
            this.baloonsGroupBox.TabIndex = 1;
            this.baloonsGroupBox.TabStop = false;
            this.baloonsGroupBox.Text = "Baloons";
            // 
            // baloonsShowTimeNumericUpDown
            // 
            this.baloonsShowTimeNumericUpDown.Location = new System.Drawing.Point(6, 62);
            this.baloonsShowTimeNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.baloonsShowTimeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baloonsShowTimeNumericUpDown.Name = "baloonsShowTimeNumericUpDown";
            this.baloonsShowTimeNumericUpDown.Size = new System.Drawing.Size(104, 20);
            this.baloonsShowTimeNumericUpDown.TabIndex = 6;
            this.baloonsShowTimeNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // baloonsShowTimeLabel
            // 
            this.baloonsShowTimeLabel.AutoSize = true;
            this.baloonsShowTimeLabel.Location = new System.Drawing.Point(6, 46);
            this.baloonsShowTimeLabel.Name = "baloonsShowTimeLabel";
            this.baloonsShowTimeLabel.Size = new System.Drawing.Size(82, 13);
            this.baloonsShowTimeLabel.TabIndex = 5;
            this.baloonsShowTimeLabel.Text = "Show time (sec)";
            // 
            // baloonsShowBaloonsCheckBox
            // 
            this.baloonsShowBaloonsCheckBox.Location = new System.Drawing.Point(6, 19);
            this.baloonsShowBaloonsCheckBox.Name = "baloonsShowBaloonsCheckBox";
            this.baloonsShowBaloonsCheckBox.Size = new System.Drawing.Size(104, 24);
            this.baloonsShowBaloonsCheckBox.TabIndex = 4;
            this.baloonsShowBaloonsCheckBox.Text = "Show baloons";
            this.baloonsShowBaloonsCheckBox.UseVisualStyleBackColor = true;
            this.baloonsShowBaloonsCheckBox.CheckedChanged += new System.EventHandler(this.baloonsShowBaloonsCheckBox_CheckedChanged);
            // 
            // monitorCheckBox
            // 
            this.monitorCheckBox.AutoSize = true;
            this.monitorCheckBox.Location = new System.Drawing.Point(6, 15);
            this.monitorCheckBox.Name = "monitorCheckBox";
            this.monitorCheckBox.Size = new System.Drawing.Size(96, 17);
            this.monitorCheckBox.TabIndex = 0;
            this.monitorCheckBox.Text = "Enable monitor";
            this.monitorCheckBox.UseVisualStyleBackColor = true;
            this.monitorCheckBox.CheckedChanged += new System.EventHandler(this.monitorCheckBox_CheckedChanged);
            // 
            // generalLogGroupBox
            // 
            this.generalLogGroupBox.Controls.Add(this.generalLogFileTextBox);
            this.generalLogGroupBox.Controls.Add(this.generalLogFileLabel);
            this.generalLogGroupBox.Controls.Add(this.generalLogDirectoryButton);
            this.generalLogGroupBox.Controls.Add(this.generalLogDirectoryTextBox);
            this.generalLogGroupBox.Controls.Add(this.generalLogDirectoryLabel);
            this.generalLogGroupBox.Controls.Add(this.generalLogSaveCheckBox);
            this.generalLogGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.generalLogGroupBox.Location = new System.Drawing.Point(3, 3);
            this.generalLogGroupBox.Name = "generalLogGroupBox";
            this.generalLogGroupBox.Size = new System.Drawing.Size(516, 121);
            this.generalLogGroupBox.TabIndex = 1;
            this.generalLogGroupBox.TabStop = false;
            this.generalLogGroupBox.Text = "Logging";
            // 
            // generalLogFileTextBox
            // 
            this.generalLogFileTextBox.Location = new System.Drawing.Point(6, 55);
            this.generalLogFileTextBox.Name = "generalLogFileTextBox";
            this.generalLogFileTextBox.Size = new System.Drawing.Size(507, 20);
            this.generalLogFileTextBox.TabIndex = 11;
            // 
            // generalLogFileLabel
            // 
            this.generalLogFileLabel.AutoSize = true;
            this.generalLogFileLabel.Location = new System.Drawing.Point(6, 39);
            this.generalLogFileLabel.Name = "generalLogFileLabel";
            this.generalLogFileLabel.Size = new System.Drawing.Size(54, 13);
            this.generalLogFileLabel.TabIndex = 10;
            this.generalLogFileLabel.Text = "File Name";
            // 
            // generalLogDirectoryButton
            // 
            this.generalLogDirectoryButton.Location = new System.Drawing.Point(473, 91);
            this.generalLogDirectoryButton.Name = "generalLogDirectoryButton";
            this.generalLogDirectoryButton.Size = new System.Drawing.Size(40, 23);
            this.generalLogDirectoryButton.TabIndex = 9;
            this.generalLogDirectoryButton.Text = "...";
            this.generalLogDirectoryButton.UseVisualStyleBackColor = true;
            this.generalLogDirectoryButton.Click += new System.EventHandler(this.generalLogDirectoryButton_Click);
            // 
            // generalLogDirectoryTextBox
            // 
            this.generalLogDirectoryTextBox.Location = new System.Drawing.Point(6, 94);
            this.generalLogDirectoryTextBox.Name = "generalLogDirectoryTextBox";
            this.generalLogDirectoryTextBox.Size = new System.Drawing.Size(461, 20);
            this.generalLogDirectoryTextBox.TabIndex = 3;
            // 
            // generalLogDirectoryLabel
            // 
            this.generalLogDirectoryLabel.AutoSize = true;
            this.generalLogDirectoryLabel.Location = new System.Drawing.Point(6, 78);
            this.generalLogDirectoryLabel.Name = "generalLogDirectoryLabel";
            this.generalLogDirectoryLabel.Size = new System.Drawing.Size(49, 13);
            this.generalLogDirectoryLabel.TabIndex = 2;
            this.generalLogDirectoryLabel.Text = "Directory";
            // 
            // generalLogSaveCheckBox
            // 
            this.generalLogSaveCheckBox.AutoSize = true;
            this.generalLogSaveCheckBox.Location = new System.Drawing.Point(6, 19);
            this.generalLogSaveCheckBox.Name = "generalLogSaveCheckBox";
            this.generalLogSaveCheckBox.Size = new System.Drawing.Size(68, 17);
            this.generalLogSaveCheckBox.TabIndex = 0;
            this.generalLogSaveCheckBox.Text = "Save log";
            this.generalLogSaveCheckBox.UseVisualStyleBackColor = true;
            this.generalLogSaveCheckBox.CheckedChanged += new System.EventHandler(this.generalLogSaveCheckBox_CheckedChanged);
            // 
            // generalTabControl
            // 
            this.generalTabControl.Controls.Add(this.generalTabPage);
            this.generalTabControl.Controls.Add(this.loggingTabPage);
            this.generalTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTabControl.Location = new System.Drawing.Point(0, 0);
            this.generalTabControl.Name = "generalTabControl";
            this.generalTabControl.SelectedIndex = 0;
            this.generalTabControl.Size = new System.Drawing.Size(530, 326);
            this.generalTabControl.TabIndex = 8;
            // 
            // generalTabPage
            // 
            this.generalTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.generalTabPage.Controls.Add(this.monitorGoupBox);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(522, 300);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            // 
            // loggingTabPage
            // 
            this.loggingTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.loggingTabPage.Controls.Add(this.updateLogGroupBox);
            this.loggingTabPage.Controls.Add(this.generalLogGroupBox);
            this.loggingTabPage.Location = new System.Drawing.Point(4, 22);
            this.loggingTabPage.Name = "loggingTabPage";
            this.loggingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loggingTabPage.Size = new System.Drawing.Size(522, 300);
            this.loggingTabPage.TabIndex = 1;
            this.loggingTabPage.Text = "Logging";
            // 
            // updateLogGroupBox
            // 
            this.updateLogGroupBox.Controls.Add(this.updateLogFileTextBox);
            this.updateLogGroupBox.Controls.Add(this.updateLogFileLabel);
            this.updateLogGroupBox.Controls.Add(this.updateLogDirectoryButton);
            this.updateLogGroupBox.Controls.Add(this.updateLogDirectoryTextBox);
            this.updateLogGroupBox.Controls.Add(this.updateLogDirectoryLabel);
            this.updateLogGroupBox.Controls.Add(this.updateLogSaveCheckBox);
            this.updateLogGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateLogGroupBox.Location = new System.Drawing.Point(3, 124);
            this.updateLogGroupBox.Name = "updateLogGroupBox";
            this.updateLogGroupBox.Size = new System.Drawing.Size(516, 121);
            this.updateLogGroupBox.TabIndex = 2;
            this.updateLogGroupBox.TabStop = false;
            this.updateLogGroupBox.Text = "Update Logging";
            // 
            // updateLogFileTextBox
            // 
            this.updateLogFileTextBox.Location = new System.Drawing.Point(6, 55);
            this.updateLogFileTextBox.Name = "updateLogFileTextBox";
            this.updateLogFileTextBox.Size = new System.Drawing.Size(507, 20);
            this.updateLogFileTextBox.TabIndex = 11;
            // 
            // updateLogFileLabel
            // 
            this.updateLogFileLabel.AutoSize = true;
            this.updateLogFileLabel.Location = new System.Drawing.Point(6, 39);
            this.updateLogFileLabel.Name = "updateLogFileLabel";
            this.updateLogFileLabel.Size = new System.Drawing.Size(54, 13);
            this.updateLogFileLabel.TabIndex = 10;
            this.updateLogFileLabel.Text = "File Name";
            // 
            // updateLogDirectoryButton
            // 
            this.updateLogDirectoryButton.Location = new System.Drawing.Point(473, 92);
            this.updateLogDirectoryButton.Name = "updateLogDirectoryButton";
            this.updateLogDirectoryButton.Size = new System.Drawing.Size(40, 23);
            this.updateLogDirectoryButton.TabIndex = 9;
            this.updateLogDirectoryButton.Text = "...";
            this.updateLogDirectoryButton.UseVisualStyleBackColor = true;
            this.updateLogDirectoryButton.Click += new System.EventHandler(this.updateLogDirectoryButton_Click);
            // 
            // updateLogDirectoryTextBox
            // 
            this.updateLogDirectoryTextBox.Location = new System.Drawing.Point(6, 94);
            this.updateLogDirectoryTextBox.Name = "updateLogDirectoryTextBox";
            this.updateLogDirectoryTextBox.Size = new System.Drawing.Size(461, 20);
            this.updateLogDirectoryTextBox.TabIndex = 3;
            // 
            // updateLogDirectoryLabel
            // 
            this.updateLogDirectoryLabel.AutoSize = true;
            this.updateLogDirectoryLabel.Location = new System.Drawing.Point(6, 78);
            this.updateLogDirectoryLabel.Name = "updateLogDirectoryLabel";
            this.updateLogDirectoryLabel.Size = new System.Drawing.Size(49, 13);
            this.updateLogDirectoryLabel.TabIndex = 2;
            this.updateLogDirectoryLabel.Text = "Directory";
            // 
            // updateLogSaveCheckBox
            // 
            this.updateLogSaveCheckBox.AutoSize = true;
            this.updateLogSaveCheckBox.Location = new System.Drawing.Point(6, 19);
            this.updateLogSaveCheckBox.Name = "updateLogSaveCheckBox";
            this.updateLogSaveCheckBox.Size = new System.Drawing.Size(68, 17);
            this.updateLogSaveCheckBox.TabIndex = 0;
            this.updateLogSaveCheckBox.Text = "Save log";
            this.updateLogSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // OptionsGuiMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generalTabControl);
            this.Controls.Add(this.actionPanel);
            this.Name = "OptionsGuiMonitor";
            this.Size = new System.Drawing.Size(530, 349);
            this.Load += new System.EventHandler(this.OptionsGuiMonitor_Load);
            this.actionPanel.ResumeLayout(false);
            this.monitorGoupBox.ResumeLayout(false);
            this.monitorGoupBox.PerformLayout();
            this.baloonsGroupBox.ResumeLayout(false);
            this.baloonsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baloonsShowTimeNumericUpDown)).EndInit();
            this.generalLogGroupBox.ResumeLayout(false);
            this.generalLogGroupBox.PerformLayout();
            this.generalTabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.loggingTabPage.ResumeLayout(false);
            this.updateLogGroupBox.ResumeLayout(false);
            this.updateLogGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox monitorGoupBox;
        private System.Windows.Forms.CheckBox monitorCheckBox;
        private System.Windows.Forms.GroupBox baloonsGroupBox;
        private System.Windows.Forms.NumericUpDown baloonsShowTimeNumericUpDown;
        private System.Windows.Forms.Label baloonsShowTimeLabel;
        private System.Windows.Forms.CheckBox baloonsShowBaloonsCheckBox;
        private System.Windows.Forms.GroupBox generalLogGroupBox;
        private System.Windows.Forms.TextBox generalLogFileTextBox;
        private System.Windows.Forms.Label generalLogFileLabel;
        private System.Windows.Forms.Button generalLogDirectoryButton;
        private System.Windows.Forms.TextBox generalLogDirectoryTextBox;
        private System.Windows.Forms.Label generalLogDirectoryLabel;
        private System.Windows.Forms.CheckBox generalLogSaveCheckBox;
        private System.Windows.Forms.FolderBrowserDialog mainFolderBrowserDialog;
        private System.Windows.Forms.TabControl generalTabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage loggingTabPage;
        private System.Windows.Forms.GroupBox updateLogGroupBox;
        private System.Windows.Forms.TextBox updateLogFileTextBox;
        private System.Windows.Forms.Label updateLogFileLabel;
        private System.Windows.Forms.Button updateLogDirectoryButton;
        private System.Windows.Forms.TextBox updateLogDirectoryTextBox;
        private System.Windows.Forms.Label updateLogDirectoryLabel;
        private System.Windows.Forms.CheckBox updateLogSaveCheckBox;
    }
}
