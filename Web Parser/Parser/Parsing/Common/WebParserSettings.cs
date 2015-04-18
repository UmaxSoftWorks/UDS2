using Umax.Interfaces.WebParser;

namespace WebParser.Parser.Parsing.Common
{
    public abstract class WebParserSettings : IWebParserSettings
    {
        public abstract string Name { get; }

        public abstract object NewInstance();
    }
}
