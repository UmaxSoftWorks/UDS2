﻿using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Controls;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Modify.Text
{
    partial class ModifyTextImageControl
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
            Umax.Plugins.Images.Classes.FontSettings fontSettings1 = new Umax.Plugins.Images.Classes.FontSettings();
            Umax.Plugins.Images.Classes.ColorSettings colorSettings1 = new Umax.Plugins.Images.Classes.ColorSettings();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.modificationsGroupBox = new System.Windows.Forms.GroupBox();
            this.modificationsImageNoiseCheckBox = new System.Windows.Forms.CheckBox();
            this.numberGroupBox = new System.Windows.Forms.GroupBox();
            this.additionalLabel1 = new System.Windows.Forms.Label();
            this.numberMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.renameGroupBox = new System.Windows.Forms.GroupBox();
            this.renameTextBox = new System.Windows.Forms.TextBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.renameComboBox = new System.Windows.Forms.ComboBox();
            this.imagesGroupBox = new System.Windows.Forms.GroupBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.locationButton = new System.Windows.Forms.Button();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.imagesComboBox = new System.Windows.Forms.ComboBox();
            this.mainFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fontSelectControl = new Umax.Plugins.Images.Controls.FontSelectControl();
            this.textGroupBox = new System.Windows.Forms.GroupBox();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.textButton = new System.Windows.Forms.Button();
            this.textComboBox = new System.Windows.Forms.ComboBox();
            this.modificationsGroupBox.SuspendLayout();
            this.numberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMinNumericUpDown)).BeginInit();
            this.renameGroupBox.SuspendLayout();
            this.imagesGroupBox.SuspendLayout();
            this.textGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.Filter = "Text|*.txt";
            // 
            // modificationsGroupBox
            // 
            this.modificationsGroupBox.Controls.Add(this.modificationsImageNoiseCheckBox);
            this.modificationsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.modificationsGroupBox.Location = new System.Drawing.Point(0, 214);
            this.modificationsGroupBox.Name = "modificationsGroupBox";
            this.modificationsGroupBox.Size = new System.Drawing.Size(460, 42);
            this.modificationsGroupBox.TabIndex = 42;
            this.modificationsGroupBox.TabStop = false;
            this.modificationsGroupBox.Text = "Modifications";
            // 
            // modificationsImageNoiseCheckBox
            // 
            this.modificationsImageNoiseCheckBox.AutoSize = true;
            this.modificationsImageNoiseCheckBox.Location = new System.Drawing.Point(6, 19);
            this.modificationsImageNoiseCheckBox.Name = "modificationsImageNoiseCheckBox";
            this.modificationsImageNoiseCheckBox.Size = new System.Drawing.Size(85, 17);
            this.modificationsImageNoiseCheckBox.TabIndex = 0;
            this.modificationsImageNoiseCheckBox.Text = "Image Noise";
            this.modificationsImageNoiseCheckBox.UseVisualStyleBackColor = true;
            // 
            // numberGroupBox
            // 
            this.numberGroupBox.Controls.Add(this.additionalLabel1);
            this.numberGroupBox.Controls.Add(this.numberMaxNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberMinNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberComboBox);
            this.numberGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberGroupBox.Location = new System.Drawing.Point(0, 167);
            this.numberGroupBox.Name = "numberGroupBox";
            this.numberGroupBox.Size = new System.Drawing.Size(460, 47);
            this.numberGroupBox.TabIndex = 43;
            this.numberGroupBox.TabStop = false;
            this.numberGroupBox.Text = "Number";
            // 
            // additionalLabel1
            // 
            this.additionalLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalLabel1.AutoSize = true;
            this.additionalLabel1.Location = new System.Drawing.Point(376, 22);
            this.additionalLabel1.Name = "additionalLabel1";
            this.additionalLabel1.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel1.TabIndex = 17;
            this.additionalLabel1.Text = "-";
            // 
            // numberMaxNumericUpDown
            // 
            this.numberMaxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberMaxNumericUpDown.Location = new System.Drawing.Point(392, 20);
            this.numberMaxNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberMaxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberMaxNumericUpDown.Name = "numberMaxNumericUpDown";
            this.numberMaxNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.numberMaxNumericUpDown.TabIndex = 16;
            this.numberMaxNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numberMinNumericUpDown
            // 
            this.numberMinNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberMinNumericUpDown.Location = new System.Drawing.Point(305, 20);
            this.numberMinNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberMinNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberMinNumericUpDown.Name = "numberMinNumericUpDown";
            this.numberMinNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.numberMinNumericUpDown.TabIndex = 15;
            this.numberMinNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numberComboBox
            // 
            this.numberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberComboBox.FormattingEnabled = true;
            this.numberComboBox.Items.AddRange(new object[] {
            "All",
            "Limited"});
            this.numberComboBox.Location = new System.Drawing.Point(6, 19);
            this.numberComboBox.Name = "numberComboBox";
            this.numberComboBox.Size = new System.Drawing.Size(112, 21);
            this.numberComboBox.TabIndex = 3;
            this.numberComboBox.SelectedIndexChanged += new System.EventHandler(this.numberComboBox_SelectedIndexChanged);
            // 
            // renameGroupBox
            // 
            this.renameGroupBox.Controls.Add(this.renameTextBox);
            this.renameGroupBox.Controls.Add(this.renameButton);
            this.renameGroupBox.Controls.Add(this.renameComboBox);
            this.renameGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.renameGroupBox.Location = new System.Drawing.Point(0, 73);
            this.renameGroupBox.Name = "renameGroupBox";
            this.renameGroupBox.Size = new System.Drawing.Size(460, 47);
            this.renameGroupBox.TabIndex = 51;
            this.renameGroupBox.TabStop = false;
            this.renameGroupBox.Text = "Rename";
            // 
            // renameTextBox
            // 
            this.renameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renameTextBox.Location = new System.Drawing.Point(124, 18);
            this.renameTextBox.Name = "renameTextBox";
            this.renameTextBox.Size = new System.Drawing.Size(295, 20);
            this.renameTextBox.TabIndex = 4;
            // 
            // renameButton
            // 
            this.renameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.renameButton.Location = new System.Drawing.Point(425, 16);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(32, 23);
            this.renameButton.TabIndex = 5;
            this.renameButton.Text = "...";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // renameComboBox
            // 
            this.renameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.renameComboBox.FormattingEnabled = true;
            this.renameComboBox.Items.AddRange(new object[] {
            "Random",
            "Name",
            "Name -> En",
            "Keyword",
            "Keyword -> En",
            "FromFile",
            "FromFile -> En"});
            this.renameComboBox.Location = new System.Drawing.Point(6, 19);
            this.renameComboBox.Name = "renameComboBox";
            this.renameComboBox.Size = new System.Drawing.Size(112, 21);
            this.renameComboBox.TabIndex = 3;
            this.renameComboBox.SelectedIndexChanged += new System.EventHandler(this.renameComboBox_SelectedIndexChanged);
            // 
            // imagesGroupBox
            // 
            this.imagesGroupBox.Controls.Add(this.locationTextBox);
            this.imagesGroupBox.Controls.Add(this.locationButton);
            this.imagesGroupBox.Controls.Add(this.locationComboBox);
            this.imagesGroupBox.Controls.Add(this.imagesComboBox);
            this.imagesGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.imagesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.imagesGroupBox.Name = "imagesGroupBox";
            this.imagesGroupBox.Size = new System.Drawing.Size(460, 73);
            this.imagesGroupBox.TabIndex = 50;
            this.imagesGroupBox.TabStop = false;
            this.imagesGroupBox.Text = "Images";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationTextBox.Location = new System.Drawing.Point(6, 46);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(413, 20);
            this.locationTextBox.TabIndex = 6;
            // 
            // locationButton
            // 
            this.locationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locationButton.Location = new System.Drawing.Point(425, 44);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(32, 23);
            this.locationButton.TabIndex = 7;
            this.locationButton.Text = "...";
            this.locationButton.UseVisualStyleBackColor = true;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // locationComboBox
            // 
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Items.AddRange(new object[] {
            "Internal",
            "External"});
            this.locationComboBox.Location = new System.Drawing.Point(6, 19);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(112, 21);
            this.locationComboBox.TabIndex = 4;
            this.locationComboBox.SelectedIndexChanged += new System.EventHandler(this.locationComboBox_SelectedIndexChanged);
            // 
            // imagesComboBox
            // 
            this.imagesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imagesComboBox.FormattingEnabled = true;
            this.imagesComboBox.Location = new System.Drawing.Point(124, 19);
            this.imagesComboBox.Name = "imagesComboBox";
            this.imagesComboBox.Size = new System.Drawing.Size(333, 21);
            this.imagesComboBox.TabIndex = 0;
            // 
            // fontSelectControl
            // 
            this.fontSelectControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.fontSelectControl.Location = new System.Drawing.Point(0, 256);
            this.fontSelectControl.Name = "fontSelectControl";
            fontSettings1.Font = Umax.Plugins.Images.Enums.FontType.Random;
            colorSettings1.Color = Umax.Plugins.Images.Enums.ColorType.Random;
            colorSettings1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorSettings1.SelectedColorRangeBMax = 200;
            colorSettings1.SelectedColorRangeBMin = 100;
            colorSettings1.SelectedColorRangeGMax = 200;
            colorSettings1.SelectedColorRangeGMin = 100;
            colorSettings1.SelectedColorRangeRMax = 200;
            colorSettings1.SelectedColorRangeRMin = 100;
            fontSettings1.FontColorSettings = colorSettings1;
            fontSettings1.FontName = "";
            fontSettings1.FontSize = 10;
            fontSettings1.FontStyle = System.Drawing.FontStyle.Regular;
            this.fontSelectControl.Settings = fontSettings1;
            this.fontSelectControl.Size = new System.Drawing.Size(460, 239);
            this.fontSelectControl.TabIndex = 52;
            // 
            // textGroupBox
            // 
            this.textGroupBox.Controls.Add(this.textTextBox);
            this.textGroupBox.Controls.Add(this.textButton);
            this.textGroupBox.Controls.Add(this.textComboBox);
            this.textGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.textGroupBox.Location = new System.Drawing.Point(0, 120);
            this.textGroupBox.Name = "textGroupBox";
            this.textGroupBox.Size = new System.Drawing.Size(460, 47);
            this.textGroupBox.TabIndex = 53;
            this.textGroupBox.TabStop = false;
            this.textGroupBox.Text = "Text";
            // 
            // textTextBox
            // 
            this.textTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTextBox.Location = new System.Drawing.Point(124, 18);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(295, 20);
            this.textTextBox.TabIndex = 7;
            // 
            // textButton
            // 
            this.textButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textButton.Location = new System.Drawing.Point(425, 16);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(32, 23);
            this.textButton.TabIndex = 8;
            this.textButton.Text = "...";
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.Click += new System.EventHandler(this.textButton_Click);
            // 
            // textComboBox
            // 
            this.textComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textComboBox.FormattingEnabled = true;
            this.textComboBox.Items.AddRange(new object[] {
            "Word",
            "Sentense",
            "Line",
            "Phrase"});
            this.textComboBox.Location = new System.Drawing.Point(6, 19);
            this.textComboBox.Name = "textComboBox";
            this.textComboBox.Size = new System.Drawing.Size(112, 21);
            this.textComboBox.TabIndex = 6;
            // 
            // ModifyTextImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fontSelectControl);
            this.Controls.Add(this.modificationsGroupBox);
            this.Controls.Add(this.numberGroupBox);
            this.Controls.Add(this.textGroupBox);
            this.Controls.Add(this.renameGroupBox);
            this.Controls.Add(this.imagesGroupBox);
            this.Name = "ModifyTextImageControl";
            this.Size = new System.Drawing.Size(460, 492);
            this.Load += new System.EventHandler(this.ModifyTextImageControl_Load);
            this.modificationsGroupBox.ResumeLayout(false);
            this.modificationsGroupBox.PerformLayout();
            this.numberGroupBox.ResumeLayout(false);
            this.numberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMinNumericUpDown)).EndInit();
            this.renameGroupBox.ResumeLayout(false);
            this.renameGroupBox.PerformLayout();
            this.imagesGroupBox.ResumeLayout(false);
            this.imagesGroupBox.PerformLayout();
            this.textGroupBox.ResumeLayout(false);
            this.textGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        private System.Windows.Forms.GroupBox modificationsGroupBox;
        private System.Windows.Forms.CheckBox modificationsImageNoiseCheckBox;
        private System.Windows.Forms.GroupBox numberGroupBox;
        private System.Windows.Forms.Label additionalLabel1;
        protected System.Windows.Forms.NumericUpDown numberMaxNumericUpDown;
        protected System.Windows.Forms.NumericUpDown numberMinNumericUpDown;
        protected System.Windows.Forms.ComboBox numberComboBox;
        private System.Windows.Forms.GroupBox renameGroupBox;
        protected System.Windows.Forms.TextBox renameTextBox;
        protected System.Windows.Forms.Button renameButton;
        protected System.Windows.Forms.ComboBox renameComboBox;
        private System.Windows.Forms.GroupBox imagesGroupBox;
        protected System.Windows.Forms.TextBox locationTextBox;
        protected System.Windows.Forms.Button locationButton;
        protected System.Windows.Forms.ComboBox locationComboBox;
        protected System.Windows.Forms.ComboBox imagesComboBox;
        private System.Windows.Forms.FolderBrowserDialog mainFolderBrowserDialog;
        private FontSelectControl fontSelectControl;
        private System.Windows.Forms.GroupBox textGroupBox;
        protected System.Windows.Forms.TextBox textTextBox;
        protected System.Windows.Forms.Button textButton;
        protected System.Windows.Forms.ComboBox textComboBox;
    }
}
