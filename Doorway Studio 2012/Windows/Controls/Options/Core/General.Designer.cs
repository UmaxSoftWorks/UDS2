namespace Umax.Windows.Controls.Options.Core
{
    partial class OptionsCoreGeneral
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
            this.generalLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.generalLanguageLabel = new System.Windows.Forms.Label();
            this.paralellizationGroupBox = new System.Windows.Forms.GroupBox();
            this.paralellizationTasksNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.paralellizationTasksLabel = new System.Windows.Forms.Label();
            this.generationGroupBox = new System.Windows.Forms.GroupBox();
            this.timeoutCheckBox = new System.Windows.Forms.CheckBox();
            this.timeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.actionPanel.SuspendLayout();
            this.generalGroupBox.SuspendLayout();
            this.paralellizationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paralellizationTasksNumericUpDown)).BeginInit();
            this.generationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutNumericUpDown)).BeginInit();
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
            this.actionPanel.TabIndex = 5;
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
            this.generalGroupBox.Controls.Add(this.generalLanguageComboBox);
            this.generalGroupBox.Controls.Add(this.generalLanguageLabel);
            this.generalGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.generalGroupBox.Location = new System.Drawing.Point(0, 0);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(530, 49);
            this.generalGroupBox.TabIndex = 6;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // generalLanguageComboBox
            // 
            this.generalLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generalLanguageComboBox.FormattingEnabled = true;
            this.generalLanguageComboBox.Items.AddRange(new object[] {
            "English",
            "Russian (Русский)"});
            this.generalLanguageComboBox.Location = new System.Drawing.Point(67, 19);
            this.generalLanguageComboBox.Name = "generalLanguageComboBox";
            this.generalLanguageComboBox.Size = new System.Drawing.Size(160, 21);
            this.generalLanguageComboBox.TabIndex = 1;
            // 
            // generalLanguageLabel
            // 
            this.generalLanguageLabel.AutoSize = true;
            this.generalLanguageLabel.Location = new System.Drawing.Point(6, 22);
            this.generalLanguageLabel.Name = "generalLanguageLabel";
            this.generalLanguageLabel.Size = new System.Drawing.Size(55, 13);
            this.generalLanguageLabel.TabIndex = 0;
            this.generalLanguageLabel.Text = "Language";
            // 
            // paralellizationGroupBox
            // 
            this.paralellizationGroupBox.Controls.Add(this.paralellizationTasksNumericUpDown);
            this.paralellizationGroupBox.Controls.Add(this.paralellizationTasksLabel);
            this.paralellizationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.paralellizationGroupBox.Location = new System.Drawing.Point(0, 49);
            this.paralellizationGroupBox.Name = "paralellizationGroupBox";
            this.paralellizationGroupBox.Size = new System.Drawing.Size(530, 46);
            this.paralellizationGroupBox.TabIndex = 7;
            this.paralellizationGroupBox.TabStop = false;
            this.paralellizationGroupBox.Text = "Paralellization";
            // 
            // paralellizationTasksNumericUpDown
            // 
            this.paralellizationTasksNumericUpDown.Location = new System.Drawing.Point(142, 19);
            this.paralellizationTasksNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.paralellizationTasksNumericUpDown.Name = "paralellizationTasksNumericUpDown";
            this.paralellizationTasksNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.paralellizationTasksNumericUpDown.TabIndex = 1;
            this.paralellizationTasksNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // paralellizationTasksLabel
            // 
            this.paralellizationTasksLabel.AutoSize = true;
            this.paralellizationTasksLabel.Location = new System.Drawing.Point(6, 21);
            this.paralellizationTasksLabel.Name = "paralellizationTasksLabel";
            this.paralellizationTasksLabel.Size = new System.Drawing.Size(130, 13);
            this.paralellizationTasksLabel.TabIndex = 0;
            this.paralellizationTasksLabel.Text = "Maximum concurent tasks";
            // 
            // generationGroupBox
            // 
            this.generationGroupBox.Controls.Add(this.timeoutLabel);
            this.generationGroupBox.Controls.Add(this.timeoutNumericUpDown);
            this.generationGroupBox.Controls.Add(this.timeoutCheckBox);
            this.generationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.generationGroupBox.Location = new System.Drawing.Point(0, 95);
            this.generationGroupBox.Name = "generationGroupBox";
            this.generationGroupBox.Size = new System.Drawing.Size(530, 47);
            this.generationGroupBox.TabIndex = 9;
            this.generationGroupBox.TabStop = false;
            this.generationGroupBox.Text = "Generation";
            // 
            // timeoutCheckBox
            // 
            this.timeoutCheckBox.AutoSize = true;
            this.timeoutCheckBox.Location = new System.Drawing.Point(9, 21);
            this.timeoutCheckBox.Name = "timeoutCheckBox";
            this.timeoutCheckBox.Size = new System.Drawing.Size(64, 17);
            this.timeoutCheckBox.TabIndex = 0;
            this.timeoutCheckBox.Text = "Timeout";
            this.timeoutCheckBox.UseVisualStyleBackColor = true;
            this.timeoutCheckBox.CheckedChanged += new System.EventHandler(this.timeoutCheckBoxCheckedChanged);
            // 
            // timeoutNumericUpDown
            // 
            this.timeoutNumericUpDown.Location = new System.Drawing.Point(142, 19);
            this.timeoutNumericUpDown.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.timeoutNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeoutNumericUpDown.Name = "timeoutNumericUpDown";
            this.timeoutNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.timeoutNumericUpDown.TabIndex = 2;
            this.timeoutNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.AutoSize = true;
            this.timeoutLabel.Location = new System.Drawing.Point(233, 21);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(47, 13);
            this.timeoutLabel.TabIndex = 3;
            this.timeoutLabel.Text = "seconds";
            // 
            // OptionsCoreGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generationGroupBox);
            this.Controls.Add(this.paralellizationGroupBox);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.generalGroupBox);
            this.Name = "OptionsCoreGeneral";
            this.Size = new System.Drawing.Size(530, 349);
            this.Load += new System.EventHandler(this.OptionsCoreGeneralLoad);
            this.actionPanel.ResumeLayout(false);
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.paralellizationGroupBox.ResumeLayout(false);
            this.paralellizationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paralellizationTasksNumericUpDown)).EndInit();
            this.generationGroupBox.ResumeLayout(false);
            this.generationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.Label generalLanguageLabel;
        private System.Windows.Forms.ComboBox generalLanguageComboBox;
        private System.Windows.Forms.GroupBox paralellizationGroupBox;
        private System.Windows.Forms.NumericUpDown paralellizationTasksNumericUpDown;
        private System.Windows.Forms.Label paralellizationTasksLabel;
        private System.Windows.Forms.GroupBox generationGroupBox;
        private System.Windows.Forms.NumericUpDown timeoutNumericUpDown;
        private System.Windows.Forms.CheckBox timeoutCheckBox;
        private System.Windows.Forms.Label timeoutLabel;
    }
}
