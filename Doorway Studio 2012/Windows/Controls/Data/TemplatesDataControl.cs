using System;
using System.Windows.Forms;
using Umax.Windows.Interfaces;

namespace Umax.Windows.Controls.Data
{
    public partial class TemplatesDataControl : UserControl, IEventedControl
    {
        public TemplatesDataControl()
        {
            InitializeComponent();
        }

        private void TemplatesControlLoad(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            this.Initialized = true;

            this.InitializeEvents();
        }

        public void InitializeEvents()
        {
            this.templatesTreeDataControl.TemplateChanged += this.TemplateChanged;
        }

        void TemplateChanged()
        {
            this.templateEditorControl.SelectedItem = this.templatesTreeDataControl.SelectedItem;
            this.templateEditorControl.SelectedTemplate = this.templatesTreeDataControl.SelectedTemplate;
            this.templateEditorControl.SelectedWorkSpace = this.templatesTreeDataControl.SelectedWorkSpace;

            this.templateEditorControl.UpdateControl();
        }

        public void DeInitializeEvents()
        {
            this.templatesTreeDataControl.TemplateChanged -= this.TemplateChanged;
            this.templatesTreeDataControl.DeInitializeEvents();
        }

        protected bool Initialized { get; set; }

        public void UpdateControl()
        {
            if (!this.Initialized)
            {
                this.OnLoad(EventArgs.Empty);
            }
        }
    }
}
