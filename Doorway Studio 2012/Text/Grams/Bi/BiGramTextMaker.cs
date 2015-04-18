using System;
using System.Collections.Generic;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.Grams.Bi
{
    public class BiGramTextMaker : TextMaker
    {
        public BiGramTextMaker()
        {
            this.Settings = new BiGramTextSettings();
        }

        public override string Name
        {
            get { return "BiGramTextMaker"; }
        }

        public override string Category
        {
            get { return "Standard"; }
        }

        public override string ControlName
        {
            get { return "BiGramTextControl"; }
        }

        public override string GUIName
        {
            get { return "BiGram"; }
        }

        /// <summary>
        /// Gets or sets Working set of text
        /// </summary>
        protected string[] Fragments { get; set; }
        protected string[] CompleteFragments { get; set; }
        protected int[] Hash { get; set; }
        protected double[] Probability { get; set; }

        public override object NewInstance()
        {
            return new BiGramTextMaker();
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
            if ((this.Settings as BiGramTextSettings).TextPunctuationMarks ==
                PunctuationMarksType.DontConsider)
            {
                for (int i = 0; i < this.Fragments.Length; i++)
                {
                    this.Fragments[i] = this.Fragments[i].Clear(".", ",", "!", "?", ":", ";", "(", ")", "-");
                }
            }

            this.CompleteFragments = new string[this.Fragments.Length];

            this.Probability = new double[this.Fragments.Length];

            for (int i = 0; i < this.Fragments.Length; i++)
            {
                this.CompleteFragments[i] = this.Fragments[i];
            }
            
            if ((this.Settings as BiGramTextSettings).TextAnalysis == AnalyseType.WithoutEndings)
            {
                for (int i = 0; i < this.Fragments.Length; i++)
                {
                    if ((this.Settings as BiGramTextSettings).TextAnalysisLength < this.Fragments[i].Length)
                    {
                        this.Fragments[i] = this.Fragments[i].Substring(0, (this.Settings as BiGramTextSettings).TextAnalysisLength);
                    }
                }
            }

            this.Hash = new int[this.Fragments.Length];

            for (int i = 0; i < this.Fragments.Length; i++)
            {
                this.Hash[i] = this.Fragments[i].GetHashCode();
            }

            // Probability crunching
            for (int i = 0; i < this.Fragments.Length; i++)
            {
                if (i == 0)
                {
                    // First word
                    this.Probability[i] = (double)this.GetWordCount(i) / (double)this.Fragments.Length;
                }
                else
                {
                    // All other words
                    this.Probability[i] = (double)this.GetWordsCount(i - 1, i) / (double)(this.GetWordCount(i) * this.Fragments.Length);
                }
            }
        }

        protected int GetWordsCount(int IndexOne, int IndexTwo)
        {
            int count = 0;

            for (int i = 1; i < this.Fragments.Length; i++)
            {
                if (this.Hash[IndexOne] == this.Hash[i - 1] && this.Hash[IndexTwo] == this.Hash[i])
                {
                    count++;
                }
            }

            return count;
        }

        protected int GetWordCount(int Index)
        {
            int count = 0;

            for (int i = 0; i < this.Fragments.Length; i++)
            {
                if (this.Hash[Index] == this.Hash[i])
                {
                    count++;
                }
            }

            return count;
        }

        protected override List<string> MakeText(TokenType Type)
        {
            int length = this.MakeTextLength(Type);
            int index = this.Random.Next(this.Fragments.Length);

            List<string> text = new List<string>(length);

            text.Add(this.CompleteFragments[index]);

            while (text.Count < length)
            {
                try
                {
                    index = this.GetNextIndex(index);

                    if ((this.Settings as BiGramTextSettings).TextConstruction == ConstructionType.Short)
                    {
                        text.Add(this.CompleteFragments[index]);
                    }
                    else
                    {
                        int r = this.Random.Next((this.Settings as BiGramTextSettings).TextConstructionMin, (this.Settings as BiGramTextSettings).TextConstructionMax);
                        for (int i = 0; i < r; i++)
                        {
                            try
                            {
                                text.Add(this.CompleteFragments[index + i]);
                            }
                            catch (Exception)
                            {
                                break;
                            }
                        }

                        index += r;
                    }
                }
                catch (Exception)
                {
                }
            }

            return text;
        }

        protected int GetNextIndex(int CurrentIndex)
        {
            List<int> positions = new List<int>();
            for (int i = 0; i < this.Fragments.Length - 1; i++)
            {
                if (((this.Probability[CurrentIndex] - this.Probability[CurrentIndex]/4) <= this.Probability[i] &&
                     this.Probability[i] <= (this.Probability[CurrentIndex] + this.Probability[CurrentIndex]/4)) &&
                    (this.Hash[i] != this.Hash[CurrentIndex]) && (i != CurrentIndex))
                {
                    positions.Add(i + 1);
                }
            }

            try
            {
                return positions[this.Random.Next(positions.Count)];
            }
            catch (Exception)
            {
                return this.Random.Next(this.Fragments.Length);
            }
        }
    }
}
