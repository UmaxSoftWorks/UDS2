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
    public class RandomTextComplexToken : MinMaxExtendableToken, IComplexToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public override bool Bold { get { return true; } }

        public override Color Color { get { return Color.Red; } }

        public override string Name { get { return "[RandomText]"; } }

        public override string[] Tokens { get { return new string[] { "[RandomText(:X:X:X)]" }; } }

        public override string[] Extensions { get { return new string[] { "Big", "Com", "BigBigWords", "BigAllWords", "Minimum", "Maximum" }; } }

        public override int Priority { get { return 4; } }

        public string[] RegexTokens { get { return new string[] { @"(\[|{)RandomText([a-zA-Z0-9 ]+)*(\]|})" }; } }

        public string[] Token { get { return new string[] { "[RandomText]", "[RandomText:Big]", "[RandomText:Com]", "[RandomText:BigBigWords]", "[RandomText:BigAllWords]", "[RandomText:100:250]" }; } }

        public string Description(LanguageType Language)
        {
            return "Random text";
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

                        int multiplyCount = this.Random.Next(200, 300);
                        if (this.CheckMinMaxExtensions(matchCollection[k].Value))
                        {
                            List<int> minmax = this.GetMinMaxExtensions(matchCollection[k].Value);
                            multiplyCount = this.Random.Next(minmax[0], minmax[1]);
                        }

                        int startIndex = GetNextWordIndexInText(Random.Next(ContentContainer.Text.Length), ContentContainer.Text);
                        int endIndex = ContentContainer.Text.Length;

                        while (startIndex >= 0 || ContentContainer.Text.Length <= endIndex || ContentContainer.Text.IndexOf(" ", endIndex) < 0)
                        {
                            startIndex = GetNextWordIndexInText(Random.Next(ContentContainer.Text.Length), ContentContainer.Text);
                            if (startIndex < 0 || ContentContainer.Text.Length <= startIndex)
                            {
                                continue;
                            }

                            // Get number of words
                            for (int l = 0; l < multiplyCount; l++)
                            {
                                startIndex = GetNextWordIndexInText(startIndex + 1, ContentContainer.Text);
                                if (ContentContainer.Text.Length <= startIndex)
                                {
                                    startIndex = -1;
                                    break;
                                }
                            }

                            endIndex = startIndex + 1;
                        }

                        string text = ContentContainer.Text.Substring(startIndex, ContentContainer.Text.IndexOf(" ", endIndex) - startIndex).Clear().ToLower();

                        if (this.GetExtensions(matchCollection[k].Value).Contains("Big", true))
                        {
                            text = text.ToUpper(StringToUpperType.FirstWord);
                        }

                        content = content.Insert(tokenIndex, text);
                    }
                }
            }

            return content;
        }

        protected int GetNextWordIndexInText(int WordStartIndex, string Text)
        {
            if (Text.Length < WordStartIndex)
            {
                WordStartIndex = Random.Next(Text.Length);
            }

            int spaceIndex = Text.IndexOf(" ", WordStartIndex);

            if (spaceIndex == -1)
            {
                return Text.Length;
            }

            return spaceIndex;
        }
    }
}
