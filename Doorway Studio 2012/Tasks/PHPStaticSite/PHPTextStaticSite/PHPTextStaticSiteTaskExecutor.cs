using Umax.Interfaces.Compatibility.ID;
using Umax.Plugins.Tasks.Common;
using Umax.Plugins.Tasks.Interfaces;
using Umax.Plugins.Tasks.PHPStaticSite.PHPTextStaticSite.Classes;

namespace Umax.Plugins.Tasks.PHPStaticSite.PHPTextStaticSite
{
    public class PHPTextStaticSiteTaskExecutor : TaskExecutor, IKeywordIDCompatible, ITemplateIDCompatible, IPresetIDCompatible
    {
        public PHPTextStaticSiteTaskExecutor()
        {
            Settings = new PHPStaticSiteTaskSettings();
        }

        public override string Name
        {
            get
            {
                return "PHPTextStaticSiteTaskExecutor";
            }
        }

        public override object NewInstance()
        {
            return new PHPTextStaticSiteTaskExecutor();
        }

        protected override ITaskContext MakeContext()
        {
            return new PHPTextTaskContext();
        }

        public int KeywordID
        {
            get { return (this.Settings == null || !(this.Settings is PHPStaticSiteTaskSettings)) ? -1 : (this.Settings as PHPStaticSiteTaskSettings).KeywordsID; }
        }

        public int TemplateID
        {
            get { return (this.Settings == null || !(this.Settings is PHPStaticSiteTaskSettings)) ? -1 : (this.Settings as PHPStaticSiteTaskSettings).TemplateID; ; }
        }

        public int PresetID
        {
            get { return (this.Settings == null || !(this.Settings is PHPStaticSiteTaskSettings)) ? -1 : (this.Settings as PHPStaticSiteTaskSettings).PresetID; }
        }
    }
}
