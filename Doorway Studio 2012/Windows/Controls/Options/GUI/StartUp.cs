using System;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Windows.Classes;

namespace Umax.Windows.Controls.Options.GUI
{
    public partial class OptionsGuiStartUp : UserControl
    {
        public OptionsGuiStartUp()
        {
            InitializeComponent();
        }

        private void OptionsGuiStartUp_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            generalMinimizedStartCheckBox.Checked = GuiOptions.Instanse.MinimizedStart;
            generalAutoStartCheckBox.Checked = GuiOptions.Instanse.AutoStart;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            GuiOptions.Instanse.MinimizedStart = generalMinimizedStartCheckBox.Checked;
            GuiOptions.Instanse.AutoStart = generalAutoStartCheckBox.Checked;

            // Saving
            GuiOptions.Instanse.Save();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void generalAutoStartCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (generalAutoStartCheckBox.Checked)
            {
                WinHelper.WriteRegistryKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "Doorway Studio 2012", Application.ExecutablePath);
            }
            else
            {
                WinHelper.RemoveRegistryKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "Doorway Studio 2012");
            }
        }
    }
}
