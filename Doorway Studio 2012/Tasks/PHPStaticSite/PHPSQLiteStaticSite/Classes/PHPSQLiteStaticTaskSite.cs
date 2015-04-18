using Umax.Plugins.Tasks.PHPStaticSite.Classes;

namespace Umax.Plugins.Tasks.PHPStaticSite.PHPSQLiteStaticSite.Classes
{
    public class PHPSQLiteStaticTaskSite : PHPStaticTaskSite
    {
        protected override string MakePHPFileContent()
        {
            return Stuff.Resources.PHPTextStatic;
        }

        public override void Save()
        {
            
        }
    }
}