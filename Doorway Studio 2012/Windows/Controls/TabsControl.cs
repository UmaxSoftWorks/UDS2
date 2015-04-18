using System;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Windows.Interfaces;

namespace Umax.Windows.Controls
{
    public partial class TabsControl : UserControl, IEventedControl
    {
        public TabsControl()
        {
            InitializeComponent();
        }

        private void TabsControlLoad(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            this.selectedWorkSpace = 0;

            this.InitializeImages();
            this.InitializeEvents();

            mainTabControl.ImageList = mainImageList;
            welcomeTabPage.ImageIndex = 0;
            generalTabPage.ImageIndex = 1;
            historyTabPage.ImageIndex = 2;

            // New Browser
            welcomeWebBrowser.DocumentText = Stuff.Resources.WelcomeString.Replace("#Name#", Brand.Brand.Name);

            mainTabControl.SelectedIndex = 1;
        }

        private void InitializeImages()
        {
            mainImageList.Images.Add(Resources.Resources.ImageGreen);
            mainImageList.Images.Add(Resources.Resources.Settings);
            mainImageList.Images.Add(Resources.Resources.Statistic);
        }

        public virtual void InitializeEvents()
        {
            Core.Core.Instanse.Manager.TaskStarted += this.EventHandler;
            Core.Core.Instanse.Manager.TaskCompleted += this.EventHandler;
            Core.Core.Instanse.Manager.TaskFailed += this.EventHandler;
        }

        public virtual void DeInitializeEvents()
        {
            Core.Core.Instanse.Manager.TaskStarted -= this.EventHandler;
            Core.Core.Instanse.Manager.TaskCompleted -= this.EventHandler;
            Core.Core.Instanse.Manager.TaskFailed -= this.EventHandler;
        }

        protected void EventHandler(object Task)
        {
            this.EventHandler();
        }

        protected void EventHandler()
        {
            if (this.CanUpdate() && !DesignMode)
            {
                this.Invoke((MethodInvoker)delegate { this.UpdateControl(); });
            }
        }

        private int selectedWorkSpace;

        public int SelectedWorkSpace
        {
            protected get
            {
                return this.selectedWorkSpace;
            }

            set
            {
                this.selectedWorkSpace = value;
                this.EventHandler();
            }
        }

        public void UpdateControl()
        {
            string content = Stuff.Resources.GeneralString.Replace("#Name#", Brand.Brand.Name);

            content = content.Replace("#WorkSpace#", (this.SelectedWorkSpace == -1 || Core.Core.Instanse.Data.Count == 0) ? string.Empty : Core.Core.Instanse.Data[this.SelectedWorkSpace].Name);

            generalWebBrowser.Navigate("about:blank");
            generalWebBrowser.Document.OpenNew(false);
            generalWebBrowser.Document.Write(content);
            generalWebBrowser.Refresh();
        }
    }
}
