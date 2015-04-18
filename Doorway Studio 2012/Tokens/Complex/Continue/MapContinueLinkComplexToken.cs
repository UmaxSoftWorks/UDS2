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

namespace Umax.Plugins.Tokens.Complex.Continue
{
    public class MapContinueLinkComplexToken : ExtendableToken, IComplexToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public override bool Bold { get { return true; } }

        public override Color Color { get { return Color.Red; } }

        public override string Name { get { return "[MapContinueLink]"; } }

        public override string[] Tokens { get { return new string[] { "[MapContinueLink(:X)]" }; } }

        public override string[] Extensions { get { return new string[] { "Random", "Next", "Prev", "Last", "Circle" }; } }

        public override int Priority { get { return 3; } }

        protected Random Random = new Random();

        public string[] RegexTokens { get { return new string[] { @"(\[|{)MapContinueLink([a-zA-Z0-9 ]+)*(\]|})" }; } }

        public string[] Token
        {
            get
            {
                return new string[]
                           {
                               "[MapContinueLink:Random]", "[MapContinueLink:Next]",
                               "[MapContinueLink:Prev]", "[MapContinueLink:Last]",
                               "[MapContinueLink:Prev:Circle]", "[MapContinueLink:Last:Circle]"
                           };
            }
        }

        public string Description(LanguageType Language)
        {
            return "Map continue link";
        }

        public string Group { get { return "Standard"; } }

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
                    List<string> extensions = this.GetExtensions(matchCollection[k].Value);

                    content = content.ReplaceOne(matchCollection[k].Value, this.ProcessExtensions(Page, ContentContainer, extensions).URL);
                }
            }

            return content;
        }

        protected virtual IPage ProcessExtensions(IPage Page, IContentContainer ContentContainer, List<string> Extensions)
        {
            // Select all map pages
            List<IPage> pages = (from IPage item in ContentContainer.Pages
                                 where item.Type == FileType.Map
                                 orderby item.ContinueNumber
                                 select item).ToList();

            // None
            IPage result = (from IPage item in ContentContainer.Pages
                            where item.Type == FileType.Index
                            orderby item.ContinueNumber
                            select item).First();

            if (pages.Count == 0)
            {
                return result;
            }

            // Random
            if (Extensions.Contains("Random", true))
            {
                result = pages[this.Random.Next(pages.Count)];
            }

            // Last
            if (Extensions.Contains("Last", true))
            {
                result = pages.Last();
            }

            if (Page.Type == FileType.Map)
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
