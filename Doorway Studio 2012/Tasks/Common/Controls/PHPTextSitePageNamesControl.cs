using System;
using System.Windows.Forms;

namespace Umax.Plugins.Tasks.Controls
{
    public partial class PHPTextSitePageNamesControl : UserControl
    {
        public PHPTextSitePageNamesControl()
        {
            InitializeComponent();
        }

        private void DynamicPHPTextSitePageNamesControl_Load(object sender, EventArgs e)
        {
        }

        private void categoryPagesContinuesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (categoryPagesContinuesCheckBox.Checked)
            {
                categoryPagesContinuesNameTextBox.Enabled = true;
                categoryPagesContinuesNumericUpDown.Enabled = true;
            }
            else
            {
                categoryPagesContinuesNameTextBox.Enabled = false;
                categoryPagesContinuesNumericUpDown.Enabled = false;
            }
        }

        private void mainPageContinuesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mainPageContinuesCheckBox.Checked)
            {
                mainPageContinuesNameTextBox.Enabled = true;
                mainPageContinuesNumericUpDown.Enabled = true;
            }
            else
            {
                mainPageContinuesNameTextBox.Enabled = false;
                mainPageContinuesNumericUpDown.Enabled = false;
            }
        }
    }
}
