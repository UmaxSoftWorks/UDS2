using System;
using System.Collections.Generic;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.MarkovChain.Custom
{
    public class MarkovChainCustomTextMaker : TextMaker
    {
        public MarkovChainCustomTextMaker()
        {
            this.Settings = new MarkovChainCustomTextSettings();
        }

        public override string Name
        {
            get { return "MarkovChainCustomTextMaker"; }
        }

        public override string Category
        {
            get { return "Standard"; }
        }

        public override string ControlName
        {
            get { return "MarkovChainCustomTextControl"; }
        }

        public override string GUIName
        {
            get { return "Markov Chain: Custom"; }
        }

        /// <summary>
        /// Gets or sets Working set of text
        /// </summary>
        protected string[] Fragments { get; set; }
        protected string[] CompleteFragments { get; set; }
        protected int[] Hash { get; set; }

        public override object NewInstance()
        {
            return new MarkovChainCustomTextMaker();
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
            if ((this.Settings as MarkovChainCustomTextSettings).TextPunctuationMarks ==
                PunctuationMarksType.DontConsider)
            {
                for (int i = 0; i < this.Fragments.Length; i++)
                {
                    this.Fragments[i] = this.Fragments[i].Clear(".", ",", "!", "?", ":", ";", "(", ")", "-");
                }
            }

            this.CompleteFragments = new string[this.Fragments.Length];
            for (int i = 0; i < this.Fragments.Length; i++)
            {
                this.CompleteFragments[i] = this.Fragments[i];
            }
            
            if ((this.Settings as MarkovChainCustomTextSettings).TextAnalysis == AnalyseType.WithoutEndings)
            {
                for (int i = 0; i < this.Fragments.Length; i++)
                {
                    if (this.Fragments[i].Length > (this.Settings as MarkovChainCustomTextSettings).TextAnalysisLength)
                    {
                        this.Fragments[i] = this.Fragments[i].Substring(0, (this.Settings as MarkovChainCustomTextSettings).TextAnalysisLength);
                    }
                }
            }

            this.Hash = new int[this.Fragments.Length];

            for (int i = 0; i < this.Fragments.Length; i++)
            {
                this.Hash[i] = this.Fragments[i].GetHashCode();
            }
        }

        protected override List<string> MakeText(TokenType Type)
        {
            int index = this.Random.Next(this.Fragments.Length);
            int length = this.MakeTextLength(Type);

            List<string> text = new List<string>(length);

            text.Add(this.CompleteFragments[index]);

            while (text.Count < length)
            {
                try
                {
                    index = this.GetNextIndex(index);

                    if ((this.Settings as MarkovChainCustomTextSettings).TextConstruction == ConstructionType.Short)
                    {
                        text.Add(this.CompleteFragments[index]);
                    }
                    else
                    {
                        int r = this.Random.Next((this.Settings as MarkovChainCustomTextSettings).TextConstructionMin, (this.Settings as MarkovChainCustomTextSettings).TextConstructionMax);
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
            for (int i = 0; i < this.Hash.Length - 1; i++)
            {
                if ((this.Hash[i] == this.Hash[CurrentIndex]) && (i != CurrentIndex))
                {
                    positions.Add(i + 1);
                }
            }

            // Probability
            if ((this.Settings as MarkovChainCustomTextSettings).TextProbability)
            {
                int[] resultsWordsCount = new int[positions.Count];
                for (int i = 0; i < positions.Count; i++)
                {
                    for (int j = 0; j < this.Fragments.Length; j++)
                    {
                        if (this.Hash[positions[i]] == this.Hash[j])
                        {
                            resultsWordsCount[i]++;
                        }
                    }
                }

                // Probability crunching
                int max = 0;
                for (int i = 0; i < resultsWordsCount.Length; i++)
                {
                    max += resultsWordsCount[i];
                }

                int currentItem = 0;
                int currentChance = this.Random.Next(max);
                for (int i = 0; i < resultsWordsCount.Length; i++)
                {
                    currentChance -= resultsWordsCount[i];
                    if (currentChance <= 0)
                    {
                        currentItem = positions[i];
                        break;
                    }
                }

                try
                {
                    return currentItem;
                }
                catch (Exception)
                {
                    return this.Random.Next(this.Hash.Length);
                }
            }

            try
            {
                return positions[this.Random.Next(positions.Count)];
            }
            catch (Exception)
            {
                return this.Random.Next(this.Hash.Length);
            }
        }
    }
}
