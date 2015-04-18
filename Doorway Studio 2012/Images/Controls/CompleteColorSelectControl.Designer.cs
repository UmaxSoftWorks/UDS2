namespace Umax.Plugins.Images.Controls
{
    partial class CompleteColorSelectControl
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
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.colorTabControl = new System.Windows.Forms.TabControl();
            this.colorTabPage = new System.Windows.Forms.TabPage();
            this.colorSelect = new Umax.Plugins.Images.Controls.ColorSelectControl();
            this.colorRangeTabPage = new System.Windows.Forms.TabPage();
            this.additionalLabel3 = new System.Windows.Forms.Label();
            this.colorRangeBMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorRangeBMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorRangeBLabel = new System.Windows.Forms.Label();
            this.additionalLabel2 = new System.Windows.Forms.Label();
            this.colorRangeGMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorRangeGMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.additionalLabel1 = new System.Windows.Forms.Label();
            this.colorRangeRMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorRangeRMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorRangeGLabel = new System.Windows.Forms.Label();
            this.colorRangeRLabel = new System.Windows.Forms.Label();
            this.colorTabControl.SuspendLayout();
            this.colorTabPage.SuspendLayout();
            this.colorRangeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorRangeBMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRangeBMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRangeGMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRangeGMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRangeRMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRangeRMinNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Random",
            "Selected",
            "Range"});
            this.colorComboBox.Location = new System.Drawing.Point(3, 3);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(106, 21);
            this.colorComboBox.TabIndex = 42;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBoxSelectedIndexChanged);
            // 
            // colorTabControl
            // 
            this.colorTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorTabControl.Controls.Add(this.colorTabPage);
            this.colorTabControl.Controls.Add(this.colorRangeTabPage);
            this.colorTabControl.Location = new System.Drawing.Point(3, 30);
            this.colorTabControl.Name = "colorTabControl";
            this.colorTabControl.SelectedIndex = 0;
            this.colorTabControl.Size = new System.Drawing.Size(442, 109);
            this.colorTabControl.TabIndex = 41;
            // 
            // colorTabPage
            // 
            this.colorTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.colorTabPage.Controls.Add(this.colorSelect);
            this.colorTabPage.Location = new System.Drawing.Point(4, 22);
            this.colorTabPage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.colorTabPage.Name = "colorTabPage";
            this.colorTabPage.Size = new System.Drawing.Size(434, 83);
            this.colorTabPage.TabIndex = 0;
            this.colorTabPage.Text = "Color";
            // 
            // colorSelect
            // 
            this.colorSelect.AccessibleDescription = "Select a color to use";
            this.colorSelect.AccessibleName = "Select Color";
            this.colorSelect.ControlID = 1;
            this.colorSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorSelect.Location = new System.Drawing.Point(0, 0);
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorSelect.Size = new System.Drawing.Size(434, 83);
            this.colorSelect.TabIndex = 1;
            // 
            // colorRangeTabPage
            // 
            this.colorRangeTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.colorRangeTabPage.Controls.Add(this.additionalLabel3);
            this.colorRangeTabPage.Controls.Add(this.colorRangeBMaxNumericUpDown);
            this.colorRangeTabPage.Controls.Add(this.colorRangeBMinNumericUpDown);
            this.colorRangeTabPage.Controls.Add(this.colorRangeBLabel);
            this.colorRangeTabPage.Controls.Add(this.additionalLabel2);
            this.colorRangeTabPage.Controls.Add(this.colorRangeGMaxNumericUpDown);
            this.colorRangeTabPage.Controls.Add(this.colorRangeGMinNumericUpDown);
            this.colorRangeTabPage.Controls.Add(this.additionalLabel1);
            this.colorRangeTabPage.Controls.Add(this.colorRangeRMaxNumericUpDown);
            this.colorRangeTabPage.Controls.Add(this.colorRangeRMinNumericUpDown);
            this.colorRangeTabPage.Controls.Add(this.colorRangeGLabel);
            this.colorRangeTabPage.Controls.Add(this.colorRangeRLabel);
            this.colorRangeTabPage.Location = new System.Drawing.Point(4, 22);
            this.colorRangeTabPage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.colorRangeTabPage.Name = "colorRangeTabPage";
            this.colorRangeTabPage.Size = new System.Drawing.Size(434, 83);
            this.colorRangeTabPage.TabIndex = 1;
            this.colorRangeTabPage.Text = "Range";
            // 
            // additionalLabel3
            // 
            this.additionalLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalLabel3.AutoSize = true;
            this.additionalLabel3.Location = new System.Drawing.Point(350, 60);
            this.additionalLabel3.Name = "additionalLabel3";
            this.additionalLabel3.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel3.TabIndex = 19;
            this.additionalLabel3.Text = "-";
            // 
            // colorRangeBMaxNumericUpDown
            // 
            this.colorRangeBMaxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorRangeBMaxNumericUpDown.Location = new System.Drawing.Point(366, 58);
            this.colorRangeBMaxNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.colorRangeBMaxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colorRangeBMaxNumericUpDown.Name = "colorRangeBMaxNumericUpDown";
            this.colorRangeBMaxNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.colorRangeBMaxNumericUpDown.TabIndex = 18;
            this.colorRangeBMaxNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // colorRangeBMinNumericUpDown
            // 
            this.colorRangeBMinNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorRangeBMinNumericUpDown.Location = new System.Drawing.Point(279, 58);
            this.colorRangeBMinNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.colorRangeBMinNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colorRangeBMinNumericUpDown.Name = "colorRangeBMinNumericUpDown";
            this.colorRangeBMinNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.colorRangeBMinNumericUpDown.TabIndex = 17;
            this.colorRangeBMinNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // colorRangeBLabel
            // 
            this.colorRangeBLabel.AutoSize = true;
            this.colorRangeBLabel.Location = new System.Drawing.Point(3, 60);
            this.colorRangeBLabel.Name = "colorRangeBLabel";
            this.colorRangeBLabel.Size = new System.Drawing.Size(14, 13);
            this.colorRangeBLabel.TabIndex = 16;
            this.colorRangeBLabel.Text = "B";
            // 
            // additionalLabel2
            // 
            this.additionalLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalLabel2.AutoSize = true;
            this.additionalLabel2.Location = new System.Drawing.Point(350, 34);
            this.additionalLabel2.Name = "additionalLabel2";
            this.additionalLabel2.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel2.TabIndex = 15;
            this.additionalLabel2.Text = "-";
            // 
            // colorRangeGMaxNumericUpDown
            // 
            this.colorRangeGMaxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorRangeGMaxNumericUpDown.Location = new System.Drawing.Point(366, 32);
            this.colorRangeGMaxNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorRangeGMaxNumericUpDown.Name = "colorRangeGMaxNumericUpDown";
            this.colorRangeGMaxNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.colorRangeGMaxNumericUpDown.TabIndex = 14;
            this.colorRangeGMaxNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // colorRangeGMinNumericUpDown
            // 
            this.colorRangeGMinNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorRangeGMinNumericUpDown.Location = new System.Drawing.Point(279, 32);
            this.colorRangeGMinNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorRangeGMinNumericUpDown.Name = "colorRangeGMinNumericUpDown";
            this.colorRangeGMinNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.colorRangeGMinNumericUpDown.TabIndex = 13;
            this.colorRangeGMinNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // additionalLabel1
            // 
            this.additionalLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalLabel1.AutoSize = true;
            this.additionalLabel1.Location = new System.Drawing.Point(350, 8);
            this.additionalLabel1.Name = "additionalLabel1";
            this.additionalLabel1.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel1.TabIndex = 12;
            this.additionalLabel1.Text = "-";
            // 
            // colorRangeRMaxNumericUpDown
            // 
            this.colorRangeRMaxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorRangeRMaxNumericUpDown.Location = new System.Drawing.Point(366, 6);
            this.colorRangeRMaxNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorRangeRMaxNumericUpDown.Name = "colorRangeRMaxNumericUpDown";
            this.colorRangeRMaxNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.colorRangeRMaxNumericUpDown.TabIndex = 11;
            this.colorRangeRMaxNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // colorRangeRMinNumericUpDown
            // 
            this.colorRangeRMinNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorRangeRMinNumericUpDown.Location = new System.Drawing.Point(279, 6);
            this.colorRangeRMinNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorRangeRMinNumericUpDown.Name = "colorRangeRMinNumericUpDown";
            this.colorRangeRMinNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.colorRangeRMinNumericUpDown.TabIndex = 10;
            this.colorRangeRMinNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // colorRangeGLabel
            // 
            this.colorRangeGLabel.AutoSize = true;
            this.colorRangeGLabel.Location = new System.Drawing.Point(2, 34);
            this.colorRangeGLabel.Name = "colorRangeGLabel";
            this.colorRangeGLabel.Size = new System.Drawing.Size(15, 13);
            this.colorRangeGLabel.TabIndex = 9;
            this.colorRangeGLabel.Text = "G";
            // 
            // colorRangeRLabel
            // 
            this.colorRangeRLabel.AutoSize = true;
            this.colorRangeRLabel.Location = new System.Drawing.Point(2, 8);
            this.colorRangeRLabel.Name = "colorRangeRLabel";
            this.colorRangeRLabel.Size = new System.Drawing.Size(15, 13);
            this.colorRangeRLabel.TabIndex = 8;
            this.colorRangeRLabel.Text = "R";
            // 
            // CompleteColorSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.colorTabControl);
            this.Name = "CompleteColorSelectControl";
            this.Size = new System.Drawing.Size(447, 143);
            this.colorTabControl.ResumeLayout(false);
            this.colorTabPage.ResumeLayout(false);
            this.colorRangeTabPage.ResumeLayout(false);
            this.colorRangeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorRangeBMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRangeBMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRangeGMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRangeGMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRangeRMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRangeRMinNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl colorTabControl;
        private System.Windows.Forms.TabPage colorTabPage;
        private System.Windows.Forms.TabPage colorRangeTabPage;
        private System.Windows.Forms.Label additionalLabel3;
        private System.Windows.Forms.Label colorRangeBLabel;
        private System.Windows.Forms.Label additionalLabel2;
        private System.Windows.Forms.Label additionalLabel1;
        private System.Windows.Forms.Label colorRangeGLabel;
        private System.Windows.Forms.Label colorRangeRLabel;
        protected System.Windows.Forms.ComboBox colorComboBox;
        protected ColorSelectControl colorSelect;
        protected System.Windows.Forms.NumericUpDown colorRangeBMaxNumericUpDown;
        protected System.Windows.Forms.NumericUpDown colorRangeBMinNumericUpDown;
        protected System.Windows.Forms.NumericUpDown colorRangeGMaxNumericUpDown;
        protected System.Windows.Forms.NumericUpDown colorRangeGMinNumericUpDown;
        protected System.Windows.Forms.NumericUpDown colorRangeRMaxNumericUpDown;
        protected System.Windows.Forms.NumericUpDown colorRangeRMinNumericUpDown;
    }
}
