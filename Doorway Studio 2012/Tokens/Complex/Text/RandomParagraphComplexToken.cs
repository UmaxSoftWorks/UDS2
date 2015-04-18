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
    public class RandomParagraphComplexToken : MinMaxExtendableToken, IComplexToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public override bool Bold { get { return true; } }

        public override Color Color { get { return Color.Red; } }

        public override string Name { get { return "[RandomParagraph]"; } }

        public override string[] Tokens { get { return new string[] { "[RandomParagraph(:X:X:X)]" }; } }

        public override string[] Extensions { get { return new string[] { "Big", "Com", "BigBigWords", "BigAllWords", "Minimum", "Maximum" }; } }

        public override int Priority { get { return 4; } }

        public string[] RegexTokens { get { return new string[] { @"(\[|{)RandomParagraph([a-zA-Z0-9 ]+)*(\]|})" }; } }

        public string[] Token { get { return new string[] { "[RandomParagraph]", "[RandomParagraph:Big]", "[RandomParagraph:Com]", "[RandomParagraph:BigBigWords]", "[RandomParagraph:BigAllWords]", "[RandomParagraph:1:3]" }; } }

        public string Description(LanguageType Language)
        {
            return "Random paragraph";
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
                                text += ContentContainer.Text.Select(StringSelectType.Paragraph, big);
                            }
                        }
                        else
                        {
                            text = ContentContainer.Text.Select(StringSelectType.Paragraph, big);
                        }

                        content = content.Insert(tokenIndex, text);
                    }
                }
            }

            return content;
        }
    }
}
