using System;
using Umax.Plugins.Tasks.Common;
using Umax.Plugins.Tasks.Controls;
using Umax.Plugins.Tasks.PHPStaticSite.PHPTextStaticSite;

namespace Umax.Plugins.Tasks.PHPStaticSite
{
    public partial class PHPStaticSiteTaskWindow : TaskWindow
    {
        public PHPStaticSiteTaskWindow()
        {
            this.Name = "PHPTextSiteTaskWindow";
            this.Text = this.GUIName;
        }

        public override string ExecutorName { get { return "PHPStaticSiteTaskExecutor"; } }

        public override object NewInstance()
        {
            return new PHPStaticSiteTaskWindow();
        }

        protected override void TaskWindowLoad(object sender, EventArgs e)
        {
            base.TaskWindowLoad(sender, e);
            pagesNamingPanel.Controls.Add(new PHPTextSitePageNamesControl());
        }

        protected override void ApplySettings()
        {
            base.ApplySettings();
            this.ApplyPageNamesSettings();
        }

        protected virtual void ApplyPageNamesSettings()
        {
            if (pagesNamingPanel.Controls.Count == 0)
            {
                return;
            }

            if (!(pagesNamingPanel.Controls[0] is PHPTextSitePageNamesControl))
            {
                return;
            }

            (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).mainPageContinuesCheckBox.Checked =
                ((this.Task.Executor as PHPTextStaticSiteTaskExecutor).Settings as PHPStaticSiteTaskSettings).
                    PageNamesMainPageContinues;
            (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).mainPageContinuesNameTextBox.Text =
                ((this.Task.Executor as PHPTextStaticSiteTaskExecutor).Settings as PHPStaticSiteTaskSettings).
                    PageNamesMainPageContinuesName;
            (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).mainPageContinuesNumericUpDown.Value =
                ((this.Task.Executor as PHPTextStaticSiteTaskExecutor).Settings as PHPStaticSiteTaskSettings).
                    PageNamesMainPageContinuesKeywordsPerPage;

            (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).regularPagesNameTextBox.Text =
                ((this.Task.Executor as PHPTextStaticSiteTaskExecutor).Settings as PHPStaticSiteTaskSettings).PageNamesRegularPagesName;

            (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).staticPagesNameTextBox.Text =
                ((this.Task.Executor as PHPTextStaticSiteTaskExecutor).Settings as PHPStaticSiteTaskSettings).PageNamesStaticPagesName;

            (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).categoryPagesNameTextBox.Text =
                ((this.Task.Executor as PHPTextStaticSiteTaskExecutor).Settings as PHPStaticSiteTaskSettings).
                    PageNamesCategoryPagesName;
            (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).categoryPagesContinuesCheckBox.Checked =
                ((this.Task.Executor as PHPTextStaticSiteTaskExecutor).Settings as PHPStaticSiteTaskSettings).
                    PageNamesCategoryPagesContinues;
            (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).categoryPagesContinuesNameTextBox.Text =
                ((this.Task.Executor as PHPTextStaticSiteTaskExecutor).Settings as PHPStaticSiteTaskSettings).
                    PageNamesCategoryPagesContinuesName;
            (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).categoryPagesContinuesNumericUpDown.Value =
                ((this.Task.Executor as PHPTextStaticSiteTaskExecutor).Settings as PHPStaticSiteTaskSettings).
                    PageNamesCategoryPagesContinuesKeywordsPerPage;
        }

        protected override void CollectSettings()
        {
            base.CollectSettings();

            // Collect page names settings
            this.CollectPageNamesSettings();
        }

        protected virtual void CollectPageNamesSettings()
        {
            if (pagesNamingPanel.Controls.Count == 0)
            {
                return;
            }

            if (!(pagesNamingPanel.Controls[0] is PHPTextSitePageNamesControl))
            {
                return;
            }

            (this.Task.Executor.Settings as PHPStaticSiteTaskSettings).PageNamesMainPageContinues = (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).mainPageContinuesCheckBox.Checked;
            (this.Task.Executor.Settings as PHPStaticSiteTaskSettings).PageNamesMainPageContinuesName = (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).mainPageContinuesNameTextBox.Text;
            (this.Task.Executor.Settings as PHPStaticSiteTaskSettings).PageNamesMainPageContinuesKeywordsPerPage =
                (int) (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).mainPageContinuesNumericUpDown.Value;

            (this.Task.Executor.Settings as PHPStaticSiteTaskSettings).PageNamesRegularPagesName = (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).regularPagesNameTextBox.Text;

            (this.Task.Executor.Settings as PHPStaticSiteTaskSettings).PageNamesStaticPagesName = (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).staticPagesNameTextBox.Text;

            (this.Task.Executor.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesName = (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).categoryPagesNameTextBox.Text;
            (this.Task.Executor.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesContinues =
                (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).categoryPagesContinuesCheckBox.Checked;
            (this.Task.Executor.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesContinuesName =
                (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).categoryPagesContinuesNameTextBox.Text;
            (this.Task.Executor.Settings as PHPStaticSiteTaskSettings).PageNamesCategoryPagesContinuesKeywordsPerPage =
                (int) (pagesNamingPanel.Controls[0] as PHPTextSitePageNamesControl).categoryPagesContinuesNumericUpDown.Value;
        }
    }
}
