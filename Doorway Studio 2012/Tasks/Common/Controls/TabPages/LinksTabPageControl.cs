using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Umax.Interfaces.Containers.Items;
using Umax.Plugins.Tasks.Enums;
using IO = System.IO;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class LinksTabPageControl : UserControl
    {
        public LinksTabPageControl()
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

        public virtual void ValidateSettings()
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (dataGridView.Rows[i].Cells[0] == null)
                {
                    throw new Exception("Please specify links template!");
                }

                if (string.IsNullOrEmpty(dataGridView.Rows[i].Cells[0].Value.ToString()))
                {
                    throw new Exception("Please specify links template!");
                }
            }

            if (saveComboBox.SelectedIndex != 0)
            {
                if (savePathTextBox.Text == string.Empty)
                {
                    throw new Exception("Please specify path to the directory where links will be saved!");
                }
            }
        }

        protected virtual void addToolStripButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows.Add();
        }

        protected virtual void removeToolStripButtonClick(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
            }
        }

        private void clearToolStripButtonClick(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
        }

        protected virtual void saveComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (saveComboBox.SelectedIndex == 0)
            {
                saveEncodingComboBox.Enabled = false;
                savePathTextBox.Enabled = false;
                saveButton.Enabled = false;
            }
            else
            {
                saveEncodingComboBox.Enabled = true;
                savePathTextBox.Enabled = true;
                saveButton.Enabled = true;
            }
        }

        protected virtual void saveButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }
            savePathTextBox.Text = mainSaveFileDialog.FileName;
        }

        public virtual void CollectSettings()
        {
            (this.Task.Executor.Settings as TaskSettings).Links = new List<string>();
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value == null)
                {
                    continue;
                }

                (this.Task.Executor.Settings as TaskSettings).Links.Add(
                    (string.IsNullOrEmpty(dataGridView.Rows[i].Cells[0].Value.ToString()))
                        ? string.Empty
                        : dataGridView.Rows[i].Cells[0].Value.ToString());
            }

            switch (saveComboBox.SelectedIndex)
            {
                    // Don't save
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).LinksSave = LinksSaveType.DontSave;
                        break;
                    }

                    // One file/Site
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).LinksSave = LinksSaveType.OneFilePerSite;
                        break;
                    }

                    // Many files/Site
                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).LinksSave = LinksSaveType.ManyFilesPerSite;
                        break;
                    }

                    // One file/Sites
                case 3:
                    {
                        (this.Task.Executor.Settings as TaskSettings).LinksSave = LinksSaveType.OneFilePerTask;
                        break;
                    }

                    // Many files/Sites
                case 4:
                    {
                        (this.Task.Executor.Settings as TaskSettings).LinksSave = LinksSaveType.ManyFilesPerTask;
                        break;
                    }
            }

            (this.Task.Executor.Settings as TaskSettings).LinksSavePath = savePathTextBox.Text;

            switch (saveEncodingComboBox.SelectedIndex)
            {
                    // ANSI
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).LinksSaveEncoding = EncodingType.ANSI;
                        break;
                    }

                    // UTF-8
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).LinksSaveEncoding = EncodingType.UTF8;
                        break;
                    }
            }
        }

        private void LinksTabPageControlLoad(object sender, EventArgs e)
        {
            addToolStripButton.Image = Resources.Resources.PlusBlue;
            removeToolStripButton.Image = Resources.Resources.MinusBlue;
            openToolStripButton.Image = Resources.Resources.Folder;
            clearToolStripButton.Image = Resources.Resources.Delete;
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

            dataGridView.Rows.Clear();

            for (int i = 0; i < items.Length; i++)
            {
                dataGridView.Rows.Add(items[i]);
            }
        }

        private void UpdateControl()
        {
            for (int i = 0; i < (this.Task.Executor.Settings as TaskSettings).Links.Count; i++)
            {
                dataGridView.Rows.Add((this.Task.Executor.Settings as TaskSettings).Links[i]);
            }

            switch ((this.Task.Executor.Settings as TaskSettings).LinksSave)
            {
                case LinksSaveType.DontSave:
                    {
                        saveComboBox.SelectedIndex = 0;
                        break;
                    }
                case LinksSaveType.OneFilePerSite:
                    {
                        saveComboBox.SelectedIndex = 1;
                        break;
                    }
                case LinksSaveType.ManyFilesPerSite:
                    {
                        saveComboBox.SelectedIndex = 2;
                        break;
                    }
                case LinksSaveType.OneFilePerTask:
                    {
                        saveComboBox.SelectedIndex = 3;
                        break;
                    }

                case LinksSaveType.ManyFilesPerTask:
                    {
                        saveComboBox.SelectedIndex = 4;
                        break;
                    }
            }

            switch ((this.Task.Executor.Settings as TaskSettings).LinksSaveEncoding)
            {
                case EncodingType.ANSI:
                    {
                        saveEncodingComboBox.SelectedIndex = 0;
                        break;
                    }

                case EncodingType.UTF8:
                    {
                        saveEncodingComboBox.SelectedIndex = 0;
                        break;
                    }
            }

            savePathTextBox.Text = (this.Task.Executor.Settings as TaskSettings).LinksSavePath;
        }
    }
}
