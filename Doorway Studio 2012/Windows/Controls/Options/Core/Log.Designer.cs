namespace Umax.Windows.Controls.Options.Core
{
    partial class OptionsCoreLog
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
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.generalLogMaxSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generalLogMaxSizeLabel = new System.Windows.Forms.Label();
            this.generalLogFileTextBox = new System.Windows.Forms.TextBox();
            this.generalLogFileLabel = new System.Windows.Forms.Label();
            this.generalLogDirectoryButton = new System.Windows.Forms.Button();
            this.generalLogDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.generalLogDirectoryLabel = new System.Windows.Forms.Label();
            this.generalLogSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.generalLogDirectoryFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.generalLogDebugModeCheckBox = new System.Windows.Forms.CheckBox();
            this.actionPanel.SuspendLayout();
            this.generalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalLogMaxSizeNumericUpDown)).BeginInit();
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
            this.applyButton.Click += new System.EventHandler(this.applyButtonClick);
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
            this.cancelButton.Click += new System.EventHandler(this.cancelButtonClick);
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.generalLogDebugModeCheckBox);
            this.generalGroupBox.Controls.Add(this.generalLogMaxSizeNumericUpDown);
            this.generalGroupBox.Controls.Add(this.generalLogMaxSizeLabel);
            this.generalGroupBox.Controls.Add(this.generalLogFileTextBox);
            this.generalGroupBox.Controls.Add(this.generalLogFileLabel);
            this.generalGroupBox.Controls.Add(this.generalLogDirectoryButton);
            this.generalGroupBox.Controls.Add(this.generalLogDirectoryTextBox);
            this.generalGroupBox.Controls.Add(this.generalLogDirectoryLabel);
            this.generalGroupBox.Controls.Add(this.generalLogSaveCheckBox);
            this.generalGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.generalGroupBox.Location = new System.Drawing.Point(0, 0);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(530, 180);
            this.generalGroupBox.TabIndex = 5;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "Logging";
            // 
            // generalLogMaxSizeNumericUpDown
            // 
            this.generalLogMaxSizeNumericUpDown.Location = new System.Drawing.Point(6, 55);
            this.generalLogMaxSizeNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.generalLogMaxSizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.generalLogMaxSizeNumericUpDown.Name = "generalLogMaxSizeNumericUpDown";
            this.generalLogMaxSizeNumericUpDown.Size = new System.Drawing.Size(102, 20);
            this.generalLogMaxSizeNumericUpDown.TabIndex = 13;
            this.generalLogMaxSizeNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // generalLogMaxSizeLabel
            // 
            this.generalLogMaxSizeLabel.AutoSize = true;
            this.generalLogMaxSizeLabel.Location = new System.Drawing.Point(6, 39);
            this.generalLogMaxSizeLabel.Name = "generalLogMaxSizeLabel";
            this.generalLogMaxSizeLabel.Size = new System.Drawing.Size(102, 13);
            this.generalLogMaxSizeLabel.TabIndex = 12;
            this.generalLogMaxSizeLabel.Text = "Maximum size (lines)";
            // 
            // generalLogFileTextBox
            // 
            this.generalLogFileTextBox.Location = new System.Drawing.Point(6, 94);
            this.generalLogFileTextBox.Name = "generalLogFileTextBox";
            this.generalLogFileTextBox.Size = new System.Drawing.Size(515, 20);
            this.generalLogFileTextBox.TabIndex = 11;
            // 
            // generalLogFileLabel
            // 
            this.generalLogFileLabel.AutoSize = true;
            this.generalLogFileLabel.Location = new System.Drawing.Point(6, 78);
            this.generalLogFileLabel.Name = "generalLogFileLabel";
            this.generalLogFileLabel.Size = new System.Drawing.Size(54, 13);
            this.generalLogFileLabel.TabIndex = 10;
            this.generalLogFileLabel.Text = "File Name";
            // 
            // generalLogDirectoryButton
            // 
            this.generalLogDirectoryButton.Location = new System.Drawing.Point(481, 131);
            this.generalLogDirectoryButton.Name = "generalLogDirectoryButton";
            this.generalLogDirectoryButton.Size = new System.Drawing.Size(40, 23);
            this.generalLogDirectoryButton.TabIndex = 9;
            this.generalLogDirectoryButton.Text = "...";
            this.generalLogDirectoryButton.UseVisualStyleBackColor = true;
            this.generalLogDirectoryButton.Click += new System.EventHandler(this.generalLogDirectoryButtonClick);
            // 
            // generalLogDirectoryTextBox
            // 
            this.generalLogDirectoryTextBox.Location = new System.Drawing.Point(6, 133);
            this.generalLogDirectoryTextBox.Name = "generalLogDirectoryTextBox";
            this.generalLogDirectoryTextBox.Size = new System.Drawing.Size(469, 20);
            this.generalLogDirectoryTextBox.TabIndex = 3;
            // 
            // generalLogDirectoryLabel
            // 
            this.generalLogDirectoryLabel.AutoSize = true;
            this.generalLogDirectoryLabel.Location = new System.Drawing.Point(6, 117);
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
            this.generalLogSaveCheckBox.CheckedChanged += new System.EventHandler(this.generalLogSaveCheckBoxCheckedChanged);
            // 
            // generalLogDebugModeCheckBox
            // 
            this.generalLogDebugModeCheckBox.AutoSize = true;
            this.generalLogDebugModeCheckBox.Location = new System.Drawing.Point(6, 159);
            this.generalLogDebugModeCheckBox.Name = "generalLogDebugModeCheckBox";
            this.generalLogDebugModeCheckBox.Size = new System.Drawing.Size(87, 17);
            this.generalLogDebugModeCheckBox.TabIndex = 14;
            this.generalLogDebugModeCheckBox.Text = "Debug mode";
            this.generalLogDebugModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // OptionsCoreLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generalGroupBox);
            this.Controls.Add(this.actionPanel);
            this.Name = "OptionsCoreLog";
            this.Size = new System.Drawing.Size(530, 349);
            this.Load += new System.EventHandler(this.OptionsCoreLogLoad);
            this.actionPanel.ResumeLayout(false);
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalLogMaxSizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.CheckBox generalLogSaveCheckBox;
        private System.Windows.Forms.TextBox generalLogDirectoryTextBox;
        private System.Windows.Forms.Label generalLogDirectoryLabel;
        private System.Windows.Forms.Button generalLogDirectoryButton;
        private System.Windows.Forms.FolderBrowserDialog generalLogDirectoryFolderBrowserDialog;
        private System.Windows.Forms.NumericUpDown generalLogMaxSizeNumericUpDown;
        private System.Windows.Forms.Label generalLogMaxSizeLabel;
        private System.Windows.Forms.TextBox generalLogFileTextBox;
        private System.Windows.Forms.Label generalLogFileLabel;
        private System.Windows.Forms.CheckBox generalLogDebugModeCheckBox;
    }
}
