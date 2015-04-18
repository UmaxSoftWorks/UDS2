using System;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Windows.Classes;
using System.IO;

namespace Umax.Windows.Controls.Options.GUI
{
    public partial class OptionsGuiMonitor : UserControl
    {
        public OptionsGuiMonitor()
        {
            InitializeComponent();
        }

        private void OptionsGuiMonitor_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            try
            {
                // Monitor
                monitorCheckBox.Checked = GuiOptions.Instanse.Monitor;

                // Baloons
                baloonsShowBaloonsCheckBox.Checked = GuiOptions.Instanse.MonitorNotifications;
                if (GuiOptions.Instanse.MonitorNotificationsTime < baloonsShowTimeNumericUpDown.Minimum || GuiOptions.Instanse.MonitorNotificationsTime > baloonsShowTimeNumericUpDown.Maximum)
                {
                    baloonsShowTimeNumericUpDown.Value = 15;
                }
                else
                {
                    baloonsShowTimeNumericUpDown.Value = GuiOptions.Instanse.MonitorNotificationsTime;
                }

                // General log
                generalLogSaveCheckBox.Enabled = GuiOptions.Instanse.MonitorLog;
                generalLogFileTextBox.Text = GuiOptions.Instanse.MonitorLogFileName;
                generalLogDirectoryTextBox.Text = GuiOptions.Instanse.MonitorLogDirectory;

                // Update log
                updateLogSaveCheckBox.Enabled = GuiOptions.Instanse.MonitorUpdateLog;
                updateLogFileTextBox.Text = GuiOptions.Instanse.MonitorUpdateLogFileName;
                updateLogDirectoryTextBox.Text = GuiOptions.Instanse.MonitorUpdateLogDirectory;

                // Events
                this.monitorCheckBox_CheckedChanged(null, null);
                this.generalLogSaveCheckBox_CheckedChanged(null, null);
                this.updateLogCheckBox_CheckedChanged(null, null);
            }
            catch (Exception)
            {
                WinHelper.MessageBox("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            GuiOptions.Instanse.Monitor = monitorCheckBox.Checked;
            GuiOptions.Instanse.MonitorNotifications = baloonsShowBaloonsCheckBox.Checked;
            GuiOptions.Instanse.MonitorNotificationsTime = (int)baloonsShowTimeNumericUpDown.Value;

            // Saving
            GuiOptions.Instanse.Save();

            // Managing monitor
            if (GuiOptions.Instanse.Monitor)
            {
                if (File.Exists(Path.Combine(Application.StartupPath, "Monitor.exe")))
                {
                    System.Diagnostics.Process.Start(Path.Combine(Application.StartupPath, "Monitor.exe"), "-quiet");
                }
            }
            else
            {
                WinHelper.SendMessage(Keys.F10, Umax.Brand.Brand.Name + " Doorway Studio 2012 Monitor");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void monitorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (monitorCheckBox.Checked)
            {
                baloonsShowBaloonsCheckBox.Enabled = true;
                baloonsShowTimeNumericUpDown.Enabled = baloonsShowBaloonsCheckBox.Checked;
                generalLogGroupBox.Enabled = true;
                updateLogGroupBox.Enabled = true;
            }
            else
            {
                baloonsShowBaloonsCheckBox.Enabled = false;
                baloonsShowTimeNumericUpDown.Enabled = false;
                generalLogGroupBox.Enabled = false;
                updateLogGroupBox.Enabled = false;
            }
        }

        private void baloonsShowBaloonsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (baloonsShowBaloonsCheckBox.Checked && monitorCheckBox.Checked)
            {
                baloonsShowTimeNumericUpDown.Enabled = true;
            }
            else
            {
                baloonsShowTimeNumericUpDown.Enabled = false;
            }
        }

        private void generalLogSaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (generalLogSaveCheckBox.Checked)
            {
                generalLogFileTextBox.Enabled = true;
                generalLogDirectoryTextBox.Enabled = true;
                generalLogDirectoryButton.Enabled = true;
            }
            else
            {
                generalLogFileTextBox.Enabled = false;
                generalLogDirectoryTextBox.Enabled = false;
                generalLogDirectoryButton.Enabled = false;
            }
        }

        private void updateLogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (updateLogSaveCheckBox.Checked)
            {
                updateLogFileTextBox.Enabled = true;
                updateLogDirectoryTextBox.Enabled = true;
                updateLogDirectoryButton.Enabled = true;
            }
            else
            {
                updateLogFileTextBox.Enabled = false;
                updateLogDirectoryTextBox.Enabled = false;
                updateLogDirectoryButton.Enabled = false;
            }
        }

        private void generalLogDirectoryButton_Click(object sender, EventArgs e)
        {
            mainFolderBrowserDialog.SelectedPath = string.Empty;
            mainFolderBrowserDialog.ShowDialog();
            if (mainFolderBrowserDialog.SelectedPath == string.Empty)
            {
                return;
            }
            generalLogDirectoryTextBox.Text = mainFolderBrowserDialog.SelectedPath;
        }

        private void updateLogDirectoryButton_Click(object sender, EventArgs e)
        {
            mainFolderBrowserDialog.SelectedPath = string.Empty;
            mainFolderBrowserDialog.ShowDialog();
            if (mainFolderBrowserDialog.SelectedPath == string.Empty)
            {
                return;
            }
            updateLogDirectoryTextBox.Text = mainFolderBrowserDialog.SelectedPath;
        }
    }
}
