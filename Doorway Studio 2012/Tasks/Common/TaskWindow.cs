using System;
using Core.Classes.Containers.Items;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Plugins.Tasks.Windows;

namespace Umax.Plugins.Tasks.Common
{
    public abstract partial class TaskWindow : StandardTaskWindow
    {
        protected TaskWindow()
        {
            InitializeComponent();
        }

        public override string GUIName
        {
            get
            {
                return "Site";
            }
        }

        public override string ExecutorName { get { return "TaskExecutor"; } }

        protected virtual void TaskWindowLoad(object sender, EventArgs e)
        {
            this.Icon = Resources.Resources.IconGears;

            this.InitializeUI();
            this.ApplySettings();
            this.InitializeEvents();

            this.SitesCountChanged();

            // Update text & image control
            textTabPageControl.UpdateControl();
            imagesTabPageControl.UpdateControl();
        }

        protected virtual void InitializeUI()
        {
            if (this.EditType != TaskEditType.None)
            {
                this.taskGeneralNameTextBox.Enabled = false;
            }
        }

        protected virtual void InitializeEvents()
        {
            generalTabPageControl.WorkSpaceChanged += this.WorkSpaceChanged;
            generalTabPageControl.SitesCountChanged += this.SitesCountChanged;
            generalTabPageControl.PresetChanged += this.PresetChanged;
            generalTabPageControl.TemplateChanged += this.TemplateChanged;

            mapTabPageControl.SiteMapTypeChanged += this.SiteMapTypeChanged;
        }

        protected virtual void SiteMapTypeChanged()
        {
            otherTabPageControl.SiteMap = mapTabPageControl.SiteMapType;
        }

        protected override IWorkSpace WorkSpace { get { return generalTabPageControl.WorkSpace; } }

        protected virtual void WorkSpaceChanged()
        {
            // Keywords & Synonyms & Merge
            keywordsTabPageControl.WorkSpace = generalTabPageControl.WorkSpace;

            // Text
            textTabPageControl.WorkSpace = generalTabPageControl.WorkSpace;

            // Images
            imagesTabPageControl.WorkSpace = generalTabPageControl.WorkSpace;

            // Other
            otherTabPageControl.WorkSpace = generalTabPageControl.WorkSpace;
        }

        protected virtual void PresetChanged()
        {

        }

        protected virtual void TemplateChanged()
        {
            otherTabPageControl.TemplateID = (this.Task.Executor.Settings as TaskSettings).TemplateID;
        }

        protected virtual void SitesCountChanged()
        {
            tokensTabPageControl.SitesCount = (this.Task.Executor.Settings as TaskSettings).GeneralSiteCount;
            tagsTabPageControl.SitesCount = (this.Task.Executor.Settings as TaskSettings).GeneralSiteCount;
            ftpTabPageControl.SitesCount = (this.Task.Executor.Settings as TaskSettings).GeneralSiteCount;
        }

        protected virtual void ApplySettings()
        {
            // Task
            this.ApplySettingsTask();

            // General
            generalTabPageControl.Task = this.Task;
            generalTabPageControl.EditType = this.EditType;

            // Images
            imagesTabPageControl.Task = this.Task;

            // FileTokens
            fileTokensTabPageControl.Task = this.Task;

            // Keywords
            keywordsTabPageControl.Task = this.Task;

            // Categories
            categoriesTabPageControl.Task = this.Task;

            // Map
            mapTabPageControl.Task = this.Task;

            // Pages
            pagesTabPageControl.Task = this.Task;

            // Text
            textTabPageControl.Task = this.Task;

            // Entrance
            entranceTabPageControl.Task = this.Task;
            
            // Tokens
            tokensTabPageControl.Task = this.Task;

            // Other
            otherTabPageControl.Task = this.Task;

            // Links
            linksTabPageControl.Task = this.Task;

            // FTP
            ftpTabPageControl.Task = this.Task;
        }

        protected virtual void ApplySettingsTask()
        {
            taskGeneralNameTextBox.Text = this.Task.Name;
            taskTimeGeneralDateTimePicker.Value = this.Task.StartTime;
            taskScheduleStepNumericUpDown.Value = (this.Task.Executor as TaskExecutor).ScheduleStep;
            switch ((this.Task.Executor as TaskExecutor).Schedule)
            {
                case TaskScheduleType.None:
                    {
                        taskScheduleComboBox.SelectedIndex = 0;
                        break;
                    }

                case TaskScheduleType.Day:
                    {
                        taskScheduleComboBox.SelectedIndex = 1;
                        break;
                    }

                case TaskScheduleType.Week:
                    {
                        taskScheduleComboBox.SelectedIndex = 2;
                        break;
                    }

                case TaskScheduleType.Month:
                    {
                        taskScheduleComboBox.SelectedIndex = 3;
                        break;
                    }

                case TaskScheduleType.Year:
                    {
                        taskScheduleComboBox.SelectedIndex = 4;
                        break;
                    }
            }
        }

        protected virtual void okButtonClick(object sender, EventArgs e)
        {
            // Check settings
            try
            {
                this.ValidateSettings();

                // Apply settings
                (this.Task as Task).Name = taskGeneralNameTextBox.Text;
                this.Task.StartTime = taskTimeGeneralDateTimePicker.Value;
                (this.Task.Executor as TaskExecutor).ScheduleStep = (int)taskScheduleStepNumericUpDown.Value;

                switch (taskScheduleComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            (this.Task.Executor as TaskExecutor).Schedule = TaskScheduleType.None;
                            break;
                        }

                    case 1:
                        {
                            (this.Task.Executor as TaskExecutor).Schedule = TaskScheduleType.Day;
                            break;
                        }

                    case 2:
                        {
                            (this.Task.Executor as TaskExecutor).Schedule = TaskScheduleType.Week;
                            break;
                        }

                    case 3:
                        {
                            (this.Task.Executor as TaskExecutor).Schedule = TaskScheduleType.Month;
                            break;
                        }

                    case 4:
                        {
                            (this.Task.Executor as TaskExecutor).Schedule = TaskScheduleType.Year;
                            break;
                        }
                }

                this.CollectSettings();

                // Images
                (this.Task.Executor as TaskExecutor).ImageMaker = imagesTabPageControl.ImageMaker;

                // Text
                (this.Task.Executor as TaskExecutor).TextMaker = textTabPageControl.TextMaker;
            }
            catch (Exception ex)
            {
                new ErrorReporter()
                    {
                        Message = ex.Message,
                        StackTrace = ex.StackTrace
                    }.ShowDialog();
                return;
            }

            // OK
            this.OK = true;
            Close();
        }

        protected virtual void ValidateSettings()
        {
            // Task
            if (taskGeneralNameTextBox.Text == string.Empty)
            {
                throw new Exception("Task have no name!");
            }

            // General
            generalTabPageControl.ValidateSettings();

            // Images
            imagesTabPageControl.ValidateSettings();

            // File tokens
            fileTokensTabPageControl.ValidateSettings();

            // Keywords
            keywordsTabPageControl.ValidateSettings();

            // Map
            mapTabPageControl.ValidateSettings();

            // Static pages
            pagesTabPageControl.ValidateSettings();

            // Text
            textTabPageControl.ValidateSettings();

            // Links
            linksTabPageControl.ValidateSettings();

            // FTP
            ftpTabPageControl.ValidateSettings();
        }

        protected virtual void CollectSettings()
        {
            // General
            generalTabPageControl.CollectSettings();

            // Images
            imagesTabPageControl.CollectSettings();

            // FileTokens
            fileTokensTabPageControl.CollectSettings();

            // Keywords
            keywordsTabPageControl.CollectSettings();

            // Categories
            categoriesTabPageControl.CollectSettings();

            // Map
            mapTabPageControl.CollectSettings();

            // Static
            pagesTabPageControl.CollectSettings();

            // Text
            textTabPageControl.CollectSettings();

            // Entrance
            entranceTabPageControl.CollectSettings();

            // Tokens
            tokensTabPageControl.CollectSettings();

            // RSS & Robots
            otherTabPageControl.CollectSettings();

            // Links
            linksTabPageControl.CollectSettings();

            // FTP
            ftpTabPageControl.CollectSettings();
        }

        protected virtual void cancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual void taskNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            (this.Task.Executor as TaskExecutor).Settings = new TaskSettings();

            this.ApplySettings();
        }

        protected virtual void taskScheduleComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskScheduleComboBox.SelectedIndex == -1) return;
            taskScheduleStepNumericUpDown.Enabled = taskScheduleComboBox.SelectedIndex != 0;
        }

        protected virtual void taskExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
