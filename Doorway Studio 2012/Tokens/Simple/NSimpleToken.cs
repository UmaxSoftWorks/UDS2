using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using Umax.Classes.Tokens;
using Umax.Interfaces.Compatibility.Tokens;
using Umax.Interfaces.Enums;
using Umax.Interfaces.TemplateEditor;
using Umax.Interfaces.Tokens;

namespace Umax.Plugins.Tokens.Simple
{
    public class NSimpleToken : MinMaxExtendableToken, ISimpleToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public override bool Bold { get { return true; } }

        public override Color Color { get { return Color.Black; } }

        public override string Name { get { return "[N:X:X]"; } }

        public override int Priority { get { return 1; } }

        public override string[] Tokens { get { return new string[] { "[N:X:X]" }; } }

        public override string[] Extensions { get { return new string[] {"Minimum", "Maximum"}; } }

        protected Random Random = new Random();

        public string[] RegexTokens { get { return new string[] { @"(\[|{)N:[0-9]+:[0-9]+(\]|})" }; } }

        public string[] Token { get { return new string[] { "[N:1:10]" }; } }

        public string Description(LanguageType Language)
        {
            return "Random number between minimum and maximum";
        }

        public string Group { get { return "Standard"; } }

        public string Invoke(string Content)
        {
            for (int i = 0; i < this.RegexTokens.Length; i++)
            {
                while (Regex.IsMatch(Content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase))
                {
                    MatchCollection collection = Regex.Matches(Content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase);

                    int matchPosition = 0;
                    for (int k = 0; k < collection.Count; k++)
                    {
                        // Minimum and maximum
                        List<int> minmax = this.GetMinMaxExtensions(collection[k].Value);

                        // Replacing
                        while (Content.Contains(collection[k].Value))
                        {
                            matchPosition = Content.IndexOf(collection[k].Value);
                            Content = Content.Remove(matchPosition, collection[k].Value.Length);
                            Content = Content.Insert(matchPosition, this.Random.Next(minmax[0], minmax[1]).ToString());
                        }
                    }
                }
            }

            return Content;
        }
    }
}
