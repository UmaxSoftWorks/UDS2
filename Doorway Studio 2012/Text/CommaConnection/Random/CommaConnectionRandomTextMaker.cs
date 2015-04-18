using System;
using System.Collections.Generic;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Plugins.Text.CommaConnection.Common;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.CommaConnection.Random
{
    public class CommaConnectionRandomTextMaker : TextMaker
    {
        public CommaConnectionRandomTextMaker()
        {
            this.Settings = new CommaConnectionTextSettings();
        }

        public override string Name
        {
            get { return "CommaConnectionRandomTextMaker"; }
        }

        public override string Category
        {
            get { return "Standard"; }
        }

        public override string ControlName
        {
            get { return "CommaConnectionRandomTextControl"; }
        }

        public override string GUIName
        {
            get { return "CommaConnection: Random"; }
        }

        /// <summary>
        /// Gets or sets Working set of text
        /// </summary>
        protected string[] Fragments { get; set; }

        public override object NewInstance()
        {
            return new CommaConnectionRandomTextMaker();
        }

        public override string Invoke(string Content, List<string> Keywords)
        {
            return string.Empty;
        }

        protected override void InitializeContent()
        {
            // Work on brackets
            base.InitializeContent();

            this.Fragments = this.Content.Split(StringSplitType.Sentence, StringSplitOptions.RemoveEmptyEntries);
        }

        protected override List<string> MakeText(TokenType Type)
        {
            int length = this.MakeTextLength(Type);

            List<string> text = new List<string>(length);

            while (text.Count < length)
            {
                string[] parts =
                    this.Fragments[this.Random.Next(this.Fragments.Length)].Split(StringSplitType.Fragment, StringSplitOptions.RemoveEmptyEntries);

                text.AddRange(parts[this.Random.Next(parts.Length)].Split(new char[] { ' ' },
                                                                              StringSplitOptions.RemoveEmptyEntries));
                text.Add((this.Random.Next(5) == 0) ? "." : ",");
            }

            return text;
        }
    }
}
