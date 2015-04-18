namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    partial class CategoriesTabPageControl
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
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.distributionLabel = new System.Windows.Forms.Label();
            this.distributionComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.generateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.mainToolStrip.SuspendLayout();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTreeView
            // 
            this.mainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTreeView.Location = new System.Drawing.Point(0, 0);
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.Size = new System.Drawing.Size(662, 360);
            this.mainTreeView.TabIndex = 14;
            this.mainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.categoriesTreeViewAfterSelect);
            // 
            // distributionLabel
            // 
            this.distributionLabel.AutoSize = true;
            this.distributionLabel.Location = new System.Drawing.Point(0, 31);
            this.distributionLabel.Name = "distributionLabel";
            this.distributionLabel.Size = new System.Drawing.Size(59, 13);
            this.distributionLabel.TabIndex = 19;
            this.distributionLabel.Text = "Distribution";
            // 
            // distributionComboBox
            // 
            this.distributionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.distributionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distributionComboBox.FormattingEnabled = true;
            this.distributionComboBox.Items.AddRange(new object[] {
            "Random",
            "When contains"});
            this.distributionComboBox.Location = new System.Drawing.Point(496, 28);
            this.distributionComboBox.Name = "distributionComboBox";
            this.distributionComboBox.Size = new System.Drawing.Size(163, 21);
            this.distributionComboBox.TabIndex = 18;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(638, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(21, 21);
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.categoriesPictureBoxClick);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.removeToolStripButton,
            this.clearToolStripButton,
            this.generateToolStripButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.mainToolStrip.Location = new System.Drawing.Point(662, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainToolStrip.Size = new System.Drawing.Size(24, 420);
            this.mainToolStrip.TabIndex = 15;
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "categoriesAddToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButtonClick);
            // 
            // removeToolStripButton
            // 
            this.removeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeToolStripButton.Name = "categoriesRemoveToolStripButton";
            this.removeToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.removeToolStripButton.Text = "Remove";
            this.removeToolStripButton.Click += new System.EventHandler(this.removeToolStripButtonClick);
            // 
            // clearToolStripButton
            // 
            this.clearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearToolStripButton.Name = "categoriesClearToolStripButton";
            this.clearToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.clearToolStripButton.Text = "Clear";
            this.clearToolStripButton.Click += new System.EventHandler(this.clearToolStripButtonClick);
            // 
            // generateToolStripButton
            // 
            this.generateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.generateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.generateToolStripButton.Name = "categoriesGenerateToolStripButton";
            this.generateToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.generateToolStripButton.Text = "Generate";
            this.generateToolStripButton.Click += new System.EventHandler(this.generateToolStripButtonClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(629, 20);
            this.nameTextBox.TabIndex = 16;
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categoriesNameTextBoxKeyDown);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.mainTreeView);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.nameTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.distributionLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.pictureBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.distributionComboBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(662, 420);
            this.mainSplitContainer.SplitterDistance = 360;
            this.mainSplitContainer.TabIndex = 20;
            // 
            // CategoriesTabPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CategoriesTabPageControl";
            this.Size = new System.Drawing.Size(686, 420);
            this.Load += new System.EventHandler(this.CategoriesTabPageControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TreeView mainTreeView;
        protected System.Windows.Forms.Label distributionLabel;
        protected System.Windows.Forms.ComboBox distributionComboBox;
        protected System.Windows.Forms.PictureBox pictureBox;
        protected System.Windows.Forms.ToolStrip mainToolStrip;
        protected System.Windows.Forms.ToolStripButton addToolStripButton;
        protected System.Windows.Forms.ToolStripButton removeToolStripButton;
        protected System.Windows.Forms.ToolStripButton clearToolStripButton;
        protected System.Windows.Forms.ToolStripButton generateToolStripButton;
        protected System.Windows.Forms.TextBox nameTextBox;
        protected System.Windows.Forms.SplitContainer mainSplitContainer;
    }
}
