using Umax.Interfaces.Tasks;

namespace Umax.Plugins.Tasks.PHPStaticSite.PHPTextStaticSite
{
    class PHPTextStaticSiteSettings : PHPStaticSiteTaskSettings
    {
        public PHPTextStaticSiteSettings(): base(){}

        public PHPTextStaticSiteSettings(ITaskSettings Settings)
            : base(Settings)
        {
        }

        public override string Name { get { return "PHPTextStaticSiteSettings"; } }
    }
}
