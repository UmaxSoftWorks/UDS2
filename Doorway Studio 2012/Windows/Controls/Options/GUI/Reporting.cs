using System;
using System.Windows.Forms;
using Umax.Classes.Helpers;
using Umax.Windows.Classes;

namespace Umax.Windows.Controls.Options.GUI
{
    public partial class OptionsGuiReporting : UserControl
    {
        public OptionsGuiReporting()
        {
            InitializeComponent();
        }

        private void reportingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fromTextBox.Enabled = reportingCheckBox.Checked;
            toTextBox.Enabled = reportingCheckBox.Checked;
            subjectTextBox.Enabled = reportingCheckBox.Checked;
            messageTextBox.Enabled = reportingCheckBox.Checked;

            hostTextBox.Enabled = reportingCheckBox.Checked;
            portNumericUpDown.Enabled = reportingCheckBox.Checked;
            loginTextBox.Enabled = reportingCheckBox.Checked;
            passwordTextBox.Enabled = reportingCheckBox.Checked;

            attachLogsCheckBox.Enabled = reportingCheckBox.Checked;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            GuiOptions.Instanse.Report = reportingCheckBox.Checked;
            GuiOptions.Instanse.ReportRnD = reportRDCheckBox.Checked;

            GuiOptions.Instanse.ReportFrom = fromTextBox.Text;
            GuiOptions.Instanse.ReportTo = toTextBox.Text;
            GuiOptions.Instanse.ReportSubject = subjectTextBox.Text;
            GuiOptions.Instanse.ReportMessage = messageTextBox.Text;

            GuiOptions.Instanse.ReportHost = hostTextBox.Text;
            GuiOptions.Instanse.ReportPort = (int)portNumericUpDown.Value;
            GuiOptions.Instanse.ReportLogin = loginTextBox.Text;
            GuiOptions.Instanse.ReportPassword = passwordTextBox.Text;

            GuiOptions.Instanse.ReportAttachments = attachLogsCheckBox.Checked;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void OptionsGuiReporting_Load(object sender, EventArgs e)
        {
            this.Initialize();

            // Events
            this.reportingCheckBox_CheckedChanged(null, null);
        }

        private void Initialize()
        {
            try
            {
                reportingCheckBox.Checked = GuiOptions.Instanse.Report;
                reportRDCheckBox.Checked = GuiOptions.Instanse.ReportRnD;

                fromTextBox.Text = GuiOptions.Instanse.ReportFrom;
                toTextBox.Text = GuiOptions.Instanse.ReportTo;
                subjectTextBox.Text = GuiOptions.Instanse.ReportSubject;
                messageTextBox.Text = GuiOptions.Instanse.ReportMessage;

                hostTextBox.Text = GuiOptions.Instanse.ReportHost;
                portNumericUpDown.Value = GuiOptions.Instanse.ReportPort;
                loginTextBox.Text = GuiOptions.Instanse.ReportLogin;
                passwordTextBox.Text = GuiOptions.Instanse.ReportPassword;

                attachLogsCheckBox.Checked = GuiOptions.Instanse.ReportAttachments;
            }
            catch (Exception)
            {
                WinHelper.MessageBox("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
