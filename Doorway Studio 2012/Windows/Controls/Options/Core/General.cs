using System;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;

namespace Umax.Windows.Controls.Options.Core
{
    public partial class OptionsCoreGeneral : UserControl
    {
        public OptionsCoreGeneral()
        {
            InitializeComponent();
        }

        private void OptionsCoreGeneralLoad(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            try
            {
                switch (global::Core.Classes.Options.Instanse.Language)
                {
                    case LanguageType.English:
                        {
                            generalLanguageComboBox.SelectedIndex = 0;
                            break;
                        }

                    case LanguageType.Russian:
                        {
                            generalLanguageComboBox.SelectedIndex = 1;
                            break;
                        }
                }

                timeoutCheckBox.Checked = global::Core.Classes.Options.Instanse.TimeoutEnabled;
                timeoutNumericUpDown.Value = global::Core.Classes.Options.Instanse.Timeout;

                paralellizationTasksNumericUpDown.Value = global::Core.Classes.Options.Instanse.MaximumConcurentTasks;
            }
            catch (Exception)
            {
                WinHelper.MessageBox("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Events
        }

        private void applyButtonClick(object sender, EventArgs e)
        {
            switch (generalLanguageComboBox.SelectedIndex)
            {
                case 0:
                    {
                        global::Core.Classes.Options.Instanse.Language = LanguageType.English;
                        break;
                    }

                case 1:
                    {
                        global::Core.Classes.Options.Instanse.Language = LanguageType.Russian;
                        break;
                    }
            }

            global::Core.Classes.Options.Instanse.TimeoutEnabled = timeoutCheckBox.Checked;
            global::Core.Classes.Options.Instanse.Timeout = (int)timeoutNumericUpDown.Value;

            global::Core.Classes.Options.Instanse.MaximumConcurentTasks = (int) paralellizationTasksNumericUpDown.Value;
        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void timeoutCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            timeoutNumericUpDown.Enabled = timeoutCheckBox.Checked;
        }
    }
}
