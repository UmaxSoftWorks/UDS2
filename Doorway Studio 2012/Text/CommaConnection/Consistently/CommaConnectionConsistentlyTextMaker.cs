using System;
using System.Collections.Generic;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Plugins.Text.CommaConnection.Common;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.CommaConnection.Consistently
{
    public class CommaConnectionConsistentlyTextMaker : TextMaker
    {
        public CommaConnectionConsistentlyTextMaker()
        {
            this.Settings = new CommaConnectionTextSettings();
        }

        public override string Name
        {
            get { return "CommaConnectionConsistentlyTextMaker"; }
        }

        public override string Category
        {
            get { return "Standard"; }
        }

        public override string ControlName
        {
            get { return "CommaConnectionConsistentlyTextControl"; }
        }

        public override string GUIName
        {
            get { return "CommaConnection: Consistently"; }
        }

        /// <summary>
        /// Gets or sets Working set of text
        /// </summary>
        protected string[] Fragments { get; set; }

        public override object NewInstance()
        {
            return new CommaConnectionConsistentlyTextMaker();
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
            int currentPart = 0;
            int currentSentense = this.Random.Next(this.Fragments.Length);
            int length = this.MakeTextLength(Type);

            List<string> text = new List<string>(length);

            while (text.Count < length)
            {
                string[] parts =
                    this.Fragments[currentSentense].Split(StringSplitType.Fragment, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length <= currentPart)
                {
                    text.Add(".");
                    currentPart = 0;
                    currentSentense = this.Random.Next(this.Fragments.Length);
                }

                text.AddRange(parts[currentPart].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                text.Add(",");

                currentPart++;
                currentSentense++;
            }

            return text;
        }
    }
}
