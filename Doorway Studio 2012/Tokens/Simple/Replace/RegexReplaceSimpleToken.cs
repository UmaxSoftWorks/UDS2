using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using Umax.Classes.Helpers;
using Umax.Classes.Tokens;
using Umax.Interfaces.Compatibility.Tokens;
using Umax.Interfaces.Enums;
using Umax.Interfaces.TemplateEditor;
using Umax.Interfaces.Tokens;

namespace Umax.Plugins.Tokens.Simple.Replace
{
    public class RegexReplaceSimpleToken : MinMaxExtendableToken, ISimpleToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public override bool Bold { get { return true; } }

        public override Color Color { get { return Color.Red; } }

        public override string Name { get { return "[RegexReplace]"; } }

        public override string[] Tokens { get { return new string[] { "[RegexReplace:X:X]", "[/RegexReplace]" }; } }

        public override int Priority { get { return 2; } }

        public override string[] Extensions { get { return new string[] { "Old", "New" }; } }

        protected Random Random = new Random();

        public string[] RegexTokens { get { return new string[] { this.RegexTokensStart[0] + "(.*)" + this.RegexTokensEnd[0] }; } }
        protected string[] RegexTokensStart { get { return new string[] { @"(\[|{)RegexReplace:[^:]+:[^:]+(\]|})" }; } }
        protected string[] RegexTokensEnd { get { return new string[] { @"(\[|{)/RegexReplace(\]|})" }; } }

        public string[] Token { get { return new string[] { "[Replace:A:B]AAA[/Replace]" }; } }

        public string Description(LanguageType Language)
        {
            return "Replaces content";
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

                    // Looking for last [replace:X:X] before [/replace]
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

                    // Replaces
                    List<string> extensions = this.GetExtensions(tokenStart);

                    // Replace
                    if (extensions.Count > 1)
                    {
                        tokenValue = Regex.Replace(tokenValue, extensions[0], extensions[1]);
                    }

                    // Inserting new content
                    Content = Content.Insert(tokenStartIndex, tokenValue);
                }

                // Cleaning for left tokens
                Content = Regex.Replace(Content, this.RegexTokensStart[i], string.Empty, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                Content = Regex.Replace(Content, this.RegexTokensEnd[i], string.Empty, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            }

            return Content;
        }
    }
}
