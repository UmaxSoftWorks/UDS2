using System;
using System.Collections.Generic;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.Mix
{
    public class MixTextMaker : TextMaker
    {
        public MixTextMaker()
        {
            this.Settings = new MixTextSettings();
        }

        public override string Name
        {
            get { return "MixTextMaker"; }
        }
        public override string Category
        {
            get { return "Standard"; }
        }

        public override string ControlName
        {
            get { return "MixTextControl"; }
        }

        public override string GUIName
        {
            get { return "Mix"; }
        }

        /// <summary>
        /// Gets or sets Working set of text
        /// </summary>
        protected string[] Fragments { get; set; }

        public override object NewInstance()
        {
            return new MixTextMaker();
        }

        public override string Invoke(string Content, List<string> Keywords)
        {
            return string.Empty;
        }

        protected override void InitializeContent()
        {
            // Work on brackets
            base.InitializeContent();

            this.Fragments = this.Content.ToLower().Split((this.Settings as MixTextSettings).TextSplit,
                                           StringSplitOptions.RemoveEmptyEntries);

            // Clear punctuation marks
            if ((this.Settings as MixTextSettings).TextPunctuationMarks == PunctuationMarksType.DontConsider)
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
                if (this.Fragments.Length < index)
                {
                    index = 0;
                }

                text.AddRange(this.Fragments[index].Split(StringSplitType.Word, StringSplitOptions.RemoveEmptyEntries));
                index++;
            }

            // Mix
            for (int i = 0; i < text.Count; i++)
            {
                index = this.Random.Next((this.Settings as MixTextSettings).TextRadius);

                if (this.Random.Next(0, 2) == 0)
                {
                    if ((i - index) > 0)
                    {
                        text.Swap(i, i - index);
                    }
                    else
                    {
                        text.Swap(text.Count - 1, text.Count - 1 - index);
                    }
                }
                else
                {
                    if ((i + index) < text.Count)
                    {
                        text.Swap(i, i + index);
                    }
                    else
                    {
                        if (index < text.Count)
                        {
                            text.Swap(0, index);
                        }
                        else
                        {
                            text.Swap(text.Count - 1, 0);
                        }
                    }
                }
            }

            return text;
        }
    }
}
