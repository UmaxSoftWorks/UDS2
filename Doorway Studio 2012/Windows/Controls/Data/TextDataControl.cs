using System;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Windows.Interfaces;

namespace Umax.Windows.Controls.Data
{
    public partial class TextDataControl : UserControl, IEventedControl
    {
        public TextDataControl()
        {
            InitializeComponent();
        }

        protected void TextControlLoad(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            this.Initialized = true;

            this.InitializeEvents();

            this.UpdateControl();
        }

        public void InitializeEvents()
        {
            this.textTreeDataControl.TextChanged += this.TextChanged;
        }

        private new void TextChanged()
        {
            this.textEditorControl.SelectedText = this.textTreeDataControl.SelectedText;
            this.textEditorControl.SelectedWorkSpace = this.textTreeDataControl.SelectedWorkSpace;

            this.textEditorControl.UpdateControl();
        }

        public void DeInitializeEvents()
        {
            this.textTreeDataControl.DeInitializeEvents();
        }


        protected void EventHandler()
        {
            if (this.CanUpdate() && !DesignMode)
            {
                this.Invoke((MethodInvoker)delegate { this.UpdateControl(); });
            }
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
