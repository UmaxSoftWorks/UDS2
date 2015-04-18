namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    partial class TextTabPageControl
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
            this.components = new System.ComponentModel.Container();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.makersGroupBox = new System.Windows.Forms.GroupBox();
            this.makersTreeView = new System.Windows.Forms.TreeView();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.makerPanel = new System.Windows.Forms.Panel();
            this.linksTextGroupBox = new System.Windows.Forms.GroupBox();
            this.linksNumberMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.additionalLabel1 = new System.Windows.Forms.Label();
            this.linksNumberMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.linksNumberLabel = new System.Windows.Forms.Label();
            this.linksWordsLabel = new System.Windows.Forms.Label();
            this.linksLengthLabel = new System.Windows.Forms.Label();
            this.linksLengthMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.additionalLabel2 = new System.Windows.Forms.Label();
            this.linksLengthMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.linksInternalLinksLengthLabel = new System.Windows.Forms.Label();
            this.linksСomboBox = new System.Windows.Forms.ComboBox();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.makersGroupBox.SuspendLayout();
            this.linksTextGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linksNumberMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksNumberMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksLengthMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksLengthMinNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.makersGroupBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.makerPanel);
            this.mainSplitContainer.Panel2.Controls.Add(this.linksTextGroupBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(686, 420);
            this.mainSplitContainer.SplitterDistance = 196;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // makersGroupBox
            // 
            this.makersGroupBox.Controls.Add(this.makersTreeView);
            this.makersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makersGroupBox.Location = new System.Drawing.Point(0, 0);
            this.makersGroupBox.Name = "makersGroupBox";
            this.makersGroupBox.Size = new System.Drawing.Size(196, 420);
            this.makersGroupBox.TabIndex = 1;
            this.makersGroupBox.TabStop = false;
            this.makersGroupBox.Text = "Text Makers";
            // 
            // makersTreeView
            // 
            this.makersTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makersTreeView.ImageIndex = 0;
            this.makersTreeView.ImageList = this.mainImageList;
            this.makersTreeView.Location = new System.Drawing.Point(3, 16);
            this.makersTreeView.Name = "makersTreeView";
            this.makersTreeView.SelectedImageIndex = 0;
            this.makersTreeView.Size = new System.Drawing.Size(190, 401);
            this.makersTreeView.TabIndex = 0;
            this.makersTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.makersTreeViewAfterSelect);
            // 
            // mainImageList
            // 
            this.mainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // makerPanel
            // 
            this.makerPanel.AutoScroll = true;
            this.makerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makerPanel.Location = new System.Drawing.Point(0, 0);
            this.makerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.makerPanel.Name = "makerPanel";
            this.makerPanel.Size = new System.Drawing.Size(486, 349);
            this.makerPanel.TabIndex = 20;
            // 
            // linksTextGroupBox
            // 
            this.linksTextGroupBox.Controls.Add(this.linksNumberMaxNumericUpDown);
            this.linksTextGroupBox.Controls.Add(this.additionalLabel1);
            this.linksTextGroupBox.Controls.Add(this.linksNumberMinNumericUpDown);
            this.linksTextGroupBox.Controls.Add(this.linksNumberLabel);
            this.linksTextGroupBox.Controls.Add(this.linksWordsLabel);
            this.linksTextGroupBox.Controls.Add(this.linksLengthLabel);
            this.linksTextGroupBox.Controls.Add(this.linksLengthMaxNumericUpDown);
            this.linksTextGroupBox.Controls.Add(this.additionalLabel2);
            this.linksTextGroupBox.Controls.Add(this.linksLengthMinNumericUpDown);
            this.linksTextGroupBox.Controls.Add(this.linksInternalLinksLengthLabel);
            this.linksTextGroupBox.Controls.Add(this.linksСomboBox);
            this.linksTextGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linksTextGroupBox.Location = new System.Drawing.Point(0, 349);
            this.linksTextGroupBox.Name = "linksTextGroupBox";
            this.linksTextGroupBox.Size = new System.Drawing.Size(486, 71);
            this.linksTextGroupBox.TabIndex = 21;
            this.linksTextGroupBox.TabStop = false;
            this.linksTextGroupBox.Text = "Links";
            // 
            // linksNumberMaxNumericUpDown
            // 
            this.linksNumberMaxNumericUpDown.Enabled = false;
            this.linksNumberMaxNumericUpDown.Location = new System.Drawing.Point(128, 46);
            this.linksNumberMaxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.linksNumberMaxNumericUpDown.Name = "linksNumberMaxNumericUpDown";
            this.linksNumberMaxNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.linksNumberMaxNumericUpDown.TabIndex = 13;
            this.linksNumberMaxNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // additionalLabel1
            // 
            this.additionalLabel1.AutoSize = true;
            this.additionalLabel1.Location = new System.Drawing.Point(112, 48);
            this.additionalLabel1.Name = "additionalLabel1";
            this.additionalLabel1.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel1.TabIndex = 12;
            this.additionalLabel1.Text = "-";
            // 
            // linksNumberMinNumericUpDown
            // 
            this.linksNumberMinNumericUpDown.Enabled = false;
            this.linksNumberMinNumericUpDown.Location = new System.Drawing.Point(56, 46);
            this.linksNumberMinNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.linksNumberMinNumericUpDown.Name = "linksNumberMinNumericUpDown";
            this.linksNumberMinNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.linksNumberMinNumericUpDown.TabIndex = 11;
            this.linksNumberMinNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // linksNumberLabel
            // 
            this.linksNumberLabel.AutoSize = true;
            this.linksNumberLabel.Location = new System.Drawing.Point(6, 48);
            this.linksNumberLabel.Name = "linksNumberLabel";
            this.linksNumberLabel.Size = new System.Drawing.Size(44, 13);
            this.linksNumberLabel.TabIndex = 10;
            this.linksNumberLabel.Text = "Number";
            // 
            // linksWordsLabel
            // 
            this.linksWordsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linksWordsLabel.AutoSize = true;
            this.linksWordsLabel.Location = new System.Drawing.Point(446, 51);
            this.linksWordsLabel.Name = "linksWordsLabel";
            this.linksWordsLabel.Size = new System.Drawing.Size(35, 13);
            this.linksWordsLabel.TabIndex = 9;
            this.linksWordsLabel.Text = "words";
            // 
            // linksLengthLabel
            // 
            this.linksLengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linksLengthLabel.AutoSize = true;
            this.linksLengthLabel.Location = new System.Drawing.Point(272, 51);
            this.linksLengthLabel.Name = "linksLengthLabel";
            this.linksLengthLabel.Size = new System.Drawing.Size(40, 13);
            this.linksLengthLabel.TabIndex = 8;
            this.linksLengthLabel.Text = "Length";
            // 
            // linksLengthMaxNumericUpDown
            // 
            this.linksLengthMaxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linksLengthMaxNumericUpDown.Enabled = false;
            this.linksLengthMaxNumericUpDown.Location = new System.Drawing.Point(390, 48);
            this.linksLengthMaxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.linksLengthMaxNumericUpDown.Name = "linksLengthMaxNumericUpDown";
            this.linksLengthMaxNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.linksLengthMaxNumericUpDown.TabIndex = 7;
            this.linksLengthMaxNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // additionalLabel2
            // 
            this.additionalLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalLabel2.AutoSize = true;
            this.additionalLabel2.Location = new System.Drawing.Point(374, 50);
            this.additionalLabel2.Name = "additionalLabel2";
            this.additionalLabel2.Size = new System.Drawing.Size(10, 13);
            this.additionalLabel2.TabIndex = 6;
            this.additionalLabel2.Text = "-";
            // 
            // linksLengthMinNumericUpDown
            // 
            this.linksLengthMinNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linksLengthMinNumericUpDown.Enabled = false;
            this.linksLengthMinNumericUpDown.Location = new System.Drawing.Point(318, 48);
            this.linksLengthMinNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.linksLengthMinNumericUpDown.Name = "linksLengthMinNumericUpDown";
            this.linksLengthMinNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.linksLengthMinNumericUpDown.TabIndex = 5;
            this.linksLengthMinNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // linksInternalLinksLengthLabel
            // 
            this.linksInternalLinksLengthLabel.AutoSize = true;
            this.linksInternalLinksLengthLabel.Location = new System.Drawing.Point(6, 46);
            this.linksInternalLinksLengthLabel.Name = "linksInternalLinksLengthLabel";
            this.linksInternalLinksLengthLabel.Size = new System.Drawing.Size(0, 13);
            this.linksInternalLinksLengthLabel.TabIndex = 3;
            // 
            // linksСomboBox
            // 
            this.linksСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.linksСomboBox.FormattingEnabled = true;
            this.linksСomboBox.Items.AddRange(new object[] {
            "None",
            "Keywords",
            "Text",
            "Keywords+Text"});
            this.linksСomboBox.Location = new System.Drawing.Point(9, 19);
            this.linksСomboBox.Name = "linksСomboBox";
            this.linksСomboBox.Size = new System.Drawing.Size(169, 21);
            this.linksСomboBox.TabIndex = 2;
            this.linksСomboBox.SelectedIndexChanged += new System.EventHandler(this.linksСomboBoxSelectedIndexChanged);
            // 
            // TextTabPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TextTabPageControl";
            this.Size = new System.Drawing.Size(686, 420);
            this.Load += new System.EventHandler(this.TextTabPageControlLoad);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.makersGroupBox.ResumeLayout(false);
            this.linksTextGroupBox.ResumeLayout(false);
            this.linksTextGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linksNumberMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksNumberMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksLengthMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksLengthMinNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer mainSplitContainer;
        protected System.Windows.Forms.GroupBox makersGroupBox;
        protected System.Windows.Forms.TreeView makersTreeView;
        protected System.Windows.Forms.Panel makerPanel;
        protected System.Windows.Forms.GroupBox linksTextGroupBox;
        protected System.Windows.Forms.NumericUpDown linksNumberMaxNumericUpDown;
        protected System.Windows.Forms.Label additionalLabel1;
        protected System.Windows.Forms.NumericUpDown linksNumberMinNumericUpDown;
        protected System.Windows.Forms.Label linksNumberLabel;
        protected System.Windows.Forms.Label linksWordsLabel;
        protected System.Windows.Forms.Label linksLengthLabel;
        protected System.Windows.Forms.NumericUpDown linksLengthMaxNumericUpDown;
        protected System.Windows.Forms.Label additionalLabel2;
        protected System.Windows.Forms.NumericUpDown linksLengthMinNumericUpDown;
        protected System.Windows.Forms.Label linksInternalLinksLengthLabel;
        protected System.Windows.Forms.ComboBox linksСomboBox;
        protected System.Windows.Forms.ImageList mainImageList;

    }
}
