using System;
using System.Collections.Generic;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.CopyPaste.Random
{
    public class CopyPasteRandomTextMaker : TextMaker
    {
        public CopyPasteRandomTextMaker()
        {
            this.Settings = new CopyPasteRandomTextSettings();
        }

        public override string Name
        {
            get { return "CopyPasteRandomTextMaker"; }
        }

        public override string Category
        {
            get { return "Standard"; }
        }

        public override string ControlName
        {
            get { return "CopyPasteRandomTextControl"; }
        }

        public override string GUIName
        {
            get { return "Copy/Paste: Random"; }
        }

        /// <summary>
        /// Gets or sets Working set of text
        /// </summary>
        protected string[] Fragments { get; set; }

        public override object NewInstance()
        {
            return new CopyPasteRandomTextMaker();
        }

        public override string Invoke(string Content, List<string> Keywords)
        {
            return string.Empty;
        }

        protected override void InitializeContent()
        {
            // Work on brackets
            base.InitializeContent();

            this.Fragments = this.Content.ToLower().Split(StringSplitType.Word, StringSplitOptions.RemoveEmptyEntries);

            // Clear punctuation marks
            if ((this.Settings as CopyPasteRandomTextSettings).TextPunctuationMarks == PunctuationMarksType.DontConsider)
            {
                for (int i = 0; i < this.Fragments.Length; i++)
                {
                    this.Fragments[i] = this.Fragments[i].Clear(".", ",", "!", "?", ":", ";", "(", ")", "-");
                }
            }
        }

        protected override List<string> MakeText(TokenType Type)
        {
            int index = this.Random.Next(this.Fragments.Length);
            int length = this.MakeTextLength(Type);

            List<string> text = new List<string>(length);

            while (text.Count < length)
            {
                text.Add(this.Fragments[index]);

                index++;
                if (this.Fragments.Length < index)
                {
                    index = 0;
                }
            }

            return text;
        }
    }
}
