using Umax.Interfaces.Compatibility.ID;
using Umax.Plugins.Tasks.Common;
using Umax.Plugins.Tasks.Interfaces;
using Umax.Plugins.Tasks.PHPStaticSite.PHPSQLiteStaticSite.Classes;

namespace Umax.Plugins.Tasks.PHPStaticSite.PHPSQLiteStaticSite
{
    public class PHPSQLiteStaticSiteTaskExecutor : TaskExecutor, IKeywordIDCompatible, ITemplateIDCompatible, IPresetIDCompatible
    {
        public PHPSQLiteStaticSiteTaskExecutor()
        {
            Settings = new PHPSQLiteStaticSiteTaskSettings();
        }

        public override string Name
        {
            get
            {
                return "PHPSQLiteStaticSiteTaskExecutor";
            }
        }

        public override object NewInstance()
        {
            return new PHPSQLiteStaticSiteTaskExecutor();
        }

        protected override ITaskContext MakeContext()
        {
            return new PHPSQLiteStaticTaskContext();
        }

        public int KeywordID
        {
            get { return (this.Settings == null || !(this.Settings is PHPSQLiteStaticSiteTaskSettings)) ? -1 : (this.Settings as PHPSQLiteStaticSiteTaskSettings).KeywordsID; }
        }

        public int TemplateID
        {
            get { return (this.Settings == null || !(this.Settings is PHPSQLiteStaticSiteTaskSettings)) ? -1 : (this.Settings as PHPSQLiteStaticSiteTaskSettings).TemplateID; ; }
        }

        public int PresetID
        {
            get { return (this.Settings == null || !(this.Settings is PHPSQLiteStaticSiteTaskSettings)) ? -1 : (this.Settings as PHPSQLiteStaticSiteTaskSettings).PresetID; }
        }
    }
}
