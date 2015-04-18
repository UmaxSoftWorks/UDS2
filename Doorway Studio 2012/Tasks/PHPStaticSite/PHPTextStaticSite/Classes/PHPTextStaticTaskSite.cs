using System.IO;
using Umax.Interfaces.Containers.Items;
using Umax.Plugins.Tasks.PHPStaticSite.Classes;

namespace Umax.Plugins.Tasks.PHPStaticSite.PHPTextStaticSite.Classes
{
    public class PHPTextStaticTaskSite : PHPStaticTaskSite
    {
        protected override string MakePHPFileContent()
        {
            return Stuff.Resources.PHPTextStatic;
        }

        protected override string MakePageName(IPage Page)
        {
            string name = base.MakePageName(Page);

            name = Path.Combine(this.Directory, name + ".txt");

            return name;
        }

        public override void Save()
        {
            
        }
    }
}
