using System.Drawing;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Tasks;

namespace Umax.Plugins.Tasks.PHPStaticSite.PHPTextStaticSite
{
    public class PHPTextStaticSiteTaskElement : ITaskElement
    {
        public string Name { get { return "PHPTextStaticSiteTaskElement"; } }
        public string WindowName { get { return "PHPTextStaticSiteTaskWindow"; } }
        public string Category { get { return "Standard"; } }
        public Image Image { get { return Umax.Resources.Resources.Gears; } }

        public LanguageType Language { get; set; }

        public string GUIName
        {
            get
            {
                return "PHP + Text Site";
            }
        }

        public object NewInstance()
        {
            return new PHPTextStaticSiteTaskElement();
        }
    }
}
