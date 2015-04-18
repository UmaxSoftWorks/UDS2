using System;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Windows.Classes;

namespace Umax.Windows.Controls.Options.GUI
{
    public partial class OptionsGuiNotifications : UserControl
    {
        public OptionsGuiNotifications()
        {
            InitializeComponent();
        }

        private void OptionsGuiNotificationsLoad(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            try
            {
                // Baloons
                baloonsShowBaloonsCheckBox.Checked = GuiOptions.Instanse.Notifications;
                if (GuiOptions.Instanse.NotificationsTime < baloonsShowTimeNumericUpDown.Minimum || GuiOptions.Instanse.NotificationsTime > baloonsShowTimeNumericUpDown.Maximum)
                {
                    baloonsShowTimeNumericUpDown.Value = 30;
                }
                else
                {
                    baloonsShowTimeNumericUpDown.Value = GuiOptions.Instanse.NotificationsTime;
                }

                baloonsShowBaloonsCheckedListBox.SetItemChecked(0, GuiOptions.Instanse.NotificationsAtTaskStarted);
                baloonsShowBaloonsCheckedListBox.SetItemChecked(1, GuiOptions.Instanse.NotificationsAtTaskFailed);
                baloonsShowBaloonsCheckedListBox.SetItemChecked(2, GuiOptions.Instanse.NotificationsAtTaskFinished);
                baloonsShowBaloonsCheckedListBox.SetItemChecked(3, GuiOptions.Instanse.NotificationsAtNoTask);

                // Sounds
                this.soundFiles = new string[4];

                soundsPlaySoundsCheckBox.Checked = GuiOptions.Instanse.PlaySounds;
                if (GuiOptions.Instanse.PlaySoundsTime < soundsPlayTimeNumericUpDown.Minimum || GuiOptions.Instanse.PlaySoundsTime > soundsPlayTimeNumericUpDown.Maximum)
                {
                    soundsPlayTimeNumericUpDown.Value = 30;
                }
                else
                {
                    soundsPlayTimeNumericUpDown.Value = GuiOptions.Instanse.PlaySoundsTime;
                }

                soundsPlaySoundsCheckedListBox.SetItemChecked(0, GuiOptions.Instanse.PlaySoundsAtTaskStarted);
                this.soundFiles[0] = GuiOptions.Instanse.PlaySoundsAtTaskStartedFile;
                soundsPlaySoundsCheckedListBox.SetItemChecked(1, GuiOptions.Instanse.PlaySoundsAtTaskFailed);
                this.soundFiles[1] = GuiOptions.Instanse.PlaySoundsAtTaskFailedFile;
                soundsPlaySoundsCheckedListBox.SetItemChecked(2, GuiOptions.Instanse.PlaySoundsAtTaskFinished);
                this.soundFiles[2] = GuiOptions.Instanse.PlaySoundsAtTaskFinishedFile;
                soundsPlaySoundsCheckedListBox.SetItemChecked(2, GuiOptions.Instanse.PlaySoundsAtNoTask);
                this.soundFiles[3] = GuiOptions.Instanse.PlaySoundsAtNoTaskFile;
            }
            catch (Exception)
            {
                WinHelper.MessageBox("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Events
            this.baloonsShowBaloonsCheckBox_CheckedChanged(null, null);
            this.soundsPlaySoundsCheckBox_CheckedChanged(null, null);
            this.soundsPlaySoundsCheckedListBox_SelectedIndexChanged(null, null);
        }

        private void applyButtonClick(object sender, EventArgs e)
        {
            GuiOptions.Instanse.Notifications = baloonsShowBaloonsCheckBox.Checked;
            GuiOptions.Instanse.NotificationsTime = (int)baloonsShowTimeNumericUpDown.Value;

            GuiOptions.Instanse.NotificationsAtTaskStarted = baloonsShowBaloonsCheckedListBox.GetItemChecked(0);
            GuiOptions.Instanse.NotificationsAtTaskFailed = baloonsShowBaloonsCheckedListBox.GetItemChecked(1);
            GuiOptions.Instanse.NotificationsAtTaskFinished = baloonsShowBaloonsCheckedListBox.GetItemChecked(2);
            GuiOptions.Instanse.NotificationsAtNoTask = baloonsShowBaloonsCheckedListBox.GetItemChecked(3);

            // Sounds
            GuiOptions.Instanse.PlaySounds = soundsPlaySoundsCheckBox.Checked;
            GuiOptions.Instanse.PlaySoundsTime = (int)soundsPlayTimeNumericUpDown.Value;

            GuiOptions.Instanse.PlaySoundsAtTaskStarted = soundsPlaySoundsCheckedListBox.GetItemChecked(0);
            GuiOptions.Instanse.PlaySoundsAtTaskStartedFile = this.soundFiles[0];
            GuiOptions.Instanse.PlaySoundsAtTaskFailed = soundsPlaySoundsCheckedListBox.GetItemChecked(1);
            GuiOptions.Instanse.PlaySoundsAtTaskFailedFile = this.soundFiles[1];
            GuiOptions.Instanse.PlaySoundsAtTaskFinished = soundsPlaySoundsCheckedListBox.GetItemChecked(2);
            GuiOptions.Instanse.PlaySoundsAtTaskFinishedFile = this.soundFiles[2];
            GuiOptions.Instanse.PlaySoundsAtNoTask = soundsPlaySoundsCheckedListBox.GetItemChecked(3);
            GuiOptions.Instanse.PlaySoundsAtNoTaskFile = this.soundFiles[3];

            // Saving
            GuiOptions.Instanse.Save();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void baloonsShowBaloonsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (baloonsShowBaloonsCheckBox.Checked)
            {
                baloonsShowTimeNumericUpDown.Enabled = true;
                baloonsShowBaloonsCheckedListBox.Enabled = true;
            }
            else
            {
                baloonsShowTimeNumericUpDown.Enabled = false;
                baloonsShowBaloonsCheckedListBox.Enabled = false;
            }
        }

        private void soundsPlaySoundsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (soundsPlaySoundsCheckBox.Checked)
            {
                soundsPlayTimeNumericUpDown.Enabled = true;
                soundsPlaySoundsCheckedListBox.Enabled = true;
            }
            else
            {
                soundsPlayTimeNumericUpDown.Enabled = false;
                soundsPlaySoundsCheckedListBox.Enabled = false;
            }
        }

        private void soundsPlaySoundsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (soundsPlaySoundsCheckedListBox.SelectedIndex == -1 || !soundsPlaySoundsCheckBox.Checked)
            {
                soundsFileLabel.Enabled = false;
                soundsFileTextBox.Enabled = false;
                soundsFileButton.Enabled = false;
            }
            else
            {
                soundsFileLabel.Enabled = true;
                soundsFileTextBox.Enabled = true;
                soundsFileButton.Enabled = true;
            }
            if (soundsPlaySoundsCheckedListBox.SelectedIndex != -1)
            {
                soundsFileTextBox.Text = this.soundFiles[soundsPlaySoundsCheckedListBox.SelectedIndex];
            }
        }

        private void soundsFileButton_Click(object sender, EventArgs e)
        {
            soundsFileOpenFileDialog.FileName = string.Empty;
            soundsFileOpenFileDialog.ShowDialog();

            if (soundsFileOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            soundsFileTextBox.Text = soundsFileOpenFileDialog.FileName;
        }

        private string[] soundFiles;

        private void soundsFileTextBox_TextChanged(object sender, EventArgs e)
        {
            this.soundFiles[soundsPlaySoundsCheckedListBox.SelectedIndex] = soundsFileTextBox.Text;
        }

        private void soundsPlayButton_Click(object sender, EventArgs e)
        {
            Player.Instanse.Play(soundsFileTextBox.Text, (int)soundsPlayTimeNumericUpDown.Value, false);
        }

        private void soundsStopButton_Click(object sender, EventArgs e)
        {
            Player.Instanse.Stop();
        }
    }
}
