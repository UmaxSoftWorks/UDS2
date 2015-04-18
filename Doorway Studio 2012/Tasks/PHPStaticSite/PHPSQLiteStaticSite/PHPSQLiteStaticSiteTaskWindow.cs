namespace Umax.Plugins.Tasks.PHPStaticSite.PHPSQLiteStaticSite
{
    public class PHPSQLiteStaticSiteTaskWindow : PHPStaticSiteTaskWindow
    {
        public PHPSQLiteStaticSiteTaskWindow()
        {
            this.Name = "PHPSQLiteStaticSiteTaskWindow";
            this.Text = this.GUIName;
        }

        public override string GUIName
        {
            get
            {
                return "Task: PHP + SQLite Site";
            }
        }

        public override string ExecutorName { get { return "PHPSQLiteStaticSiteTaskExecutor"; } }

        public override object NewInstance()
        {
            return new PHPSQLiteStaticSiteTaskWindow();
        }
    }
}
