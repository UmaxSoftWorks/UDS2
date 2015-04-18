using Umax.Plugins.Tasks.Classes;
using Umax.Plugins.Tasks.Interfaces;

namespace Umax.Plugins.Tasks.HTMLStaticSite.Classes
{
    public class HTMLStaticTaskContext : TaskContext
    {
        protected override ITaskSite MakeSite()
        {
            return new HTMLStaticTaskSite();
        }
    }
}
