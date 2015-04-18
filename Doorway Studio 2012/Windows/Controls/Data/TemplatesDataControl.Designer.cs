using Umax.Windows.Controls.Editors;
using Umax.Windows.Controls.Views.Data;

namespace Umax.Windows.Controls.Data
{
    partial class TemplatesDataControl
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
            this.templatesTreeDataControl = new Umax.Windows.Controls.Views.Data.TemplatesTreeDataControl();
            this.templateEditorControl = new Umax.Windows.Controls.Editors.TemplateEditorControl();
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
            this.mainSplitContainer.Panel1.Controls.Add(this.templatesTreeDataControl);
            this.mainSplitContainer.Panel1MinSize = 170;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.templateEditorControl);
            this.mainSplitContainer.Size = new System.Drawing.Size(794, 353);
            this.mainSplitContainer.SplitterDistance = 170;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // templatesTreeDataControl
            // 
            this.templatesTreeDataControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templatesTreeDataControl.Location = new System.Drawing.Point(0, 0);
            this.templatesTreeDataControl.Margin = new System.Windows.Forms.Padding(0);
            this.templatesTreeDataControl.Name = "templatesTreeDataControl";
            this.templatesTreeDataControl.SelectedItem = -1;
            this.templatesTreeDataControl.SelectedTemplate = -1;
            this.templatesTreeDataControl.SelectedWorkSpace = -1;
            this.templatesTreeDataControl.Size = new System.Drawing.Size(170, 353);
            this.templatesTreeDataControl.TabIndex = 0;
            // 
            // templateEditorControl
            // 
            this.templateEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateEditorControl.Location = new System.Drawing.Point(0, 0);
            this.templateEditorControl.Margin = new System.Windows.Forms.Padding(0);
            this.templateEditorControl.Name = "templateEditorControl";
            this.templateEditorControl.SelectedItem = -1;
            this.templateEditorControl.SelectedTemplate = -1;
            this.templateEditorControl.SelectedWorkSpace = -1;
            this.templateEditorControl.Size = new System.Drawing.Size(620, 353);
            this.templateEditorControl.TabIndex = 0;
            // 
            // TemplatesDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "TemplatesDataControl";
            this.Size = new System.Drawing.Size(794, 353);
            this.Load += new System.EventHandler(this.TemplatesControlLoad);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer mainSplitContainer;
        private TemplatesTreeDataControl templatesTreeDataControl;
        private Editors.TemplateEditorControl templateEditorControl;

    }
}
