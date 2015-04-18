using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Controls;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Generate.Text
{
    partial class GenerateTextImageControl
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
            Umax.Plugins.Images.Classes.ColorSettings colorSettings2 = new Umax.Plugins.Images.Classes.ColorSettings();
            Umax.Plugins.Images.Classes.ColorSettings colorSettings1 = new Umax.Plugins.Images.Classes.ColorSettings();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameButton = new System.Windows.Forms.Button();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.additionalLabel2 = new System.Windows.Forms.Label();
            this.sizeHeigthMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeHeigthMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.additionalLabel3 = new System.Windows.Forms.Label();
            this.sizeWidthMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeWidthMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeHeightLabel = new System.Windows.Forms.Label();
            this.sizeWidthLabel = new System.Windows.Forms.Label();
            this.modificationsGroupBox = new System.Windows.Forms.GroupBox();
            this.modificationsNoiseCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundColorGroupBox = new System.Windows.Forms.GroupBox();
            this.textGroupBox = new System.Windows.Forms.GroupBox();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.textButton = new System.Windows.Forms.Button();
            this.textComboBox = new System.Windows.Forms.ComboBox();
            this.numberGroupBox = new System.Windows.Forms.GroupBox();
            this.additionalLabel1 = new System.Windows.Forms.Label();
            this.numberMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.fontSelectControl = new Umax.Plugins.Images.Controls.FontSelectControl();
            this.backgroundCompleteColorSelectControl = new Umax.Plugins.Images.Controls.CompleteColorSelectControl();
            this.nameGroupBox.SuspendLayout();
            this.sizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeigthMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeigthMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidthMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidthMinNumericUpDown)).BeginInit();
            this.modificationsGroupBox.SuspendLayout();
            this.backgroundColorGroupBox.SuspendLayout();
            this.textGroupBox.SuspendLayout();
            this.numberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMinNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.nameTextBox);
            this.nameGroupBox.Controls.Add(this.nameButton);
            this.nameGroupBox.Controls.Add(this.nameComboBox);
            this.nameGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameGroupBox.Location = new System.Drawing.Point(0, 0);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(460, 47);
            this.nameGroupBox.TabIndex = 35;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(124, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(292, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // nameButton
            // 
            this.nameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameButton.Location = new System.Drawing.Point(422, 17);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(32, 23);
            this.nameButton.TabIndex = 5;
            this.nameButton.Text = "...";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // nameComboBox
            // 
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Items.AddRange(new object[] {
            "Random",
            "Keyword",
            "Keyword -> En",
            "From file",
            "From file -> En"});
            this.nameComboBox.Location = new System.Drawing.Point(6, 19);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(112, 21);
            this.nameComboBox.TabIndex = 3;
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.Filter = "Text|*.txt";
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.additionalLabel2);
            this.sizeGroupBox.Controls.Add(this.sizeHeigthMaxNumericUpDown);
            this.sizeGroupBox.Controls.Add(this.sizeHeigthMinNumericUpDown);
            this.sizeGroupBox.Controls.Add(this.additionalLabel3);
            this.sizeGroupBox.Controls.Add(this.sizeWidthMaxNumericUpDown);
            this.sizeGroupBox.Controls.Add(this.sizeWidthMinNumericUpDown);
            this.sizeGroupBox.Controls.Add(this.sizeHeightLabel);
            this.sizeGroupBox.Controls.Add(this.sizeWidthLabel);
            this.sizeGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.sizeGroupBox.Location = new System.Drawing.Point(0, 141);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(460, 69);
            this.sizeGroupBox.TabIndex = 37;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // additionalLabel2
            // 
            this.additionalLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalLabel2.AutoSize = true;
            this.additionalLabel2.Location = new System.Drawing.Point(373, 47);
            this.additionalLabel2.Name = "additionalLabel2";
            this.additionalLabel2.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel2.TabIndex = 7;
            this.additionalLabel2.Text = "-";
            // 
            // sizeHeigthMaxNumericUpDown
            // 
            this.sizeHeigthMaxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeHeigthMaxNumericUpDown.Location = new System.Drawing.Point(389, 45);
            this.sizeHeigthMaxNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sizeHeigthMaxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeHeigthMaxNumericUpDown.Name = "sizeHeigthMaxNumericUpDown";
            this.sizeHeigthMaxNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.sizeHeigthMaxNumericUpDown.TabIndex = 6;
            this.sizeHeigthMaxNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // sizeHeigthMinNumericUpDown
            // 
            this.sizeHeigthMinNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeHeigthMinNumericUpDown.Location = new System.Drawing.Point(302, 45);
            this.sizeHeigthMinNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sizeHeigthMinNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeHeigthMinNumericUpDown.Name = "sizeHeigthMinNumericUpDown";
            this.sizeHeigthMinNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.sizeHeigthMinNumericUpDown.TabIndex = 5;
            this.sizeHeigthMinNumericUpDown.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // additionalLabel3
            // 
            this.additionalLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalLabel3.AutoSize = true;
            this.additionalLabel3.Location = new System.Drawing.Point(373, 21);
            this.additionalLabel3.Name = "additionalLabel3";
            this.additionalLabel3.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel3.TabIndex = 4;
            this.additionalLabel3.Text = "-";
            // 
            // sizeWidthMaxNumericUpDown
            // 
            this.sizeWidthMaxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeWidthMaxNumericUpDown.Location = new System.Drawing.Point(389, 19);
            this.sizeWidthMaxNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sizeWidthMaxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeWidthMaxNumericUpDown.Name = "sizeWidthMaxNumericUpDown";
            this.sizeWidthMaxNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.sizeWidthMaxNumericUpDown.TabIndex = 3;
            this.sizeWidthMaxNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // sizeWidthMinNumericUpDown
            // 
            this.sizeWidthMinNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeWidthMinNumericUpDown.Location = new System.Drawing.Point(302, 19);
            this.sizeWidthMinNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sizeWidthMinNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeWidthMinNumericUpDown.Name = "sizeWidthMinNumericUpDown";
            this.sizeWidthMinNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.sizeWidthMinNumericUpDown.TabIndex = 2;
            this.sizeWidthMinNumericUpDown.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // sizeHeightLabel
            // 
            this.sizeHeightLabel.AutoSize = true;
            this.sizeHeightLabel.Location = new System.Drawing.Point(6, 47);
            this.sizeHeightLabel.Name = "sizeHeightLabel";
            this.sizeHeightLabel.Size = new System.Drawing.Size(38, 13);
            this.sizeHeightLabel.TabIndex = 1;
            this.sizeHeightLabel.Text = "Height";
            // 
            // sizeWidthLabel
            // 
            this.sizeWidthLabel.AutoSize = true;
            this.sizeWidthLabel.Location = new System.Drawing.Point(6, 21);
            this.sizeWidthLabel.Name = "sizeWidthLabel";
            this.sizeWidthLabel.Size = new System.Drawing.Size(35, 13);
            this.sizeWidthLabel.TabIndex = 0;
            this.sizeWidthLabel.Text = "Width";
            // 
            // modificationsGroupBox
            // 
            this.modificationsGroupBox.Controls.Add(this.modificationsNoiseCheckBox);
            this.modificationsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.modificationsGroupBox.Location = new System.Drawing.Point(0, 210);
            this.modificationsGroupBox.Name = "modificationsGroupBox";
            this.modificationsGroupBox.Size = new System.Drawing.Size(460, 42);
            this.modificationsGroupBox.TabIndex = 41;
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
            // backgroundColorGroupBox
            // 
            this.backgroundColorGroupBox.Controls.Add(this.backgroundCompleteColorSelectControl);
            this.backgroundColorGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.backgroundColorGroupBox.Location = new System.Drawing.Point(0, 491);
            this.backgroundColorGroupBox.Name = "backgroundColorGroupBox";
            this.backgroundColorGroupBox.Size = new System.Drawing.Size(460, 160);
            this.backgroundColorGroupBox.TabIndex = 42;
            this.backgroundColorGroupBox.TabStop = false;
            this.backgroundColorGroupBox.Text = "Background color";
            // 
            // textGroupBox
            // 
            this.textGroupBox.Controls.Add(this.textTextBox);
            this.textGroupBox.Controls.Add(this.textButton);
            this.textGroupBox.Controls.Add(this.textComboBox);
            this.textGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.textGroupBox.Location = new System.Drawing.Point(0, 47);
            this.textGroupBox.Name = "textGroupBox";
            this.textGroupBox.Size = new System.Drawing.Size(460, 47);
            this.textGroupBox.TabIndex = 44;
            this.textGroupBox.TabStop = false;
            this.textGroupBox.Text = "Text";
            // 
            // textTextBox
            // 
            this.textTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTextBox.Location = new System.Drawing.Point(124, 19);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(292, 20);
            this.textTextBox.TabIndex = 7;
            // 
            // textButton
            // 
            this.textButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textButton.Location = new System.Drawing.Point(422, 17);
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
            // numberGroupBox
            // 
            this.numberGroupBox.Controls.Add(this.additionalLabel1);
            this.numberGroupBox.Controls.Add(this.numberMaxNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberMinNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberComboBox);
            this.numberGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberGroupBox.Location = new System.Drawing.Point(0, 94);
            this.numberGroupBox.Name = "numberGroupBox";
            this.numberGroupBox.Size = new System.Drawing.Size(460, 47);
            this.numberGroupBox.TabIndex = 45;
            this.numberGroupBox.TabStop = false;
            this.numberGroupBox.Text = "Number";
            // 
            // additionalLabel1
            // 
            this.additionalLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalLabel1.AutoSize = true;
            this.additionalLabel1.Location = new System.Drawing.Point(373, 22);
            this.additionalLabel1.Name = "additionalLabel1";
            this.additionalLabel1.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel1.TabIndex = 17;
            this.additionalLabel1.Text = "-";
            // 
            // numberMaxNumericUpDown
            // 
            this.numberMaxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberMaxNumericUpDown.Location = new System.Drawing.Point(389, 20);
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
            this.numberMinNumericUpDown.Location = new System.Drawing.Point(302, 20);
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
            // fontSelectControl
            // 
            this.fontSelectControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.fontSelectControl.Location = new System.Drawing.Point(0, 252);
            this.fontSelectControl.Name = "fontSelectControl";
            fontSettings1.Font = Umax.Plugins.Images.Enums.FontType.Random;
            colorSettings2.Color = Umax.Plugins.Images.Enums.ColorType.Random;
            colorSettings2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorSettings2.SelectedColorRangeBMax = 200;
            colorSettings2.SelectedColorRangeBMin = 100;
            colorSettings2.SelectedColorRangeGMax = 200;
            colorSettings2.SelectedColorRangeGMin = 100;
            colorSettings2.SelectedColorRangeRMax = 200;
            colorSettings2.SelectedColorRangeRMin = 100;
            fontSettings1.FontColorSettings = colorSettings2;
            fontSettings1.FontName = "";
            fontSettings1.FontSize = 10;
            fontSettings1.FontStyle = System.Drawing.FontStyle.Regular;
            this.fontSelectControl.Settings = fontSettings1;
            this.fontSelectControl.Size = new System.Drawing.Size(460, 239);
            this.fontSelectControl.TabIndex = 43;
            // 
            // backgroundCompleteColorSelectControl
            // 
            this.backgroundCompleteColorSelectControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundCompleteColorSelectControl.Location = new System.Drawing.Point(3, 16);
            this.backgroundCompleteColorSelectControl.Name = "backgroundCompleteColorSelectControl";
            colorSettings1.Color = Umax.Plugins.Images.Enums.ColorType.Random;
            colorSettings1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorSettings1.SelectedColorRangeBMax = 200;
            colorSettings1.SelectedColorRangeBMin = 100;
            colorSettings1.SelectedColorRangeGMax = 200;
            colorSettings1.SelectedColorRangeGMin = 100;
            colorSettings1.SelectedColorRangeRMax = 200;
            colorSettings1.SelectedColorRangeRMin = 100;
            this.backgroundCompleteColorSelectControl.Settings = colorSettings1;
            this.backgroundCompleteColorSelectControl.Size = new System.Drawing.Size(454, 141);
            this.backgroundCompleteColorSelectControl.TabIndex = 0;
            // 
            // GenerateTextImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backgroundColorGroupBox);
            this.Controls.Add(this.fontSelectControl);
            this.Controls.Add(this.modificationsGroupBox);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.numberGroupBox);
            this.Controls.Add(this.textGroupBox);
            this.Controls.Add(this.nameGroupBox);
            this.Name = "GenerateTextImageControl";
            this.Size = new System.Drawing.Size(460, 650);
            this.Load += new System.EventHandler(this.GenerateTextImageControl_Load);
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeigthMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeigthMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidthMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidthMinNumericUpDown)).EndInit();
            this.modificationsGroupBox.ResumeLayout(false);
            this.modificationsGroupBox.PerformLayout();
            this.backgroundColorGroupBox.ResumeLayout(false);
            this.textGroupBox.ResumeLayout(false);
            this.textGroupBox.PerformLayout();
            this.numberGroupBox.ResumeLayout(false);
            this.numberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMinNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        protected System.Windows.Forms.TextBox nameTextBox;
        protected System.Windows.Forms.Button nameButton;
        protected System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.Label additionalLabel2;
        private System.Windows.Forms.NumericUpDown sizeHeigthMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown sizeHeigthMinNumericUpDown;
        private System.Windows.Forms.Label additionalLabel3;
        private System.Windows.Forms.NumericUpDown sizeWidthMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown sizeWidthMinNumericUpDown;
        private System.Windows.Forms.Label sizeHeightLabel;
        private System.Windows.Forms.Label sizeWidthLabel;
        private System.Windows.Forms.GroupBox modificationsGroupBox;
        private System.Windows.Forms.CheckBox modificationsNoiseCheckBox;
        private System.Windows.Forms.GroupBox backgroundColorGroupBox;
        private CompleteColorSelectControl backgroundCompleteColorSelectControl;
        private FontSelectControl fontSelectControl;
        private System.Windows.Forms.GroupBox textGroupBox;
        protected System.Windows.Forms.TextBox textTextBox;
        protected System.Windows.Forms.Button textButton;
        protected System.Windows.Forms.ComboBox textComboBox;
        private System.Windows.Forms.GroupBox numberGroupBox;
        private System.Windows.Forms.Label additionalLabel1;
        protected System.Windows.Forms.NumericUpDown numberMaxNumericUpDown;
        protected System.Windows.Forms.NumericUpDown numberMinNumericUpDown;
        protected System.Windows.Forms.ComboBox numberComboBox;
    }
}
