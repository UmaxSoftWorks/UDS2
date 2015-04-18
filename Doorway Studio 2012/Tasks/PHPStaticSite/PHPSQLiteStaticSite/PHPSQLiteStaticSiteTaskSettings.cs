using Umax.Interfaces.Tasks;

namespace Umax.Plugins.Tasks.PHPStaticSite.PHPSQLiteStaticSite
{
    public class PHPSQLiteStaticSiteTaskSettings : PHPStaticSiteTaskSettings
    {
        public PHPSQLiteStaticSiteTaskSettings(): base(){}

        public PHPSQLiteStaticSiteTaskSettings(ITaskSettings Settings)
            : base(Settings)
        {
        }

        public override string Name { get { return "PHPSQLiteStaticSiteTaskSettings"; } }
    }
}
