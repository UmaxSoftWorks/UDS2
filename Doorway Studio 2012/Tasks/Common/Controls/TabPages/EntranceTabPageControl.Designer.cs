namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    partial class EntranceTabPageControl
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
            this.codeGroupBox = new System.Windows.Forms.GroupBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.generalURLLabel = new System.Windows.Forms.Label();
            this.insertTypeComboBox = new System.Windows.Forms.ComboBox();
            this.generalInsertTypeLabel = new System.Windows.Forms.Label();
            this.encryptCheckBox = new System.Windows.Forms.CheckBox();
            this.generalURLTextBox = new System.Windows.Forms.TextBox();
            this.acceptorAdressComboBox = new System.Windows.Forms.ComboBox();
            this.generalAcceptorAdressLabel = new System.Windows.Forms.Label();
            this.generalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.generalTypeLabel = new System.Windows.Forms.Label();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.codeGroupBox.SuspendLayout();
            this.generalGroupBox.SuspendLayout();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeGroupBox
            // 
            this.codeGroupBox.Controls.Add(this.codeTextBox);
            this.codeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.codeGroupBox.Name = "codeGroupBox";
            this.codeGroupBox.Size = new System.Drawing.Size(686, 316);
            this.codeGroupBox.TabIndex = 3;
            this.codeGroupBox.TabStop = false;
            this.codeGroupBox.Text = "HTML-code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeTextBox.Location = new System.Drawing.Point(3, 16);
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.codeTextBox.Size = new System.Drawing.Size(680, 297);
            this.codeTextBox.TabIndex = 0;
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.generalURLLabel);
            this.generalGroupBox.Controls.Add(this.insertTypeComboBox);
            this.generalGroupBox.Controls.Add(this.generalInsertTypeLabel);
            this.generalGroupBox.Controls.Add(this.encryptCheckBox);
            this.generalGroupBox.Controls.Add(this.generalURLTextBox);
            this.generalGroupBox.Controls.Add(this.acceptorAdressComboBox);
            this.generalGroupBox.Controls.Add(this.generalAcceptorAdressLabel);
            this.generalGroupBox.Controls.Add(this.generalTypeComboBox);
            this.generalGroupBox.Controls.Add(this.generalTypeLabel);
            this.generalGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalGroupBox.Location = new System.Drawing.Point(0, 0);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(686, 100);
            this.generalGroupBox.TabIndex = 2;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // generalURLLabel
            // 
            this.generalURLLabel.AutoSize = true;
            this.generalURLLabel.Location = new System.Drawing.Point(6, 77);
            this.generalURLLabel.Name = "generalURLLabel";
            this.generalURLLabel.Size = new System.Drawing.Size(29, 13);
            this.generalURLLabel.TabIndex = 7;
            this.generalURLLabel.Text = "URL";
            // 
            // insertTypeComboBox
            // 
            this.insertTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.insertTypeComboBox.FormattingEnabled = true;
            this.insertTypeComboBox.Items.AddRange(new object[] {
            "Insert",
            "Insert via document.write",
            "Insert as external .js file"});
            this.insertTypeComboBox.Location = new System.Drawing.Point(96, 46);
            this.insertTypeComboBox.Name = "insertTypeComboBox";
            this.insertTypeComboBox.Size = new System.Drawing.Size(210, 21);
            this.insertTypeComboBox.TabIndex = 6;
            this.insertTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.generalComboBoxSelectedIndexChanged);
            // 
            // generalInsertTypeLabel
            // 
            this.generalInsertTypeLabel.AutoSize = true;
            this.generalInsertTypeLabel.Location = new System.Drawing.Point(6, 49);
            this.generalInsertTypeLabel.Name = "generalInsertTypeLabel";
            this.generalInsertTypeLabel.Size = new System.Drawing.Size(33, 13);
            this.generalInsertTypeLabel.TabIndex = 5;
            this.generalInsertTypeLabel.Text = "Insert";
            // 
            // encryptCheckBox
            // 
            this.encryptCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptCheckBox.AutoSize = true;
            this.encryptCheckBox.Location = new System.Drawing.Point(559, 21);
            this.encryptCheckBox.Name = "encryptCheckBox";
            this.encryptCheckBox.Size = new System.Drawing.Size(62, 17);
            this.encryptCheckBox.TabIndex = 0;
            this.encryptCheckBox.Text = "Encrypt";
            this.encryptCheckBox.UseVisualStyleBackColor = true;
            // 
            // generalURLTextBox
            // 
            this.generalURLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalURLTextBox.Location = new System.Drawing.Point(96, 74);
            this.generalURLTextBox.Name = "generalURLTextBox";
            this.generalURLTextBox.Size = new System.Drawing.Size(584, 20);
            this.generalURLTextBox.TabIndex = 4;
            this.generalURLTextBox.TextChanged += new System.EventHandler(this.generalURLTextBoxTextChanged);
            // 
            // acceptorAdressComboBox
            // 
            this.acceptorAdressComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptorAdressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acceptorAdressComboBox.FormattingEnabled = true;
            this.acceptorAdressComboBox.Items.AddRange(new object[] {
            "Static",
            "Dynamic"});
            this.acceptorAdressComboBox.Location = new System.Drawing.Point(559, 46);
            this.acceptorAdressComboBox.Name = "acceptorAdressComboBox";
            this.acceptorAdressComboBox.Size = new System.Drawing.Size(121, 21);
            this.acceptorAdressComboBox.TabIndex = 3;
            this.acceptorAdressComboBox.SelectedIndexChanged += new System.EventHandler(this.generalComboBoxSelectedIndexChanged);
            // 
            // generalAcceptorAdressLabel
            // 
            this.generalAcceptorAdressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generalAcceptorAdressLabel.AutoSize = true;
            this.generalAcceptorAdressLabel.Location = new System.Drawing.Point(501, 49);
            this.generalAcceptorAdressLabel.Name = "generalAcceptorAdressLabel";
            this.generalAcceptorAdressLabel.Size = new System.Drawing.Size(52, 13);
            this.generalAcceptorAdressLabel.TabIndex = 2;
            this.generalAcceptorAdressLabel.Text = "URL type";
            // 
            // generalTypeComboBox
            // 
            this.generalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generalTypeComboBox.FormattingEnabled = true;
            this.generalTypeComboBox.Items.AddRange(new object[] {
            "Redirect",
            "Frame",
            "Custom"});
            this.generalTypeComboBox.Location = new System.Drawing.Point(96, 19);
            this.generalTypeComboBox.Name = "generalTypeComboBox";
            this.generalTypeComboBox.Size = new System.Drawing.Size(210, 21);
            this.generalTypeComboBox.TabIndex = 1;
            this.generalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.generalComboBoxSelectedIndexChanged);
            // 
            // generalTypeLabel
            // 
            this.generalTypeLabel.AutoSize = true;
            this.generalTypeLabel.Location = new System.Drawing.Point(6, 22);
            this.generalTypeLabel.Name = "generalTypeLabel";
            this.generalTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.generalTypeLabel.TabIndex = 0;
            this.generalTypeLabel.Text = "Type";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.generalGroupBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.codeGroupBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(686, 420);
            this.mainSplitContainer.SplitterDistance = 100;
            this.mainSplitContainer.TabIndex = 4;
            // 
            // EntranceTabPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EntranceTabPageControl";
            this.Size = new System.Drawing.Size(686, 420);
            this.codeGroupBox.ResumeLayout(false);
            this.codeGroupBox.PerformLayout();
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox codeGroupBox;
        protected System.Windows.Forms.TextBox codeTextBox;
        protected System.Windows.Forms.GroupBox generalGroupBox;
        protected System.Windows.Forms.Label generalURLLabel;
        protected System.Windows.Forms.ComboBox insertTypeComboBox;
        protected System.Windows.Forms.Label generalInsertTypeLabel;
        protected System.Windows.Forms.CheckBox encryptCheckBox;
        protected System.Windows.Forms.TextBox generalURLTextBox;
        protected System.Windows.Forms.ComboBox acceptorAdressComboBox;
        protected System.Windows.Forms.Label generalAcceptorAdressLabel;
        protected System.Windows.Forms.ComboBox generalTypeComboBox;
        protected System.Windows.Forms.Label generalTypeLabel;
        protected System.Windows.Forms.SplitContainer mainSplitContainer;
    }
}
