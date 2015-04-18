using System;
using System.Collections.Generic;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Extensibility.Tokens;

namespace Umax.Classes.Tokens
{
    public abstract class ExtendableToken : Token, IExtendableToken
    {
        public abstract string[] Extensions { get; }

        /// <summary>
        /// Gets token extensions
        /// </summary>
        /// <param name="Token">Token value</param>
        /// <returns>List of extension</returns>
        public List<string> GetExtensions(string Token)
        {
            List<string> extensions = new List<string>();

            Token = Token.Trim(' ', '[', ']', '}', '{');
            string[] parts = Token.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 0)
            {
                for (int i = 1; i < parts.Length; i++)
                {
                    extensions.Add(parts[i]);
                }
            }

            return extensions;
        }

        public string ProcessExtensions(List<string> Items, List<string> Extensions)
        {
            string item = string.Empty;

            if (Extensions.Contains("All", true))
            {
                item = Items.AsString();
            }
            else
            {
                item = Items[new Random(Environment.TickCount).Next(Items.Count)];
            }

            return this.ProcessExtensions(item, Extensions);
        }

        public string ProcessExtensions(string Text, List<string> Extensions)
        {
            if (Extensions.Contains("Com", true))
            {
                Text = Text.Replace(" ", ", ").Trim(' ', ',');
            }

            if (Extensions.Contains("Big", true))
            {
                Text = Text.ToUpper(StringToUpperType.FirstWord);
            }

            if (Extensions.Contains("BigBigWords", true))
            {
                Text = Text.ToUpper(StringToUpperType.BigWords);
            }

            if (Extensions.Contains("BigAllWords", true))
            {
                Text = Text.ToUpper(StringToUpperType.AllWords);
            }

            return Text;
        }
    }
}
