using System.Drawing;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Tasks;

namespace Umax.Plugins.Tasks.HTMLStaticSite
{
    public class HTMLStaticSiteTaskElement : ITaskElement
    {
        public string Name { get { return "HTMLStaticSiteTaskElement"; } }
        public string WindowName { get { return "HTMLStaticSiteTaskWindow"; } }
        public string Category { get { return "Standard"; } }
        public Image Image { get { return Umax.Resources.Resources.Gears; } }

        public LanguageType Language { get; set; }

        public string GUIName
        {
            get
            {
                return "HTML Site";
            }
        }

        public object NewInstance()
        {
            return new HTMLStaticSiteTaskElement();
        }
    }
}
