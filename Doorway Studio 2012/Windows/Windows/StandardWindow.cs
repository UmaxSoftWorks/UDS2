using System;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Windows.Interfaces;

namespace Umax.Windows.Windows
{
    public class StandardWindow : Form, IStandardWindow
    {
        public string Title { get { return this.Text; } }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.TextChanged += this.TitleChanged;

            RunTime.Instance.Windows.Add(this);
        }

        void TitleChanged(object sender, EventArgs e)
        {
            RunTime.Instance.Windows.Update();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            RunTime.Instance.Windows.Remove(this);
        }

        public void Restore()
        {
            (this as Form).Restore();
            this.Focus();
        }
    }
}
