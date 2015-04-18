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

namespace Umax.Plugins.Tokens.Complex.Blocks
{
    public class PageBlockComplexToken : MinMaxExtendableToken, IComplexToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public override bool Bold { get { return true; } }

        public override Color Color { get { return Color.Red; } }

        public override string Name { get { return "[PageBlock]"; } }

        public override string[] Tokens { get { return new string[] { "[PageBlock:X:X]", "[/PageBlock]" }; } }

        public override string[] Extensions { get { return new string[] { "Minimum", "Maximum", "Category" }; } }

        public override int Priority { get { return 3; } }

        protected Random Random = new Random();

        public string[] RegexTokens { get { return new string[] { this.RegexTokensStart[0] + "(.*)" + this.RegexTokensEnd[0] }; } }
        protected string[] RegexTokensStart { get { return new string[] { @"(\[|{)PageBlock([a-zA-Z0-9 ]+)*(\]|})" }; } }
        protected string[] RegexTokensEnd { get { return new string[] { @"(\[|{)/PageBlock(\]|})" }; } }

        public string[] Token
        {
            get
            {
                string begin = "[PageBlock:5:10] [PageLink] ";
                string end = " [/PageBlock:5:10]";
                return new string[]
                           {
                               begin + "[PageKeyword]" + end,
                               begin + "[PageKeyword:Big]" + end,
                               begin + "[PageKeyword:All]" + end,
                               begin + "[PageKeyword:Com]" + end,
                               begin + "[PageKeyword:BigAllWords]" + end,
                               begin + "[PageKeyword:BigBigWords]" + end
                           };
            }
        }

        public string Description(LanguageType Language)
        {
            return "Page block";
        }

        public string Group { get { return "Standard"; } }

        public string Invoke(IPage Page, IContentContainer ContentContainer)
        {
            string content = Page.Content;

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

                    // Looking for last [pageblock:X:X] before [/pageblock]
                    for (int k = 0; k < tokenStartMatchCollection.Count; k++)
                    {
                        int tokenIndex = content.LastIndexOf(this.RegexTokensStart[i], tokenStartMatchCollection[k].Value, tokenEndIndex);
                        if (tokenEndIndex < tokenIndex || tokenIndex < 0)
                        {
                            break;
                        }

                        tokenStartIndex = tokenIndex;
                    }

                    // Select pages
                    List<IPage> pages = this.GetExtensions(tokenStart).Contains("Category", true)
                                            ? (from IPage item in ContentContainer.Pages
                                               where item.Type == FileType.Page && item.Category == Page.Category
                                               select item).ToList()
                                            : (from IPage item in ContentContainer.Pages
                                               where item.Type == FileType.Page
                                               select item).ToList();

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

            return content;
        }

        public string[] RegexTokenTokens { get { return new string[] { @"(\[|{)PageKeyword([a-zA-Z0-9 ]+)*(\]|})" }; } }

        public string[] TokenExtensions { get { return new string[] { "Big", "All", "Com", "BigAllWords", "BigBigWords" }; } }

        public string[] RegexLinkTokens { get { return new string[] { @"(\[|{)PageLink(\]|})" }; } }

        protected string ReplaceBlockTokens(IPage Page, string Content, IContentContainer ContentContainer)
        {
            // Link
            for (int i = 0; i < this.RegexLinkTokens.Length; i++)
            {
                while (Regex.IsMatch(Content, this.RegexLinkTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    Content = Regex.Replace(Content, this.RegexLinkTokens[i], Page.Type == FileType.Page ? Page.URL : "[MenuLink]");
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
                                                           Page.Type == FileType.Page
                                                               ? this.ProcessExtensions(Page.Keywords, extensions)
                                                               : "[MenuKeyword" + (extensions.Count == 0 ? string.Empty : ":" + extensions.AsString(":")) + "]");
                        }
                    }
                }
            }

            return Content;
        }
    }
}
