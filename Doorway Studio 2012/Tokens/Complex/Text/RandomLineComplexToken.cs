using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Classes.Tokens;
using Umax.Interfaces.Compatibility.Tokens;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.TemplateEditor;
using Umax.Interfaces.Tokens;

namespace Umax.Plugins.Tokens.Complex.Text
{
    public class RandomLineComplexToken : MinMaxExtendableToken, IComplexToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public override bool Bold { get { return true; } }

        public override Color Color { get { return Color.Red; } }

        public override string Name { get { return "[RandomLine]"; } }

        public override string[] Tokens { get { return new string[] { "[RandomLine(:X:X:X)]" }; } }

        public override string[] Extensions { get { return new string[] { "Big", "Com", "BigBigWords", "BigAllWords", "Minimum", "Maximum" }; } }

        public override int Priority { get { return 4; } }

        public string[] RegexTokens { get { return new string[] { @"(\[|{)RandomLine([a-zA-Z0-9 ]+)*(\]|})" }; } }

        public string[] Token { get { return new string[] { "[RandomLine]", "[RandomLine:Big]", "[RandomLine:Com]", "[RandomLine:BigBigWords]", "[RandomLine:BigAllWords]", "[RandomLine:100:250]" }; } }

        public string Description(LanguageType Language)
        {
            return "Random line";
        }

        public string Group { get { return "Standard"; } }

        protected Random Random = new Random();

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
                    int tokenIndex = 0;
                    while (content.Contains(matchCollection[k].Value))
                    {
                        tokenIndex = content.IndexOf(matchCollection[k].Value);
                        content = content.Remove(tokenIndex, matchCollection[k].Value.Length);

                        bool big = this.GetExtensions(matchCollection[k].Value).Contains("Big", true);
                        string text = string.Empty;

                        if (this.CheckMinMaxExtensions(matchCollection[k].Value))
                        {
                            List<int> minmax = this.GetMinMaxExtensions(matchCollection[k].Value);
                            int number = this.Random.Next(minmax[0], minmax[1]);
                            for (int l = 0; l < number; l++)
                            {
                                text += ContentContainer.Text.Select(StringSelectType.Line, big);
                            }
                        }
                        else
                        {
                            text = ContentContainer.Text.Select(StringSelectType.Line, big);
                        }

                        content = content.Insert(tokenIndex, text);
                    }
                }
            }

            return content;
        }
    }
}
