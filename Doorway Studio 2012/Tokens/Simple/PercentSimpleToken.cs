using System;
using System.Drawing;
using System.Text.RegularExpressions;
using Umax.Classes.Helpers;
using Umax.Interfaces.Compatibility.Tokens;
using Umax.Interfaces.Enums;
using Umax.Interfaces.TemplateEditor;
using Umax.Interfaces.Tokens;

namespace Umax.Plugins.Tokens.Simple
{
    public class PercentSimpleToken : ISimpleToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public bool Bold { get { return true; } }

        public Color Color { get { return Color.Red; } }

        public string Name { get { return "[X%]"; } }

        public string[] Tokens { get { return new string[] { "[X%]", "[/X%]" }; } }

        public int Priority { get { return 2; } }

        protected Random Random = new Random();

        public string[] RegexTokens { get { return new string[] { this.RegexTokensStart[0] + "(.*)" + this.RegexTokensEnd[0] }; } }
        protected string[] RegexTokensStart { get { return new string[] { @"(\[|{)[0-9]+%(\]|})" }; } }
        protected string[] RegexTokensEnd { get { return new string[] { @"(\[|{)/[0-9]+%(\]|})" }; } }

        public string[] Token { get { return new string[]{"[10%][/10%]"}; } }

        public string Description(LanguageType Language)
        {
            return "Insert item with specified probability";
        }

        public string Group { get { return "Standard"; } }

        public string Invoke(string Content)
        {
            for (int i = 0; i < this.RegexTokens.Length; i++)
            {
                while (Regex.IsMatch(Content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    string tokenStart = string.Empty;
                    int tokenStartIndex = 0;

                    string tokenEnd = Regex.Match(Content, this.RegexTokensEnd[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline).Value;
                    int tokenEndIndex = Content.IndexOf(tokenEnd);


                    MatchCollection tokenStartMatchCollection = Regex.Matches(Content, this.RegexTokensStart[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    tokenStartIndex = Content.IndexOf(tokenStartMatchCollection[0].Value);

                    // Looking for last [X%] before [/X%]
                    for (int k = 0; k < tokenStartMatchCollection.Count; k++)
                    {
                        int tokenIndex = Content.LastIndexOf(this.RegexTokensStart[i], tokenStartMatchCollection[k].Value, tokenEndIndex);
                        if (tokenEndIndex < tokenIndex || tokenIndex < 0)
                        {
                            break;
                        }

                        tokenStartIndex = tokenIndex;
                    }

                    // Replacing
                    string tokenValue = Content.Substring(tokenStartIndex, tokenEndIndex + tokenEnd.Length - tokenStartIndex);
                    Content = Content.Remove(tokenStartIndex, tokenEndIndex + tokenEnd.Length - tokenStartIndex);

                    tokenStart = Regex.Match(tokenValue, this.RegexTokensStart[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline).Value;

                    // Minimum and maximum
                    int percent = int.Parse(Regex.Match(tokenStart, "[0-9]+", RegexOptions.Compiled).Value);
                    if (percent < 0)
                    {
                        percent = 0;
                    }

                    if (percent > 100)
                    {
                        percent = 100;
                    }

                    // Preparing content to multiply
                    tokenValue = tokenValue.Replace(tokenStart, string.Empty);
                    tokenValue = tokenValue.Replace(tokenEnd, string.Empty);

                    // Inserting new content
                    Content = Content.Insert(tokenStartIndex, (this.Random.Next(0, 100) < percent) ? tokenValue : string.Empty);
                }

                // Cleaning for left tokens
                Content = Regex.Replace(Content, this.RegexTokensStart[i], string.Empty, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                Content = Regex.Replace(Content, this.RegexTokensEnd[i], string.Empty, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            }

            return Content;
        }
    }
}
