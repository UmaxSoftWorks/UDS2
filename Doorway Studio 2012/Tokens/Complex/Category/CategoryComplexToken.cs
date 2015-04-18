using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
    public class CategoryComplexToken : ExtendableToken, IComplexToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public override bool Bold { get { return true; } }

        public override Color Color { get { return Color.Red; } }

        public override string Name { get { return "[Category]"; } }

        public override string[] Tokens { get { return new string[] { "[Category(:X:X:X:X)]" }; } }

        public override string[] Extensions { get { return new string[] { "Big", "All", "Com", "BigAllWords", "BigBigWords", "Next", "Prev", "Circle", "Category" }; } }

        public override int Priority { get { return 4; } }

        public string[] RegexTokens { get { return new string[] { @"(\[|{)Category([a-zA-Z0-9 ]+)*(\]|})" }; } }

        protected Random Random = new Random();

        public string[] RegexLinkTokens { get { return new string[] { @"(\[|{)CategoryLink([a-zA-Z0-9 ]+)*(\]|})" }; } }

        public string[] RegexLinkExtensions { get { return new string[] { "Next", "Prev", "Circle", "Category" }; } }

        public string[] Token
        {
            get
            {
                return new string[]
                           {
                               "[Category]",
                               "[Category:Big]",
                               "[Category:All]",
                               "[Category:Com]",
                               "[Category:BigAllWords]",
                               "[Category:BigBigWords]",
                               "[Category:Next]",
                               "[Category:Prev]",
                               "[Category:Next:Circle]",
                               "[Category:Prev:Circle]",
                               "[Category:Next:Category]",
                               "[Category:Prev:Category]",
                               "[CategoryLink]",
                               "[CategoryLink:Next]",
                               "[CategoryLink:Prev]",
                               "[CategoryLink:Next:Circle]",
                               "[CategoryLink:Prev:Circle]",
                               "[CategoryLink:Next:Category]",
                               "[CategoryLink:Prev:Category]"
                           };
            }
        }

        public string Description(LanguageType Language)
        {
            return "Category";
        }

        public string Group { get { return "Standard"; } }

        public string Invoke(IPage Page, IContentContainer ContentContainer)
        {
            string content = Page.Content;

            // Token
            for (int i = 0; i < this.RegexTokens.Length; i++)
            {
                if (!Regex.IsMatch(content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    continue;
                }

                MatchCollection matchCollection = Regex.Matches(content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);

                for (int k = 0; k < matchCollection.Count; k++)
                {
                    List<string> extensions = this.GetExtensions(matchCollection[k].Value);

                    while (content.Contains(matchCollection[k].Value))
                    {
                        content = content.ReplaceOne(matchCollection[k].Value, this.ProcessExtensions(this.ProcessExtensions(Page, ContentContainer, extensions).Keywords, extensions));
                    }
                }
            }

            // Link
            for (int i = 0; i < this.RegexLinkTokens.Length; i++)
            {
                if (!Regex.IsMatch(content, this.RegexLinkTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    continue;
                }

                MatchCollection matchCollection = Regex.Matches(content, this.RegexLinkTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);

                for (int k = 0; k < matchCollection.Count; k++)
                {
                    List<string> extensions = this.GetExtensions(matchCollection[k].Value);

                    content = content.Replace(matchCollection[k].Value, this.ProcessExtensions(Page, ContentContainer, extensions).URL);
                }
            }

            return content;
        }

        protected virtual IPage ProcessExtensions(IPage Page, IContentContainer ContentContainer, List<string> Extensions)
        {
            // Select all map pages
            List<IPage> pages = Extensions.Contains("Category", true)
                                    ? (from IPage item in ContentContainer.Pages
                                       where item.Type == FileType.Category && item.Category == Page.Category && item.ContinueNumber == 0
                                       select item).ToList()
                                    : (from IPage item in ContentContainer.Pages
                                       where item.Type == FileType.Category && item.ContinueNumber == 0
                                       select item).ToList();

            // None
            IPage result = Page.Type == FileType.Category
                               ? Page
                               : (from IPage item in ContentContainer.Pages
                                  where item.Type == FileType.Index
                                  orderby item.ContinueNumber
                                  select item).First();

            if (Page.Type == FileType.Page)
            {
                int index = pages.IndexOf(Page);

                // Prev
                if (Extensions.Contains("Prev", true))
                {
                    if (Extensions.Contains("Circle", true))
                    {
                        result = index == 0 ? pages[0] : pages[index - 1];
                    }
                    else
                    {
                        result = index == 0 ? pages.Last() : pages[index - 1];
                    }
                }

                // Next
                if (Extensions.Contains("Next", true))
                {
                    if (Extensions.Contains("Circle", true))
                    {
                        result = (index + 1) == pages.Count ? pages[0] : pages[index + 1];
                    }
                    else
                    {
                        result = (index + 1) == pages.Count ? pages[index] : pages[index + 1];
                    }
                }
            }

            return result;
        }
    }
}
