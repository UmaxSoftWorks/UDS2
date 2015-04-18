using System;
using System.Windows.Forms;
using Umax.Windows.Interfaces;

namespace Umax.Windows.Controls.Data
{
    public partial class ImagesDataControl : UserControl, IEventedControl
    {
        public ImagesDataControl()
        {
            InitializeComponent();
        }

        protected void ImagesControlLoad(object sender, EventArgs e)
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
            this.imagesTreeDataControl.ImagesChanged += this.ImagesChanged;
        }

        void ImagesChanged()
        {
            this.imagesEditorControl.SelectedImages = this.imagesTreeDataControl.SelectedImages;
            this.imagesEditorControl.SelectedWorkSpace = this.imagesTreeDataControl.SelectedWorkSpace;

            this.imagesEditorControl.UpdateControl();
        }

        public void DeInitializeEvents()
        {
            this.imagesTreeDataControl.ImagesChanged -= this.ImagesChanged;
            this.imagesTreeDataControl.DeInitializeEvents();
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
