using System;
using System.Drawing;
using System.Windows.Forms;
using Umax.Windows.Windows;

namespace Umax.Windows.Tools.TemplateEditor
{
    public partial class TemplateEditor : StandardWindow
    {
        public TemplateEditor()
        {
            InitializeComponent();
        }

        private void TemplateEditorLoad(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            this.Icon = Resources.Resources.IconRed;
            this.Text = Brand.Brand.Name + " " + this.Text;

            // Welcome label
            this.TemplateEditorSizeChanged(sender, e);

            this.InitializeEvents();
        }

        private void InitializeEvents()
        {
            this.templatesTreeControl.TemplateChanged += this.TemplateChanged;
            this.tokensControl.TokenSelected += this.TokenSelected;
        }

        void TemplateChanged()
        {
            if (!this.templateEditorControl.Visible)
            {
                this.templateEditorControl.Visible = true;
            }

            this.templateEditorControl.SelectedItem = this.templatesTreeControl.SelectedItem;
            this.templateEditorControl.SelectedTemplate = this.templatesTreeControl.SelectedTemplate;
            this.templateEditorControl.SelectedWorkSpace = this.templatesTreeControl.SelectedWorkSpace;

            this.templateEditorControl.Tokens = tokensControl.Items;

            this.templateEditorControl.UpdateControl();

            // Check if user confirmed change
            if (this.templateEditorControl.SelectedItem != this.templatesTreeControl.SelectedItem ||
            this.templateEditorControl.SelectedTemplate != this.templatesTreeControl.SelectedTemplate)
            {
                this.templatesTreeControl.SelectedItem = this.templateEditorControl.SelectedItem;
                this.templatesTreeControl.SelectedTemplate = this.templateEditorControl.SelectedTemplate;
                this.templatesTreeControl.SelectedWorkSpace = this.templateEditorControl.SelectedWorkSpace;

                this.templatesTreeControl.UpdateControl();
            }
        }

        private void TemplateEditorFormClosing(object sender, FormClosingEventArgs e)
        {
            this.templatesTreeControl.TemplateChanged -= this.TemplateChanged;
            this.templatesTreeControl.DeInitializeEvents();
        }

        private void TemplateEditorSizeChanged(object sender, EventArgs e)
        {
            this.welcomeLabel.Location = new Point((this.mainSplitContainer.Panel2.Width / 2) - (this.welcomeLabel.Width / 2),
                                          (this.mainSplitContainer.Panel2.Height / 2) - (this.welcomeLabel.Height / 2));
        }

        void TokenSelected()
        {
            this.templateEditorControl.SelectedToken = tokensControl.SelectedToken;
        }
    }
}
