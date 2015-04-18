using System;
using System.Collections;
using System.Collections.Generic;
using Umax.Classes.Helpers;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.MarkovChain.Classic
{
    public class MarkovChainClassicTextMaker : TextMaker
    {
        public MarkovChainClassicTextMaker()
        {
            this.StartIndex = new ArrayList();
            this.Words = new Hashtable(10240, .1f);

            this.Settings = new MarkovChainClassicTextSettings();
        }

        public override string Name
        {
            get { return "MarkovChainClassicTextMaker"; }
        }

        public override string Category
        {
            get { return "Standard"; }
        }

        public override string ControlName
        {
            get { return "MarkovChainClassicTextControl"; }
        }

        public override string GUIName
        {
            get { return "Markov Chain: Classic"; }
        }

        protected ArrayList StartIndex { get; set; }

        /// <summary>
        /// Gets or sets words hash table
        /// </summary>
        protected Hashtable Words { get; set; }

        public override object NewInstance()
        {
            return new MarkovChainClassicTextMaker();
        }

        public override string Invoke(string Content, List<string> Keywords)
        {
            return string.Empty;
        }

        protected override void InitializeContent()
        {
            // Work on brackets
            base.InitializeContent();

            // Clear punctuation marks
            if ((this.Settings as MarkovChainClassicTextSettings).TextPunctuationMarks == PunctuationMarksType.DontConsider)
            {
                this.Content = this.Content.Clear(".", ",", "!", "?", ":", ";", "(", ")", "-");
            }

            this.Content = this.Content.Replace("\r", " ").Replace("\n", " ").Replace("\t", " ").Replace("  ", " ");

            this.AnalyzeContent();
        }

        protected void AnalyzeContent()
        {
            Structs.RootWord w = new Structs.RootWord();
            Structs.Child c = new Structs.Child();

            string[] fragments = this.Content.Replace("\r", " ").Replace("\n", " ").Replace("\t", " ").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            bool nextIsStart = false;

            for (int i = 0; i < fragments.Length; i++)
            {
                try
                {
                    string item = fragments[i].ToLower();
                    w = new Structs.RootWord();
                    c = new Structs.Child();

                    if (this.Words.ContainsKey(item))
                    {
                        // Already Exists, add new child word or update count of existing child word
                        if (i < fragments.Length - 1)
                        {
                            w = (Structs.RootWord)this.Words[item];
                            if (nextIsStart)
                            {
                                w.Start = true;
                                nextIsStart = false;
                                this.StartIndex.Add(item);
                            }

                            if (w.Childs.ContainsKey(fragments[i + 1].ToLower()))
                            {
                                // Exists, just update count
                                c = (Structs.Child)w.Childs[fragments[i + 1].ToLower()];
                                c.Occurrence++;
                                w.Childs.Remove(fragments[i + 1].ToLower());
                            }
                            else
                            {
                                // Doesn't Exist, add new word
                                c.Word = fragments[i + 1];
                                c.Occurrence = 1;
                            }

                            w.ChildCount++;
                            w.Childs.Add(fragments[i + 1].ToLower(), c);

                            this.Words.Remove(item);
                            this.Words.Add(item, w);
                        }
                    }
                    else
                    {
                        // New Word
                        w = new Structs.RootWord();
                        w.Childs = new Hashtable();
                        if (i == 0)
                        {
                            w.Start = true;
                            this.StartIndex.Add(item);
                        }

                        w.Word = fragments[i];

                        if (i < fragments.Length - 1)
                        {
                            c.Word = fragments[i + 1];
                            c.Occurrence = 1;
                            w.Childs.Add(fragments[i + 1].ToLower(), c);
                            w.ChildCount = 1;
                        }
                        else
                        {
                            w.End = true;
                        }

                        if (item.Substring(item.Length - 1, 1) == ".")
                        {
                            w.End = true;
                            nextIsStart = true;
                        }
                        else if (nextIsStart)
                        {
                            w.Start = true;
                            nextIsStart = false;
                            this.StartIndex.Add(item);
                        }

                        this.Words.Add(item, w);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        protected override List<string> MakeText(TokenType Type)
        {
            int length = this.MakeTextLength(Type);

            List<string> text = new List<string>(length * 2);
            List<string> output = new List<string>();
            do
            {
                output = this.MakeChain(length);

                for (int i = 0; i < output.Count; i++)
                {
                    text.Add(output[i]);
                }

            } while (text.Count < length);

            return text;
        }

        protected List<string> MakeChain(int Length)
        {
            List<string> text = new List<string>(10);
            Structs.RootWord w = (Structs.RootWord)Words[((string)this.StartIndex[this.Random.Next(this.StartIndex.Count)]).ToLower()];
            text.Add(w.Word + " ");

            Structs.Child c = new Structs.Child();
            ArrayList a = new ArrayList();
            int pos = 0;
            int rnd = 0; int min = 0; int max = 0;

            do
            {
                rnd = this.Random.Next(w.ChildCount/* + 1*/);
                pos = 0;
                foreach (object x in w.Childs)
                {
                    c = (Structs.Child)w.Childs[((DictionaryEntry)x).Key];
                    min = pos;
                    pos += c.Occurrence; //bigger slice for more occurrences
                    max = pos;
                    if (min <= rnd & max >= rnd)
                    {
                        text.Add(c.Word);
                        w = (Structs.RootWord)Words[c.Word.ToLower()];
                        break;
                    }
                }

                if (Length < text.Count)
                {
                    break;
                }
            } while (!w.End);

            return text;
        }
    }
}
