namespace Umax.Plugins.Text.ConceptualGraph.Custom
{
    partial class ConceptualGraphCustomTextControl
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
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.generalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.generalRightPanel = new System.Windows.Forms.Panel();
            this.generalPunctuationLabel = new System.Windows.Forms.Label();
            this.generalProbabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.generalPunctuationComboBox = new System.Windows.Forms.ComboBox();
            this.generalLeftPanel = new System.Windows.Forms.Panel();
            this.generalConstructionGroupBox = new System.Windows.Forms.GroupBox();
            this.additionalLabel17 = new System.Windows.Forms.Label();
            this.generalConstructionMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generalConstructionMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generalConstructionLabel = new System.Windows.Forms.Label();
            this.generalConstructionComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sentencesMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentencesLengthInfelicityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentencesLengthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertStepInfelicityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordsMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordsMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paragraphsMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paragraphsMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLengthMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLengthMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punctuationMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punctuationMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertStepNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentencesMinNumericUpDown)).BeginInit();
            this.generalGroupBox.SuspendLayout();
            this.generalTableLayoutPanel.SuspendLayout();
            this.generalRightPanel.SuspendLayout();
            this.generalLeftPanel.SuspendLayout();
            this.generalConstructionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalConstructionMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalConstructionMinNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.generalTableLayoutPanel);
            this.generalGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.generalGroupBox.Location = new System.Drawing.Point(0, 361);
            this.generalGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(460, 87);
            this.generalGroupBox.TabIndex = 31;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // generalTableLayoutPanel
            // 
            this.generalTableLayoutPanel.ColumnCount = 2;
            this.generalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalTableLayoutPanel.Controls.Add(this.generalRightPanel, 1, 0);
            this.generalTableLayoutPanel.Controls.Add(this.generalLeftPanel, 0, 0);
            this.generalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.generalTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.generalTableLayoutPanel.Name = "generalTableLayoutPanel";
            this.generalTableLayoutPanel.RowCount = 1;
            this.generalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalTableLayoutPanel.Size = new System.Drawing.Size(454, 68);
            this.generalTableLayoutPanel.TabIndex = 32;
            // 
            // generalRightPanel
            // 
            this.generalRightPanel.Controls.Add(this.generalPunctuationLabel);
            this.generalRightPanel.Controls.Add(this.generalProbabilityCheckBox);
            this.generalRightPanel.Controls.Add(this.generalPunctuationComboBox);
            this.generalRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalRightPanel.Location = new System.Drawing.Point(227, 0);
            this.generalRightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.generalRightPanel.Name = "generalRightPanel";
            this.generalRightPanel.Size = new System.Drawing.Size(227, 68);
            this.generalRightPanel.TabIndex = 1;
            // 
            // generalPunctuationLabel
            // 
            this.generalPunctuationLabel.AutoSize = true;
            this.generalPunctuationLabel.Location = new System.Drawing.Point(3, 12);
            this.generalPunctuationLabel.Name = "generalPunctuationLabel";
            this.generalPunctuationLabel.Size = new System.Drawing.Size(95, 13);
            this.generalPunctuationLabel.TabIndex = 34;
            this.generalPunctuationLabel.Text = "Punctuation marks";
            // 
            // generalProbabilityCheckBox
            // 
            this.generalProbabilityCheckBox.AutoSize = true;
            this.generalProbabilityCheckBox.Location = new System.Drawing.Point(6, 28);
            this.generalProbabilityCheckBox.Name = "generalProbabilityCheckBox";
            this.generalProbabilityCheckBox.Size = new System.Drawing.Size(74, 17);
            this.generalProbabilityCheckBox.TabIndex = 29;
            this.generalProbabilityCheckBox.Text = "Probability";
            this.generalProbabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // generalPunctuationComboBox
            // 
            this.generalPunctuationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalPunctuationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generalPunctuationComboBox.FormattingEnabled = true;
            this.generalPunctuationComboBox.Items.AddRange(new object[] {
            "Consider",
            "Don\'t consider"});
            this.generalPunctuationComboBox.Location = new System.Drawing.Point(109, 9);
            this.generalPunctuationComboBox.Name = "generalPunctuationComboBox";
            this.generalPunctuationComboBox.Size = new System.Drawing.Size(118, 21);
            this.generalPunctuationComboBox.TabIndex = 33;
            // 
            // generalLeftPanel
            // 
            this.generalLeftPanel.Controls.Add(this.generalConstructionGroupBox);
            this.generalLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.generalLeftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.generalLeftPanel.Name = "generalLeftPanel";
            this.generalLeftPanel.Size = new System.Drawing.Size(227, 68);
            this.generalLeftPanel.TabIndex = 0;
            // 
            // generalConstructionGroupBox
            // 
            this.generalConstructionGroupBox.Controls.Add(this.additionalLabel17);
            this.generalConstructionGroupBox.Controls.Add(this.generalConstructionMaxNumericUpDown);
            this.generalConstructionGroupBox.Controls.Add(this.generalConstructionMinNumericUpDown);
            this.generalConstructionGroupBox.Controls.Add(this.generalConstructionLabel);
            this.generalConstructionGroupBox.Controls.Add(this.generalConstructionComboBox);
            this.generalConstructionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalConstructionGroupBox.Location = new System.Drawing.Point(0, 0);
            this.generalConstructionGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.generalConstructionGroupBox.Name = "generalConstructionGroupBox";
            this.generalConstructionGroupBox.Size = new System.Drawing.Size(227, 68);
            this.generalConstructionGroupBox.TabIndex = 35;
            this.generalConstructionGroupBox.TabStop = false;
            this.generalConstructionGroupBox.Text = "Construction";
            // 
            // additionalLabel17
            // 
            this.additionalLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalLabel17.AutoSize = true;
            this.additionalLabel17.Location = new System.Drawing.Point(143, 49);
            this.additionalLabel17.Name = "additionalLabel17";
            this.additionalLabel17.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel17.TabIndex = 31;
            this.additionalLabel17.Text = "-";
            // 
            // generalConstructionMaxNumericUpDown
            // 
            this.generalConstructionMaxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generalConstructionMaxNumericUpDown.Location = new System.Drawing.Point(159, 47);
            this.generalConstructionMaxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.generalConstructionMaxNumericUpDown.Name = "generalConstructionMaxNumericUpDown";
            this.generalConstructionMaxNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.generalConstructionMaxNumericUpDown.TabIndex = 30;
            this.generalConstructionMaxNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // generalConstructionMinNumericUpDown
            // 
            this.generalConstructionMinNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generalConstructionMinNumericUpDown.Location = new System.Drawing.Point(72, 47);
            this.generalConstructionMinNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.generalConstructionMinNumericUpDown.Name = "generalConstructionMinNumericUpDown";
            this.generalConstructionMinNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.generalConstructionMinNumericUpDown.TabIndex = 29;
            this.generalConstructionMinNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // generalConstructionLabel
            // 
            this.generalConstructionLabel.AutoSize = true;
            this.generalConstructionLabel.Location = new System.Drawing.Point(6, 49);
            this.generalConstructionLabel.Name = "generalConstructionLabel";
            this.generalConstructionLabel.Size = new System.Drawing.Size(38, 13);
            this.generalConstructionLabel.TabIndex = 28;
            this.generalConstructionLabel.Text = "Words";
            // 
            // generalConstructionComboBox
            // 
            this.generalConstructionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalConstructionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generalConstructionComboBox.FormattingEnabled = true;
            this.generalConstructionComboBox.Items.AddRange(new object[] {
            "Short",
            "Long"});
            this.generalConstructionComboBox.Location = new System.Drawing.Point(4, 20);
            this.generalConstructionComboBox.Name = "generalConstructionComboBox";
            this.generalConstructionComboBox.Size = new System.Drawing.Size(220, 21);
            this.generalConstructionComboBox.TabIndex = 26;
            this.generalConstructionComboBox.SelectedIndexChanged += new System.EventHandler(this.generalConstructionComboBox_SelectedIndexChanged);
            // 
            // ConceptualGraphCustomTextControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generalGroupBox);
            this.Name = "ConceptualGraphCustomTextControl";
            this.Size = new System.Drawing.Size(460, 453);
            this.Controls.SetChildIndex(this.generalGroupBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.sentencesMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentencesLengthInfelicityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentencesLengthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertStepInfelicityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordsMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordsMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paragraphsMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paragraphsMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLengthMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLengthMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punctuationMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punctuationMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertStepNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sentencesMinNumericUpDown)).EndInit();
            this.generalGroupBox.ResumeLayout(false);
            this.generalTableLayoutPanel.ResumeLayout(false);
            this.generalRightPanel.ResumeLayout(false);
            this.generalRightPanel.PerformLayout();
            this.generalLeftPanel.ResumeLayout(false);
            this.generalConstructionGroupBox.ResumeLayout(false);
            this.generalConstructionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalConstructionMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalConstructionMinNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.Label generalPunctuationLabel;
        private System.Windows.Forms.GroupBox generalConstructionGroupBox;
        private System.Windows.Forms.Label additionalLabel17;
        protected System.Windows.Forms.NumericUpDown generalConstructionMaxNumericUpDown;
        protected System.Windows.Forms.NumericUpDown generalConstructionMinNumericUpDown;
        private System.Windows.Forms.Label generalConstructionLabel;
        protected System.Windows.Forms.ComboBox generalConstructionComboBox;
        protected System.Windows.Forms.CheckBox generalProbabilityCheckBox;
        protected System.Windows.Forms.ComboBox generalPunctuationComboBox;
        private System.Windows.Forms.TableLayoutPanel generalTableLayoutPanel;
        private System.Windows.Forms.Panel generalLeftPanel;
        private System.Windows.Forms.Panel generalRightPanel;


    }
}
