using System;
using System.Collections.Generic;
using System.Text;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Classes.XML;
using Umax.Interfaces.Compatibility.Text;
using Umax.Interfaces.Compatibility.Tokens;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Text;
using Umax.Plugins.Text.Enums;
using IO = System.IO;

namespace Umax.Plugins.Text.Common
{
    public abstract class TextMaker : ITextMaker, ITextDataCompatible, ITokensRegexCompatible
    {
        public TextMaker()
        {
            this.Settings = new TextSettings();

            this.State = MakerStateType.Uninitialized;

            this.Content = string.Empty;
        }

        /// <summary>
        /// Gets text maker name
        /// </summary>
        public virtual string Name
        {
            get { return "TextMaker"; }
        }

        /// <summary>
        /// Gets category
        /// </summary>
        public virtual string Category
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// Gets control name
        /// </summary>
        public virtual string ControlName
        {
            get { return "TextControl"; }
        }

        /// <summary>
        /// Gets gui name
        /// </summary>
        public virtual string GUIName
        {
            get { return "TextMaker"; }
        }

        public virtual string[] Tokens { get { return new string[] { "[TEXT]", "[MINITEXT]", "[MICROTEXT]", "[TEXTNOKEYS]", "[MINITEXTNOKEYS]", "[MICROTEXTNOKEYS]"}; } }

        public virtual string[] RegexTokens { get { return new string[] { @"\[Text\]", @"\[MiniText\]", @"\[MicroText\]", @"\[TextNoKeys\]", @"\[MiniTextNoKeys\]", @"\[MicroTextNoKeys\]" }; } }

        /// <summary>
        /// Gets or sets validate state
        /// </summary>
        public MakerStateType State { get; set; }

        /// <summary>
        /// Gets or sets settings
        /// </summary>
        public virtual ITextSettings Settings { get; set; }

        /// <summary>
        /// Gets or sets Content
        /// </summary>
        protected string Content { get; set; }

        /// <summary>
        /// Gets or sets Text Index
        /// </summary>
        protected int TextIndex { get; set; }

        /// <summary>
        /// Gets or sets Random generator
        /// </summary>
        protected System.Random Random { get; set; }

        /// <summary>
        /// Generates text
        /// </summary>
        /// <param name="Content">Content to replace</param>
        /// <param name="Keywords">List of Keywords</param>
        /// <returns>list of words</returns>
        public virtual string Invoke(string Content, List<string> Keywords)
        {
            // Parse token
            TokenType tokenType = this.GetTokenType(Content);
            bool insertKeywords = !Content.ToLower().Contains("nokey");

            List<string> text = this.MakeText(tokenType).Split(StringSplitType.Word);

            // Clear punctuation marks
            if ((this.Settings as TextSettings).PunctuationMarks)
            {
                this.ClearPunctuationMarks(text);
            }

            // Insert keywords
            if (insertKeywords)
            {
                this.InsertKeywords(text, Keywords, tokenType);
            }

            // Insert punctuation marks
            if ((this.Settings as TextSettings).PunctuationMarks)
            {
                this.InsertPunctuationMarks(text, tokenType);
            }

            // Split into paragraphs
            this.MakeParagraphs(text, tokenType);

            // Make sentences 
            this.MakeSentences(text, tokenType, (this.Settings as TextSettings).Sentences);

            // Process punctuation marks
            if ((this.Settings as TextSettings).PunctuationMarksBigLetters)
            {
                this.ProcessPunctuationMarks(text);
            }

            // Wrap phrases
            if ((this.Settings as TextSettings).SelectPhrases)
            {
                this.WrapPhrases(text);
            }

            // Convert to string
            return text.AsString();
        }

        protected TokenType GetTokenType(string Token)
        {
            string token = Token.ToLower();

            if (token.Contains("mini"))
            {
                return TokenType.Mini;
            }

            if (token.Contains("micro"))
            {
                return TokenType.Micro;
            }

            return TokenType.Regular;
        }

        /// <summary>
        /// Prepare to work
        /// </summary>
        public virtual void Initialize()
        {
            try
            {
                this.State = this.Validate();

                // Initialize content
                this.InitializeContent();
            }
            catch (Exception ex)
            {
                this.State = MakerStateType.Invalid;
                throw ex;
            }
        }

        /// <summary>
        /// Initializes content (split text, etc).
        /// </summary>
        protected virtual void InitializeContent()
        {
            // Process brackets
            if ((this.Settings as TextSettings).Brackets)
            {
                this.Content = this.ProcessBrackets(this.Content);
            }
        }

        /// <summary>
        /// Validate input data
        /// </summary>
        /// <returns>Validation state</returns>
        protected virtual MakerStateType Validate()
        {
            if ((this.Settings as TextSettings).TextLocation == LocationType.Internal)
            {
                if (this.TextData == null)
                {
                    throw new Exception("Text data isn't provided.");
                }

                if (this.TextData.Count == 0)
                {
                    throw new Exception("Text data empty.");
                }

                this.TextIndex = -1;

                for (int i = 0; i < this.TextData.Count; i++)
                {
                    if (this.TextData[i].ID == (this.Settings as TextSettings).TextID)
                    {
                        this.TextIndex = i;
                        break;
                    }
                }

                if (this.TextIndex == -1)
                {
                    throw new Exception("Internal text not found.");
                }

                this.Content = this.TextData[this.TextIndex].Content;
            }
            else
            {
                if ((this.Settings as TextSettings).TextExternalLocation == ExternalLocationType.Directory)
                {
                    if (IO.Directory.Exists((this.Settings as TextSettings).TextExternalLocationPath))
                    {
                        throw new Exception("External text folder location not found.");
                    }

                    this.Content = string.Empty;

                    string[] textFiles = IO.Directory.GetFiles(
                        (this.Settings as TextSettings).TextExternalLocationPath, "*.txt",
                        IO.SearchOption.AllDirectories);

                    if (textFiles.Length == 0)
                    {
                        throw new Exception("External text folder is empty.");
                    }

                    for (int i = 0; i < textFiles.Length; i++)
                    {
                        this.Content += IO.File.ReadAllText(textFiles[i], Encoding.Default) + "\r\n";
                    }
                }
                else
                {
                    if (IO.File.Exists((this.Settings as TextSettings).TextExternalLocationPath))
                    {
                        throw new Exception("External text file location not found.");
                    }

                    this.Content = IO.File.ReadAllText((this.Settings as TextSettings).TextExternalLocationPath,
                                                       Encoding.Default);
                }
            }

            if (string.IsNullOrEmpty(this.Content))
            {
                throw new Exception("Provided text empty.");
            }

            return MakerStateType.Initialized;
        }

        /// <summary>
        /// Load settings
        /// </summary>
        /// <param name="TextPath">Path to the configuration file</param>
        public virtual void Load(string TextPath)
        {
            try
            {
                this.Settings = (ITextSettings)CustomXmlDeserializer.Deserialize(IO.File.ReadAllText(IO.Path.Combine(TextPath, "text.xml"), Encoding.Default), 1);
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Save Settings
        /// </summary>
        /// <param name="TextPath">Path to the configuration file</param>
        public virtual void Save(string TextPath)
        {
            this.TextData = null;
            try
            {
                CustomXmlSerializer.Serialize(this.Settings, 1, this.Settings.Name).Save(IO.Path.Combine(TextPath, "text.xml"));
            }
            catch (Exception)
            {
            }
        }

        public virtual object NewInstance()
        {
            return null;
        }

        public virtual void Dispose()
        {
        }

        public IEventedList<IText> TextData { get; set; }

        protected abstract List<string> MakeText(TokenType Type);

        protected void InsertKeywords(List<string> Text, List<string> Keywords, TokenType Type)
        {
            // Number of insertion for each keyword
            int count = (int) (((double) Text.Count/100.0f)*
                               this.Random.Next((int) (this.Settings as TextSettings).KeywordsPercentageMin,
                                                (int) (this.Settings as TextSettings).KeywordsPercentageMax));

            // Keyword list
            List<string> keywords = new List<string>();
            if ((this.Settings as TextSettings).KeywordsPersentagePerEachKeyword)
            {
                for (int i = 0; i < Keywords.Count; i++)
                {
                    for (int k = 0; k < count; k++)
                    {
                        keywords.Add(Keywords[i]);
                    }
                }

                // Swapping
                for (int i = 0; i < keywords.Count; i++)
                {
                    keywords.Swap(i, this.Random.Next(keywords.Count));
                }
            }
            else
            {
                for (int k = 0; k < count; k++)
                {
                    keywords.Add(Keywords.Count == 1 ? Keywords[0] : Keywords[this.Random.Next(Keywords.Count)]);
                }
            }

            // Wrap keywords with tags
            if ((this.Settings as TextSettings).SelectKeywords)
            {
                this.WrapKeywords(keywords);
            }

            // Insert keywords into text
            switch ((this.Settings as TextSettings).KeywordsInsert)
            {
                case KeywordsInsertType.Random:
                    {
                        for (int i = 0; i < keywords.Count; i++)
                        {
                            Text.Insert(this.Random.Next(Text.Count), keywords[i]);
                        }

                        break;
                    }

                case KeywordsInsertType.Step:
                    {
                        int step = Text.Count/keywords.Count;
                        int startPosition = step;
                        int currentKeyword = 0;

                        while (currentKeyword < keywords.Count)
                        {
                            startPosition += step;
                            int confusion = this.Random.Next((this.Settings as TextSettings).KeywordsInsertStepInfelicity);

                            startPosition += ((this.Random.Next(0, 2) == 0) ? 1 : -1)*confusion;

                            if (keywords.Count <= currentKeyword)
                            {
                                break;
                            }

                            if (Text.Count < startPosition)
                            {
                                startPosition -= Text.Count;
                            }

                            Text.Insert(startPosition, keywords[currentKeyword]);
                            currentKeyword++;
                        }

                        break;
                    }

                case KeywordsInsertType.SentenseBeginning:
                    {
                        int usedKeywords = 0;

                        for (int i = 0; i < Text.Count - 2; i++)
                        {
                            if (Text[i].Contains(".") || Text[i].Contains("!") || Text[i].Contains("?"))
                            {
                                if (keywords.Count <= usedKeywords)
                                {
                                    break;
                                }

                                Text.Insert(i + 1, keywords[usedKeywords]);
                                usedKeywords++;
                            }
                        }

                        // Insert all other keywords
                        while (usedKeywords < keywords.Count)
                        {
                            Text.Insert(this.Random.Next(Text.Count), keywords[usedKeywords]);
                            usedKeywords++;
                        }

                        break;
                    }

                case KeywordsInsertType.AfterPunctuationMarks:
                    {
                        int usedKeywords = 0;

                        string[] marks = (this.Settings as TextSettings).PunctuationMarksList
                            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                        // Insert into beginning
                        for (int i = 0; i < Text.Count - 2; i++)
                        {
                            if (keywords.Count <= usedKeywords)
                            {
                                break;
                            }

                            // Insert
                            if (Text[i].Contains(StringContainsType.Any, marks))
                            {
                                Text.Insert(i + 1, keywords[usedKeywords]);
                                usedKeywords++;
                            }
                        }

                        // Insert all other keywords
                        while (usedKeywords < keywords.Count)
                        {
                            Text.Insert(this.Random.Next(Text.Count), keywords[usedKeywords]);
                            usedKeywords++;
                        }

                        break;
                    }
            }
        }

        protected void WrapKeywords(List<string> Keywords)
        {
            int percentage = this.Random.Next((int) (this.Settings as TextSettings).SelectPercentageMin,
                                              (int) (this.Settings as TextSettings).SelectPercentageMax);
            string[] tags = (this.Settings as TextSettings).SelectKeywordsTags.Split(new char[] {' '},
                                                                                     StringSplitOptions.RemoveEmptyEntries);
            if (tags.Length == 0)
            {
                return;
            }

            for (int i = 0; i < Keywords.Count; i++)
            {
                if (this.Random.Next(0, 100) < percentage)
                {
                    string tag = tags[this.Random.Next(tags.Length)];
                    Keywords[i] = "<" + tag + ">" + Keywords[i].Trim() + "</" + tag + ">";
                }
            }
        }

        protected void WrapPhrases(List<string> Text)
        {
            int phrasesCount = (this.Random.Next((int) (this.Settings as TextSettings).SelectPercentageMin,
                                                 (int) (this.Settings as TextSettings).SelectPercentageMax)*Text.Count)/100;

            string[] tags = (this.Settings as TextSettings).SelectPhrasesTags.Split(new char[] {' '},
                                                                                    StringSplitOptions.RemoveEmptyEntries);
            if (tags.Length == 0)
            {
                return;
            }

            int usedPhrasesCount = 0;

            while (usedPhrasesCount < phrasesCount)
            {
                int startIndex = this.Random.Next(Text.Count);
                int endIndex = startIndex + this.Random.Next(2, 4);

                if (endIndex <= Text.Count)
                {
                    continue;
                }

                bool canProceed = true;
                for (int i = startIndex; i < endIndex; i++)
                {
                    if (Text[i].Contains(StringContainsType.Any, "<p>", "</p>") || Text[i].Contains(StringContainsType.Any, tags))
                    {
                        canProceed = false;
                    }
                }

                if (!canProceed)
                {
                    continue;
                }

                string tag = tags[this.Random.Next(tags.Length)];
                Text[startIndex] = "<" + tag + ">" + Text[startIndex];
                Text[endIndex] += "</" + tag + ">";

                usedPhrasesCount++;
            }
        }

        /// <summary>
        /// Clear text from punctuation marks
        /// </summary>
        /// <param name="Text"></param>
        protected void ClearPunctuationMarks(List<string> Text)
        {
            for (int i = 0; i < Text.Count - 1; i++)
            {
                Text[i] = Text[i].Clear(".", "?", "!", ",", ":", ";", "-");
            }
        }

        /// <summary>
        /// Process punctuation marks (make uppercase beginnings of sentences) 
        /// </summary>
        /// <param name="Text"></param>
        protected void ProcessPunctuationMarks(List<string> Text)
        {
            string[] marks = (this.Settings as TextSettings).PunctuationMarksBigLettersList.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (marks.Length == 0)
            {
                return;
            }

            for (int i = 0; i < Text.Count - 1; i++)
            {
                if (Text[i].Contains(StringContainsType.Any, marks) && (!Text[i].Contains("<a href=") && !Text[i].Contains("</a>")))
                {
                    Text[i + 1] = Text[i + 1].ToUpper(StringToUpperType.FirstWord);
                }
            }
        }

        /// <summary>
        /// Insert punctuation marks
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Type"></param>
        protected void InsertPunctuationMarks(List<string> Text, TokenType Type)
        {
            string[] marks = (this.Settings as TextSettings).PunctuationMarksList
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (marks.Length == 0)
            {
                return;
            }

            int marksCount = this.MakePunctuationMarksCount(Type);

            for (int i = 0; i < marksCount; i++)
            {
                int position = this.Random.Next(Text.Count);
                if (Text[position].Contains(StringContainsType.Any, marks))
                {
                    continue;
                }

                Text[position] += marks[this.Random.Next(marks.Length)];
            }
        }

        protected int MakeSentencesCount(List<string> Text, TokenType Type, SentencesType SType)
        {
            int sentences = 0;

            switch (SType)
            {
                case SentencesType.Random:
                    {
                        sentences = this.Random.Next((this.Settings as TextSettings).SentencesMin,
                                                     (this.Settings as TextSettings).SentencesMax);

                        switch (Type)
                        {
                            case TokenType.Mini:
                                {
                                    sentences /= 2;
                                    break;
                                }

                            case TokenType.Micro:
                                {
                                    sentences /= 5;
                                    break;
                                }
                        }

                        break;
                    }

                case SentencesType.Step:
                    {
                        sentences = Text.Count/(this.Settings as TextSettings).SentencesLength;
                        break;
                    }
            }

            return sentences;
        }

        protected void MakeSentences(List<string> Text, TokenType Type, SentencesType SType)
        {
            int position = 0;

            int sentences = this.MakeSentencesCount(Text, Type, SType);

            string[] marks = (this.Settings as TextSettings).PunctuationMarksList
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sentences; i++)
            {
                switch (SType)
                {
                    case SentencesType.Random:
                        {
                            if (!Text[position].Contains(StringContainsType.Any, ".", "?", "!"))
                            {
                                position = this.Random.Next(Text.Count);

                                // Search for punctuation marks
                                if ((this.Settings as TextSettings).PunctuationMarks)
                                {
                                    if (Text[position].Contains(StringContainsType.Any, marks))
                                    {
                                        continue;
                                    }
                                }
                            }

                            break;
                        }

                    case SentencesType.Step:
                        {
                            position += (this.Settings as TextSettings).SentencesLength;

                            // Infelicity
                            position += ((this.Random.Next(0, 2) == 0) ? 1 : -1)*
                                        (this.Settings as TextSettings).SentencesLengthInfelicity;

                            if (!Text[position].Contains(StringContainsType.Any, ".", "!", "?"))
                            {
                                // Search for punctuation marks
                                if ((this.Settings as TextSettings).PunctuationMarks)
                                {
                                    if (Text[position].Contains(StringContainsType.Any, marks))
                                    {
                                        continue;
                                    }
                                }
                            }

                            break;
                        }
                }

                if (Text[position].Contains(StringContainsType.Any, ".", "!", "?"))
                {
                    continue;
                }

                string mark = ".";
                switch (this.Random.Next(10))
                {
                    case 0:
                        {
                            mark = "!";
                            break;
                        }

                    case 1:
                        {
                            mark = "?";
                            break;
                        }
                }

                if (Text[position].EndsWith("</p>"))
                {
                    Text[position] = Text[position].Substring(0, Text[position].Length - 4) + mark + "</p>";
                }
                else
                {
                    Text[position] += mark;
                }
            }
        }

        protected void MakeParagraphs(List<string> Text, TokenType Type)
        {
            if (Text.Count == 0)
            {
                return;
            }

            int iterations = 5;

            bool sentences = Text.ContainsString(".");

            int count = this.MakeParagraphsCount(Type);

            // Making <p> and </p> at the beginning and at the end
            Text[0] = "<p>" + Text[0];
            Text[Text.Count - 1] += "</p>";

            for (int i = 0; i < count - 1; i++)
            {
                int index = this.Random.Next(1, Text.Count - 1);
                if (sentences && Text.ContainsStringCount(".") != 0)
                {
                    int iteration = 0;

                    do
                    {
                        index = Text.IndexOfString(".", this.Random.Next(1, Text.Count - 1));
                        if (index != -1)
                        {
                            if (Text[index].Contains("</p>"))
                            {
                                index = -1;
                                iteration++;
                            }

                            if (iteration == iterations)
                            {
                                break;
                            }
                        }
                    } while (index == -1);

                    if (index == -1 && iteration == iterations)
                    {
                        index = this.Random.Next(1, Text.Count - 1);
                    }
                }

                if (Text.Count < index + 1)
                {
                    Text[index] += "</p>";
                    Text[index + 1] = "<p>" + Text[index + 1];
                }
            }
        }

        protected int MakeParagraphsCount(TokenType Type)
        {
            int count = this.Random.Next((this.Settings as TextSettings).ParagraphsMin,
                                         (this.Settings as TextSettings).ParagraphsMax);

            switch (Type)
            {
                case TokenType.Mini:
                    {
                        count /= 2;
                        break;
                    }

                case TokenType.Micro:
                    {
                        count /= 5;
                        break;
                    }
            }

            return count;
        }

        protected int MakePunctuationMarksCount(TokenType Type)
        {
            int count = this.Random.Next((this.Settings as TextSettings).PunctuationMarksMin,
                                         (this.Settings as TextSettings).PunctuationMarksMax);

            switch (Type)
            {
                case TokenType.Mini:
                    {
                        count /= 2;
                        break;
                    }

                case TokenType.Micro:
                    {
                        count /= 5;
                        break;
                    }
            }

            return count;
        }

        protected string ProcessBrackets(string InputString)
        {
            return InputString.OpenUp("{", "}", "|").OpenUp("[", "]", "|");
        }

        protected int MakeTextLength(TokenType Type)
        {
            int length = this.Random.Next((this.Settings as TextSettings).TextLengthMin,
                                                  (this.Settings as TextSettings).TextLengthMax);

            switch (Type)
            {
                case TokenType.Mini:
                    {
                        length /= 2;
                        break;
                    }

                case TokenType.Micro:
                    {
                        length /= 5;
                        break;
                    }
            }

            return length;
        }
    }
}
