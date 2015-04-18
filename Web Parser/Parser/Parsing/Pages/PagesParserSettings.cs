using WebParser.Parser.Parsing.Common;

namespace WebParser.Parser.Parsing.Pages
{
    public class PagesParserSettings : WebParserSettings
    {
        public override string Name
        {
            get { return "PagesParserSettings"; }
        }

        public override object NewInstance()
        {
            return new PagesParserSettings();
        }
    }
}
