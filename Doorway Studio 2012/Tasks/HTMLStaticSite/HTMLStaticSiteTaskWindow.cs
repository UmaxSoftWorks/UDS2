using System;
using Umax.Plugins.Tasks.Common;
using Umax.Plugins.Tasks.Common.Controls;
using Umax.Plugins.Tasks.Enums;

namespace Umax.Plugins.Tasks.HTMLStaticSite
{
    public class HTMLStaticSiteTaskWindow : TaskWindow
    {
        public HTMLStaticSiteTaskWindow()
        {
            this.Name = "HTMLStaticSiteTaskWindow";
            this.Text = this.GUIName;
        }

        public override string GUIName
        {
            get
            {
                return "Task: HTML Site";
            }
        }

        public override string ExecutorName { get { return "HTMLStaticSiteTaskExecutor"; } }

        public override object NewInstance()
        {
            return new HTMLStaticSiteTaskWindow();
        }

        protected override void TaskWindowLoad(object sender, EventArgs e)
        {
            base.TaskWindowLoad(sender, e);
            pagesNamingPanel.Controls.Add(new HTMLSitePageNamesControl());
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

            if (!(pagesNamingPanel.Controls[0] is HTMLSitePageNamesControl))
            {
                return;
            }

            (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).generalExtensionTextBox.Text =
                ((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).PageNamesGeneralExtension;
            (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).generalSeparatorTextBox.Text =
                ((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).PageNamesGeneralSeparator;
            (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).mainPageNameTextBox.Text =
                ((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).PageNamesMainPageName;
            (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).mainPageContinuesCheckBox.Checked =
                ((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).
                    PageNamesMainPageContinues;
            (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).mainPageContinuesNameTextBox.Text =
                ((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).
                    PageNamesMainPageContinuesName;
            (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).mainPageContinuesNumericUpDown.Value =
                ((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).
                    PageNamesMainPageContinuesKeywordsPerPage;

            switch (((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).PageNamesRegularPages
                )
            {
                case PageNameType.Keyword:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).regularPagesTypeComboBox.
                            SelectedIndex = 0;
                        break;
                    }

                case PageNameType.KeywordToEn:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).regularPagesTypeComboBox.
                            SelectedIndex = 1;
                        break;
                    }

                case PageNameType.NumberGlobal:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).regularPagesTypeComboBox.
                            SelectedIndex = 2;
                        break;
                    }

                case PageNameType.NumberLocal:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).regularPagesTypeComboBox.
                            SelectedIndex = 3;
                        break;
                    }

                case PageNameType.Custom:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).regularPagesTypeComboBox.
                            SelectedIndex = 4;
                        break;
                    }
            }

            (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).regularPagesNameTextBox.Text =
                ((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).PageNamesRegularPagesName;

            switch (((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).PageNamesStaticPages)
            {
                case PageNameType.Keyword:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).staticPagesTypeComboBox.
                            SelectedIndex = 0;
                        break;
                    }

                case PageNameType.KeywordToEn:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).staticPagesTypeComboBox.
                            SelectedIndex = 1;
                        break;
                    }

                case PageNameType.NumberGlobal:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).staticPagesTypeComboBox.
                            SelectedIndex = 2;
                        break;
                    }

                case PageNameType.NumberLocal:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).staticPagesTypeComboBox.
                            SelectedIndex = 3;
                        break;
                    }

                case PageNameType.Custom:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).staticPagesTypeComboBox.
                            SelectedIndex = 4;
                        break;
                    }
            }

            (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).staticPagesNameTextBox.Text =
                ((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).PageNamesStaticPagesName;

            switch (((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).PageNamesCategoryPages)
            {
                case PageNameType.Keyword:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesTypeComboBox.
                            SelectedIndex = 0;
                        break;
                    }

                case PageNameType.KeywordToEn:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesTypeComboBox.
                            SelectedIndex = 1;
                        break;
                    }

                case PageNameType.NumberGlobal:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesTypeComboBox.
                            SelectedIndex = 2;
                        break;
                    }

                case PageNameType.NumberLocal:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesTypeComboBox.
                            SelectedIndex = 3;
                        break;
                    }

                case PageNameType.Custom:
                    {
                        (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesTypeComboBox.
                            SelectedIndex = 4;
                        break;
                    }
            }

            (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesNameTextBox.Text =
                ((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).
                    PageNamesCategoryPagesName;
            (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesContinuesCheckBox.Checked =
                ((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).
                    PageNamesCategoryPagesContinues;
            (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesContinuesNameTextBox.Text =
                ((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).
                    PageNamesCategoryPagesContinuesName;
            (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesContinuesNumericUpDown.Value =
                ((this.Task.Executor as HTMLStaticSiteTaskExecutor).Settings as HTMLStaticSiteTaskSettings).
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

            if (!(pagesNamingPanel.Controls[0] is HTMLSitePageNamesControl))
            {
                return;
            }

            (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesGeneralExtension =
                (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).generalExtensionTextBox.Text;
            (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesGeneralSeparator =
                (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).generalSeparatorTextBox.Text;

            (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesMainPageName =
                (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).mainPageNameTextBox.Text;
            (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesMainPageContinues =
                (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).mainPageContinuesCheckBox.Checked;
            (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesMainPageContinuesName =
                (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).mainPageContinuesNameTextBox.Text;
            (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesMainPageContinuesKeywordsPerPage =
                (int) (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).mainPageContinuesNumericUpDown.Value;

            switch ((pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).regularPagesTypeComboBox.SelectedIndex)
            {
                    // Keyword
                case 0:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesRegularPages = PageNameType.Keyword;
                        break;
                    }

                    // Keyword -> En
                case 1:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesRegularPages = PageNameType.KeywordToEn;
                        break;
                    }

                    // Global Number
                case 2:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesRegularPages = PageNameType.NumberGlobal;
                        break;
                    }

                    // Local Number
                case 3:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesRegularPages = PageNameType.NumberLocal;
                        break;
                    }

                    // Custom
                case 4:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesRegularPages = PageNameType.Custom;
                        break;
                    }
            }

            (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesRegularPagesName =
                (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).regularPagesNameTextBox.Text;

            switch ((pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).staticPagesTypeComboBox.SelectedIndex)
            {
                    // Keyword
                case 0:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesStaticPages = PageNameType.Keyword;
                        break;
                    }

                    // Keyword -> En
                case 1:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesStaticPages = PageNameType.KeywordToEn;
                        break;
                    }

                    // Global Number
                case 2:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesStaticPages = PageNameType.NumberGlobal;
                        break;
                    }

                    // Local Number
                case 3:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesStaticPages = PageNameType.NumberLocal;
                        break;
                    }

                    // Custom
                case 4:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesStaticPages = PageNameType.Custom;
                        break;
                    }
            }

            (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesStaticPagesName =
                (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).staticPagesNameTextBox.Text;

            switch ((pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesTypeComboBox.SelectedIndex
                )
            {
                    // Keyword
                case 0:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesCategoryPages = PageNameType.Keyword;
                        break;
                    }

                    // Keyword -> En
                case 1:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesCategoryPages = PageNameType.KeywordToEn;
                        break;
                    }

                    // Global Number
                case 2:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesCategoryPages = PageNameType.NumberGlobal;
                        break;
                    }

                    // Local Number
                case 3:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesCategoryPages = PageNameType.NumberLocal;
                        break;
                    }

                    // Custom
                case 4:
                    {
                        (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesCategoryPages = PageNameType.Custom;
                        break;
                    }
            }

            (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesCategoryPagesName =
                (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesNameTextBox.Text;
            (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesCategoryPagesContinues =
                (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesContinuesCheckBox.Checked;
            (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesCategoryPagesContinuesName =
                (pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesContinuesNameTextBox.Text;
            (this.Task.Executor.Settings as HTMLStaticSiteTaskSettings).PageNamesCategoryPagesContinuesKeywordsPerPage =
                (int)(pagesNamingPanel.Controls[0] as HTMLSitePageNamesControl).categoryPagesContinuesNumericUpDown
                          .Value;
        }
    }
}
