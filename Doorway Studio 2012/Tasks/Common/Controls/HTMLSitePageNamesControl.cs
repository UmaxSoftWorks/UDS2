using System;
using System.Windows.Forms;

namespace Umax.Plugins.Tasks.Common.Controls
{
    public partial class HTMLSitePageNamesControl : UserControl
    {
        public HTMLSitePageNamesControl()
        {
            InitializeComponent();
        }

        private void HTMLSitePageNamesControlLoad(object sender, EventArgs e)
        {
            regularPagesTypeComboBox.SelectedIndex = 0;
            staticPagesTypeComboBox.SelectedIndex = 0;
            categoryPagesTypeComboBox.SelectedIndex = 0;
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
