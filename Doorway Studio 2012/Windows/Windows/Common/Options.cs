using System;
using System.Windows.Forms;
using Umax.Windows.Controls.Options.Core;
using Umax.Windows.Controls.Options.GUI;

namespace Umax.Windows.Windows.Common
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void OptionsLoad(object sender, EventArgs e)
        {
            this.Icon = Resources.Resources.IconRed;
            this.Text = Brand.Brand.Name + " " + this.Text;

            mainTreeView.ExpandAll();
        }

        protected UserControl control { get; set; }
        private void mainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            mainPanel.Controls.Clear();
            this.control = null;

            switch (e.Node.Name)
            {
                    // Core
                case "EnvironmentNode":
                case "EnvironmentGeneralNode":
                    {
                        this.control = new OptionsCoreGeneral();
                        break;
                    }

                case "EnvironmentPlugInsNode":
                    {
                        this.control = new OptionsCorePlugIns();
                        break;
                    }

                case "EnvironmentWebUINode":
                    {
                        break;
                    }

                case "EnvironmentLoggingNode":
                    {
                        this.control = new OptionsCoreLog();
                        break;
                    }

                case "EnvironmentMaintenanceNode":
                    {
                        break;
                    }

                    // GUI
                case "GUINode":
                case "GUIGeneralNode":
                    {
                        this.control = new OptionsGuiGeneral();
                        break;
                    }

                case "GUIStartUpNode":
                    {
                        this.control = new OptionsGuiStartUp();
                        break;
                    }

                case "GUINotificationsNode":
                    {
                        this.control = new OptionsGuiNotifications();
                        break;
                    }

                case "GUIUpdatesNode":
                    {
                        this.control = new OptionsGuiUpdates();
                        break;
                    }
                case "GUIMonitorNode":
                    {
                        control = new OptionsGuiMonitor();
                        break;
                    }

                case "GUIReportingNode":
                    {
                        this.control = new OptionsGuiReporting();
                        break;
                    }
            }

            if (this.control != null)
            {
                this.control.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(this.control);
            }
        }
    }
}
