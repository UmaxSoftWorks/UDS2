using System;
using System.Windows.Forms;

namespace Umax.Windows.Windows.Common
{
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();
        }

        public bool Restart { get; protected set; }
        public string URL { get; set; }

        private void UpdaterLoad(object sender, EventArgs e)
        {
            this.Text = Brand.Brand.Name + " " + this.Text;
            this.InitializeImages();

            Restart = false;
        }

        protected void InitializeImages()
        {
            this.Icon = Resources.Resources.IconRed;
            mainPictureBox.Image = Resources.Resources.ImageUpdate;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }

        private void Updater_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        //if monitor isn't running start it with "-update"
    }
}
