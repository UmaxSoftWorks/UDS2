using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Controls;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Generate.Figures
{
    partial class GenerateFiguresImageControl
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
            this.figuresColorGroupBox = new System.Windows.Forms.GroupBox();
            this.modificationsGroupBox = new System.Windows.Forms.GroupBox();
            this.modificationsNoiseCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundColorGroupBox = new System.Windows.Forms.GroupBox();
            this.numberGroupBox = new System.Windows.Forms.GroupBox();
            this.additionalLabel4 = new System.Windows.Forms.Label();
            this.numberFiguresMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberFiguresMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberFiguresLabel = new System.Windows.Forms.Label();
            this.additionalLabel1 = new System.Windows.Forms.Label();
            this.numberMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundCompleteColorSelectControl = new Umax.Plugins.Images.Controls.CompleteColorSelectControl();
            this.figuresCompleteColorSelectControl = new Umax.Plugins.Images.Controls.CompleteColorSelectControl();
            this.nameGroupBox.SuspendLayout();
            this.sizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeigthMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeigthMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidthMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidthMinNumericUpDown)).BeginInit();
            this.figuresColorGroupBox.SuspendLayout();
            this.modificationsGroupBox.SuspendLayout();
            this.backgroundColorGroupBox.SuspendLayout();
            this.numberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberFiguresMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFiguresMinNumericUpDown)).BeginInit();
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
            this.nameTextBox.Size = new System.Drawing.Size(295, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // nameButton
            // 
            this.nameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameButton.Location = new System.Drawing.Point(425, 17);
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
            this.sizeGroupBox.Location = new System.Drawing.Point(0, 47);
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
            this.additionalLabel2.Location = new System.Drawing.Point(376, 47);
            this.additionalLabel2.Name = "additionalLabel2";
            this.additionalLabel2.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel2.TabIndex = 7;
            this.additionalLabel2.Text = "-";
            // 
            // sizeHeigthMaxNumericUpDown
            // 
            this.sizeHeigthMaxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeHeigthMaxNumericUpDown.Location = new System.Drawing.Point(392, 45);
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
            this.sizeHeigthMinNumericUpDown.Location = new System.Drawing.Point(305, 45);
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
            this.additionalLabel3.Location = new System.Drawing.Point(376, 21);
            this.additionalLabel3.Name = "additionalLabel3";
            this.additionalLabel3.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel3.TabIndex = 4;
            this.additionalLabel3.Text = "-";
            // 
            // sizeWidthMaxNumericUpDown
            // 
            this.sizeWidthMaxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeWidthMaxNumericUpDown.Location = new System.Drawing.Point(392, 19);
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
            this.sizeWidthMinNumericUpDown.Location = new System.Drawing.Point(305, 19);
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
            // figuresColorGroupBox
            // 
            this.figuresColorGroupBox.Controls.Add(this.figuresCompleteColorSelectControl);
            this.figuresColorGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.figuresColorGroupBox.Location = new System.Drawing.Point(0, 230);
            this.figuresColorGroupBox.Name = "figuresColorGroupBox";
            this.figuresColorGroupBox.Size = new System.Drawing.Size(460, 160);
            this.figuresColorGroupBox.TabIndex = 38;
            this.figuresColorGroupBox.TabStop = false;
            this.figuresColorGroupBox.Text = "Figures color";
            // 
            // modificationsGroupBox
            // 
            this.modificationsGroupBox.Controls.Add(this.modificationsNoiseCheckBox);
            this.modificationsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.modificationsGroupBox.Location = new System.Drawing.Point(0, 188);
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
            this.backgroundColorGroupBox.Location = new System.Drawing.Point(0, 390);
            this.backgroundColorGroupBox.Name = "backgroundColorGroupBox";
            this.backgroundColorGroupBox.Size = new System.Drawing.Size(460, 160);
            this.backgroundColorGroupBox.TabIndex = 42;
            this.backgroundColorGroupBox.TabStop = false;
            this.backgroundColorGroupBox.Text = "Background color";
            // 
            // numberGroupBox
            // 
            this.numberGroupBox.Controls.Add(this.additionalLabel4);
            this.numberGroupBox.Controls.Add(this.numberFiguresMaxNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberFiguresMinNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberFiguresLabel);
            this.numberGroupBox.Controls.Add(this.additionalLabel1);
            this.numberGroupBox.Controls.Add(this.numberMaxNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberMinNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberComboBox);
            this.numberGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberGroupBox.Location = new System.Drawing.Point(0, 116);
            this.numberGroupBox.Name = "numberGroupBox";
            this.numberGroupBox.Size = new System.Drawing.Size(460, 72);
            this.numberGroupBox.TabIndex = 43;
            this.numberGroupBox.TabStop = false;
            this.numberGroupBox.Text = "Number";
            // 
            // additionalLabel4
            // 
            this.additionalLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalLabel4.AutoSize = true;
            this.additionalLabel4.Location = new System.Drawing.Point(376, 48);
            this.additionalLabel4.Name = "additionalLabel4";
            this.additionalLabel4.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel4.TabIndex = 21;
            this.additionalLabel4.Text = "-";
            // 
            // numberFiguresMaxNumericUpDown
            // 
            this.numberFiguresMaxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberFiguresMaxNumericUpDown.Location = new System.Drawing.Point(392, 46);
            this.numberFiguresMaxNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberFiguresMaxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberFiguresMaxNumericUpDown.Name = "numberFiguresMaxNumericUpDown";
            this.numberFiguresMaxNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.numberFiguresMaxNumericUpDown.TabIndex = 20;
            this.numberFiguresMaxNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numberFiguresMinNumericUpDown
            // 
            this.numberFiguresMinNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberFiguresMinNumericUpDown.Location = new System.Drawing.Point(305, 46);
            this.numberFiguresMinNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberFiguresMinNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberFiguresMinNumericUpDown.Name = "numberFiguresMinNumericUpDown";
            this.numberFiguresMinNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.numberFiguresMinNumericUpDown.TabIndex = 19;
            this.numberFiguresMinNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numberFiguresLabel
            // 
            this.numberFiguresLabel.AutoSize = true;
            this.numberFiguresLabel.Location = new System.Drawing.Point(6, 48);
            this.numberFiguresLabel.Name = "numberFiguresLabel";
            this.numberFiguresLabel.Size = new System.Drawing.Size(41, 13);
            this.numberFiguresLabel.TabIndex = 18;
            this.numberFiguresLabel.Text = "Figures";
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
            // backgroundCompleteColorSelectControl
            // 
            this.backgroundCompleteColorSelectControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundCompleteColorSelectControl.Location = new System.Drawing.Point(3, 16);
            this.backgroundCompleteColorSelectControl.Name = "backgroundCompleteColorSelectControl";
            colorSettings2.Color = Umax.Plugins.Images.Enums.ColorType.Random;
            colorSettings2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorSettings2.SelectedColorRangeBMax = 200;
            colorSettings2.SelectedColorRangeBMin = 100;
            colorSettings2.SelectedColorRangeGMax = 200;
            colorSettings2.SelectedColorRangeGMin = 100;
            colorSettings2.SelectedColorRangeRMax = 200;
            colorSettings2.SelectedColorRangeRMin = 100;
            this.backgroundCompleteColorSelectControl.Settings = colorSettings2;
            this.backgroundCompleteColorSelectControl.Size = new System.Drawing.Size(454, 141);
            this.backgroundCompleteColorSelectControl.TabIndex = 0;
            // 
            // figuresCompleteColorSelectControl
            // 
            this.figuresCompleteColorSelectControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figuresCompleteColorSelectControl.Location = new System.Drawing.Point(3, 16);
            this.figuresCompleteColorSelectControl.Name = "figuresCompleteColorSelectControl";
            colorSettings1.Color = Umax.Plugins.Images.Enums.ColorType.Random;
            colorSettings1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorSettings1.SelectedColorRangeBMax = 200;
            colorSettings1.SelectedColorRangeBMin = 100;
            colorSettings1.SelectedColorRangeGMax = 200;
            colorSettings1.SelectedColorRangeGMin = 100;
            colorSettings1.SelectedColorRangeRMax = 200;
            colorSettings1.SelectedColorRangeRMin = 100;
            this.figuresCompleteColorSelectControl.Settings = colorSettings1;
            this.figuresCompleteColorSelectControl.Size = new System.Drawing.Size(454, 141);
            this.figuresCompleteColorSelectControl.TabIndex = 0;
            // 
            // GenerateFiguresImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backgroundColorGroupBox);
            this.Controls.Add(this.figuresColorGroupBox);
            this.Controls.Add(this.modificationsGroupBox);
            this.Controls.Add(this.numberGroupBox);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.nameGroupBox);
            this.Name = "GenerateFiguresImageControl";
            this.Size = new System.Drawing.Size(460, 555);
            this.Load += new System.EventHandler(this.GenerateKeywordImageControl_Load);
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeigthMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeigthMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidthMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidthMinNumericUpDown)).EndInit();
            this.figuresColorGroupBox.ResumeLayout(false);
            this.modificationsGroupBox.ResumeLayout(false);
            this.modificationsGroupBox.PerformLayout();
            this.backgroundColorGroupBox.ResumeLayout(false);
            this.numberGroupBox.ResumeLayout(false);
            this.numberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberFiguresMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFiguresMinNumericUpDown)).EndInit();
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
        private System.Windows.Forms.GroupBox figuresColorGroupBox;
        private System.Windows.Forms.GroupBox modificationsGroupBox;
        private System.Windows.Forms.CheckBox modificationsNoiseCheckBox;
        private CompleteColorSelectControl figuresCompleteColorSelectControl;
        private System.Windows.Forms.GroupBox backgroundColorGroupBox;
        private CompleteColorSelectControl backgroundCompleteColorSelectControl;
        private System.Windows.Forms.GroupBox numberGroupBox;
        private System.Windows.Forms.Label additionalLabel1;
        protected System.Windows.Forms.NumericUpDown numberMaxNumericUpDown;
        protected System.Windows.Forms.NumericUpDown numberMinNumericUpDown;
        protected System.Windows.Forms.ComboBox numberComboBox;
        private System.Windows.Forms.Label additionalLabel4;
        private System.Windows.Forms.NumericUpDown numberFiguresMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown numberFiguresMinNumericUpDown;
        private System.Windows.Forms.Label numberFiguresLabel;
    }
}
