using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Tasks;
using Umax.Plugins.Tasks.Classes;
using Umax.Plugins.Tasks.Enums;
using IO = System.IO;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class FTPTabPageControl : UserControl
    {
        public FTPTabPageControl()
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

        public int SitesCount
        {
            set
            {
                if (dataDataGridView.Rows.Count < value)
                {
                    dataDataGridView.Rows.Add();
                }
                else
                {
                    dataDataGridView.Rows.RemoveAt(dataDataGridView.Rows.Count - 1);
                }
            }
        }

        public virtual void ValidateSettings()
        {
            if (generalComboBox.SelectedIndex == 0)
            {
                return;
            }

            if (generalComboBox.SelectedIndex == 1)
            {
                for (int i = 0; i < dataDataGridView.RowCount; i++)
                {
                    if (dataDataGridView.Rows[i].Cells[0] == null || dataDataGridView.Rows[i].Cells[1] == null ||
                        dataDataGridView.Rows[i].Cells[2] == null || dataDataGridView.Rows[i].Cells[3] == null)
                    {
                        throw new Exception("Please specify FTP data!");
                    }

                    if (string.IsNullOrEmpty(dataDataGridView.Rows[i].Cells[0].Value.ToString()) || string.IsNullOrEmpty(dataDataGridView.Rows[i].Cells[1].Value.ToString()) ||
                        string.IsNullOrEmpty(dataDataGridView.Rows[i].Cells[2].Value.ToString()) || string.IsNullOrEmpty(dataDataGridView.Rows[i].Cells[3].Value.ToString()))
                    {
                        throw new Exception("Please specify FTP data!");
                    }
                }
            }
            else
            {
                if (generalExportPathTextBox.Text == string.Empty)
                {
                    throw new Exception("Please specify path to the directory where FileZilla projects will be saved!");
                }
            }
        }

        public virtual void CollectSettings()
        {
            switch (generalComboBox.SelectedIndex)
            {
                // None
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).FTP = FTPType.None;
                        break;
                    }

                // Standard
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).FTP = FTPType.Standard;
                        break;
                    }

                // FileZilla
                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).FTP = FTPType.FileZilla;
                        break;
                    }
            }

            (this.Task.Executor.Settings as TaskSettings).FTPDeleteWhenUpload = generalDeleteAfterUploadСheckBox.Checked;
            (this.Task.Executor.Settings as TaskSettings).FTPExportPath = generalExportPathTextBox.Text;

            (this.Task.Executor.Settings as TaskSettings).FTPData = new List<FTPConnection>();
            for (int i = 0; i < dataDataGridView.RowCount; i++)
            {
                if (dataDataGridView.Rows[i].Cells[0].Value == null || dataDataGridView.Rows[i].Cells[1].Value == null ||
                    dataDataGridView.Rows[i].Cells[2].Value == null || dataDataGridView.Rows[i].Cells[3].Value == null)
                {
                    continue;
                }

                if (((!string.IsNullOrEmpty(dataDataGridView.Rows[i].Cells[0].Value.ToString()) && !string.IsNullOrEmpty(dataDataGridView.Rows[i].Cells[1].Value.ToString())) &&
                     !string.IsNullOrEmpty(dataDataGridView.Rows[i].Cells[2].Value.ToString())) && !string.IsNullOrEmpty(dataDataGridView.Rows[i].Cells[3].Value.ToString()))
                {
                    (this.Task.Executor.Settings as TaskSettings).FTPData.Add(new FTPConnection
                                                                                  {
                                                                                      Host = dataDataGridView.Rows[i].Cells[0].Value.ToString(),
                                                                                      UserName = dataDataGridView.Rows[i].Cells[1].Value.ToString(),
                                                                                      Password = dataDataGridView.Rows[i].Cells[2].Value.ToString(),
                                                                                      RemoteDirectory = dataDataGridView.Rows[i].Cells[3].Value.ToString()
                                                                                  });
                }
            }
        }

        protected virtual void generalComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (generalComboBox.SelectedIndex == 0)
            {
                generalDeleteAfterUploadСheckBox.Enabled = false;
                generalExportPathTextBox.Enabled = false;
                generalButton.Enabled = false;
                mainToolStrip.Enabled = false;
                dataDataGridView.Enabled = false;
            }
            else
            {
                if (generalComboBox.SelectedIndex == 1)
                {
                    generalDeleteAfterUploadСheckBox.Enabled = true;
                    generalExportPathTextBox.Enabled = false;
                    generalButton.Enabled = false;
                }
                else
                {
                    generalDeleteAfterUploadСheckBox.Enabled = false;
                    generalExportPathTextBox.Enabled = true;
                    generalButton.Enabled = true;
                }

                mainToolStrip.Enabled = true;
                dataDataGridView.Enabled = true;
            }
        }

        protected virtual void generalButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            generalExportPathTextBox.Text = mainOpenFileDialog.FileName;
        }

        private void FTPTabPageControlLoad(object sender, EventArgs e)
        {
            openToolStripButton.Image = Umax.Resources.Resources.Folder;
            clearToolStripButton.Image = Umax.Resources.Resources.Delete;
        }

        private void openToolStripButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            string[] items = IO.File.ReadAllLines(mainOpenFileDialog.FileName, Encoding.Default);

            for (int i = 0; i < dataDataGridView.Rows.Count; i++)
            {
                if (i < items.Length)
                {
                    string[] parts = items[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Clear row data
                    for (int k = 0; k < dataDataGridView.Rows[i].Cells.Count; k++)
                    {
                        dataDataGridView.Rows[i].Cells[k].Value = string.Empty;
                    }

                    // Insert new data
                    for (int k = 0; k < parts.Length; k++)
                    {
                        for (int l = 0; l < dataDataGridView.Rows[i].Cells.Count; l++)
                        {
                            if (l < parts.Length)
                            {
                                dataDataGridView.Rows[i].Cells[k].Value = parts[k];
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void clearToolStripButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < dataDataGridView.Rows.Count; i++)
            {
                dataDataGridView.Rows[i].Cells[0].Value = string.Empty;
                dataDataGridView.Rows[i].Cells[1].Value = string.Empty;
                dataDataGridView.Rows[i].Cells[2].Value = string.Empty;
                dataDataGridView.Rows[i].Cells[3].Value = string.Empty;
            }
        }

        private void UpdateControl()
        {
            switch ((this.Task.Executor.Settings as TaskSettings).FTP)
            {
                case FTPType.None:
                    {
                        generalComboBox.SelectedIndex = 0;
                        break;
                    }

                case FTPType.Standard:
                    {
                        generalComboBox.SelectedIndex = 1;
                        break;
                    }

                case FTPType.FileZilla:
                    {
                        generalComboBox.SelectedIndex = 2;
                        break;
                    }
            }

            generalExportPathTextBox.Text = (this.Task.Executor.Settings as TaskSettings).FTPExportPath;
            generalDeleteAfterUploadСheckBox.Checked = (this.Task.Executor.Settings as TaskSettings).FTPDeleteWhenUpload;

            for (int i = 0; i < (this.Task.Executor.Settings as TaskSettings).FTPData.Count; i++)
            {
                dataDataGridView.Rows.Add((this.Task.Executor.Settings as TaskSettings).FTPData[i].Host,
                                          (this.Task.Executor.Settings as TaskSettings).FTPData[i].UserName,
                                          (this.Task.Executor.Settings as TaskSettings).FTPData[i].Password,
                                          (this.Task.Executor.Settings as TaskSettings).FTPData[i].RemoteDirectory);
            }
        }
    }
}