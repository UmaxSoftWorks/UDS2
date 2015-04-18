using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Controls;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Modify.Figures
{
    partial class ModifyFiguresImageControl
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
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.modificationsGroupBox = new System.Windows.Forms.GroupBox();
            this.modificationsNoiseCheckBox = new System.Windows.Forms.CheckBox();
            this.numberGroupBox = new System.Windows.Forms.GroupBox();
            this.additionalLabel2 = new System.Windows.Forms.Label();
            this.numberFiguresMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberFiguresMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberFiguresLabel = new System.Windows.Forms.Label();
            this.additionalLabel1 = new System.Windows.Forms.Label();
            this.numberMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.figuresColorGroupBox = new System.Windows.Forms.GroupBox();
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
            this.figuresCompleteColorSelectControl = new Umax.Plugins.Images.Controls.CompleteColorSelectControl();
            this.modificationsGroupBox.SuspendLayout();
            this.numberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberFiguresMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFiguresMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMinNumericUpDown)).BeginInit();
            this.figuresColorGroupBox.SuspendLayout();
            this.renameGroupBox.SuspendLayout();
            this.imagesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.Filter = "Text|*.txt";
            // 
            // modificationsGroupBox
            // 
            this.modificationsGroupBox.Controls.Add(this.modificationsNoiseCheckBox);
            this.modificationsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.modificationsGroupBox.Location = new System.Drawing.Point(0, 193);
            this.modificationsGroupBox.Name = "modificationsGroupBox";
            this.modificationsGroupBox.Size = new System.Drawing.Size(460, 42);
            this.modificationsGroupBox.TabIndex = 42;
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
            // numberGroupBox
            // 
            this.numberGroupBox.Controls.Add(this.additionalLabel2);
            this.numberGroupBox.Controls.Add(this.numberFiguresMaxNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberFiguresMinNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberFiguresLabel);
            this.numberGroupBox.Controls.Add(this.additionalLabel1);
            this.numberGroupBox.Controls.Add(this.numberMaxNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberMinNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberComboBox);
            this.numberGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberGroupBox.Location = new System.Drawing.Point(0, 120);
            this.numberGroupBox.Name = "numberGroupBox";
            this.numberGroupBox.Size = new System.Drawing.Size(460, 73);
            this.numberGroupBox.TabIndex = 43;
            this.numberGroupBox.TabStop = false;
            this.numberGroupBox.Text = "Number";
            // 
            // additionalLabel2
            // 
            this.additionalLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalLabel2.AutoSize = true;
            this.additionalLabel2.Location = new System.Drawing.Point(376, 48);
            this.additionalLabel2.Name = "additionalLabel2";
            this.additionalLabel2.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel2.TabIndex = 25;
            this.additionalLabel2.Text = "-";
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
            this.numberFiguresMaxNumericUpDown.TabIndex = 24;
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
            this.numberFiguresMinNumericUpDown.TabIndex = 23;
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
            this.numberFiguresLabel.TabIndex = 22;
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
            // figuresColorGroupBox
            // 
            this.figuresColorGroupBox.Controls.Add(this.figuresCompleteColorSelectControl);
            this.figuresColorGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.figuresColorGroupBox.Location = new System.Drawing.Point(0, 235);
            this.figuresColorGroupBox.Name = "figuresColorGroupBox";
            this.figuresColorGroupBox.Size = new System.Drawing.Size(460, 160);
            this.figuresColorGroupBox.TabIndex = 49;
            this.figuresColorGroupBox.TabStop = false;
            this.figuresColorGroupBox.Text = "Figures color";
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
            // ModifyFiguresImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.figuresColorGroupBox);
            this.Controls.Add(this.modificationsGroupBox);
            this.Controls.Add(this.numberGroupBox);
            this.Controls.Add(this.renameGroupBox);
            this.Controls.Add(this.imagesGroupBox);
            this.Name = "ModifyFiguresImageControl";
            this.Size = new System.Drawing.Size(460, 400);
            this.Load += new System.EventHandler(this.ModifyTextImageControl_Load);
            this.modificationsGroupBox.ResumeLayout(false);
            this.modificationsGroupBox.PerformLayout();
            this.numberGroupBox.ResumeLayout(false);
            this.numberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberFiguresMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFiguresMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMinNumericUpDown)).EndInit();
            this.figuresColorGroupBox.ResumeLayout(false);
            this.renameGroupBox.ResumeLayout(false);
            this.renameGroupBox.PerformLayout();
            this.imagesGroupBox.ResumeLayout(false);
            this.imagesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        private System.Windows.Forms.GroupBox modificationsGroupBox;
        private System.Windows.Forms.CheckBox modificationsNoiseCheckBox;
        private System.Windows.Forms.GroupBox numberGroupBox;
        private System.Windows.Forms.Label additionalLabel1;
        protected System.Windows.Forms.NumericUpDown numberMaxNumericUpDown;
        protected System.Windows.Forms.NumericUpDown numberMinNumericUpDown;
        protected System.Windows.Forms.ComboBox numberComboBox;
        private System.Windows.Forms.GroupBox figuresColorGroupBox;
        private CompleteColorSelectControl figuresCompleteColorSelectControl;
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
        private System.Windows.Forms.Label additionalLabel2;
        private System.Windows.Forms.NumericUpDown numberFiguresMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown numberFiguresMinNumericUpDown;
        private System.Windows.Forms.Label numberFiguresLabel;
    }
}
