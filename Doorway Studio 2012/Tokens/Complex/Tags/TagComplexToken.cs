using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using Umax.Classes.Helpers;
using Umax.Classes.Tokens;
using Umax.Interfaces.Compatibility.Tokens;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.TemplateEditor;
using Umax.Interfaces.Tokens;

namespace Umax.Plugins.Tokens.Complex.Tags
{
    public class TagComplexToken : ExtendableToken, IComplexToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public override bool Bold { get { return true; } }

        public override Color Color { get { return Color.Red; } }

        public override string Name { get { return "[Tag]"; } }

        public override string[] Tokens { get { return new string[] { "[Tag(:X:X:X:X)]" }; } }

        public override string[] Extensions { get { return new string[] { "Big", "All", "Com", "BigAllWords", "BigBigWords" }; } }

        public override int Priority { get { return 4; } }

        public string[] RegexTokens { get { return new string[] { @"(\[|{)Tag([a-zA-Z0-9 ]+)*(\]|})" }; } }

        public string[] Token { get { return new string[] { "[Tag]", "[Tag:Big]", "[Tag:All]", "[Tag:Com]", "[Tag:BigAllWords]", "[Tag:BigBigWords]" }; } }

        public string Description(LanguageType Language)
        {
            return "Tag";
        }

        public string Group { get { return "Standard"; } }

        protected Random Random = new Random();

        public string Invoke(IPage Page, IContentContainer ContentContainer)
        {
            string content = Page.Content;

            // Token
            for (int i = 0; i < this.RegexTokens.Length; i++)
            {
                if (!Regex.IsMatch(content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    continue;
                }

                MatchCollection matchCollection = Regex.Matches(content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);

                for (int k = 0; k < matchCollection.Count; k++)
                {
                    List<string> extensions = this.GetExtensions(matchCollection[k].Value);

                    while (content.Contains(matchCollection[k].Value))
                    {
                        content = content.ReplaceOne(matchCollection[k].Value, this.ProcessExtensions(Page.Tag, extensions));
                    }
                }
            }

            return content;
        }
    }
}
