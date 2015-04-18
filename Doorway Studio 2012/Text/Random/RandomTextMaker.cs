using System;
using System.Collections.Generic;
using Umax.Classes.Enums;
using Umax.Plugins.Text.Common;
using Umax.Classes.Helpers;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.Random
{
    public class RandomTextMaker : TextMaker
    {
        public RandomTextMaker()
        {
            this.Settings = new RandomTextSettings();
        }

        public override string Name
        {
            get { return "RandomTextMaker"; }
        }

        public override string Category
        {
            get { return "Standard"; }
        }

        public override string ControlName
        {
            get { return "RandomTextControl"; }
        }

        public override string GUIName
        {
            get { return "Random"; }
        }

        /// <summary>
        /// Gets or sets Working set of text
        /// </summary>
        protected string[] Fragments { get; set; }

        public override object NewInstance()
        {
            return new RandomTextMaker();
        }

        public override string Invoke(string Content, List<string> Keywords)
        {
            return string.Empty;
        }

        protected override void InitializeContent()
        {
            // Work on brackets
            base.InitializeContent();

            this.Fragments = this.Content.ToLower().Split((this.Settings as RandomTextSettings).TextSplit,
                                           StringSplitOptions.RemoveEmptyEntries);

            // Clear punctuation marks
            if ((this.Settings as RandomTextSettings).TextPunctuationMarks == PunctuationMarksType.DontConsider)
            {
                for (int i = 0; i < this.Fragments.Length; i++)
                {
                    this.Fragments[i] = this.Fragments[i].Clear(".", ",", "!", "?", ":", ";", "(", ")", "-");
                }
            }
        }

        protected override List<string> MakeText(TokenType Type)
        {
            int index = 0;
            int length = this.MakeTextLength(Type);

            List<string> text = new List<string>(length);

            do
            {
                index = this.MakeIndex();
                
                if ((this.Settings as RandomTextSettings).TextConstruction == ConstructionType.Short)
                {
                    text.AddRange(this.Fragments[index].Split(StringSplitType.Word, StringSplitOptions.RemoveEmptyEntries));
                }
                else
                {
                    int plus = this.Random.Next((this.Settings as RandomTextSettings).TextConstructionMin, (this.Settings as RandomTextSettings).TextConstructionMax);
                    for (int i = index; i < index + plus; i++)
                    {
                        if (i < this.Fragments.Length)
                        {
                            text.AddRange(this.Fragments[i].Split(StringSplitType.Word, StringSplitOptions.RemoveEmptyEntries));
                        }
                        else { break; }
                    }
                }
            } while (text.Count < length);

            return text;
        }

        protected int MakeIndex()
        {
            int index = -1;

            while (index < 0 || this.Fragments.Length < index)
            {
                index = this.Random.Next(this.Fragments.Length) +
                        (((this.Random.Next(2) == 0) ? 1 : -1)*
                         this.Random.Next((this.Settings as RandomTextSettings).TextRadius));
            }

            return index;
        }
    }
}
