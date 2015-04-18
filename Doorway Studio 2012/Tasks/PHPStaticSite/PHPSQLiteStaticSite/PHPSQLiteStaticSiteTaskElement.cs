using System.Drawing;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Tasks;

namespace Umax.Plugins.Tasks.PHPStaticSite.PHPSQLiteStaticSite
{
    public class PHPSQLiteStaticSiteTaskElement : ITaskElement
    {
        public string Name { get { return "PHPSQLiteStaticSiteTaskElement"; } }
        public string WindowName { get { return "PHPSQLiteStaticSiteTaskWindow"; } }
        public string Category { get { return "Standard"; } }
        public Image Image { get { return Umax.Resources.Resources.Gears; } }

        public LanguageType Language { get; set; }

        public string GUIName
        {
            get
            {
                return "PHP + SQLite Site";
            }
        }

        public object NewInstance()
        {
            return new PHPSQLiteStaticSiteTaskElement();
        }
    }
}
