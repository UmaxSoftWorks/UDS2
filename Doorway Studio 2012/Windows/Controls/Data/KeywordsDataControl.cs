using System;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Windows.Interfaces;

namespace Umax.Windows.Controls.Data
{
    public partial class KeywordsDataControl : UserControl, IEventedControl
    {
        public KeywordsDataControl()
        {
            InitializeComponent();
        }

        protected void KeywordsControlLoad(object sender, EventArgs e)
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
            this.keywordsTreeDataControl.KeywordsChanged += this.KeywordsChanged;
        }

        void KeywordsChanged()
        {
            this.keywordsEditorControl.SelectedKeywords = this.keywordsTreeDataControl.SelectedKeywords;
            this.keywordsEditorControl.SelectedWorkSpace = this.keywordsTreeDataControl.SelectedWorkSpace;

            this.keywordsEditorControl.UpdateControl();
        }

        public void DeInitializeEvents()
        {
            this.keywordsTreeDataControl.DeInitializeEvents();
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
