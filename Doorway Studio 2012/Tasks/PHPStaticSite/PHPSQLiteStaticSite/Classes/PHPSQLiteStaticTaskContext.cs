using Umax.Plugins.Tasks.Classes;
using Umax.Plugins.Tasks.Interfaces;

namespace Umax.Plugins.Tasks.PHPStaticSite.PHPSQLiteStaticSite.Classes
{
    public class PHPSQLiteStaticTaskContext : TaskContext
    {
        protected override ITaskSite MakeSite()
        {
            return new PHPSQLiteStaticTaskSite();
        }
    }
}
