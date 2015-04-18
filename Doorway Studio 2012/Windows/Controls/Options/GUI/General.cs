using System;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Windows.Classes;
using Umax.Windows.Enums;

namespace Umax.Windows.Controls.Options.GUI
{
    public partial class OptionsGuiGeneral : UserControl
    {
        public OptionsGuiGeneral()
        {
            InitializeComponent();
        }

        private void OptionsGuiGeneralLoad(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            try
            {
                CheckFXCheckBox.Checked = !GuiOptions.Instanse.NoFxCheck;

                switch (GuiOptions.Instanse.Appearance)
                {
                    case AppearanceType.Classic:
                        {
                            appearanceComboBox.SelectedIndex = 0;
                            break;
                        }

                    case AppearanceType.Modern:
                        {
                            appearanceComboBox.SelectedIndex = 0;
                            break;
                        }
                }

                appearanceNewsCheckBox.Checked = GuiOptions.Instanse.AppearanceNews;
                appearanceGeneralCheckBox.Checked = GuiOptions.Instanse.AppearanceGeneral;
                appearanceLargeCalendarCheckBox.Checked = GuiOptions.Instanse.AppearanceLargeCalendar;

                managerCheckBox.Checked = GuiOptions.Instanse.Manager;
                managerPinCheckBox.Checked = GuiOptions.Instanse.ManagerPin;

                switch (GuiOptions.Instanse.ManagerLocation)
                {
                    case ManagerLocationType.Custom:
                        {
                            managerLocationComboBox.SelectedIndex = 0;
                            break;
                        }
                    case ManagerLocationType.Right:
                        {
                            managerLocationComboBox.SelectedIndex = 1;
                            break;
                        }
                    case ManagerLocationType.Left:
                        {
                            managerLocationComboBox.SelectedIndex = 2;
                            break;
                        }
                }

                // Window
                this.windowPinCheckBox.Checked = GuiOptions.Instanse.TrayWindowPinned;
                this.windowOpacityNumericUpDown.Value = GuiOptions.Instanse.TrayWindowOpacity;
            }
            catch (Exception)
            {
                WinHelper.MessageBox("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void applyButtonClick(object sender, EventArgs e)
        {
            GuiOptions.Instanse.NoFxCheck = !CheckFXCheckBox.Checked;

            switch (appearanceComboBox.SelectedIndex)
            {
                case 0:
                    {
                        GuiOptions.Instanse.Appearance = AppearanceType.Classic;
                        break;
                    }

                case 1:
                    {
                        GuiOptions.Instanse.Appearance = AppearanceType.Modern;
                        break;
                    }
            }

            GuiOptions.Instanse.AppearanceNews = appearanceNewsCheckBox.Checked;
            GuiOptions.Instanse.AppearanceGeneral = appearanceGeneralCheckBox.Checked;
            GuiOptions.Instanse.AppearanceLargeCalendar = appearanceLargeCalendarCheckBox.Checked;

            GuiOptions.Instanse.Manager = managerCheckBox.Checked;
            GuiOptions.Instanse.ManagerPin = managerPinCheckBox.Checked;
            switch (managerLocationComboBox.SelectedIndex)
            {
                case 0:
                    {
                        GuiOptions.Instanse.ManagerLocation = ManagerLocationType.Custom;
                        break;
                    }
                case 1:
                    {
                        GuiOptions.Instanse.ManagerLocation = ManagerLocationType.Right;
                        break;
                    }
                case 2:
                    {
                        GuiOptions.Instanse.ManagerLocation = ManagerLocationType.Left;
                        break;
                    }
            }

            // Window
            GuiOptions.Instanse.TrayWindowPinned = this.windowPinCheckBox.Checked;
            GuiOptions.Instanse.TrayWindowOpacity = (int)this.windowOpacityNumericUpDown.Value;

            // Saving
            GuiOptions.Instanse.Save();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void dotNetLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.microsoft.com/downloads/en/details.aspx?FamilyID=ab99342f-5d1a-413d-8319-81da479ab0d7&displaylang=en");
            }
            catch (Exception) { }
        }

        private void managerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (managerCheckBox.Checked)
            {
                managerLocationLabel.Enabled = true;
                managerPinCheckBox.Enabled = true;
                managerLocationComboBox.Enabled = true;
            }
            else
            {
                managerLocationLabel.Enabled = false;
                managerPinCheckBox.Enabled = false;
                managerLocationComboBox.Enabled = false;
            }
        }
    }
}
