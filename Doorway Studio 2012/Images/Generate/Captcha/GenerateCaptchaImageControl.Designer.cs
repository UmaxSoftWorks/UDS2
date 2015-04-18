namespace Umax.Plugins.Images.Generate.Captcha
{
    partial class GenerateCaptchaImageControl
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
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameButton = new System.Windows.Forms.Button();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.numberGroupBox = new System.Windows.Forms.GroupBox();
            this.additionalLabel1 = new System.Windows.Forms.Label();
            this.numberMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.additionalLabel2 = new System.Windows.Forms.Label();
            this.sizeHeigthMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeHeigthMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.additionalLabel3 = new System.Windows.Forms.Label();
            this.sizeWidthMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeWidthMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeHeightLabel = new System.Windows.Forms.Label();
            this.sizeWidthLabel = new System.Windows.Forms.Label();
            this.nameGroupBox.SuspendLayout();
            this.numberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMinNumericUpDown)).BeginInit();
            this.sizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeigthMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeigthMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidthMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidthMinNumericUpDown)).BeginInit();
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
            // numberGroupBox
            // 
            this.numberGroupBox.Controls.Add(this.additionalLabel1);
            this.numberGroupBox.Controls.Add(this.numberMaxNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberMinNumericUpDown);
            this.numberGroupBox.Controls.Add(this.numberComboBox);
            this.numberGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberGroupBox.Location = new System.Drawing.Point(0, 47);
            this.numberGroupBox.Name = "numberGroupBox";
            this.numberGroupBox.Size = new System.Drawing.Size(460, 47);
            this.numberGroupBox.TabIndex = 36;
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
            this.sizeGroupBox.Location = new System.Drawing.Point(0, 94);
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
            // GenerateCaptchaImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.numberGroupBox);
            this.Controls.Add(this.nameGroupBox);
            this.Name = "GenerateCaptchaImageControl";
            this.Size = new System.Drawing.Size(460, 168);
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.numberGroupBox.ResumeLayout(false);
            this.numberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMinNumericUpDown)).EndInit();
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeigthMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeHeigthMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidthMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeWidthMinNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        private System.Windows.Forms.GroupBox numberGroupBox;
        protected System.Windows.Forms.TextBox nameTextBox;
        protected System.Windows.Forms.Button nameButton;
        protected System.Windows.Forms.ComboBox nameComboBox;
        protected System.Windows.Forms.ComboBox numberComboBox;
        private System.Windows.Forms.Label additionalLabel1;
        protected System.Windows.Forms.NumericUpDown numberMaxNumericUpDown;
        protected System.Windows.Forms.NumericUpDown numberMinNumericUpDown;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.Label additionalLabel2;
        private System.Windows.Forms.NumericUpDown sizeHeigthMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown sizeHeigthMinNumericUpDown;
        private System.Windows.Forms.Label additionalLabel3;
        private System.Windows.Forms.NumericUpDown sizeWidthMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown sizeWidthMinNumericUpDown;
        private System.Windows.Forms.Label sizeHeightLabel;
        private System.Windows.Forms.Label sizeWidthLabel;
    }
}
