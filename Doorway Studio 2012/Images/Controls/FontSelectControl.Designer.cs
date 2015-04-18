using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Controls
{
    partial class FontSelectControl
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
            Umax.Plugins.Images.Classes.ColorSettings colorSettings1 = new Umax.Plugins.Images.Classes.ColorSettings();
            this.fontGroupBox = new System.Windows.Forms.GroupBox();
            this.fontStrikeoutCheckBox = new System.Windows.Forms.CheckBox();
            this.fontItalicCheckBox = new System.Windows.Forms.CheckBox();
            this.fontUnderlineCheckBox = new System.Windows.Forms.CheckBox();
            this.fontBoldCheckBox = new System.Windows.Forms.CheckBox();
            this.fontTypeComboBox = new System.Windows.Forms.ComboBox();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.fontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.fontComboBox = new System.Windows.Forms.ComboBox();
            this.fontColorGroupBox = new System.Windows.Forms.GroupBox();
            this.fontCompleteColorSelectControl = new Umax.Plugins.Images.Controls.CompleteColorSelectControl();
            this.fontGroupBox.SuspendLayout();
            this.fontColorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontGroupBox
            // 
            this.fontGroupBox.Controls.Add(this.fontStrikeoutCheckBox);
            this.fontGroupBox.Controls.Add(this.fontItalicCheckBox);
            this.fontGroupBox.Controls.Add(this.fontUnderlineCheckBox);
            this.fontGroupBox.Controls.Add(this.fontBoldCheckBox);
            this.fontGroupBox.Controls.Add(this.fontTypeComboBox);
            this.fontGroupBox.Controls.Add(this.fontSizeLabel);
            this.fontGroupBox.Controls.Add(this.fontSizeComboBox);
            this.fontGroupBox.Controls.Add(this.fontComboBox);
            this.fontGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.fontGroupBox.Location = new System.Drawing.Point(0, 0);
            this.fontGroupBox.Name = "fontGroupBox";
            this.fontGroupBox.Size = new System.Drawing.Size(460, 74);
            this.fontGroupBox.TabIndex = 42;
            this.fontGroupBox.TabStop = false;
            this.fontGroupBox.Text = "Font";
            // 
            // fontStrikeoutCheckBox
            // 
            this.fontStrikeoutCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fontStrikeoutCheckBox.AutoSize = true;
            this.fontStrikeoutCheckBox.Location = new System.Drawing.Point(368, 46);
            this.fontStrikeoutCheckBox.Name = "fontStrikeoutCheckBox";
            this.fontStrikeoutCheckBox.Size = new System.Drawing.Size(68, 17);
            this.fontStrikeoutCheckBox.TabIndex = 13;
            this.fontStrikeoutCheckBox.Text = "Strikeout";
            this.fontStrikeoutCheckBox.UseVisualStyleBackColor = true;
            // 
            // fontItalicCheckBox
            // 
            this.fontItalicCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fontItalicCheckBox.AutoSize = true;
            this.fontItalicCheckBox.Location = new System.Drawing.Point(279, 46);
            this.fontItalicCheckBox.Name = "fontItalicCheckBox";
            this.fontItalicCheckBox.Size = new System.Drawing.Size(48, 17);
            this.fontItalicCheckBox.TabIndex = 12;
            this.fontItalicCheckBox.Text = "Italic";
            this.fontItalicCheckBox.UseVisualStyleBackColor = true;
            // 
            // fontUnderlineCheckBox
            // 
            this.fontUnderlineCheckBox.AutoSize = true;
            this.fontUnderlineCheckBox.Location = new System.Drawing.Point(124, 46);
            this.fontUnderlineCheckBox.Name = "fontUnderlineCheckBox";
            this.fontUnderlineCheckBox.Size = new System.Drawing.Size(71, 17);
            this.fontUnderlineCheckBox.TabIndex = 11;
            this.fontUnderlineCheckBox.Text = "Underline";
            this.fontUnderlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // fontBoldCheckBox
            // 
            this.fontBoldCheckBox.AutoSize = true;
            this.fontBoldCheckBox.Location = new System.Drawing.Point(6, 46);
            this.fontBoldCheckBox.Name = "fontBoldCheckBox";
            this.fontBoldCheckBox.Size = new System.Drawing.Size(47, 17);
            this.fontBoldCheckBox.TabIndex = 10;
            this.fontBoldCheckBox.Text = "Bold";
            this.fontBoldCheckBox.UseVisualStyleBackColor = true;
            // 
            // fontTypeComboBox
            // 
            this.fontTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontTypeComboBox.FormattingEnabled = true;
            this.fontTypeComboBox.Items.AddRange(new object[] {
            "Random",
            "Selected"});
            this.fontTypeComboBox.Location = new System.Drawing.Point(6, 19);
            this.fontTypeComboBox.Name = "fontTypeComboBox";
            this.fontTypeComboBox.Size = new System.Drawing.Size(112, 21);
            this.fontTypeComboBox.TabIndex = 9;
            this.fontTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontTypeComboBoxSelectedIndexChanged);
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Location = new System.Drawing.Point(365, 22);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(27, 13);
            this.fontSizeLabel.TabIndex = 8;
            this.fontSizeLabel.Text = "Size";
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fontSizeComboBox.Items.AddRange(new object[] {
            "6",
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "28",
            "32",
            "36",
            "40",
            "44",
            "48"});
            this.fontSizeComboBox.Location = new System.Drawing.Point(406, 19);
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(48, 21);
            this.fontSizeComboBox.TabIndex = 3;
            this.fontSizeComboBox.Text = "10";
            // 
            // fontComboBox
            // 
            this.fontComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox.Location = new System.Drawing.Point(124, 19);
            this.fontComboBox.MaxDropDownItems = 16;
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(235, 21);
            this.fontComboBox.TabIndex = 1;
            // 
            // fontColorGroupBox
            // 
            this.fontColorGroupBox.Controls.Add(this.fontCompleteColorSelectControl);
            this.fontColorGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.fontColorGroupBox.Location = new System.Drawing.Point(0, 74);
            this.fontColorGroupBox.Name = "fontColorGroupBox";
            this.fontColorGroupBox.Size = new System.Drawing.Size(460, 160);
            this.fontColorGroupBox.TabIndex = 41;
            this.fontColorGroupBox.TabStop = false;
            this.fontColorGroupBox.Text = "Font color";
            // 
            // fontCompleteColorSelectControl
            // 
            this.fontCompleteColorSelectControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontCompleteColorSelectControl.Location = new System.Drawing.Point(3, 16);
            this.fontCompleteColorSelectControl.Name = "fontCompleteColorSelectControl";
            colorSettings1.Color = Umax.Plugins.Images.Enums.ColorType.Random;
            colorSettings1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorSettings1.SelectedColorRangeBMax = 200;
            colorSettings1.SelectedColorRangeBMin = 100;
            colorSettings1.SelectedColorRangeGMax = 200;
            colorSettings1.SelectedColorRangeGMin = 100;
            colorSettings1.SelectedColorRangeRMax = 200;
            colorSettings1.SelectedColorRangeRMin = 100;
            this.fontCompleteColorSelectControl.Settings = colorSettings1;
            this.fontCompleteColorSelectControl.Size = new System.Drawing.Size(454, 141);
            this.fontCompleteColorSelectControl.TabIndex = 0;
            // 
            // FontSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fontColorGroupBox);
            this.Controls.Add(this.fontGroupBox);
            this.Name = "FontSelectControl";
            this.Size = new System.Drawing.Size(460, 239);
            this.fontGroupBox.ResumeLayout(false);
            this.fontGroupBox.PerformLayout();
            this.fontColorGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fontGroupBox;
        private System.Windows.Forms.CheckBox fontStrikeoutCheckBox;
        private System.Windows.Forms.CheckBox fontItalicCheckBox;
        private System.Windows.Forms.CheckBox fontUnderlineCheckBox;
        private System.Windows.Forms.CheckBox fontBoldCheckBox;
        private System.Windows.Forms.ComboBox fontTypeComboBox;
        private System.Windows.Forms.Label fontSizeLabel;
        private System.Windows.Forms.ComboBox fontSizeComboBox;
        private System.Windows.Forms.ComboBox fontComboBox;
        private System.Windows.Forms.GroupBox fontColorGroupBox;
        private CompleteColorSelectControl fontCompleteColorSelectControl;
    }
}
