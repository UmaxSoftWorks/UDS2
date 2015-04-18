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

namespace Umax.Plugins.Tokens.Complex.Custom
{
    public class RandomCustomBlockComplexToken : MinMaxExtendableToken, IComplexToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public override bool Bold { get { return true; } }
        public override Color Color { get { return Color.Red; } }

        public override string Name { get { return "[RandomCustomBlock]"; } }

        public override string[] Tokens { get { return new string[] { "[RandomCustomBlock(:X:X)]" }; } }

        public override string[] Extensions { get { return new string[] { "Minimum", "Maximum" }; } }

        public override int Priority { get { return 3; } }

        protected Random Random = new Random();

        public string[] RegexTokens { get { return new string[] { this.RegexTokensStart[0] + "(.*)" + this.RegexTokensEnd[0] }; } }
        protected string[] RegexTokensStart { get { return new string[] { @"(\[|{)RandomCustomBlock:[0-9]+:[0-9]+(\]|})" }; } }
        protected string[] RegexTokensEnd { get { return new string[] { @"(\[|{)/RandomCustomBlock(\]|})" }; } }

        public string[] Token
        {
            get
            {
                string begin = "[RandomCustomBlock:5:10] [RandomCustomLink] ";
                string end = " [/RandomCustomBlock]";
                return new string[]
                           {
                               begin + "[RandomCustomKeyword]" + end,
                               begin + "[RandomCustomKeyword:Big]" + end,
                               begin + "[RandomCustomKeyword:All]" + end,
                               begin + "[RandomCustomKeyword:Com]" + end,
                               begin + "[RandomCustomKeyword:BigAllWords]" + end,
                               begin + "[RandomCustomKeyword:BigBigWords]" + end
                           };
            }
        }

        public string Description(LanguageType Language)
        {
            return "Random custom block";
        }

        public string Group { get { return "Standard"; } }

        public string Invoke(IPage Page, IContentContainer ContentContainer)
        {
            string content = Page.Content;

            List<IPage> pages = (from IPage item in ContentContainer.Pages
                                 where item.Type == FileType.Custom
                                 select item).ToList();

            IPage mainpage = (from IPage item in ContentContainer.Pages
                              where item.Type == FileType.Index && item.ContinueNumber == 0
                              select item).First();

            for (int i = 0; i < this.RegexTokens.Length; i++)
            {
                if (!Regex.IsMatch(content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    continue;
                }

                while (Regex.IsMatch(content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    string tokenStart = string.Empty;
                    int tokenStartIndex = 0;

                    string tokenEnd = Regex.Match(content, this.RegexTokensStart[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline).Value;
                    int tokenEndIndex = content.IndexOf(tokenEnd);

                    MatchCollection tokenStartMatchCollection = Regex.Matches(content, this.RegexTokensStart[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    tokenStartIndex = content.IndexOf(tokenStartMatchCollection[0].Value);

                    // Looking for last [randomcustomblock:X:X] before [/randomcustomblock]
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
                    if (minmax[0] == 0 && minmax[1] == 0)
                    {
                        multiplyCount = pages.Count;
                    }

                    // Preparing content to multiply
                    tokenValue = tokenValue.Replace(tokenStart, pages.Count != 0 ? string.Empty : string.Format("[MenuBlock:{0}:{1}]", minmax[0], minmax[1]));
                    tokenValue = tokenValue.Replace(tokenEnd, pages.Count != 0 ? string.Empty : "[/MenuBlock]");

                    // Multiplying
                    int pageIndex = 0;
                    StringBuilder blockContent = new StringBuilder(tokenValue.Length * multiplyCount);
                    for (int k = 0; k < multiplyCount; k++)
                    {
                        if (pages.Count == 0)
                        {
                            blockContent.Append(this.ReplaceBlockTokens(mainpage, tokenValue, ContentContainer));
                        }
                        else
                        {
                            if (pages.Count <= pageIndex)
                            {
                                pageIndex = 0;
                            }

                            blockContent.Append(this.ReplaceBlockTokens(pages[pageIndex], tokenValue, ContentContainer));
                            pageIndex++;
                        }
                    }

                    // Inserting new content
                    content = content.Insert(tokenStartIndex, blockContent.ToString());
                }

                // Cleaning for left tokens
                content = Regex.Replace(content, this.RegexTokensStart[i], string.Empty, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                content = Regex.Replace(content, this.RegexTokensEnd[i], string.Empty, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            }

            // Replace out of blocks tokens
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
                        content = content.ReplaceOne(matchCollection[k].Value,
                                                       pages.Count != 0
                                                           ? this.ProcessExtensions(pages[this.Random.Next(pages.Count)].Keywords, extensions)
                                                           : "[RandomKeyword" + (extensions.Count == 0 ? string.Empty : ":" + extensions.AsString(":")) + "]");
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
                        content = content.ReplaceOne(matchCollection[k].Value, pages.Count != 0 ? pages[this.Random.Next(pages.Count)].URL : "[RandomKeywordLink]");
                    }
                }
            }

            return content;
        }

        public string[] RegexTokenTokens { get { return new string[] { @"(\[|{)RandomCustomKeyword([a-zA-Z0-9 ]+)*(\]|})" }; } }

        public string[] TokenExtensions { get { return new string[] { "Big", "All", "Com", "BigAllWords", "BigBigWords" }; } }

        public string[] RegexLinkTokens { get { return new string[] { @"(\[|{)RandomCustomLink(\]|})" }; } }

        protected virtual string ReplaceBlockTokens(IPage Page, string Content, IContentContainer ContentContainer)
        {
            // Link
            for (int i = 0; i < this.RegexLinkTokens.Length; i++)
            {
                while (Regex.IsMatch(Content, this.RegexLinkTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    Content = Regex.Replace(Content, this.RegexLinkTokens[i], Page.Type == FileType.Custom ? Page.URL : "[RandomKeywordLink]");
                }
            }

            // Token
            for (int i = 0; i < this.RegexTokenTokens.Length; i++)
            {
                while (Regex.IsMatch(Content, this.RegexTokenTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
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
                            Content = Content.ReplaceOne(matchCollection[k].Value,
                                                           Page.Type == FileType.Custom
                                                               ? this.ProcessExtensions(Page.Keywords, extensions)
                                                               : "[RandomKeyword" + (extensions.Count == 0 ? string.Empty : ":" + extensions.AsString(":")) + "]");
                        }
                    }
                }
            }

            return Content;
        }
    }
}
