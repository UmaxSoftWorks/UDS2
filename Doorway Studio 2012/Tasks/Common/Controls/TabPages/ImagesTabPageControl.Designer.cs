namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    partial class ImagesTabPageControl
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
            this.imagesPanel = new System.Windows.Forms.Panel();
            this.imagesCheckBox = new System.Windows.Forms.CheckBox();
            this.makerPanel = new System.Windows.Forms.Panel();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.makersGroupBox.SuspendLayout();
            this.imagesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.makersGroupBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.imagesPanel);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.makerPanel);
            this.mainSplitContainer.Size = new System.Drawing.Size(686, 420);
            this.mainSplitContainer.SplitterDistance = 196;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // makersGroupBox
            // 
            this.makersGroupBox.Controls.Add(this.makersTreeView);
            this.makersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makersGroupBox.Location = new System.Drawing.Point(0, 29);
            this.makersGroupBox.Name = "makersGroupBox";
            this.makersGroupBox.Size = new System.Drawing.Size(196, 391);
            this.makersGroupBox.TabIndex = 21;
            this.makersGroupBox.TabStop = false;
            this.makersGroupBox.Text = "Image Makers";
            // 
            // makersTreeView
            // 
            this.makersTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makersTreeView.ImageIndex = 0;
            this.makersTreeView.ImageList = this.mainImageList;
            this.makersTreeView.Location = new System.Drawing.Point(3, 16);
            this.makersTreeView.Name = "makersTreeView";
            this.makersTreeView.SelectedImageIndex = 0;
            this.makersTreeView.Size = new System.Drawing.Size(190, 372);
            this.makersTreeView.TabIndex = 1;
            this.makersTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.makersTreeViewAfterSelect);
            // 
            // mainImageList
            // 
            this.mainImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imagesPanel
            // 
            this.imagesPanel.Controls.Add(this.imagesCheckBox);
            this.imagesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.imagesPanel.Location = new System.Drawing.Point(0, 0);
            this.imagesPanel.Name = "imagesPanel";
            this.imagesPanel.Size = new System.Drawing.Size(196, 29);
            this.imagesPanel.TabIndex = 22;
            // 
            // imagesCheckBox
            // 
            this.imagesCheckBox.AutoSize = true;
            this.imagesCheckBox.Location = new System.Drawing.Point(3, 7);
            this.imagesCheckBox.Name = "imagesCheckBox";
            this.imagesCheckBox.Size = new System.Drawing.Size(81, 17);
            this.imagesCheckBox.TabIndex = 21;
            this.imagesCheckBox.Text = "Use images";
            this.imagesCheckBox.UseVisualStyleBackColor = true;
            this.imagesCheckBox.CheckedChanged += new System.EventHandler(this.imagesCheckBoxCheckedChanged);
            // 
            // makerPanel
            // 
            this.makerPanel.AutoScroll = true;
            this.makerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makerPanel.Location = new System.Drawing.Point(0, 0);
            this.makerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.makerPanel.Name = "makerPanel";
            this.makerPanel.Size = new System.Drawing.Size(486, 420);
            this.makerPanel.TabIndex = 4;
            // 
            // ImagesTabPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ImagesTabPageControl";
            this.Size = new System.Drawing.Size(686, 420);
            this.Load += new System.EventHandler(this.ImagesTabPageControlLoad);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.makersGroupBox.ResumeLayout(false);
            this.imagesPanel.ResumeLayout(false);
            this.imagesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer mainSplitContainer;
        protected System.Windows.Forms.GroupBox makersGroupBox;
        protected System.Windows.Forms.TreeView makersTreeView;
        protected System.Windows.Forms.Panel imagesPanel;
        protected System.Windows.Forms.CheckBox imagesCheckBox;
        protected System.Windows.Forms.Panel makerPanel;
        protected System.Windows.Forms.ImageList mainImageList;
    }
}
