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

namespace Umax.Plugins.Tokens.Simple.DateTime
{
    public class RuDateSimpleToken : ExtendableToken, ISimpleToken, ITokensRegexCompatible, ITokenTemplateEditorCompatible
    {
        public override bool Bold { get { return true; } }

        public override Color Color { get { return Color.Black; } }

        public override string Name { get { return "[RuDate]"; } }

        public override int Priority { get { return 4; } }

        public override string[] Tokens { get { return new string[] { "[RuDate(:X)]" }; } }

        public override string[] Extensions { get { return new string[] { "Random" }; } }

        public string[] RegexTokens { get { return new string[] { @"(\[|{)RuDate([a-zA-Z0-9 ]+)*(\]|})" }; } }

        public string[] Token { get { return new string[] { "[RuDate]", "[RuDate:Random]" }; } }

        public string Description(LanguageType Language)
        {
            return "Russian format date";
        }

        public string Group { get { return "Standard"; } }

        protected Random Random = new Random();

        public string Invoke(string Content)
        {
            for (int i = 0; i < this.RegexTokens.Length; i++)
            {
                if (!Regex.IsMatch(Content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
                {
                    continue;
                }

                MatchCollection matchCollection = Regex.Matches(Content, this.RegexTokens[i], RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);

                for (int k = 0; k < matchCollection.Count; k++)
                {
                    List<string> extensions = this.GetExtensions(matchCollection[k].Value);

                    if (extensions.Contains("Random", true))
                    {
                        // Replacing
                        int tokenIndex = 0;
                        while (Content.Contains(matchCollection[k].Value))
                        {
                            tokenIndex = Content.IndexOf(matchCollection[k].Value);
                            Content = Content.Remove(tokenIndex, matchCollection[k].Value.Length);
                            Content = Content.Insert(tokenIndex,
                                                     this.Random.Next(1, 31).ToString() + "." + this.Random.Next(1, 13).ToString() + "." +
                                                     this.Random.Next(global::System.DateTime.Now.Year - 5, global::System.DateTime.Now.Year + 5).ToString());
                        }
                    }
                    else
                    {
                        Content = Content.Replace(matchCollection[k].Value,
                                                  global::System.DateTime.Now.Day.ToString() + "." + global::System.DateTime.Now.Month.ToString() + "." + global::System.DateTime.Now.Year.ToString());
                    }
                }
            }

            return Content;
        }
    }
}
