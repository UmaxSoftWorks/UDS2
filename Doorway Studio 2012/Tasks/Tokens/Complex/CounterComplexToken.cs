using System.Drawing;
using System.Text.RegularExpressions;
using Umax.Interfaces.Compatibility.Tokens;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.TemplateEditor;
using Umax.Interfaces.Tokens;

namespace Umax.Plugins.Tasks.Tokens.Complex
{
    internal class CounterComplexToken : IComplexToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public bool Bold { get { return true; } }

        public Color Color { get { return Color.Black; } }

        public string Name { get { return "[Counter]"; } }

        public int Priority { get { return 1; } }

        public string[] Tokens { get { return new string[] { "[Counter]" }; } }

        public string[] RegexTokens { get { return new string[] { @"(\[|{)Counter(\]|})" }; } }

        public string[] Token { get { return new string[] { "[Counter]" }; } }

        public string Description(LanguageType Language)
        {
            return "Site [Counter] token";
        }

        public string Group { get { return Brand.Brand.Name; } }

        public string Invoke(IPage Page, IContentContainer ContentContainer)
        {
            string content = Page.Content;
            for (int i = 0; i < this.RegexTokens.Length; i++)
            {
                if (!Regex.IsMatch(content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    continue;
                }

                MatchCollection matchCollection = Regex.Matches(content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);

                for (int k = 0; k < matchCollection.Count; k++)
                {
                    content = content.Replace(matchCollection[k].Value, ContentContainer.Extensions.Strings["COUNTER"]);
                }
            }

            return content;
        }
    }
}
