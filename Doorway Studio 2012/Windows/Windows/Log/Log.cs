using System;
using System.Windows.Forms;
using Umax.Interfaces.Events;
using Umax.Windows.Interfaces;

namespace Umax.Windows.Windows.Log
{
    public partial class Log : StandardWindow, IExitableWindow
    {
        public Log()
        {
            InitializeComponent();
        }

        protected void LogLoad(object sender, EventArgs e)
        {
            this.Text = Brand.Brand.Name + " " + this.Text;

            this.InitializeImages();

            logContol.UpdateControl();
        }

        protected void InitializeImages()
        {
            this.Icon = Resources.Resources.IconRed;
        }

        protected void LogClosing(object sender, FormClosingEventArgs e)
        {
            logContol.DeInitializeEvents();
        }

        public bool Exit { get; set; }

        public void ShowWindow()
        {
        }

        public event SimpleEventHandler Dismissed;

        private void LogFormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Dismissed != null)
            {
                this.Dismissed();
            }
        }

        public void Execute()
        {
            this.ShowDialog();
        }
    }
}
