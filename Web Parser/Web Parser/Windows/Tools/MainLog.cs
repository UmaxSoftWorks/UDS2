using System;
using System.Windows.Forms;
using Umax.Brand;
using Umax.Resources;
using WebParser.Core.Classes;

namespace WebParser.Windows.Tools
{
    public partial class MainLog : Form
    {
        public MainLog()
        {
            InitializeComponent();
        }

        private void MainLogLoad(object sender, EventArgs e)
        {
            this.Icon = Resources.IconGrey;
            this.Text = Brand.Name + " " + this.Text;

            mainListBox.Items.AddRange(Logger.Instanse.Items.ToArray());

            Logger.Instanse.Added += this.LogMessageAdded;
        }

        private void LogMessageAdded(object Entry)
        {
            mainListBox.Items.Add(Entry);
        }

        private void MainLogFormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Instanse.Added -= this.LogMessageAdded;
        }
    }
}
