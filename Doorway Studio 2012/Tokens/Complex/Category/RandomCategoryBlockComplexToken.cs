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

namespace Umax.Plugins.Tokens.Complex.Category
{
    public class RandomCategoryBlockComplexToken : MinMaxExtendableToken, IComplexToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public override bool Bold { get { return true; } }

        public override Color Color { get { return Color.Red; } }

        public override string Name { get { return "[RandomCategoryBlock]"; } }

        public override string[] Tokens { get { return new string[] { "[RandomCategoryBlock:X:X]", "[/RandomCategoryBlock]" }; } }

        public override string[] Extensions { get { return new string[] { "Minimum", "Maximum", "Category" }; } }

        public override int Priority { get { return 3; } }

        protected Random Random = new Random();

        public string[] RegexTokens { get { return new string[] { this.RegexTokensStart[0] + "(.*)" + this.RegexTokensEnd[0] }; } }
        protected string[] RegexTokensStart { get { return new string[] { @"(\[|{)RandomCategoryBlock([a-zA-Z0-9 ]+)*(\]|})" }; } }
        protected string[] RegexTokensEnd { get { return new string[] { @"(\[|{)/RandomCategoryBlock(\]|})" }; } }

        public string[] Token
        {
            get
            {
                string begin = "[RandomCategoryBlock:5:10] [CategoryLink] ";
                string end = " [/RandomCategoryBlock:5:10]";
                string subBegin = "[SubCategoryBlock:5:10] [SubCategoryLink] ";
                string subEnd = " [/SubCategoryBlock]";
                return new string[]
                           {
                               begin + "[RandomCategoryKeyword]" + end,
                               begin + "[RandomCategoryKeyword:Big]" + end,
                               begin + "[RandomCategoryKeyword:All]" + end,
                               begin + "[RandomCategoryKeyword:Com]" + end,
                               begin + "[RandomCategoryKeyword:BigAllWords]" + end,
                               begin + "[RandomCategoryKeyword:BigBigWords]" + end,

                               begin + "[RandomCategoryKeyword]" + subBegin + "[SubCategoryKeyword]" + subEnd + end,
                               begin + "[RandomCategoryKeyword:Big]" + subBegin + "[SubCategoryKeyword:Big]" + subEnd + end,
                               begin + "[RandomCategoryKeyword:All]" + subBegin + "[SubCategoryKeyword:All]" + subEnd + end,
                               begin + "[RandomCategoryKeyword:Com]" + subBegin + "[SubCategoryKeyword:Com]" + subEnd + end,
                               begin + "[RandomCategoryKeyword:BigAllWords]" + subBegin + "[SubCategoryKeyword:BigAllWords]" + subEnd + end,
                               begin + "[RandomCategoryKeyword:BigBigWords]" + subBegin + "[SubCategoryKeyword:BigBigWords]" + subEnd + end
                           };
            }
        }

        public string Description(LanguageType Language)
        {
            return "Random category block";
        }

        public string Group { get { return "Standard"; } }

        public string Invoke(IPage Page, IContentContainer ContentContainer)
        {
            string content = Page.Content;

            IPage mainpage = (from IPage item in ContentContainer.Pages
                              where item.Type == FileType.Index && item.ContinueNumber == 0
                              select item).First();

            // Select pages
            List<IPage> pages = (from IPage item in ContentContainer.Pages
                                 where item.Type == FileType.Category && item.ContinueNumber == 0
                                 select item).ToList();

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

                    // Looking for last [randomcategoryblock:X:X] before [/randomcategoryblock]
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
                    StringBuilder blockContent = new StringBuilder(tokenValue.Length * multiplyCount);
                    for (int k = 0; k < multiplyCount; k++)
                    {
                        if (pages.Count == 0)
                        {
                            blockContent.Append(this.ReplaceBlockTokens(mainpage, tokenValue, ContentContainer));
                        }
                        else
                        {
                            blockContent.Append(this.ReplaceBlockTokens(pages[this.Random.Next(pages.Count)], tokenValue, ContentContainer));
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

        public string[] RegexTokenTokens { get { return new string[] { @"(\[|{)RandomCategoryKeyword([a-zA-Z0-9 ]+)*(\]|})" }; } }

        public string[] TokenExtensions { get { return new string[] { "Big", "All", "Com", "BigAllWords", "BigBigWords" }; } }

        public string[] RegexLinkTokens { get { return new string[] { @"(\[|{)RandomCategoryLink(\]|})" }; } }

        protected string ReplaceBlockTokens(IPage Page, string Content, IContentContainer ContentContainer)
        {
            // Link
            for (int i = 0; i < this.RegexLinkTokens.Length; i++)
            {
                while (Regex.IsMatch(Content, this.RegexLinkTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    Content = Regex.Replace(Content, this.RegexLinkTokens[i], Page.Type == FileType.Map ? Page.URL : "[MenuLink]");
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
                                                           Page.Type == FileType.Category
                                                               ? this.ProcessExtensions(Page.Keywords, extensions)
                                                               : "[MenuKeyword" + (extensions.Count == 0 ? string.Empty : ":" + extensions.AsString(":")) + "]");
                        }
                    }
                }
            }

            // Replace subcategory
            IPage mainpage = (from IPage item in ContentContainer.Pages
                              where item.Type == FileType.Index && item.ContinueNumber == 0
                              select item).First();


            // Select pages
            List<IPage> pages = (from IPage item in ContentContainer.Pages
                                 where item.Type == FileType.Category && item.ContinueNumber == 0 && Page.Category.Categories.Contains(item.Category)
                                 select item).ToList();

            for (int i = 0; i < this.RegexSubTokens.Length; i++)
            {
                if (!Regex.IsMatch(Content, this.RegexSubTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    continue;
                }

                while (Regex.IsMatch(Content, this.RegexSubTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    string tokenStart = string.Empty;
                    int tokenStartIndex = 0;

                    string tokenEnd = Regex.Match(Content, this.RegexSubTokensStart[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline).Value;
                    int tokenEndIndex = Content.IndexOf(tokenEnd);

                    MatchCollection tokenStartMatchCollection = Regex.Matches(Content, this.RegexSubTokensStart[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    tokenStartIndex = Content.IndexOf(tokenStartMatchCollection[0].Value);

                    // Looking for last [subcategoryblock:X:X] before [/subcategoryblock]
                    for (int k = 0; k < tokenStartMatchCollection.Count; k++)
                    {
                        int tokenIndex = Content.LastIndexOf(this.RegexSubTokensStart[i], tokenStartMatchCollection[k].Value, tokenEndIndex);
                        if (tokenEndIndex < tokenIndex || tokenIndex < 0)
                        {
                            break;
                        }

                        tokenStartIndex = tokenIndex;
                    }

                    // Replacing
                    string tokenValue = Content.Substring(tokenStartIndex, tokenEndIndex + tokenEnd.Length - tokenStartIndex);
                    Content = Content.Remove(tokenStartIndex, tokenEndIndex + tokenEnd.Length - tokenStartIndex);

                    tokenStart = Regex.Match(tokenValue, this.RegexSubTokensStart[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline).Value;

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
                            blockContent.Append(this.ReplaceSubBlockTokens(mainpage, tokenValue, ContentContainer));
                        }
                        else
                        {
                            if (pages.Count <= pageIndex)
                            {
                                pageIndex = 0;
                            }

                            blockContent.Append(this.ReplaceSubBlockTokens(pages[pageIndex], tokenValue, ContentContainer));
                            pageIndex++;
                        }
                    }

                    // Inserting new content
                    Content = Content.Insert(tokenStartIndex, blockContent.ToString());
                }

                // Cleaning for left tokens
                Content = Regex.Replace(Content, this.RegexTokensStart[i], string.Empty, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                Content = Regex.Replace(Content, this.RegexTokensEnd[i], string.Empty, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            }

            return Content;
        }

        public string[] SubTokens { get { return new string[] { "[SubCategoryBlock:X:X]", "[/SubCategoryBlock]" }; } }

        public string[] SubExtensions { get { return new string[] { "Minimum", "Maximum" }; } }

        public string[] RegexSubTokens { get { return new string[] { this.RegexTokensStart[0] + "(.*)" + this.RegexTokensEnd[0] }; } }
        protected string[] RegexSubTokensStart { get { return new string[] { @"(\[|{)SubCategoryBlock([a-zA-Z0-9 ]+)*(\]|})" }; } }
        protected string[] RegexSubTokensEnd { get { return new string[] { @"(\[|{)/SubCategoryBlock(\]|})" }; } }


        public string[] RegexSubTokenTokens { get { return new string[] { @"(\[|{)SubCategoryKeyword([a-zA-Z0-9 ]+)*(\]|})" }; } }

        public string[] SubTokenExtensions { get { return new string[] { "Big", "All", "Com", "BigAllWords", "BigBigWords" }; } }

        public string[] RegexSubLinkTokens { get { return new string[] { @"(\[|{)SubCategoryLink(\]|})" }; } }

        protected string ReplaceSubBlockTokens(IPage Page, string Content, IContentContainer ContentContainer)
        {
            // Link
            for (int i = 0; i < this.RegexSubLinkTokens.Length; i++)
            {
                while (Regex.IsMatch(Content, this.RegexSubLinkTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    Content = Regex.Replace(Content, this.RegexSubLinkTokens[i], Page.Type == FileType.Map ? Page.URL : "[MenuLink]");
                }
            }

            // Token
            for (int i = 0; i < this.RegexSubTokenTokens.Length; i++)
            {
                while (Regex.IsMatch(Content, this.RegexSubTokenTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    if (!Regex.IsMatch(Content, this.RegexSubTokenTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                    {
                        continue;
                    }

                    MatchCollection matchCollection = Regex.Matches(Content, this.RegexSubTokenTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);

                    for (int k = 0; k < matchCollection.Count; k++)
                    {
                        List<string> extensions = this.GetExtensions(matchCollection[k].Value);

                        while (Content.Contains(matchCollection[k].Value))
                        {
                            Content = Content.ReplaceOne(matchCollection[k].Value,
                                                         Page.Type == FileType.Category
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
