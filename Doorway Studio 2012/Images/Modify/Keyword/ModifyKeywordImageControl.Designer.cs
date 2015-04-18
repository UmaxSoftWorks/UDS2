using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Controls;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Modify.Keyword
{
    partial class ModifyKeywordImageControl
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
            Umax.Plugins.Images.Classes.FontSettings fontSettings2 = new Umax.Plugins.Images.Classes.FontSettings();
            Umax.Plugins.Images.Classes.ColorSettings colorSettings2 = new Umax.Plugins.Images.Classes.ColorSettings();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.renameGroupBox = new System.Windows.Forms.GroupBox();
            this.renameTextBox = new System.Windows.Forms.TextBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.renameComboBox = new System.Windows.Forms.ComboBox();
            this.modificationsGroupBox = new System.Windows.Forms.GroupBox();
            this.modificationsNoiseCheckBox = new System.Windows.Forms.CheckBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.imagesGroupBox = new System.Windows.Forms.GroupBox();
            this.locationButton = new System.Windows.Forms.Button();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.imagesComboBox = new System.Windows.Forms.ComboBox();
            this.fontSelectControl = new Umax.Plugins.Images.Controls.FontSelectControl();
            this.renameGroupBox.SuspendLayout();
            this.modificationsGroupBox.SuspendLayout();
            this.imagesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.Filter = "Text|*.txt";
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
            this.renameGroupBox.TabIndex = 57;
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
            // modificationsGroupBox
            // 
            this.modificationsGroupBox.Controls.Add(this.modificationsNoiseCheckBox);
            this.modificationsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.modificationsGroupBox.Location = new System.Drawing.Point(0, 120);
            this.modificationsGroupBox.Name = "modificationsGroupBox";
            this.modificationsGroupBox.Size = new System.Drawing.Size(460, 42);
            this.modificationsGroupBox.TabIndex = 53;
            this.modificationsGroupBox.TabStop = false;
            this.modificationsGroupBox.Text = "Modifications";
            // 
            // modificationsNoiseCheckBox
            // 
            this.modificationsNoiseCheckBox.AutoSize = true;
            this.modificationsNoiseCheckBox.Location = new System.Drawing.Point(6, 19);
            this.modificationsNoiseCheckBox.Name = "modificationsNoiseCheckBox";
            this.modificationsNoiseCheckBox.Size = new System.Drawing.Size(53, 17);
            this.modificationsNoiseCheckBox.TabIndex = 0;
            this.modificationsNoiseCheckBox.Text = "Noise";
            this.modificationsNoiseCheckBox.UseVisualStyleBackColor = true;
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
            this.imagesGroupBox.TabIndex = 56;
            this.imagesGroupBox.TabStop = false;
            this.imagesGroupBox.Text = "Images";
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
            this.fontSelectControl.Location = new System.Drawing.Point(0, 162);
            this.fontSelectControl.Name = "fontSelectControl";
            fontSettings2.Font = Umax.Plugins.Images.Enums.FontType.Random;
            colorSettings2.Color = Umax.Plugins.Images.Enums.ColorType.Random;
            colorSettings2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorSettings2.SelectedColorRangeBMax = 200;
            colorSettings2.SelectedColorRangeBMin = 100;
            colorSettings2.SelectedColorRangeGMax = 200;
            colorSettings2.SelectedColorRangeGMin = 100;
            colorSettings2.SelectedColorRangeRMax = 200;
            colorSettings2.SelectedColorRangeRMin = 100;
            fontSettings2.FontColorSettings = colorSettings2;
            fontSettings2.FontName = "";
            fontSettings2.FontSize = 10;
            fontSettings2.FontStyle = System.Drawing.FontStyle.Regular;
            this.fontSelectControl.Settings = fontSettings2;
            this.fontSelectControl.Size = new System.Drawing.Size(460, 239);
            this.fontSelectControl.TabIndex = 58;
            // 
            // ModifyKeywordImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fontSelectControl);
            this.Controls.Add(this.modificationsGroupBox);
            this.Controls.Add(this.renameGroupBox);
            this.Controls.Add(this.imagesGroupBox);
            this.Name = "ModifyKeywordImageControl";
            this.Size = new System.Drawing.Size(460, 399);
            this.Load += new System.EventHandler(this.ModifyKeywordImageControl_Load);
            this.renameGroupBox.ResumeLayout(false);
            this.renameGroupBox.PerformLayout();
            this.modificationsGroupBox.ResumeLayout(false);
            this.modificationsGroupBox.PerformLayout();
            this.imagesGroupBox.ResumeLayout(false);
            this.imagesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog mainFolderBrowserDialog;
        private System.Windows.Forms.GroupBox renameGroupBox;
        protected System.Windows.Forms.TextBox renameTextBox;
        protected System.Windows.Forms.Button renameButton;
        protected System.Windows.Forms.ComboBox renameComboBox;
        private System.Windows.Forms.GroupBox modificationsGroupBox;
        private System.Windows.Forms.CheckBox modificationsNoiseCheckBox;
        protected System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.GroupBox imagesGroupBox;
        protected System.Windows.Forms.Button locationButton;
        protected System.Windows.Forms.ComboBox locationComboBox;
        protected System.Windows.Forms.ComboBox imagesComboBox;
        private FontSelectControl fontSelectControl;
    }
}
