using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Enums;
using Umax.Classes.Helpers;

namespace Umax.Windows.Controls.Options.Core
{
    public partial class OptionsCorePlugIns : UserControl
    {
        public OptionsCorePlugIns()
        {
            InitializeComponent();
        }

        private void OptionsCorePlugInsLoad(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            pluginsDataGridView.Rows.Clear();

            try
            {
                pluginsCheckBox.Checked = global::Core.Classes.Options.Instanse.PluginsEnabled;
                for (int i = 0; i < global::Core.Classes.Options.Instanse.Plugins.Count; i++)
                {
                    pluginsDataGridView.Rows.Add(global::Core.Classes.Options.Instanse.Plugins[i]);
                }
            }
            catch (Exception)
            {
                WinHelper.MessageBox("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Events
            this.pluginsCheckBoxCheckedChanged(null, EventArgs.Empty);
        }

        private void applyButtonClick(object sender, EventArgs e)
        {
            global::Core.Classes.Options.Instanse.PluginsEnabled = pluginsCheckBox.Checked;
            global::Core.Classes.Options.Instanse.Plugins = new List<string>();
            for (int i = 0; i < pluginsDataGridView.Rows.Count; i++)
            {
                if (pluginsDataGridView.Rows[i].Cells[0].Value != null)
                {
                    global::Core.Classes.Options.Instanse.Plugins.Add(
                        pluginsDataGridView.Rows[i].Cells[0].Value.ToString());
                }
            }
        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void pluginsCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            pluginsDataGridView.Enabled = pluginsCheckBox.Checked;
            pluginsToolStrip.Enabled = pluginsCheckBox.Checked;
        }

        private void pluginsAddToolStripButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            pluginsDataGridView.Rows.Add(mainOpenFileDialog.FileName);
        }

        private void pluginsRemoveToolStripButtonClick(object sender, EventArgs e)
        {
            if (pluginsDataGridView.SelectedRows.Count > 0)
            {
                pluginsDataGridView.Rows.RemoveAt(pluginsDataGridView.SelectedRows[0].Index);
            }
        }

        private void pluginsClearToolStripButtonClick(object sender, EventArgs e)
        {
            pluginsDataGridView.Rows.Clear();
        }
    }
}
