namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    partial class MapTabPageControl
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
            this.mapGroupBox = new System.Windows.Forms.GroupBox();
            this.mapTabControl = new System.Windows.Forms.TabControl();
            this.mapIncludeTabPage = new System.Windows.Forms.TabPage();
            this.mapIncludeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.mapHTMLTabPage = new System.Windows.Forms.TabPage();
            this.mapHTMLLinksGroupBox = new System.Windows.Forms.GroupBox();
            this.additionalLabel1 = new System.Windows.Forms.Label();
            this.mapHTMLLinksMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mapHTMLLinksMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mapHTMLComboBox = new System.Windows.Forms.ComboBox();
            this.mapHTMLNameTextBox = new System.Windows.Forms.TextBox();
            this.mapHTMLNameLabel = new System.Windows.Forms.Label();
            this.mapXMLTabPage = new System.Windows.Forms.TabPage();
            this.mapXMLNameTextBox = new System.Windows.Forms.TextBox();
            this.mapXMLNameLabel = new System.Windows.Forms.Label();
            this.mapComboBox = new System.Windows.Forms.ComboBox();
            this.mapGroupBox.SuspendLayout();
            this.mapTabControl.SuspendLayout();
            this.mapIncludeTabPage.SuspendLayout();
            this.mapHTMLTabPage.SuspendLayout();
            this.mapHTMLLinksGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapHTMLLinksMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapHTMLLinksMinNumericUpDown)).BeginInit();
            this.mapXMLTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapGroupBox
            // 
            this.mapGroupBox.Controls.Add(this.mapTabControl);
            this.mapGroupBox.Controls.Add(this.mapComboBox);
            this.mapGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mapGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mapGroupBox.Name = "mapGroupBox";
            this.mapGroupBox.Size = new System.Drawing.Size(417, 178);
            this.mapGroupBox.TabIndex = 3;
            this.mapGroupBox.TabStop = false;
            this.mapGroupBox.Text = "Map";
            // 
            // mapTabControl
            // 
            this.mapTabControl.Controls.Add(this.mapIncludeTabPage);
            this.mapTabControl.Controls.Add(this.mapHTMLTabPage);
            this.mapTabControl.Controls.Add(this.mapXMLTabPage);
            this.mapTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mapTabControl.Location = new System.Drawing.Point(3, 48);
            this.mapTabControl.Name = "mapTabControl";
            this.mapTabControl.SelectedIndex = 0;
            this.mapTabControl.Size = new System.Drawing.Size(411, 127);
            this.mapTabControl.TabIndex = 4;
            // 
            // mapIncludeTabPage
            // 
            this.mapIncludeTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.mapIncludeTabPage.Controls.Add(this.mapIncludeCheckedListBox);
            this.mapIncludeTabPage.Location = new System.Drawing.Point(4, 22);
            this.mapIncludeTabPage.Name = "mapIncludeTabPage";
            this.mapIncludeTabPage.Size = new System.Drawing.Size(403, 101);
            this.mapIncludeTabPage.TabIndex = 2;
            this.mapIncludeTabPage.Text = "Include";
            // 
            // mapIncludeCheckedListBox
            // 
            this.mapIncludeCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapIncludeCheckedListBox.FormattingEnabled = true;
            this.mapIncludeCheckedListBox.Items.AddRange(new object[] {
            "Index",
            "Regular pages",
            "Static pages",
            "Categories",
            "Custom pages"});
            this.mapIncludeCheckedListBox.Location = new System.Drawing.Point(0, 0);
            this.mapIncludeCheckedListBox.Name = "mapIncludeCheckedListBox";
            this.mapIncludeCheckedListBox.Size = new System.Drawing.Size(403, 101);
            this.mapIncludeCheckedListBox.TabIndex = 0;
            // 
            // mapHTMLTabPage
            // 
            this.mapHTMLTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.mapHTMLTabPage.Controls.Add(this.mapHTMLLinksGroupBox);
            this.mapHTMLTabPage.Controls.Add(this.mapHTMLComboBox);
            this.mapHTMLTabPage.Controls.Add(this.mapHTMLNameTextBox);
            this.mapHTMLTabPage.Controls.Add(this.mapHTMLNameLabel);
            this.mapHTMLTabPage.Location = new System.Drawing.Point(4, 22);
            this.mapHTMLTabPage.Name = "mapHTMLTabPage";
            this.mapHTMLTabPage.Size = new System.Drawing.Size(403, 101);
            this.mapHTMLTabPage.TabIndex = 1;
            this.mapHTMLTabPage.Text = "HTML";
            // 
            // mapHTMLLinksGroupBox
            // 
            this.mapHTMLLinksGroupBox.Controls.Add(this.additionalLabel1);
            this.mapHTMLLinksGroupBox.Controls.Add(this.mapHTMLLinksMaxNumericUpDown);
            this.mapHTMLLinksGroupBox.Controls.Add(this.mapHTMLLinksMinNumericUpDown);
            this.mapHTMLLinksGroupBox.Location = new System.Drawing.Point(6, 59);
            this.mapHTMLLinksGroupBox.Name = "mapHTMLLinksGroupBox";
            this.mapHTMLLinksGroupBox.Size = new System.Drawing.Size(171, 50);
            this.mapHTMLLinksGroupBox.TabIndex = 4;
            this.mapHTMLLinksGroupBox.TabStop = false;
            this.mapHTMLLinksGroupBox.Text = "Links/Page";
            // 
            // additionalLabel1
            // 
            this.additionalLabel1.AutoSize = true;
            this.additionalLabel1.Location = new System.Drawing.Point(81, 23);
            this.additionalLabel1.Name = "additionalLabel1";
            this.additionalLabel1.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel1.TabIndex = 13;
            this.additionalLabel1.Text = "-";
            // 
            // mapHTMLLinksMaxNumericUpDown
            // 
            this.mapHTMLLinksMaxNumericUpDown.Location = new System.Drawing.Point(101, 19);
            this.mapHTMLLinksMaxNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mapHTMLLinksMaxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mapHTMLLinksMaxNumericUpDown.Name = "mapHTMLLinksMaxNumericUpDown";
            this.mapHTMLLinksMaxNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.mapHTMLLinksMaxNumericUpDown.TabIndex = 12;
            this.mapHTMLLinksMaxNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // mapHTMLLinksMinNumericUpDown
            // 
            this.mapHTMLLinksMinNumericUpDown.Location = new System.Drawing.Point(6, 19);
            this.mapHTMLLinksMinNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mapHTMLLinksMinNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mapHTMLLinksMinNumericUpDown.Name = "mapHTMLLinksMinNumericUpDown";
            this.mapHTMLLinksMinNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.mapHTMLLinksMinNumericUpDown.TabIndex = 11;
            this.mapHTMLLinksMinNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // mapHTMLComboBox
            // 
            this.mapHTMLComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapHTMLComboBox.FormattingEnabled = true;
            this.mapHTMLComboBox.Items.AddRange(new object[] {
            "Single page",
            "Multi page"});
            this.mapHTMLComboBox.Location = new System.Drawing.Point(6, 6);
            this.mapHTMLComboBox.Name = "mapHTMLComboBox";
            this.mapHTMLComboBox.Size = new System.Drawing.Size(171, 21);
            this.mapHTMLComboBox.TabIndex = 1;
            // 
            // mapHTMLNameTextBox
            // 
            this.mapHTMLNameTextBox.Location = new System.Drawing.Point(47, 33);
            this.mapHTMLNameTextBox.Name = "mapHTMLNameTextBox";
            this.mapHTMLNameTextBox.Size = new System.Drawing.Size(129, 20);
            this.mapHTMLNameTextBox.TabIndex = 3;
            // 
            // mapHTMLNameLabel
            // 
            this.mapHTMLNameLabel.AutoSize = true;
            this.mapHTMLNameLabel.Location = new System.Drawing.Point(6, 36);
            this.mapHTMLNameLabel.Name = "mapHTMLNameLabel";
            this.mapHTMLNameLabel.Size = new System.Drawing.Size(35, 13);
            this.mapHTMLNameLabel.TabIndex = 2;
            this.mapHTMLNameLabel.Text = "Name";
            // 
            // mapXMLTabPage
            // 
            this.mapXMLTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.mapXMLTabPage.Controls.Add(this.mapXMLNameTextBox);
            this.mapXMLTabPage.Controls.Add(this.mapXMLNameLabel);
            this.mapXMLTabPage.Location = new System.Drawing.Point(4, 22);
            this.mapXMLTabPage.Name = "mapXMLTabPage";
            this.mapXMLTabPage.Size = new System.Drawing.Size(403, 101);
            this.mapXMLTabPage.TabIndex = 0;
            this.mapXMLTabPage.Text = "XML";
            // 
            // mapXMLNameTextBox
            // 
            this.mapXMLNameTextBox.Location = new System.Drawing.Point(44, 6);
            this.mapXMLNameTextBox.Name = "mapXMLNameTextBox";
            this.mapXMLNameTextBox.Size = new System.Drawing.Size(129, 20);
            this.mapXMLNameTextBox.TabIndex = 5;
            // 
            // mapXMLNameLabel
            // 
            this.mapXMLNameLabel.AutoSize = true;
            this.mapXMLNameLabel.Location = new System.Drawing.Point(3, 9);
            this.mapXMLNameLabel.Name = "mapXMLNameLabel";
            this.mapXMLNameLabel.Size = new System.Drawing.Size(35, 13);
            this.mapXMLNameLabel.TabIndex = 4;
            this.mapXMLNameLabel.Text = "Name";
            // 
            // mapComboBox
            // 
            this.mapComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapComboBox.FormattingEnabled = true;
            this.mapComboBox.Items.AddRange(new object[] {
            "None",
            "XML",
            "HTML",
            "XML+HTML",
            "Auto HTML",
            "XML+Auto HTML"});
            this.mapComboBox.Location = new System.Drawing.Point(7, 19);
            this.mapComboBox.Name = "mapComboBox";
            this.mapComboBox.Size = new System.Drawing.Size(121, 21);
            this.mapComboBox.TabIndex = 1;
            this.mapComboBox.SelectedIndexChanged += new System.EventHandler(this.mapComboBoxSelectedIndexChanged);
            // 
            // MapTabPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mapGroupBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MapTabPageControl";
            this.Size = new System.Drawing.Size(417, 178);
            this.mapGroupBox.ResumeLayout(false);
            this.mapTabControl.ResumeLayout(false);
            this.mapIncludeTabPage.ResumeLayout(false);
            this.mapHTMLTabPage.ResumeLayout(false);
            this.mapHTMLTabPage.PerformLayout();
            this.mapHTMLLinksGroupBox.ResumeLayout(false);
            this.mapHTMLLinksGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapHTMLLinksMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapHTMLLinksMinNumericUpDown)).EndInit();
            this.mapXMLTabPage.ResumeLayout(false);
            this.mapXMLTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox mapGroupBox;
        protected System.Windows.Forms.TabControl mapTabControl;
        protected System.Windows.Forms.TabPage mapIncludeTabPage;
        protected System.Windows.Forms.CheckedListBox mapIncludeCheckedListBox;
        protected System.Windows.Forms.TabPage mapHTMLTabPage;
        protected System.Windows.Forms.GroupBox mapHTMLLinksGroupBox;
        protected System.Windows.Forms.Label additionalLabel1;
        protected System.Windows.Forms.NumericUpDown mapHTMLLinksMaxNumericUpDown;
        protected System.Windows.Forms.NumericUpDown mapHTMLLinksMinNumericUpDown;
        protected System.Windows.Forms.ComboBox mapHTMLComboBox;
        protected System.Windows.Forms.TextBox mapHTMLNameTextBox;
        protected System.Windows.Forms.Label mapHTMLNameLabel;
        protected System.Windows.Forms.TabPage mapXMLTabPage;
        protected System.Windows.Forms.TextBox mapXMLNameTextBox;
        protected System.Windows.Forms.Label mapXMLNameLabel;
        protected System.Windows.Forms.ComboBox mapComboBox;
    }
}
