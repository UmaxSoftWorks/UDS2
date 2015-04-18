using System;
using System.Windows.Forms;
using Umax.Classes.Helpers;

namespace Umax.Windows.Controls.Options.Core
{
    public partial class OptionsCoreLog : UserControl
    {
        public OptionsCoreLog()
        {
            InitializeComponent();
        }

        private void OptionsCoreLogLoad(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            try
            {
                generalLogSaveCheckBox.Checked = global::Core.Classes.Options.Instanse.LogSave;
                if (global::Core.Classes.Options.Instanse.LogMaxSize < generalLogMaxSizeNumericUpDown.Minimum || global::Core.Classes.Options.Instanse.LogMaxSize > generalLogMaxSizeNumericUpDown.Maximum)
                {
                    generalLogMaxSizeNumericUpDown.Value = 1000;
                }
                else
                {
                    generalLogMaxSizeNumericUpDown.Value = global::Core.Classes.Options.Instanse.LogMaxSize;
                }

                generalLogFileTextBox.Text = global::Core.Classes.Options.Instanse.LogFileName;
                generalLogDirectoryTextBox.Text = global::Core.Classes.Options.Instanse.LogDirectory;
                generalLogDebugModeCheckBox.Checked = global::Core.Classes.Options.Instanse.LogDebugMode;

            }
            catch (Exception)
            {
                WinHelper.MessageBox("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Events
            this.generalLogSaveCheckBoxCheckedChanged(null, null);
        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void applyButtonClick(object sender, EventArgs e)
        {
            if (generalLogSaveCheckBox.Checked && generalLogFileTextBox.Text == string.Empty)
            {
                WinHelper.MessageBox("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            global::Core.Classes.Options.Instanse.LogSave = generalLogSaveCheckBox.Checked;
            global::Core.Classes.Options.Instanse.LogMaxSize = (int)generalLogMaxSizeNumericUpDown.Value;
            global::Core.Classes.Options.Instanse.LogFileName = generalLogFileTextBox.Text;
            global::Core.Classes.Options.Instanse.LogDirectory = generalLogDirectoryTextBox.Text;
            global::Core.Classes.Options.Instanse.LogDebugMode = generalLogDebugModeCheckBox.Checked;
        }

        private void generalLogSaveCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            generalLogMaxSizeNumericUpDown.Enabled = generalLogSaveCheckBox.Checked;
            generalLogFileTextBox.Enabled = generalLogSaveCheckBox.Checked;
            generalLogDirectoryTextBox.Enabled = generalLogSaveCheckBox.Checked;
            generalLogDirectoryButton.Enabled = generalLogSaveCheckBox.Checked;
            generalLogDebugModeCheckBox.Enabled = generalLogSaveCheckBox.Checked;
        }

        private void generalLogDirectoryButtonClick(object sender, EventArgs e)
        {
            generalLogDirectoryFolderBrowserDialog.SelectedPath = string.Empty;
            generalLogDirectoryFolderBrowserDialog.ShowDialog();
            if (generalLogDirectoryFolderBrowserDialog.SelectedPath == string.Empty)
            {
                return;
            }
            generalLogDirectoryTextBox.Text = generalLogDirectoryFolderBrowserDialog.SelectedPath;

        }
    }
}
