namespace Umax.Plugins.Text.Mix
{
    partial class MixTextControl
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
            this.generalPunctuationLabel = new System.Windows.Forms.Label();
            this.generalPunctuationComboBox = new System.Windows.Forms.ComboBox();
            this.generalRadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generalRadiusLabel = new System.Windows.Forms.Label();
            this.generalComboBox = new System.Windows.Forms.ComboBox();
            this.generalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.generalLeftPanel = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.generalRadiusNumericUpDown)).BeginInit();
            this.generalTableLayoutPanel.SuspendLayout();
            this.generalLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.generalTableLayoutPanel);
            this.generalGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.generalGroupBox.Location = new System.Drawing.Point(0, 361);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(460, 99);
            this.generalGroupBox.TabIndex = 28;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // generalPunctuationLabel
            // 
            this.generalPunctuationLabel.AutoSize = true;
            this.generalPunctuationLabel.Location = new System.Drawing.Point(3, 33);
            this.generalPunctuationLabel.Name = "generalPunctuationLabel";
            this.generalPunctuationLabel.Size = new System.Drawing.Size(95, 13);
            this.generalPunctuationLabel.TabIndex = 32;
            this.generalPunctuationLabel.Text = "Punctuation marks";
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
            this.generalPunctuationComboBox.Location = new System.Drawing.Point(106, 30);
            this.generalPunctuationComboBox.Name = "generalPunctuationComboBox";
            this.generalPunctuationComboBox.Size = new System.Drawing.Size(118, 21);
            this.generalPunctuationComboBox.TabIndex = 27;
            // 
            // generalRadiusNumericUpDown
            // 
            this.generalRadiusNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generalRadiusNumericUpDown.Location = new System.Drawing.Point(159, 57);
            this.generalRadiusNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.generalRadiusNumericUpDown.Name = "generalRadiusNumericUpDown";
            this.generalRadiusNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.generalRadiusNumericUpDown.TabIndex = 31;
            this.generalRadiusNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // generalRadiusLabel
            // 
            this.generalRadiusLabel.AutoSize = true;
            this.generalRadiusLabel.Location = new System.Drawing.Point(3, 59);
            this.generalRadiusLabel.Name = "generalRadiusLabel";
            this.generalRadiusLabel.Size = new System.Drawing.Size(40, 13);
            this.generalRadiusLabel.TabIndex = 30;
            this.generalRadiusLabel.Text = "Radius";
            // 
            // generalComboBox
            // 
            this.generalComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generalComboBox.FormattingEnabled = true;
            this.generalComboBox.Items.AddRange(new object[] {
            "Words",
            "Parts of sentences",
            "Sentences",
            "Lines"});
            this.generalComboBox.Location = new System.Drawing.Point(3, 3);
            this.generalComboBox.Name = "generalComboBox";
            this.generalComboBox.Size = new System.Drawing.Size(221, 21);
            this.generalComboBox.TabIndex = 1;
            // 
            // generalTableLayoutPanel
            // 
            this.generalTableLayoutPanel.ColumnCount = 2;
            this.generalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalTableLayoutPanel.Controls.Add(this.generalLeftPanel, 0, 0);
            this.generalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.generalTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.generalTableLayoutPanel.Name = "generalTableLayoutPanel";
            this.generalTableLayoutPanel.RowCount = 1;
            this.generalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalTableLayoutPanel.Size = new System.Drawing.Size(454, 80);
            this.generalTableLayoutPanel.TabIndex = 33;
            // 
            // generalLeftPanel
            // 
            this.generalLeftPanel.Controls.Add(this.generalComboBox);
            this.generalLeftPanel.Controls.Add(this.generalPunctuationLabel);
            this.generalLeftPanel.Controls.Add(this.generalRadiusLabel);
            this.generalLeftPanel.Controls.Add(this.generalPunctuationComboBox);
            this.generalLeftPanel.Controls.Add(this.generalRadiusNumericUpDown);
            this.generalLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.generalLeftPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.generalLeftPanel.Name = "generalLeftPanel";
            this.generalLeftPanel.Size = new System.Drawing.Size(227, 80);
            this.generalLeftPanel.TabIndex = 0;
            // 
            // MixTextControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generalGroupBox);
            this.Name = "MixTextControl";
            this.Size = new System.Drawing.Size(460, 462);
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
            ((System.ComponentModel.ISupportInitialize)(this.generalRadiusNumericUpDown)).EndInit();
            this.generalTableLayoutPanel.ResumeLayout(false);
            this.generalLeftPanel.ResumeLayout(false);
            this.generalLeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.NumericUpDown generalRadiusNumericUpDown;
        private System.Windows.Forms.Label generalRadiusLabel;
        private System.Windows.Forms.ComboBox generalPunctuationComboBox;
        private System.Windows.Forms.ComboBox generalComboBox;
        private System.Windows.Forms.Label generalPunctuationLabel;
        private System.Windows.Forms.TableLayoutPanel generalTableLayoutPanel;
        private System.Windows.Forms.Panel generalLeftPanel;

    }
}
