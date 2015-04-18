﻿using System;
using System.Drawing;
using System.Text.RegularExpressions;
using Umax.Classes.Helpers;
using Umax.Interfaces.Compatibility.Tokens;
using Umax.Interfaces.Enums;
using Umax.Interfaces.TemplateEditor;
using Umax.Interfaces.Tokens;

namespace Umax.Plugins.Tokens.Simple
{
    public class RandomSimpleToken : ISimpleToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public bool Bold { get { return true; } }

        public Color Color { get { return Color.Red; } }

        public string Name { get { return "[Random]"; } }

        public string[] Tokens { get { return new string[] { "[Random][Or][/Or][Or][/Or][/Random]" }; } }

        public int Priority { get { return 0; } }

        protected Random Random = new Random();

        public string[] RegexTokens { get { return new string[] { this.RegexTokensStart[0] + "(.*)" + this.RegexTokensEnd[0] }; } }
        protected string[] RegexTokensStart { get { return new string[] { @"(\[|{)Random(\]|})" }; } }
        protected string[] RegexTokensEnd { get { return new string[] { @"(\[|{)/Random(\]|})" }; } }

        public string[] Token { get { return new string[] { "[Random][Or]AAA[/Or][Or]BBB[/Or][Or]CCC[/Or][/Random]" }; } }

        public string Description(LanguageType Language)
        {
            return "Select one of specified items";
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

                    // Looking for last [RANDOM] before [/RANDOM]
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

                    tokenValue = tokenValue.Replace(tokenStart, string.Empty);
                    tokenValue = tokenValue.Replace(tokenEnd, string.Empty);

                    // Getting all [or] and replacing
                    MatchCollection tokenPartsMatchCollection = Regex.Matches(Content, @"(\[|{)OR(\]|})", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    for (int k = 0; k < tokenPartsMatchCollection.Count; k++)
                    {
                        tokenValue = tokenValue.Replace(tokenPartsMatchCollection[k].Value, string.Empty);
                    }

                    // Getting all [/or] and splitting
                    tokenPartsMatchCollection = Regex.Matches(Content, @"(\[|{)/OR(\]|})", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    string[] tokenSplitters = new string[tokenPartsMatchCollection.Count];
                    for (int k = 0; k < tokenPartsMatchCollection.Count; k++)
                    {
                        tokenSplitters[k] = tokenPartsMatchCollection[k].Value;
                    }

                    string[] tokenParts = tokenValue.Split(tokenSplitters, StringSplitOptions.RemoveEmptyEntries);

                    // Inserting new content
                    Content = Content.Insert(tokenStartIndex, tokenParts[this.Random.Next(tokenParts.Length)]);
                }

                // Cleaning for left tokens
                Content = Regex.Replace(Content, this.RegexTokensStart[i], string.Empty, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                Content = Regex.Replace(Content, this.RegexTokensEnd[i], string.Empty, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            }

            return Content;
        }
    }
}
