namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    partial class OtherTabPageControl
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
            this.robotsGroupBox = new System.Windows.Forms.GroupBox();
            this.robotsTextBox = new System.Windows.Forms.TextBox();
            this.robotsComboBox = new System.Windows.Forms.ComboBox();
            this.RSSGroupBox = new System.Windows.Forms.GroupBox();
            this.RSSContentComboBox = new System.Windows.Forms.ComboBox();
            this.RSSContentLabel = new System.Windows.Forms.Label();
            this.RSSComboBox = new System.Windows.Forms.ComboBox();
            this.RSSEntriesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.robotsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.robotsGroupBox.SuspendLayout();
            this.RSSGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RSSEntriesNumericUpDown)).BeginInit();
            this.robotsSplitContainer.Panel1.SuspendLayout();
            this.robotsSplitContainer.Panel2.SuspendLayout();
            this.robotsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // robotsGroupBox
            // 
            this.robotsGroupBox.Controls.Add(this.robotsSplitContainer);
            this.robotsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.robotsGroupBox.Location = new System.Drawing.Point(0, 49);
            this.robotsGroupBox.Name = "robotsGroupBox";
            this.robotsGroupBox.Size = new System.Drawing.Size(686, 371);
            this.robotsGroupBox.TabIndex = 1;
            this.robotsGroupBox.TabStop = false;
            this.robotsGroupBox.Text = "robots.txt";
            // 
            // robotsTextBox
            // 
            this.robotsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.robotsTextBox.Enabled = false;
            this.robotsTextBox.Location = new System.Drawing.Point(0, 0);
            this.robotsTextBox.Multiline = true;
            this.robotsTextBox.Name = "robotsTextBox";
            this.robotsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.robotsTextBox.Size = new System.Drawing.Size(680, 323);
            this.robotsTextBox.TabIndex = 3;
            // 
            // robotsComboBox
            // 
            this.robotsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.robotsComboBox.FormattingEnabled = true;
            this.robotsComboBox.Items.AddRange(new object[] {
            "None",
            "Auto",
            "Manual"});
            this.robotsComboBox.Location = new System.Drawing.Point(3, 3);
            this.robotsComboBox.Name = "robotsComboBox";
            this.robotsComboBox.Size = new System.Drawing.Size(121, 21);
            this.robotsComboBox.TabIndex = 2;
            this.robotsComboBox.SelectedIndexChanged += new System.EventHandler(this.robotsComboBoxSelectedIndexChanged);
            // 
            // RSSGroupBox
            // 
            this.RSSGroupBox.Controls.Add(this.RSSContentComboBox);
            this.RSSGroupBox.Controls.Add(this.RSSContentLabel);
            this.RSSGroupBox.Controls.Add(this.RSSComboBox);
            this.RSSGroupBox.Controls.Add(this.RSSEntriesNumericUpDown);
            this.RSSGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RSSGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RSSGroupBox.Name = "RSSGroupBox";
            this.RSSGroupBox.Size = new System.Drawing.Size(686, 49);
            this.RSSGroupBox.TabIndex = 0;
            this.RSSGroupBox.TabStop = false;
            this.RSSGroupBox.Text = "RSS";
            // 
            // RSSContentComboBox
            // 
            this.RSSContentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RSSContentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RSSContentComboBox.Enabled = false;
            this.RSSContentComboBox.FormattingEnabled = true;
            this.RSSContentComboBox.Items.AddRange(new object[] {
            "Generate",
            "Page content"});
            this.RSSContentComboBox.Location = new System.Drawing.Point(488, 19);
            this.RSSContentComboBox.Name = "RSSContentComboBox";
            this.RSSContentComboBox.Size = new System.Drawing.Size(121, 21);
            this.RSSContentComboBox.TabIndex = 14;
            // 
            // RSSContentLabel
            // 
            this.RSSContentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RSSContentLabel.AutoSize = true;
            this.RSSContentLabel.Location = new System.Drawing.Point(438, 22);
            this.RSSContentLabel.Name = "RSSContentLabel";
            this.RSSContentLabel.Size = new System.Drawing.Size(44, 13);
            this.RSSContentLabel.TabIndex = 13;
            this.RSSContentLabel.Text = "Content";
            // 
            // RSSComboBox
            // 
            this.RSSComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RSSComboBox.FormattingEnabled = true;
            this.RSSComboBox.Items.AddRange(new object[] {
            "None",
            "All",
            "Limited"});
            this.RSSComboBox.Location = new System.Drawing.Point(6, 19);
            this.RSSComboBox.Name = "RSSComboBox";
            this.RSSComboBox.Size = new System.Drawing.Size(121, 21);
            this.RSSComboBox.TabIndex = 12;
            this.RSSComboBox.SelectedIndexChanged += new System.EventHandler(this.RSSComboBoxSelectedIndexChanged);
            // 
            // RSSEntriesNumericUpDown
            // 
            this.RSSEntriesNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RSSEntriesNumericUpDown.Enabled = false;
            this.RSSEntriesNumericUpDown.Location = new System.Drawing.Point(615, 20);
            this.RSSEntriesNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RSSEntriesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RSSEntriesNumericUpDown.Name = "RSSEntriesNumericUpDown";
            this.RSSEntriesNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.RSSEntriesNumericUpDown.TabIndex = 9;
            this.RSSEntriesNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // robotsSplitContainer
            // 
            this.robotsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.robotsSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.robotsSplitContainer.IsSplitterFixed = true;
            this.robotsSplitContainer.Location = new System.Drawing.Point(3, 16);
            this.robotsSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.robotsSplitContainer.Name = "robotsSplitContainer";
            this.robotsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // robotsSplitContainer.Panel1
            // 
            this.robotsSplitContainer.Panel1.Controls.Add(this.robotsComboBox);
            // 
            // robotsSplitContainer.Panel2
            // 
            this.robotsSplitContainer.Panel2.Controls.Add(this.robotsTextBox);
            this.robotsSplitContainer.Size = new System.Drawing.Size(680, 352);
            this.robotsSplitContainer.SplitterDistance = 25;
            this.robotsSplitContainer.TabIndex = 4;
            // 
            // OtherTabPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.robotsGroupBox);
            this.Controls.Add(this.RSSGroupBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OtherTabPageControl";
            this.Size = new System.Drawing.Size(686, 420);
            this.robotsGroupBox.ResumeLayout(false);
            this.RSSGroupBox.ResumeLayout(false);
            this.RSSGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RSSEntriesNumericUpDown)).EndInit();
            this.robotsSplitContainer.Panel1.ResumeLayout(false);
            this.robotsSplitContainer.Panel2.ResumeLayout(false);
            this.robotsSplitContainer.Panel2.PerformLayout();
            this.robotsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox robotsGroupBox;
        protected System.Windows.Forms.TextBox robotsTextBox;
        protected System.Windows.Forms.ComboBox robotsComboBox;
        protected System.Windows.Forms.GroupBox RSSGroupBox;
        protected System.Windows.Forms.ComboBox RSSContentComboBox;
        protected System.Windows.Forms.Label RSSContentLabel;
        protected System.Windows.Forms.ComboBox RSSComboBox;
        protected System.Windows.Forms.NumericUpDown RSSEntriesNumericUpDown;
        protected System.Windows.Forms.SplitContainer robotsSplitContainer;
    }
}
