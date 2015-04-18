using System;
using System.Windows.Forms;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Tasks;
using Umax.Plugins.Tasks.Enums;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class EntranceTabPageControl : UserControl
    {
        public EntranceTabPageControl()
        {
            InitializeComponent();
        }

        protected ITask task;

        /// <summary>
        /// Sets task
        /// </summary>
        public ITask Task
        {
            get { return this.task; }
            set
            {
                this.task = value;

                this.UpdateControl();
            }
        }

        public virtual void CollectSettings()
        {
            switch (generalTypeComboBox.SelectedIndex)
            {
                // Redirect
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).Entrance = EntranceType.Redirect;
                        break;
                    }

                // Frame
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).Entrance = EntranceType.Frame;
                        break;
                    }

                // Other
                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).Entrance = EntranceType.Custom;
                        break;
                    }
            }

            switch (insertTypeComboBox.SelectedIndex)
            {
                // Insert
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).EntranceInsert = EntranceInsertType.Direct;
                        break;
                    }

                // Insert via document.write
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).EntranceInsert = EntranceInsertType.DocumentWrite;
                        break;
                    }

                // Insert as external .js file
                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).EntranceInsert = EntranceInsertType.ExternalJavaScript;
                        break;
                    }
            }

            (this.Task.Executor.Settings as TaskSettings).EntranceAcceptorURL = generalURLTextBox.Text;

            (this.Task.Executor.Settings as TaskSettings).EntranceJSEncrypt = encryptCheckBox.Checked;

            switch (acceptorAdressComboBox.SelectedIndex)
            {
                // Static
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).EntranceAcceptor = EntranceAcceptorType.Static;
                        break;
                    }

                // Dynamic
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).EntranceAcceptor = EntranceAcceptorType.Dynamic;
                        break;
                    }
            }

            (this.Task.Executor.Settings as TaskSettings).EntranceCode = codeTextBox.Text;
        }

        protected virtual void generalComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshControls();
        }

        protected virtual void RefreshControls()
        {
            switch (generalTypeComboBox.SelectedIndex)
            {
                // Redirect
                case 0:
                    {
                        if (insertTypeComboBox.SelectedIndex == 0)
                        {
                            encryptCheckBox.Checked = false;
                            encryptCheckBox.Enabled = false;
                        }
                        else
                        {
                            encryptCheckBox.Enabled = true;
                        }

                        if (acceptorAdressComboBox.SelectedIndex == 0)
                        {
                            codeTextBox.Text = "<script language='javascript'>document.location='" + generalURLTextBox.Text + "';</script>";
                        }
                        else
                        {
                            codeTextBox.Text = "<script language='javascript'>document.location='" + generalURLTextBox.Text + "[PLUSKEYWORD]';</script>";
                        }

                        acceptorAdressComboBox.Enabled = true;
                        break;
                    }

                // Frame
                case 1:
                    {
                        if (insertTypeComboBox.SelectedIndex == 0)
                        {
                            encryptCheckBox.Checked = false;
                            encryptCheckBox.Enabled = false;
                        }
                        else
                        {
                            encryptCheckBox.Enabled = true;
                        }

                        if (acceptorAdressComboBox.SelectedIndex == 0)
                        {
                            codeTextBox.Text = "<script language='javascript'>var Addr = '" + generalURLTextBox.Text + "';document.write('<iframe src=' + Addr + ' width=\"100%\" height=\"100%\" frameborder=\"NO\" border=\"0\" framespacing=\"0\" scrolling=\"NO\"></iframe>');document.write(\"<script language='javascript'>document.delete();<script>\");</script>";
                        }
                        else
                        {
                            codeTextBox.Text = "<script language='javascript'>var Addr = '" + generalURLTextBox.Text + "[PLUSKEYWORD]';document.write('<iframe src=' + Addr + ' width=\"100%\" height=\"100%\" frameborder=\"NO\" border=\"0\" framespacing=\"0\" scrolling=\"NO\"></iframe>');document.write(\"<script language='javascript'>document.delete();<script>\");</script>";
                        }

                        acceptorAdressComboBox.Enabled = true;
                        break;
                    }

                // Other
                case 2:
                    {
                        if (insertTypeComboBox.SelectedIndex == 0)
                        {
                            encryptCheckBox.Checked = false;
                            encryptCheckBox.Enabled = false;
                        }
                        else
                        {
                            encryptCheckBox.Enabled = true;
                        }

                        acceptorAdressComboBox.SelectedIndex = 0;
                        acceptorAdressComboBox.Enabled = false;

                        codeTextBox.Text = string.Empty;
                        break;
                    }
            }
        }

        protected virtual void generalURLTextBoxTextChanged(object sender, EventArgs e)
        {
            this.RefreshControls();
        }

        private void UpdateControl()
        {
            switch ((this.Task.Executor.Settings as TaskSettings).Entrance)
            {
                case EntranceType.Redirect:
                    {
                        generalTypeComboBox.SelectedIndex = 0;
                        break;
                    }

                case EntranceType.Frame:
                    {
                        generalTypeComboBox.SelectedIndex = 1;
                        break;
                    }

                case EntranceType.Custom:
                    {
                        generalTypeComboBox.SelectedIndex = 2;
                        break;
                    }
            }

            switch ((this.Task.Executor.Settings as TaskSettings).EntranceInsert)
            {
                case EntranceInsertType.Direct:
                    {
                        insertTypeComboBox.SelectedIndex = 0;
                        break;
                    }

                case EntranceInsertType.DocumentWrite:
                    {
                        insertTypeComboBox.SelectedIndex = 1;
                        break;
                    }

                case EntranceInsertType.ExternalJavaScript:
                    {
                        insertTypeComboBox.SelectedIndex = 2;
                        break;
                    }
            }

            switch ((this.Task.Executor.Settings as TaskSettings).EntranceAcceptor)
            {
                case EntranceAcceptorType.Static:
                    {
                        acceptorAdressComboBox.SelectedIndex = 0;
                        break;
                    }

                case EntranceAcceptorType.Dynamic:
                    {
                        acceptorAdressComboBox.SelectedIndex = 1;
                        break;
                    }
            }

            encryptCheckBox.Checked = (this.Task.Executor.Settings as TaskSettings).EntranceJSEncrypt;
            codeTextBox.Text = (this.Task.Executor.Settings as TaskSettings).EntranceCode;
        }
    }
}
