using Umax.Plugins.Tasks.Classes;
using Umax.Plugins.Tasks.Interfaces;

namespace Umax.Plugins.Tasks.PHPStaticSite.PHPTextStaticSite.Classes
{
    public class PHPTextTaskContext : TaskContext
    {
        protected override ITaskSite MakeSite()
        {
            return new PHPTextStaticTaskSite();
        }
    }
}
