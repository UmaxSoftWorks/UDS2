using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Plugins.Tasks.Enums;

namespace Umax.Plugins.Tasks.Common.Controls.TabPages
{
    public partial class OtherTabPageControl : UserControl
    {
        public OtherTabPageControl()
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

        protected virtual void RSSComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (RSSComboBox.SelectedIndex == 0)
            {
                RSSEntriesNumericUpDown.Enabled = false;
                RSSContentComboBox.Enabled = false;
            }
            else
            {
                RSSEntriesNumericUpDown.Enabled = true;
                RSSContentComboBox.Enabled = true;
            }
        }

        protected virtual void robotsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            robotsTextBox.Enabled = robotsComboBox.SelectedIndex != 0;

            this.UpdateRobots();
        }

        private IWorkSpace workSpace;
        public IWorkSpace WorkSpace
        {
            protected get { return this.workSpace; }
            set
            {
                this.workSpace = value;

                this.UpdateRobots();
            }
        }

        private int templateID;
        public int TemplateID
        {
            protected get { return this.templateID; }
            set
            {
                this.templateID = value;

                this.UpdateRobots();
            }
        }


        private MapType siteMap;
        public MapType SiteMap
        {
            protected get { return this.siteMap; }
            set
            {
                this.siteMap = value;

                this.UpdateRobots();
            }
        }

        protected virtual void UpdateRobots()
        {
            if (robotsComboBox.SelectedIndex == 1)
            {
                if (this.TemplateID != -1)
                {
                    StringBuilder robots = new StringBuilder(200);
                    robots.AppendLine("User-agent: *");

                    int templateIndex = -1;

                    for (int i = 0; i < this.WorkSpace.Templates.Count; i++)
                    {
                        if (this.WorkSpace.Templates[i].ID == this.TemplateID)
                        {
                            templateIndex = i;
                            break;
                        }
                    }

                    if (templateIndex == -1)
                    {
                        robotsTextBox.Text = string.Empty;
                        return;
                    }

                    var directories = (from i in this.WorkSpace.Templates[templateIndex].Items.ToList()
                                       where ((i.Type == FileType.File || i.Type == FileType.Image) && !i.Path.ToLower().StartsWith("http"))
                                       select i.Path).Distinct();

                    foreach (string directory in directories)
                    {
                        try
                        {
                            robots.AppendLine("Disallow: " +
                                (directory.ToLower().Contains("files") ?
                                    directory.Substring(0, directory.LastIndexOf("\\") + 1).
                                        Substring(directory.ToLower().LastIndexOf("\\files\\"))
                                            .Replace("\\", "/") : directory));
                        }
                        catch (Exception) { }
                    }

                    if (this.SiteMap == MapType.XML || this.SiteMap == MapType.XMLHTML)
                    {
                        robots.AppendLine("Sitemap: [SITEMAP]");
                    }

                    robotsTextBox.Text = robots.ToString();
                }
            }
            else
            {
                robotsTextBox.Text = string.Empty;
            }
        }

        public virtual void CollectSettings()
        {
            // Robots
            switch (robotsComboBox.SelectedIndex)
            {
                // None
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).Robots = RobotsType.None;
                        break;
                    }

                // Auto
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).Robots = RobotsType.Auto;
                        break;
                    }

                // Manual
                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).Robots = RobotsType.Manual;
                        break;
                    }
            }

            (this.Task.Executor.Settings as TaskSettings).RobotsContent = robotsTextBox.Text;

            // RSS
            switch (RSSComboBox.SelectedIndex)
            {
                // None
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).RSS = RSSType.None;
                        break;
                    }

                // All
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).RSS = RSSType.All;
                        break;
                    }

                // Limited
                case 2:
                    {
                        (this.Task.Executor.Settings as TaskSettings).RSS = RSSType.Limited;
                        break;
                    }
            }

            (this.Task.Executor.Settings as TaskSettings).RSSLength = (int)RSSEntriesNumericUpDown.Value;

            switch (RSSContentComboBox.SelectedIndex)
            {
                // Generate
                case 0:
                    {
                        (this.Task.Executor.Settings as TaskSettings).RSSContent = RSSContentType.Generate;
                        break;
                    }

                // Page content  
                case 1:
                    {
                        (this.Task.Executor.Settings as TaskSettings).RSSContent = RSSContentType.PageContent;
                        break;
                    }
            }
        }

        private void UpdateControl()
        {
            switch ((this.Task.Executor.Settings as TaskSettings).RSS)
            {
                case RSSType.None:
                    {
                        RSSComboBox.SelectedIndex = 0;
                        break;
                    }

                case RSSType.All:
                    {
                        RSSComboBox.SelectedIndex = 1;
                        break;
                    }

                case RSSType.Limited:
                    {
                        RSSComboBox.SelectedIndex = 2;
                        break;
                    }
            }

            RSSEntriesNumericUpDown.Value = (this.Task.Executor.Settings as TaskSettings).RSSLength;

            switch ((this.Task.Executor.Settings as TaskSettings).RSSContent)
            {
                case RSSContentType.Generate:
                    {
                        RSSContentComboBox.SelectedIndex = 0;
                        break;
                    }

                case RSSContentType.PageContent:
                    {
                        RSSContentComboBox.SelectedIndex = 1;
                        break;
                    }
            }

            switch ((this.Task.Executor.Settings as TaskSettings).Robots)
            {
                case RobotsType.None:
                    {
                        robotsComboBox.SelectedIndex = 0;
                        break;
                    }

                case RobotsType.Auto:
                    {
                        robotsComboBox.SelectedIndex = 1;
                        break;
                    }

                case RobotsType.Manual:
                    {
                        robotsComboBox.SelectedIndex = 1;
                        break;
                    }
            }

            robotsTextBox.Text = (this.Task.Executor.Settings as TaskSettings).RobotsContent;
        }
    }
}
