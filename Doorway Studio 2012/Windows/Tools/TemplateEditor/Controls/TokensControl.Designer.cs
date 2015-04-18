namespace Umax.Windows.Tools.TemplateEditor.Controls
{
    partial class TokensControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokensControl));
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainListBox = new Umax.UI.XPListBox.XPListBox();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchPictureBox);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(200, 50);
            this.searchPanel.TabIndex = 0;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(3, 6);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(3, 22);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(168, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBoxTextChanged);
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPictureBox.BackgroundImage = Resources.Resources.Delete;
            this.searchPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchPictureBox.Location = new System.Drawing.Point(177, 22);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(20, 20);
            this.searchPictureBox.TabIndex = 0;
            this.searchPictureBox.TabStop = false;
            this.searchPictureBox.Click += new System.EventHandler(this.searchPictureBoxClick);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 50);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.mainListBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.descriptionTextBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(200, 450);
            this.mainSplitContainer.SplitterDistance = 385;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // mainListBox
            // 
            this.mainListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mainListBox.FormattingEnabled = true;
            this.mainListBox.ImageList = this.mainImageList;
            this.mainListBox.Location = new System.Drawing.Point(0, 0);
            this.mainListBox.Margin = new System.Windows.Forms.Padding(0);
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(200, 385);
            this.mainListBox.TabIndex = 0;
            this.mainListBox.SelectedValueChanged += new System.EventHandler(this.mainListBoxSelectedValueChanged);
            // 
            // mainImageList
            // 
            this.mainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainImageList.ImageSize = new System.Drawing.Size(12, 12);
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 0);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 61);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // TokensControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.searchPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TokensControl";
            this.Size = new System.Drawing.Size(200, 500);
            this.Load += new System.EventHandler(this.TokensControlLoad);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private Umax.UI.XPListBox.XPListBox mainListBox;
        private System.Windows.Forms.ImageList mainImageList;
    }
}
