using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Umax.Interfaces.Compatibility.Tasks;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using Umax.Plugins.Tasks.Enums;
using Umax.Windows.Classes;
using IO = System.IO;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class GeneralTabPageControl : UserControl
    {
        public GeneralTabPageControl()
        {
            InitializeComponent();
        }

        protected ITask task;

        /// <summary>
        /// Sets task executor
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

        public IWorkSpace WorkSpace
        {
            get
            {
                if (wsComboBox.SelectedIndex == -1)
                {
                    return null;
                }

                return Core.Core.Instanse.Data.Select((wsComboBox.SelectedItem as IDElement).ID, ItemSelectType.ID);
            }
        }

        public event SimpleEventHandler WorkSpaceChanged;

        public event SimpleEventHandler PresetChanged;

        public event SimpleEventHandler TemplateChanged;

        protected virtual void wsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (wsComboBox.SelectedIndex == -1)
            {
                return;
            }

            // Presets
            presetComboBox.Items.Clear();
            for (int i = 0; i < this.WorkSpace.Presets.Count; i++)
            {
                presetComboBox.Items.Add(new IDElement(this.WorkSpace.Presets[i].ID, this.WorkSpace.Presets[i].Name));
            }

            // Templates
            templateComboBox.Items.Clear();
            for (int i = 0; i < this.WorkSpace.Templates.Count; i++)
            {
                templateComboBox.Items.Add(new IDElement(this.WorkSpace.Templates[i].ID, this.WorkSpace.Templates[i].Name));
            }

            if (this.WorkSpaceChanged != null)
            {
                this.WorkSpaceChanged.Invoke();
            }
        }

        protected virtual void presetComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (wsComboBox.SelectedIndex == -1)
            {
                return;
            }

            if (presetComboBox.SelectedIndex == -1)
            {
                return;
            }

            if (this.PresetChanged != null)
            {
                this.PresetChanged.Invoke();
            }
        }

        protected virtual void archiveComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (archiveComboBox.SelectedIndex == 0)
            {
                archiveTextBox.Enabled = false;
            }
            else
            {
                archiveTextBox.Enabled = true;
                if (archiveComboBox.SelectedIndex == 1)
                {
                    archiveTextBox.Text = "archive.zip";
                }
                else if (archiveComboBox.SelectedIndex == 2)
                {
                    archiveTextBox.Text = "archive.tar.gz";
                }
            }
        }

        protected virtual void presetClearPictureBoxClick(object sender, EventArgs e)
        {
            presetComboBox.SelectedIndex = -1;
        }

        public event SimpleEventHandler SitesCountChanged;

        protected virtual void sitesNumericUpDownValueChanged(object sender, EventArgs e)
        {
            if (urlsDataGridView.Rows.Count < sitesNumericUpDown.Value)
            {
                urlsDataGridView.Rows.Add();
            }
            else
            {
                urlsDataGridView.Rows.RemoveAt(urlsDataGridView.Rows.Count - 1);
            }

            if (this.SitesCountChanged != null)
            {
                this.SitesCountChanged.Invoke();
            }
        }

        protected virtual void saveButtonClick(object sender, EventArgs e)
        {
            mainFolderBrowserDialog.SelectedPath = string.Empty;
            mainFolderBrowserDialog.ShowDialog();
            if (mainFolderBrowserDialog.SelectedPath == string.Empty)
            {
                return;
            }

            saveTextBox.Text = mainFolderBrowserDialog.SelectedPath;
        }

        public virtual void ValidateSettings()
        {
            // General
            if (wsComboBox.SelectedIndex == -1)
            {
                throw new Exception("Please select workSpace!");
            }

            if (templateComboBox.SelectedIndex == -1)
            {
                throw new Exception("Please select Template!");
            }

            if (saveTextBox.Text == string.Empty)
            {
                throw new Exception("Please specify path to the directory where results will be saved!");
            }

            if (!IO.Path.IsPathRooted(saveTextBox.Text))
            {
                throw new Exception("Please specify correct path to the directory where results will be saved!");
            }

            if (archiveComboBox.SelectedIndex != 0)
            {
                if (archiveTextBox.Text == string.Empty)
                {
                    throw new Exception("Please specify archive file name!");
                }
            }

            for (int i = 0; i < urlsDataGridView.RowCount; i++)
            {
                if (urlsDataGridView.Rows[i].Cells[0].Value == null)
                {
                    throw new Exception("Please specify URL!");
                }

                if (string.IsNullOrEmpty(urlsDataGridView.Rows[i].Cells[0].Value.ToString()))
                {
                    throw new Exception("Please specify URL!");
                }
            }
        }

        public virtual void CollectSettings()
        {
            (this.Task.Executor.Settings as TaskSettings).GeneralSiteCount = (int)sitesNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).GeneralThreadCount = (int)threadsNumericUpDown.Value;
            (this.Task.Executor.Settings as TaskSettings).WorkSpaceID = this.WorkSpace.ID;

            (this.Task.Executor.Settings as TaskSettings).PresetID = presetComboBox.SelectedIndex == -1 ? -1 : (presetComboBox.SelectedItem as IDElement).ID;

            (this.Task.Executor.Settings as TaskSettings).TemplateID = (templateComboBox.SelectedItem as IDElement).ID;

            (this.Task.Executor.Settings as TaskSettings).GeneralSavePath = saveTextBox.Text;
            switch (saveSubDirectoriesComboBox.SelectedIndex)
            {
                // None
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).GeneralSubDirectories = SubDirectoriesType.None;
                        break;
                    }

                // Keyword
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).GeneralSubDirectories = SubDirectoriesType.Keyword;
                        break;
                    }

                // Number
                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).GeneralSubDirectories = SubDirectoriesType.Number;
                        break;
                    }

                // Keyword + Number
                case 3:
                    {
                        (this.Task.Executor.Settings as TaskSettings).GeneralSubDirectories = SubDirectoriesType.KeywordNumber;
                        break;
                    }

                // URL
                case 4:
                    {
                        (this.Task.Executor.Settings as TaskSettings).GeneralSubDirectories = SubDirectoriesType.URL;
                        break;
                    }
            }
            switch (archiveComboBox.SelectedIndex)
            {
                // None
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).GeneralArchive = ArchiveType.None;
                        break;
                    }

                // Zip
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).GeneralArchive = ArchiveType.Zip;
                        break;
                    }

                // Tar.gz
                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).GeneralArchive = ArchiveType.TarGz;
                        break;
                    }
            }

            (this.Task.Executor.Settings as TaskSettings).GeneralFileDirectoryModificationStartTime = dateTimeStartDateTimePicker.Value;
            (this.Task.Executor.Settings as TaskSettings).GeneralFileDirectoryModificationEndTime = dateTimeEndDateTimePicker.Value;

            (this.Task.Executor.Settings as TaskSettings).GeneralArchiveName = archiveTextBox.Text;
            (this.Task.Executor.Settings as TaskSettings).GeneralUrls = new List<string>();
            for (int i = 0; i < urlsDataGridView.RowCount; i++)
            {
                if (urlsDataGridView.Rows[i].Cells[0].Value == null)
                {
                    continue;
                }

                (this.Task.Executor.Settings as TaskSettings).GeneralUrls.Add(urlsDataGridView.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void templateComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (wsComboBox.SelectedIndex == -1)
            {
                return;
            }

            if (templateComboBox.SelectedIndex == -1)
            {
                return;
            }

            if (this.TemplateChanged != null)
            {
                this.TemplateChanged.Invoke();
            }
        }

        private void GeneralTabPageControlLoad(object sender, EventArgs e)
        {
            presetClearPictureBox.Image = Resources.Resources.Delete;
            urlsOpenToolStripButton.Image = Resources.Resources.Folder;
            urlsClearToolStripButton.Image = Resources.Resources.Delete;

            if (this.EditType != TaskEditType.None)
            {
                wsComboBox.Enabled = false;
            }
        }

        private void urlsOpenToolStripButtonClick(object sender, EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            string[] items = IO.File.ReadAllLines(mainOpenFileDialog.FileName, Encoding.Default);

            for (int i = 0; i < urlsDataGridView.Rows.Count; i++)
            {
                if (i < items.Length)
                {
                    urlsDataGridView.Rows[i].Cells[0].Value = items[i];
                }
                else
                {
                    break;
                }
            }
        }

        private void urlsClearToolStripButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < urlsDataGridView.Rows.Count; i++)
            {
                urlsDataGridView.Rows[i].Cells[0].Value = string.Empty;
            }
        }

        public TaskEditType EditType { get; set; }

        private void UpdateControl()
        {
            sitesNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).GeneralSiteCount;
            threadsNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).GeneralThreadCount;

            this.sitesNumericUpDownValueChanged(this, EventArgs.Empty);

            for (int i = 0; i < sitesNumericUpDown.Value; i++)
            {
                if (i < (this.Task.Executor.Settings as TaskSettings).GeneralUrls.Count)
                {
                    urlsDataGridView.Rows[i].Cells[0].Value = (this.Task.Executor.Settings as TaskSettings).GeneralUrls[i];
                }
            }

            // Fill and apply selected workspace
            // Fill will execute fill of templates and presets
            for (int i = 0; i < (this.Task.Executor as ITaskDataCompatible).Data.Count; i++)
            {
                wsComboBox.Items.Add(new IDElement((this.Task.Executor as ITaskDataCompatible).Data[i].ID, (this.Task.Executor as ITaskDataCompatible).Data[i].Name));
            }

            if ((this.Task.Executor.Settings as TaskSettings).WorkSpaceID != -1)
            {
                for (int i = 0; i < wsComboBox.Items.Count; i++)
                {
                    if ((wsComboBox.Items[i] as IDElement).ID == (this.Task.Executor.Settings as TaskSettings).WorkSpaceID)
                    {
                        wsComboBox.SelectedIndex = i;
                        break;
                    }
                }
            }

            // If workspace was selected than try to select template and preset
            if ((this.Task.Executor.Settings as TaskSettings).WorkSpaceID != -1 && wsComboBox.SelectedIndex != -1)
            {
                int workSpaceIndex = (this.Task.Executor as ITaskDataCompatible).Data.Items.IndexOf((wsComboBox.SelectedItem as IDElement).ID);

                if (workSpaceIndex != -1)
                {
                    for (int i = 0; i < (this.Task.Executor as ITaskDataCompatible).Data[workSpaceIndex].Templates.Count; i++)
                    {
                        if ((this.Task.Executor.Settings as TaskSettings).TemplateID == (templateComboBox.SelectedItem as IDElement).ID)
                        {
                            templateComboBox.SelectedIndex = i;
                            break;
                        }
                    }

                    for (int i = 0; i < (this.Task.Executor as ITaskDataCompatible).Data[workSpaceIndex].Presets.Count; i++)
                    {
                        if ((this.Task.Executor.Settings as TaskSettings).PresetID == (presetComboBox.SelectedItem as IDElement).ID)
                        {
                            presetComboBox.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }

            // Fill rest of controls
            saveTextBox.Text = (this.Task.Executor.Settings as TaskSettings).GeneralSavePath;
            switch ((this.Task.Executor.Settings as TaskSettings).GeneralSubDirectories)
            {
                case SubDirectoriesType.None:
                    {
                        saveSubDirectoriesComboBox.SelectedIndex = 0;
                        break;
                    }

                case SubDirectoriesType.Keyword:
                    {
                        saveSubDirectoriesComboBox.SelectedIndex = 1;
                        break;
                    }

                case SubDirectoriesType.Number:
                    {
                        saveSubDirectoriesComboBox.SelectedIndex = 2;
                        break;
                    }

                case SubDirectoriesType.KeywordNumber:
                    {
                        saveSubDirectoriesComboBox.SelectedIndex = 3;
                        break;
                    }

                case SubDirectoriesType.URL:
                    {
                        saveSubDirectoriesComboBox.SelectedIndex = 4;
                        break;
                    }
            }

            dateTimeStartDateTimePicker.Value = (this.Task.Executor.Settings as TaskSettings).GeneralFileDirectoryModificationStartTime;
            dateTimeEndDateTimePicker.Value = (this.Task.Executor.Settings as TaskSettings).GeneralFileDirectoryModificationEndTime;

            switch ((this.Task.Executor.Settings as TaskSettings).GeneralArchive)
            {
                case ArchiveType.None:
                    {
                        archiveComboBox.SelectedIndex = 0;
                        break;
                    }

                case ArchiveType.Zip:
                    {
                        archiveComboBox.SelectedIndex = 1;
                        break;
                    }

                case ArchiveType.TarGz:
                    {
                        archiveComboBox.SelectedIndex = 2;
                        break;
                    }
            }

            archiveTextBox.Text = (this.Task.Executor.Settings as TaskSettings).GeneralArchiveName;
        }
    }
}
