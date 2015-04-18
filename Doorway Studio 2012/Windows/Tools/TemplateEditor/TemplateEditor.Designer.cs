using Umax.Windows.Controls.Views.Data;
using Umax.Windows.Tools.TemplateEditor.Controls;

namespace Umax.Windows.Tools.TemplateEditor
{
    partial class TemplateEditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.templatesTreeControl = new Umax.Windows.Controls.Views.Data.TemplatesTreeDataControl();
            this.templateEditorControl = new TemplateEditorControl();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.tokensControl = new TokensControl();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
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
            this.mainSplitContainer.Panel1.Controls.Add(this.templatesTreeControl);
            this.mainSplitContainer.Panel1MinSize = 170;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.templateEditorControl);
            this.mainSplitContainer.Panel2.Controls.Add(this.welcomeLabel);
            this.mainSplitContainer.Size = new System.Drawing.Size(594, 392);
            this.mainSplitContainer.SplitterDistance = 170;
            this.mainSplitContainer.TabIndex = 3;
            // 
            // templatesTreeControl
            // 
            this.templatesTreeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templatesTreeControl.Location = new System.Drawing.Point(0, 0);
            this.templatesTreeControl.Margin = new System.Windows.Forms.Padding(0);
            this.templatesTreeControl.Name = "templatesTreeControl";
            this.templatesTreeControl.SelectedItem = -1;
            this.templatesTreeControl.SelectedTemplate = -1;
            this.templatesTreeControl.SelectedWorkSpace = -1;
            this.templatesTreeControl.Size = new System.Drawing.Size(170, 392);
            this.templatesTreeControl.TabIndex = 1;
            // 
            // templateEditorControl
            // 
            this.templateEditorControl.CurrentItem = -1;
            this.templateEditorControl.CurrentTemplate = -1;
            this.templateEditorControl.CurrentWorkSpace = -1;
            this.templateEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateEditorControl.Location = new System.Drawing.Point(0, 0);
            this.templateEditorControl.Margin = new System.Windows.Forms.Padding(0);
            this.templateEditorControl.Name = "templateEditorControl";
            this.templateEditorControl.SelectedItem = 0;
            this.templateEditorControl.SelectedTemplate = 0;
            this.templateEditorControl.SelectedWorkSpace = 0;
            this.templateEditorControl.Size = new System.Drawing.Size(420, 392);
            this.templateEditorControl.TabIndex = 2;
            this.templateEditorControl.Visible = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.Location = new System.Drawing.Point(56, 176);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(309, 33);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Please select template";
            // 
            // tokensControl
            // 
            this.tokensControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.tokensControl.Location = new System.Drawing.Point(594, 0);
            this.tokensControl.Margin = new System.Windows.Forms.Padding(0);
            this.tokensControl.Name = "tokensControl";
            this.tokensControl.Size = new System.Drawing.Size(200, 392);
            this.tokensControl.TabIndex = 0;
            // 
            // TemplateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 392);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.tokensControl);
            this.Name = "TemplateEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doorway Studio 2012: Template Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TemplateEditorFormClosing);
            this.Load += new System.EventHandler(this.TemplateEditorLoad);
            this.SizeChanged += new System.EventHandler(this.TemplateEditorSizeChanged);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TokensControl tokensControl;
        private TemplatesTreeDataControl templatesTreeControl;
        private TemplateEditorControl templateEditorControl;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Label welcomeLabel;
    }
}