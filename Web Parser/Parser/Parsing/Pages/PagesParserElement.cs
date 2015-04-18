using System.Drawing;
using Umax.Interfaces.Enums;
using Umax.Interfaces.WebParser;
using Umax.Resources;

namespace WebParser.Parser.Parsing.Pages
{
    public class PagesParserElement: IWebParserElement
    {
        public string Name { get { return "PagesParserElement"; } }
        public string WindowName { get { return "PagesParserControl"; } }
        public string Category { get { return "Standard"; } }
        public Image Image { get { return Resources.Gears; } }

        public LanguageType Language { get; set; }

        public string GUIName
        {
            get
            {
                return "Pages";
            }
        }

        public object NewInstance()
        {
            return new PagesParserElement();
        }
    }
}
