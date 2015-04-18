namespace Umax.Windows.Controls.Data
{
    partial class ImagesDataControl
    {
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

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.imagesTreeDataControl = new Umax.Windows.Controls.Views.Data.ImagesTreeDataControl();
            this.imagesEditorControl = new Umax.Windows.Controls.Editors.ImagesEditorControl();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
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
            this.mainSplitContainer.Panel1.Controls.Add(this.imagesTreeDataControl);
            this.mainSplitContainer.Panel1MinSize = 170;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.imagesEditorControl);
            this.mainSplitContainer.Size = new System.Drawing.Size(794, 353);
            this.mainSplitContainer.SplitterDistance = 170;
            this.mainSplitContainer.TabIndex = 6;
            // 
            // imagesTreeDataControl
            // 
            this.imagesTreeDataControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesTreeDataControl.Location = new System.Drawing.Point(0, 0);
            this.imagesTreeDataControl.Name = "imagesTreeDataControl";
            this.imagesTreeDataControl.SelectedImages = -1;
            this.imagesTreeDataControl.SelectedWorkSpace = -1;
            this.imagesTreeDataControl.Size = new System.Drawing.Size(170, 353);
            this.imagesTreeDataControl.TabIndex = 0;
            // 
            // imagesEditorControl
            // 
            this.imagesEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesEditorControl.Location = new System.Drawing.Point(0, 0);
            this.imagesEditorControl.Margin = new System.Windows.Forms.Padding(0);
            this.imagesEditorControl.Name = "imagesEditorControl";
            this.imagesEditorControl.SelectedImages = -1;
            this.imagesEditorControl.SelectedWorkSpace = -1;
            this.imagesEditorControl.Size = new System.Drawing.Size(620, 353);
            this.imagesEditorControl.TabIndex = 0;
            // 
            // ImagesDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "ImagesDataControl";
            this.Size = new System.Drawing.Size(794, 353);
            this.Load += new System.EventHandler(this.ImagesControlLoad);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer mainSplitContainer;
        private Editors.ImagesEditorControl imagesEditorControl;
        private Views.Data.ImagesTreeDataControl imagesTreeDataControl;

    }
}
