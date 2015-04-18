namespace Umax.Windows.Controls.Options.GUI
{
    partial class OptionsGuiUpdates
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
            this.generalCheckWhileRunningPeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generalCheckWhileRunningPeriodLabel = new System.Windows.Forms.Label();
            this.generalCheckWhileRunningCheckBox = new System.Windows.Forms.CheckBox();
            this.generalCheckOnStartUpCheckBox = new System.Windows.Forms.CheckBox();
            this.actionPanel.SuspendLayout();
            this.generalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalCheckWhileRunningPeriodNumericUpDown)).BeginInit();
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
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.generalCheckWhileRunningPeriodNumericUpDown);
            this.generalGroupBox.Controls.Add(this.generalCheckWhileRunningPeriodLabel);
            this.generalGroupBox.Controls.Add(this.generalCheckWhileRunningCheckBox);
            this.generalGroupBox.Controls.Add(this.generalCheckOnStartUpCheckBox);
            this.generalGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.generalGroupBox.Location = new System.Drawing.Point(0, 0);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(530, 94);
            this.generalGroupBox.TabIndex = 5;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // generalCheckWhileRunningPeriodNumericUpDown
            // 
            this.generalCheckWhileRunningPeriodNumericUpDown.Location = new System.Drawing.Point(117, 65);
            this.generalCheckWhileRunningPeriodNumericUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.generalCheckWhileRunningPeriodNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.generalCheckWhileRunningPeriodNumericUpDown.Name = "generalCheckWhileRunningPeriodNumericUpDown";
            this.generalCheckWhileRunningPeriodNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.generalCheckWhileRunningPeriodNumericUpDown.TabIndex = 3;
            this.generalCheckWhileRunningPeriodNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // generalCheckWhileRunningPeriodLabel
            // 
            this.generalCheckWhileRunningPeriodLabel.AutoSize = true;
            this.generalCheckWhileRunningPeriodLabel.Location = new System.Drawing.Point(6, 67);
            this.generalCheckWhileRunningPeriodLabel.Name = "generalCheckWhileRunningPeriodLabel";
            this.generalCheckWhileRunningPeriodLabel.Size = new System.Drawing.Size(105, 13);
            this.generalCheckWhileRunningPeriodLabel.TabIndex = 2;
            this.generalCheckWhileRunningPeriodLabel.Text = "Check period (hours)";
            // 
            // generalCheckWhileRunningCheckBox
            // 
            this.generalCheckWhileRunningCheckBox.AutoSize = true;
            this.generalCheckWhileRunningCheckBox.Location = new System.Drawing.Point(6, 42);
            this.generalCheckWhileRunningCheckBox.Name = "generalCheckWhileRunningCheckBox";
            this.generalCheckWhileRunningCheckBox.Size = new System.Drawing.Size(175, 17);
            this.generalCheckWhileRunningCheckBox.TabIndex = 1;
            this.generalCheckWhileRunningCheckBox.Text = "Check for update while working";
            this.generalCheckWhileRunningCheckBox.UseVisualStyleBackColor = true;
            this.generalCheckWhileRunningCheckBox.CheckedChanged += new System.EventHandler(this.generalCheckWhileRunningCheckBox_CheckedChanged);
            // 
            // generalCheckOnStartUpCheckBox
            // 
            this.generalCheckOnStartUpCheckBox.AutoSize = true;
            this.generalCheckOnStartUpCheckBox.Location = new System.Drawing.Point(6, 19);
            this.generalCheckOnStartUpCheckBox.Name = "generalCheckOnStartUpCheckBox";
            this.generalCheckOnStartUpCheckBox.Size = new System.Drawing.Size(158, 17);
            this.generalCheckOnStartUpCheckBox.TabIndex = 0;
            this.generalCheckOnStartUpCheckBox.Text = "Check for update on startup";
            this.generalCheckOnStartUpCheckBox.UseVisualStyleBackColor = true;
            this.generalCheckOnStartUpCheckBox.CheckedChanged += new System.EventHandler(this.generalCheckOnStartUpCheckBox_CheckedChanged);
            // 
            // OptionsGuiUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generalGroupBox);
            this.Controls.Add(this.actionPanel);
            this.Name = "OptionsGuiUpdates";
            this.Size = new System.Drawing.Size(530, 349);
            this.Load += new System.EventHandler(this.OptionsGuiUpdates_Load);
            this.actionPanel.ResumeLayout(false);
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalCheckWhileRunningPeriodNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.CheckBox generalCheckOnStartUpCheckBox;
        private System.Windows.Forms.NumericUpDown generalCheckWhileRunningPeriodNumericUpDown;
        private System.Windows.Forms.Label generalCheckWhileRunningPeriodLabel;
        private System.Windows.Forms.CheckBox generalCheckWhileRunningCheckBox;

    }
}
