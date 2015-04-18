using System;
using System.Collections.Generic;
using Umax.Classes.Helpers;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.ConceptualGraph.Custom
{
    public class ConceptualGraphCustomTextMaker : TextMaker
    {
        public ConceptualGraphCustomTextMaker()
        {
            this.Settings = new ConceptualGraphCustomTextSettings();
        }

        public override string Name
        {
            get { return "ConceptualGraphCustomTextMaker"; }
        }

        public override string Category
        {
            get { return "Standard"; }
        }

        public override string ControlName
        {
            get { return "ConceptualGraphCustomTextControl"; }
        }

        public override string GUIName
        {
            get { return "Conceptual Graph"; }
        }

        protected string[] Fragments { get; set; }
        protected string[] CompleteFragments { get; set; }
        protected int[] Hash { get; set; }

        public override object NewInstance()
        {
            return new ConceptualGraphCustomTextMaker();
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
            if ((this.Settings as ConceptualGraphCustomTextSettings).TextPunctuationMarks == PunctuationMarksType.DontConsider)
            {
                this.Content = this.Content.Clear(".", ",", "!", "?", ":", ";", "(", ")", "-");
            }

            this.Content = this.Content.Replace("\r", " ").Replace("\n", " ").Replace("\t", " ").Replace("  ", " ");

            this.AnalyzeContent();
        }

        protected void AnalyzeContent()
        {
            Fragments = new string[CompleteFragments.Length];
            for (int i = 0; i < CompleteFragments.Length; i++)
            {
                CompleteFragments[i] = CompleteFragments[i].Trim();
                if (CompleteFragments[i].Contains(" "))
                {
                    Fragments[i] = CompleteFragments[i].Substring(CompleteFragments[i].LastIndexOf(" ") + 1);
                }
                else
                {
                    Fragments[i] = CompleteFragments[i];
                }
            }

            Hash = new int[Fragments.Length];

            for (int i = 0; i < Fragments.Length; i++)
            {
                Hash[i] = Fragments[i].GetHashCode();
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

                    if ((this.Settings as ConceptualGraphCustomTextSettings).TextConstruction == ConstructionType.Short)
                    {
                        text.AddRange(this.Fragments[index + 1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                    }
                    else
                    {
                        int r = this.Random.Next((this.Settings as ConceptualGraphCustomTextSettings).TextConstructionMin, (this.Settings as ConceptualGraphCustomTextSettings).TextConstructionMax);
                        for (int i = 0; i < r; i++)
                        {
                            try
                            {
                                text.AddRange(this.Fragments[index + i].Split(new char[] { ' ' },
                                                                     StringSplitOptions.RemoveEmptyEntries));
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

        private int GetNextIndex(int CurrentIndex)
        {
            List<int> positions = new List<int>();

            for (int i = 0; i < Fragments.Length; i++)
            {
                if (this.Hash[i] == this.Hash[CurrentIndex])
                {
                    if ((i != CurrentIndex) && ((i + 1) < this.Fragments.Length))
                    {
                        positions.Add(i + 1);
                    }
                }
            }

            // Probability
            if ((this.Settings as ConceptualGraphCustomTextSettings).TextProbability)
            {
                int[] resultsWordsCount = new int[positions.Count];
                for (int i = 0; i < positions.Count; i++)
                {
                    for (int j = 0; j < this.Fragments.Length; j++)
                    {
                        if (this.Fragments[positions[i]].Contains(this.Fragments[j]))
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
                int currentChance = this.Random.Next(0, max);
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
                    return this.Random.Next(this.Fragments.Length);
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
