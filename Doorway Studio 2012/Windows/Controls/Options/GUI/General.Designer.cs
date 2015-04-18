namespace Umax.Windows.Controls.Options.GUI
{
    partial class OptionsGuiGeneral
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
            this.generalGoupBox = new System.Windows.Forms.GroupBox();
            this.dotNetLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CheckFXCheckBox = new System.Windows.Forms.CheckBox();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.appearanceGroupBox = new System.Windows.Forms.GroupBox();
            this.appearanceComboBox = new System.Windows.Forms.ComboBox();
            this.managerGroupBox = new System.Windows.Forms.GroupBox();
            this.managerLocationComboBox = new System.Windows.Forms.ComboBox();
            this.managerLocationLabel = new System.Windows.Forms.Label();
            this.managerPinCheckBox = new System.Windows.Forms.CheckBox();
            this.managerCheckBox = new System.Windows.Forms.CheckBox();
            this.appearanceLargeCalendarCheckBox = new System.Windows.Forms.CheckBox();
            this.appearanceGeneralCheckBox = new System.Windows.Forms.CheckBox();
            this.appearanceNewsCheckBox = new System.Windows.Forms.CheckBox();
            this.windowGroupBox = new System.Windows.Forms.GroupBox();
            this.windowOpacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.windowOpacityLabel = new System.Windows.Forms.Label();
            this.windowPinCheckBox = new System.Windows.Forms.CheckBox();
            this.generalGoupBox.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.appearanceGroupBox.SuspendLayout();
            this.managerGroupBox.SuspendLayout();
            this.windowGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowOpacityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // generalGoupBox
            // 
            this.generalGoupBox.Controls.Add(this.dotNetLinkLabel);
            this.generalGoupBox.Controls.Add(this.CheckFXCheckBox);
            this.generalGoupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.generalGoupBox.Location = new System.Drawing.Point(0, 0);
            this.generalGoupBox.Name = "generalGoupBox";
            this.generalGoupBox.Size = new System.Drawing.Size(530, 45);
            this.generalGoupBox.TabIndex = 0;
            this.generalGoupBox.TabStop = false;
            this.generalGoupBox.Text = "General";
            // 
            // dotNetLinkLabel
            // 
            this.dotNetLinkLabel.AutoSize = true;
            this.dotNetLinkLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dotNetLinkLabel.Location = new System.Drawing.Point(427, 16);
            this.dotNetLinkLabel.Name = "dotNetLinkLabel";
            this.dotNetLinkLabel.Size = new System.Drawing.Size(100, 13);
            this.dotNetLinkLabel.TabIndex = 1;
            this.dotNetLinkLabel.TabStop = true;
            this.dotNetLinkLabel.Text = ".Net Framework 3.5";
            this.dotNetLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dotNetLinkLabel_LinkClicked);
            // 
            // CheckFXCheckBox
            // 
            this.CheckFXCheckBox.AutoSize = true;
            this.CheckFXCheckBox.Location = new System.Drawing.Point(6, 15);
            this.CheckFXCheckBox.Name = "CheckFXCheckBox";
            this.CheckFXCheckBox.Size = new System.Drawing.Size(172, 17);
            this.CheckFXCheckBox.TabIndex = 0;
            this.CheckFXCheckBox.Text = "Check .Net Framework version";
            this.CheckFXCheckBox.UseVisualStyleBackColor = true;
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.applyButton);
            this.actionPanel.Controls.Add(this.cancelButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 326);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(530, 23);
            this.actionPanel.TabIndex = 2;
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
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // appearanceGroupBox
            // 
            this.appearanceGroupBox.Controls.Add(this.appearanceComboBox);
            this.appearanceGroupBox.Controls.Add(this.managerGroupBox);
            this.appearanceGroupBox.Controls.Add(this.appearanceLargeCalendarCheckBox);
            this.appearanceGroupBox.Controls.Add(this.appearanceGeneralCheckBox);
            this.appearanceGroupBox.Controls.Add(this.appearanceNewsCheckBox);
            this.appearanceGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.appearanceGroupBox.Location = new System.Drawing.Point(0, 45);
            this.appearanceGroupBox.Name = "appearanceGroupBox";
            this.appearanceGroupBox.Size = new System.Drawing.Size(530, 112);
            this.appearanceGroupBox.TabIndex = 3;
            this.appearanceGroupBox.TabStop = false;
            this.appearanceGroupBox.Text = "Appearance";
            // 
            // appearanceComboBox
            // 
            this.appearanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appearanceComboBox.FormattingEnabled = true;
            this.appearanceComboBox.Items.AddRange(new object[] {
            "Classic",
            "Modern"});
            this.appearanceComboBox.Location = new System.Drawing.Point(6, 19);
            this.appearanceComboBox.Name = "appearanceComboBox";
            this.appearanceComboBox.Size = new System.Drawing.Size(121, 21);
            this.appearanceComboBox.TabIndex = 3;
            // 
            // managerGroupBox
            // 
            this.managerGroupBox.Controls.Add(this.managerLocationComboBox);
            this.managerGroupBox.Controls.Add(this.managerLocationLabel);
            this.managerGroupBox.Controls.Add(this.managerPinCheckBox);
            this.managerGroupBox.Controls.Add(this.managerCheckBox);
            this.managerGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.managerGroupBox.Location = new System.Drawing.Point(311, 16);
            this.managerGroupBox.Name = "managerGroupBox";
            this.managerGroupBox.Size = new System.Drawing.Size(216, 93);
            this.managerGroupBox.TabIndex = 4;
            this.managerGroupBox.TabStop = false;
            this.managerGroupBox.Text = "Manager";
            // 
            // managerLocationComboBox
            // 
            this.managerLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.managerLocationComboBox.Enabled = false;
            this.managerLocationComboBox.FormattingEnabled = true;
            this.managerLocationComboBox.Items.AddRange(new object[] {
            "Custom",
            "Right",
            "Left"});
            this.managerLocationComboBox.Location = new System.Drawing.Point(60, 65);
            this.managerLocationComboBox.Name = "managerLocationComboBox";
            this.managerLocationComboBox.Size = new System.Drawing.Size(146, 21);
            this.managerLocationComboBox.TabIndex = 3;
            // 
            // managerLocationLabel
            // 
            this.managerLocationLabel.AutoSize = true;
            this.managerLocationLabel.Enabled = false;
            this.managerLocationLabel.Location = new System.Drawing.Point(6, 68);
            this.managerLocationLabel.Name = "managerLocationLabel";
            this.managerLocationLabel.Size = new System.Drawing.Size(48, 13);
            this.managerLocationLabel.TabIndex = 2;
            this.managerLocationLabel.Text = "Location";
            // 
            // managerPinCheckBox
            // 
            this.managerPinCheckBox.AutoSize = true;
            this.managerPinCheckBox.Enabled = false;
            this.managerPinCheckBox.Location = new System.Drawing.Point(6, 42);
            this.managerPinCheckBox.Name = "managerPinCheckBox";
            this.managerPinCheckBox.Size = new System.Drawing.Size(96, 17);
            this.managerPinCheckBox.TabIndex = 1;
            this.managerPinCheckBox.Text = "Pin to Desktop";
            this.managerPinCheckBox.UseVisualStyleBackColor = true;
            // 
            // managerCheckBox
            // 
            this.managerCheckBox.AutoSize = true;
            this.managerCheckBox.Location = new System.Drawing.Point(6, 19);
            this.managerCheckBox.Name = "managerCheckBox";
            this.managerCheckBox.Size = new System.Drawing.Size(68, 17);
            this.managerCheckBox.TabIndex = 0;
            this.managerCheckBox.Text = "Manager";
            this.managerCheckBox.UseVisualStyleBackColor = true;
            this.managerCheckBox.CheckedChanged += new System.EventHandler(this.managerCheckBox_CheckedChanged);
            // 
            // appearanceLargeCalendarCheckBox
            // 
            this.appearanceLargeCalendarCheckBox.AutoSize = true;
            this.appearanceLargeCalendarCheckBox.Location = new System.Drawing.Point(6, 92);
            this.appearanceLargeCalendarCheckBox.Name = "appearanceLargeCalendarCheckBox";
            this.appearanceLargeCalendarCheckBox.Size = new System.Drawing.Size(98, 17);
            this.appearanceLargeCalendarCheckBox.TabIndex = 2;
            this.appearanceLargeCalendarCheckBox.Text = "Large Calendar";
            this.appearanceLargeCalendarCheckBox.UseVisualStyleBackColor = true;
            // 
            // appearanceGeneralCheckBox
            // 
            this.appearanceGeneralCheckBox.AutoSize = true;
            this.appearanceGeneralCheckBox.Location = new System.Drawing.Point(6, 69);
            this.appearanceGeneralCheckBox.Name = "appearanceGeneralCheckBox";
            this.appearanceGeneralCheckBox.Size = new System.Drawing.Size(63, 17);
            this.appearanceGeneralCheckBox.TabIndex = 1;
            this.appearanceGeneralCheckBox.Text = "General";
            this.appearanceGeneralCheckBox.UseVisualStyleBackColor = true;
            // 
            // appearanceNewsCheckBox
            // 
            this.appearanceNewsCheckBox.AutoSize = true;
            this.appearanceNewsCheckBox.Location = new System.Drawing.Point(6, 46);
            this.appearanceNewsCheckBox.Name = "appearanceNewsCheckBox";
            this.appearanceNewsCheckBox.Size = new System.Drawing.Size(53, 17);
            this.appearanceNewsCheckBox.TabIndex = 0;
            this.appearanceNewsCheckBox.Text = "News";
            this.appearanceNewsCheckBox.UseVisualStyleBackColor = true;
            // 
            // windowGroupBox
            // 
            this.windowGroupBox.Controls.Add(this.windowOpacityNumericUpDown);
            this.windowGroupBox.Controls.Add(this.windowOpacityLabel);
            this.windowGroupBox.Controls.Add(this.windowPinCheckBox);
            this.windowGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowGroupBox.Location = new System.Drawing.Point(0, 157);
            this.windowGroupBox.Name = "windowGroupBox";
            this.windowGroupBox.Size = new System.Drawing.Size(530, 83);
            this.windowGroupBox.TabIndex = 8;
            this.windowGroupBox.TabStop = false;
            this.windowGroupBox.Text = "Tray Window";
            // 
            // windowOpacityNumericUpDown
            // 
            this.windowOpacityNumericUpDown.Location = new System.Drawing.Point(6, 55);
            this.windowOpacityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.windowOpacityNumericUpDown.Name = "windowOpacityNumericUpDown";
            this.windowOpacityNumericUpDown.Size = new System.Drawing.Size(104, 20);
            this.windowOpacityNumericUpDown.TabIndex = 2;
            this.windowOpacityNumericUpDown.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // windowOpacityLabel
            // 
            this.windowOpacityLabel.AutoSize = true;
            this.windowOpacityLabel.Location = new System.Drawing.Point(6, 39);
            this.windowOpacityLabel.Name = "windowOpacityLabel";
            this.windowOpacityLabel.Size = new System.Drawing.Size(54, 13);
            this.windowOpacityLabel.TabIndex = 6;
            this.windowOpacityLabel.Text = "Opacity %";
            // 
            // windowPinCheckBox
            // 
            this.windowPinCheckBox.AutoSize = true;
            this.windowPinCheckBox.Location = new System.Drawing.Point(6, 19);
            this.windowPinCheckBox.Name = "windowPinCheckBox";
            this.windowPinCheckBox.Size = new System.Drawing.Size(96, 17);
            this.windowPinCheckBox.TabIndex = 0;
            this.windowPinCheckBox.Text = "Pin to Desktop";
            this.windowPinCheckBox.UseVisualStyleBackColor = true;
            // 
            // OptionsGuiGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.windowGroupBox);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.appearanceGroupBox);
            this.Controls.Add(this.generalGoupBox);
            this.Name = "OptionsGuiGeneral";
            this.Size = new System.Drawing.Size(530, 349);
            this.Load += new System.EventHandler(this.OptionsGuiGeneralLoad);
            this.generalGoupBox.ResumeLayout(false);
            this.generalGoupBox.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.appearanceGroupBox.ResumeLayout(false);
            this.appearanceGroupBox.PerformLayout();
            this.managerGroupBox.ResumeLayout(false);
            this.managerGroupBox.PerformLayout();
            this.windowGroupBox.ResumeLayout(false);
            this.windowGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowOpacityNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox generalGoupBox;
        private System.Windows.Forms.CheckBox CheckFXCheckBox;
        private System.Windows.Forms.LinkLabel dotNetLinkLabel;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.GroupBox appearanceGroupBox;
        private System.Windows.Forms.CheckBox appearanceNewsCheckBox;
        private System.Windows.Forms.CheckBox appearanceLargeCalendarCheckBox;
        private System.Windows.Forms.CheckBox appearanceGeneralCheckBox;
        private System.Windows.Forms.GroupBox managerGroupBox;
        private System.Windows.Forms.CheckBox managerCheckBox;
        private System.Windows.Forms.CheckBox managerPinCheckBox;
        private System.Windows.Forms.Label managerLocationLabel;
        private System.Windows.Forms.ComboBox managerLocationComboBox;
        private System.Windows.Forms.ComboBox appearanceComboBox;
        private System.Windows.Forms.GroupBox windowGroupBox;
        private System.Windows.Forms.NumericUpDown windowOpacityNumericUpDown;
        private System.Windows.Forms.Label windowOpacityLabel;
        private System.Windows.Forms.CheckBox windowPinCheckBox;
    }
}
