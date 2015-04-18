using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using Umax.Interfaces.Compatibility.Tokens;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.TemplateEditor;
using Umax.Interfaces.Tokens;

namespace Umax.Plugins.Tokens.Complex
{
    public class URLComplexToken : IComplexToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public bool Bold { get { return true; } }

        public Color Color { get { return Color.Red; } }

        public string Name { get { return "[Url]"; } }

        public string[] Tokens { get { return new string[] { "[Url]" }; } }

        public int Priority { get { return 4; } }

        public string[] RegexTokens { get { return new string[] { @"(\[|{)Url(\]|})" }; } }

        public string[] Token { get { return new string[] { "[Url]" }; } }

        public string Description(LanguageType Language)
        {
            return "Site Url";
        }

        public string Group { get { return "Standard"; } }

        protected Random Random = new Random();

        public string Invoke(IPage Page, IContentContainer ContentContainer)
        {
            string content = Page.Content;

            // Find main page
            IPage mainpage = (from IPage item in ContentContainer.Pages
                              where item.Type == FileType.Index && item.ContinueNumber == 0
                              select item).First();

            for (int i = 0; i < this.RegexTokens.Length; i++)
            {
                if (!Regex.IsMatch(content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    continue;
                }

                MatchCollection matchCollection = Regex.Matches(content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);

                for (int k = 0; k < matchCollection.Count; k++)
                {
                    content = content.Replace(matchCollection[k].Value, mainpage.URL);
                }
            }

            return content;
        }
    }
}
