namespace Umax.Windows.Controls.Data
{
    partial class TextDataControl
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
            this.textEditorControl = new Umax.Windows.Controls.Editors.TextEditorControl();
            this.textTreeDataControl = new Umax.Windows.Controls.Views.Data.TextTreeDataControl();
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
            this.mainSplitContainer.Panel1.Controls.Add(this.textTreeDataControl);
            this.mainSplitContainer.Panel1MinSize = 170;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.textEditorControl);
            this.mainSplitContainer.Size = new System.Drawing.Size(794, 353);
            this.mainSplitContainer.SplitterDistance = 170;
            this.mainSplitContainer.TabIndex = 9;
            // 
            // textEditorControl
            // 
            this.textEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditorControl.Location = new System.Drawing.Point(0, 0);
            this.textEditorControl.Margin = new System.Windows.Forms.Padding(0);
            this.textEditorControl.Name = "textEditorControl";
            this.textEditorControl.SelectedText = 0;
            this.textEditorControl.SelectedWorkSpace = 0;
            this.textEditorControl.Size = new System.Drawing.Size(620, 353);
            this.textEditorControl.TabIndex = 0;
            // 
            // textTreeDataControl
            // 
            this.textTreeDataControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTreeDataControl.Location = new System.Drawing.Point(0, 0);
            this.textTreeDataControl.Name = "textTreeDataControl";
            this.textTreeDataControl.SelectedText = 0;
            this.textTreeDataControl.SelectedWorkSpace = 0;
            this.textTreeDataControl.Size = new System.Drawing.Size(170, 353);
            this.textTreeDataControl.TabIndex = 0;
            // 
            // TextDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "TextDataControl";
            this.Size = new System.Drawing.Size(794, 353);
            this.Load += new System.EventHandler(this.TextControlLoad);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer mainSplitContainer;
        private Editors.TextEditorControl textEditorControl;
        private Views.Data.TextTreeDataControl textTreeDataControl;

    }
}
