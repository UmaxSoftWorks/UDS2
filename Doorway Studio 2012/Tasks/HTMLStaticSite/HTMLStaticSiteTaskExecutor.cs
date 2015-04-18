using Umax.Interfaces.Compatibility.ID;
using Umax.Plugins.Tasks.Common;
using Umax.Plugins.Tasks.HTMLStaticSite.Classes;
using Umax.Plugins.Tasks.Interfaces;

namespace Umax.Plugins.Tasks.HTMLStaticSite
{
    public class HTMLStaticSiteTaskExecutor : TaskExecutor, IKeywordIDCompatible, ITemplateIDCompatible, IPresetIDCompatible
    {
        public HTMLStaticSiteTaskExecutor()
        {
            Settings = new HTMLStaticSiteTaskSettings();
        }

        public override string Name
        {
            get
            {
                return "HTMLStaticSiteTaskExecutor";
            }
        }

        public override object NewInstance()
        {
            return new HTMLStaticSiteTaskExecutor();
        }

        protected override ITaskContext MakeContext()
        {
            return new HTMLStaticTaskContext();
        }

        public int KeywordID
        {
            get { return (this.Settings == null || !(this.Settings is HTMLStaticSiteTaskSettings)) ? -1 : (this.Settings as HTMLStaticSiteTaskSettings).KeywordsID; }
        }

        public int TemplateID
        {
            get { return (this.Settings == null || !(this.Settings is HTMLStaticSiteTaskSettings)) ? -1 : (this.Settings as HTMLStaticSiteTaskSettings).TemplateID; ; }
        }

        public int PresetID
        {
            get { return (this.Settings == null || !(this.Settings is HTMLStaticSiteTaskSettings)) ? -1 : (this.Settings as HTMLStaticSiteTaskSettings).PresetID; }
        }
    }
}
