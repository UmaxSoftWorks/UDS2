namespace Umax.Windows.Controls.Data
{
    partial class KeywordsDataControl
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
            this.keywordsTreeDataControl = new Umax.Windows.Controls.Views.Data.KeywordsTreeDataControl();
            this.keywordsEditorControl = new Umax.Windows.Controls.Editors.KeywordsEditorControl();
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
            this.mainSplitContainer.Panel1.Controls.Add(this.keywordsTreeDataControl);
            this.mainSplitContainer.Panel1MinSize = 170;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.keywordsEditorControl);
            this.mainSplitContainer.Size = new System.Drawing.Size(794, 353);
            this.mainSplitContainer.SplitterDistance = 170;
            this.mainSplitContainer.TabIndex = 8;
            // 
            // keywordsTreeDataControl
            // 
            this.keywordsTreeDataControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keywordsTreeDataControl.Location = new System.Drawing.Point(0, 0);
            this.keywordsTreeDataControl.Margin = new System.Windows.Forms.Padding(0);
            this.keywordsTreeDataControl.Name = "keywordsTreeDataControl";
            this.keywordsTreeDataControl.SelectedKeywords = -1;
            this.keywordsTreeDataControl.SelectedWorkSpace = -1;
            this.keywordsTreeDataControl.Size = new System.Drawing.Size(170, 353);
            this.keywordsTreeDataControl.TabIndex = 0;
            // 
            // keywordsEditorControl
            // 
            this.keywordsEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keywordsEditorControl.Location = new System.Drawing.Point(0, 0);
            this.keywordsEditorControl.Margin = new System.Windows.Forms.Padding(0);
            this.keywordsEditorControl.Name = "keywordsEditorControl";
            this.keywordsEditorControl.SelectedKeywords = 0;
            this.keywordsEditorControl.SelectedWorkSpace = 0;
            this.keywordsEditorControl.Size = new System.Drawing.Size(620, 353);
            this.keywordsEditorControl.TabIndex = 0;
            // 
            // KeywordsDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "KeywordsDataControl";
            this.Size = new System.Drawing.Size(794, 353);
            this.Load += new System.EventHandler(this.KeywordsControlLoad);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private Views.Data.KeywordsTreeDataControl keywordsTreeDataControl;
        private Editors.KeywordsEditorControl keywordsEditorControl;
    }
}
