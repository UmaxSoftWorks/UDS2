namespace Umax.Plugins.Tasks.PHPStaticSite.PHPTextStaticSite
{
    public class PHPTextStaticSiteTaskWindow : PHPStaticSiteTaskWindow
    {
        public PHPTextStaticSiteTaskWindow()
        {
            this.Name = "PHPTextStaticSiteTaskWindow";
            this.Text = this.GUIName;
        }

        public override string GUIName
        {
            get
            {
                return "Task: PHP + Text Site";
            }
        }

        public override string ExecutorName { get { return "PHPTextStaticSiteTaskExecutor"; } }

        public override object NewInstance()
        {
            return new PHPTextStaticSiteTaskWindow();
        }
    }
}
