using System;
using System.Windows.Forms;
using Core.Classes;
using Umax.Classes.Helpers;
using Umax.Windows.Interfaces;

namespace Umax.Windows.Controls.Views
{
    public partial class LogContol : UserControl, IEventedControl
    {
        public LogContol()
        {
            InitializeComponent();
        }

        private void LogContolLoad(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            this.Initialized = true;

            this.InitializeImages();

            this.UpdateControl();

            this.InitializeEvents();
        }

        protected virtual void InitializeImages()
        {
            saveToolStripButton.Image = Resources.Resources.Save;
            clearToolStripButton.Image = Resources.Resources.Delete;
            clearMemoryToolStripButton.Image = Resources.Resources.Computer;
        }

        public virtual void InitializeEvents()
        {
            Logger.Instanse.Added += this.LogEntryAdded;
        }

        protected void LogEntryAdded(object Entry)
        {
            if (this.CanUpdate() && !this.DesignMode)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    historyListBox.Items.Add(Entry.ToString());
                    historyListBox.SelectedIndex = historyListBox.Items.Count - 1;
                });
            }
        }

        protected bool Initialized { get; set; }

        public virtual void UpdateControl()
        {
            if (!this.Initialized)
            {
                this.OnLoad(EventArgs.Empty);
            }

            historyListBox.Items.Clear();
            historyListBox.Items.AddRange(Logger.Instanse.Items.ToArray());
            historyListBox.SelectedIndex = historyListBox.Items.Count - 1;
        }

        public virtual void DeInitializeEvents()
        {
            Logger.Instanse.Added -= this.LogEntryAdded;
        }

        protected void Save(object sender, EventArgs e)
        {

        }

        protected void Clear(object sender, EventArgs e)
        {
            historyListBox.Items.Clear();
        }

        protected void ClearMemory(object sender, EventArgs e)
        {
            Core.Core.Instanse.CollectGarbage();
        }
    }
}
