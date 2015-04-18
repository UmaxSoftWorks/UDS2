using System;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Windows.Classes;

namespace Umax.Windows.Controls.Options.GUI
{
    public partial class OptionsGuiUpdates : UserControl
    {
        public OptionsGuiUpdates()
        {
            InitializeComponent();
        }

        private void OptionsGuiUpdates_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            GuiOptions.Instanse.UpdateCheckAtStartup = generalCheckOnStartUpCheckBox.Checked;
            GuiOptions.Instanse.UpdateCheckWhileRunning = generalCheckWhileRunningCheckBox.Checked;
            GuiOptions.Instanse.UpdateCheckWhileRunningPeriod = (int)generalCheckWhileRunningPeriodNumericUpDown.Value;

            // Saving
            GuiOptions.Instanse.Save();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            try
            {
                generalCheckOnStartUpCheckBox.Checked = GuiOptions.Instanse.UpdateCheckAtStartup;
                generalCheckWhileRunningCheckBox.Checked = GuiOptions.Instanse.UpdateCheckWhileRunning;

                if (GuiOptions.Instanse.UpdateCheckWhileRunningPeriod < generalCheckWhileRunningPeriodNumericUpDown.Minimum || GuiOptions.Instanse.UpdateCheckWhileRunningPeriod > generalCheckWhileRunningPeriodNumericUpDown.Maximum)
                {
                    generalCheckWhileRunningPeriodNumericUpDown.Value = 12;
                }
                else
                {
                    generalCheckWhileRunningPeriodNumericUpDown.Value = GuiOptions.Instanse.UpdateCheckWhileRunningPeriod;
                }
            }
            catch (Exception)
            {
                WinHelper.MessageBox("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Events
            this.generalCheckOnStartUpCheckBox_CheckedChanged(null, null);
            this.generalCheckWhileRunningCheckBox_CheckedChanged(null, null);
        }

        private void generalCheckOnStartUpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (generalCheckOnStartUpCheckBox.Checked)
            {
                generalCheckWhileRunningCheckBox.Enabled = true;
                generalCheckWhileRunningPeriodNumericUpDown.Enabled = generalCheckWhileRunningCheckBox.Checked;
            }
            else
            {
                generalCheckWhileRunningCheckBox.Enabled = false;
                generalCheckWhileRunningPeriodNumericUpDown.Enabled = false;
            }
        }

        private void generalCheckWhileRunningCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (generalCheckOnStartUpCheckBox.Checked)
            {
                generalCheckWhileRunningPeriodNumericUpDown.Enabled = generalCheckWhileRunningCheckBox.Checked;
            }
            else
            {
                generalCheckWhileRunningPeriodNumericUpDown.Enabled = false;
            }
        }
    }
}
