using System;
using System.Windows.Forms;
using Umax.Classes.Helpers;

namespace Umax.Windows.Windows.Help
{
    public partial class EULA : Form
    {
        public EULA()
        {
            InitializeComponent();
        }

        public bool Accepted { get; protected set; }

        private void EULA_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.Resources.IconRed;
            this.Text = Brand.Brand.Name + " " + this.Text;
            licenseLabel.Text = Brand.Brand.Name + " " + licenseLabel.Text;
            try
            {
                switch (Brand.Brand.Name)
                {
                    case "Umax":
                        {
                            Accepted = bool.Parse(WinHelper.ReadRegistryKey(@"SOFTWARE\Umax SoftWorks", "EULA"));
                            break;
                        }
                }
            }
            catch (Exception)
            {
                this.Accepted = false;
            }
        }

        private void agreeButton_Click(object sender, EventArgs e)
        {
            this.Accepted = true;
            this.SetRegistryValue(true);
            Close();
        }

        protected void SetRegistryValue(bool Accepted)
        {
            switch (Brand.Brand.Name)
            {
                case "Umax":
                    {
                        WinHelper.WriteRegistryKey(@"SOFTWARE\Umax SoftWorks", "EULA", Accepted.ToString());
                        break;
                    }
            }
        }

        private void EULA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.Accepted)
            {
                e.Cancel = true;
            }
        }
    }
}
