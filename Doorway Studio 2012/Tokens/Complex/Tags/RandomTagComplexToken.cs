using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public class RandomTagComplexToken : MinMaxExtendableToken, IComplexToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public override bool Bold { get { return true; } }
        public override Color Color { get { return Color.Red; } }

        public override string Name { get { return "[RandomTagBlock]"; } }

        public override string[] Tokens { get { return new string[] { "[RandomTagBlock(:X:X)]" }; } }

        public override string[] Extensions { get { return new string[] { "Minimum", "Maximum" }; } }

        public override int Priority { get { return 3; } }

        protected Random Random = new Random();

        public string[] RegexTokens { get { return new string[] { this.RegexTokensStart[0] + "(.*)" + this.RegexTokensEnd[0] }; } }
        protected string[] RegexTokensStart { get { return new string[] { @"(\[|{)RandomTagBlock:[0-9]+:[0-9]+(\]|})" }; } }
        protected string[] RegexTokensEnd { get { return new string[] { @"(\[|{)/RandomTagBlock(\]|})" }; } }

        public string[] Token
        {
            get
            {
                string begin = "[RandomTagBlock:5:10] [RandomTagLink] ";
                string end = " [/RandomTagBlock:5:10]";
                return new string[]
                           {
                               begin + "[RandomTag]" + end,
                               begin + "[RandomTag:Keyword]" + end,
                               begin + "[RandomTag:Big]" + end,
                               begin + "[RandomTag:All]" + end,
                               begin + "[RandomTag:Com]" + end,
                               begin + "[RandomTag:BigAllWords]" + end,
                               begin + "[RandomTag:BigBigWords]" + end
                           };
            }
        }

        public string Description(LanguageType Language)
        {
            return "Random tag block";
        }

        public string Group { get { return "Standard"; } }

        public string Invoke(IPage Page, IContentContainer ContentContainer)
        {
            string content = Page.Content;

            // Block
            for (int i = 0; i < this.RegexTokens.Length; i++)
            {
                while (Regex.IsMatch(content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    string tokenStart = string.Empty;
                    int tokenStartIndex = 0;

                    string tokenEnd = Regex.Match(content, this.RegexTokensEnd[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline).Value;
                    int tokenEndIndex = content.IndexOf(tokenEnd);

                    MatchCollection tokenStartMatchCollection = Regex.Matches(content, this.RegexTokensStart[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    tokenStartIndex = content.IndexOf(tokenStartMatchCollection[0].Value);

                    // Looking for last [randomtagblock:X:X] before [/randomtagblock]
                    for (int k = 0; k < tokenStartMatchCollection.Count; k++)
                    {
                        int tokenIndex = content.LastIndexOf(this.RegexTokensStart[i], tokenStartMatchCollection[k].Value, tokenEndIndex);
                        if (tokenEndIndex < tokenIndex || tokenIndex < 0)
                        {
                            break;
                        }

                        tokenStartIndex = tokenIndex;
                    }

                    // Replacing
                    string tokenValue = content.Substring(tokenStartIndex, tokenEndIndex + tokenEnd.Length - tokenStartIndex);
                    content = content.Remove(tokenStartIndex, tokenEndIndex + tokenEnd.Length - tokenStartIndex);

                    tokenStart = Regex.Match(tokenValue, this.RegexTokensStart[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline).Value;

                    // Minimum and maximum
                    List<int> minmax = this.GetMinMaxExtensions(tokenStart);

                    int multiplyCount = this.Random.Next(minmax[0], minmax[1]);

                    // Preparing content to multiply
                    tokenValue = tokenValue.Replace(tokenStart, string.Empty);
                    tokenValue = tokenValue.Replace(tokenEnd, string.Empty);

                    // Multiplying
                    StringBuilder blockContent = new StringBuilder(tokenValue.Length * multiplyCount);
                    for (int k = 0; k < multiplyCount; k++)
                    {
                        blockContent.Append(this.ReplaceBlockTokens(tokenValue, ContentContainer));
                    }

                    // Inserting new content
                    content = content.Insert(tokenStartIndex, tokenValue);
                }

                // Cleaning for left tokens
                content = Regex.Replace(content, this.RegexTokensStart[i], string.Empty, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                content = Regex.Replace(content, this.RegexTokensEnd[i], string.Empty, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            }

            // Replace out of blocks tokens

            List<IPage> pages = (from IPage item in ContentContainer.Pages
                                 where item.Type == FileType.Index || item.Type == FileType.Page
                                 select item).ToList();

            // Tokens
            for (int i = 0; i < this.RegexTokenTokens.Length; i++)
            {
                if (!Regex.IsMatch(content, this.RegexTokenTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    continue;
                }

                MatchCollection matchCollection = Regex.Matches(content, this.RegexTokenTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);

                for (int k = 0; k < matchCollection.Count; k++)
                {
                    List<string> extensions = this.GetExtensions(matchCollection[k].Value);

                    while (content.Contains(matchCollection[k].Value))
                    {
                        if (extensions.Contains("Keyword", true))
                        {
                            content = content.ReplaceOne(matchCollection[k].Value, this.ProcessExtensions(pages[this.Random.Next(pages.Count)].Keywords, extensions));
                        }
                        else
                        {
                            content = content.ReplaceOne(matchCollection[k].Value, this.ProcessExtensions(pages[this.Random.Next(pages.Count)].Tag, extensions));
                        }
                    }
                }
            }

            // Links
            for (int i = 0; i < this.RegexLinkTokens.Length; i++)
            {
                if (!Regex.IsMatch(content, this.RegexLinkTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    continue;
                }

                MatchCollection matchCollection = Regex.Matches(content, this.RegexLinkTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);

                for (int k = 0; k < matchCollection.Count; k++)
                {
                    while (content.Contains(matchCollection[k].Value))
                    {
                        content = content.ReplaceOne(matchCollection[k].Value, pages[this.Random.Next(pages.Count)].URL);
                    }
                }
            }

            return content;
        }

        public string[] RegexTokenTokens { get { return new string[] { @"(\[|{)RandomTag([a-zA-Z0-9 ]+)*(\]|})" }; } }

        public string[] TokenExtensions { get { return new string[] { "Keyword", "Big", "All", "Com", "BigAllWords", "BigBigWords" }; } }

        public string[] RegexLinkTokens { get { return new string[] { @"(\[|{)RandomTagLink(\]|})" }; } }

        protected virtual string ReplaceBlockTokens(string Content, IContentContainer ContentContainer)
        {
            List<IPage> pages = (from IPage item in ContentContainer.Pages
                                 where item.Type == FileType.Index || item.Type == FileType.Page
                                 select item).ToList();

            IPage page = pages[this.Random.Next(pages.Count)];

            // Tokens
            for (int i = 0; i < this.RegexTokenTokens.Length; i++)
            {
                if (!Regex.IsMatch(Content, this.RegexTokenTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    continue;
                }

                MatchCollection matchCollection = Regex.Matches(Content, this.RegexTokenTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);

                for (int k = 0; k < matchCollection.Count; k++)
                {
                    List<string> extensions = this.GetExtensions(matchCollection[k].Value);

                    while (Content.Contains(matchCollection[k].Value))
                    {
                        if (extensions.Contains("Keyword", true))
                        {
                            Content = Content.ReplaceOne(matchCollection[k].Value, this.ProcessExtensions(page.Keywords, extensions));
                        }
                        else
                        {
                            Content = Content.ReplaceOne(matchCollection[k].Value, this.ProcessExtensions(page.Tag, extensions));
                        }
                    }
                }
            }

            // Links
            for (int i = 0; i < this.RegexLinkTokens.Length; i++)
            {
                if (!Regex.IsMatch(Content, this.RegexLinkTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    continue;
                }

                Content = Regex.Replace(Content, this.RegexLinkTokens[i], page.URL);
            }

            return Content;
        }
    }
}
