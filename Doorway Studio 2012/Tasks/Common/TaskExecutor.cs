using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Umax.Classes.Helpers;
using Umax.Classes.XML;
using Umax.Interfaces.Compatibility.ID;
using Umax.Interfaces.Compatibility.Images;
using Umax.Interfaces.Compatibility.Tasks;
using Umax.Interfaces.Compatibility.Text;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using Umax.Interfaces.Images;
using Umax.Interfaces.Tasks;
using Umax.Interfaces.Text;
using Umax.Plugins.Tasks.Classes;
using Umax.Plugins.Tasks.Enums;
using Umax.Plugins.Tasks.Helpers;
using Umax.Plugins.Tasks.Interfaces;
using IO = System.IO;

namespace Umax.Plugins.Tasks.Common
{
    public abstract class TaskExecutor : ITaskExecutor, ITaskDataCompatible, ITaskTokensCompatible, ITaskTextCompatible,
                                         ITaskImageCompatible, ITaskMultiRunCompatible, ITextIDCompatible, IImageIDCompatible
    {
        public TaskExecutor()
        {
            this.Logger = new List<string>();
            this.Pages = new List<IPage>();

            // Schedule
            this.ScheduleStep = 1;
            this.Schedule = TaskScheduleType.None;

            this.Random = new Random(Environment.TickCount);

            // Settings
            this.Settings = new TaskSettings();

            // Keywords
            this.Keywords = new List<string>();

            // Context
            this.FileTokens = new List<FileTokenExecutor>();
            this.Context = new List<ITaskContext>();
        }

        public event SimpleEventHandler ProgressChanged;
        public event SimpleEventHandler StateChanged;
        public event SimpleEventHandler LogChanged;

        public virtual string Name
        {
            get { return "TaskExecutor"; }
        }

        public virtual string GUIName
        {
            get { return Name; }
        }

        public List<IPage> Pages { get; set; }

        public LanguageType Language { get; set; }

        private TaskStateType state;
        public TaskStateType State
        {
            get { return this.state; }
            set
            {
                this.state = value;

                if (this.state == TaskStateType.Error)
                {
                    this.StopExecution();
                }

                if (this.StateChanged != null)
                {
                    this.StateChanged.Invoke();
                }
            }
        }

        public int Progress
        {
            get
            {
                int progress = 0;
                for (int i = 0; i < this.Context.Count; i++)
                {
                    progress += this.Context[i].Progress;
                }

                return this.Context.Count == 0 ? 0 : progress/this.Context.Count;
            }
        }

        private List<string> logger;
        protected List<string> Logger
        {
            get { return logger; }
            set
            {
                this.logger = value;
                if (this.LogChanged != null)
                {
                    this.LogChanged.Invoke();
                }
            }
        }

        protected Random Random { get; set; }

        public string Log { get { return this.Logger.AsString("\r\n"); } }

        public IDataContainer Data { get; set; }
        public ITextContainer Text { get; set; }
        public ITokenContainer Tokens { get; set; }
        public IImageContainer Images { get; set; }

        public ITaskSettings Settings { get; set; }
        public ITextMaker TextMaker { get; set; }
        public IImageMaker ImageMaker { get; set; }


        public int ScheduleStep { get; set; }
        public TaskScheduleType Schedule { get; set; }

        public virtual void Save(string TaskPath)
        {
            this.SelectedKeywordsCount = 0;

            this.Random = null;
            this.Keywords = null;
            this.FileTokens = null;
            this.Context = null;
            this.Logger = null;

            try
            {
                CustomXmlSerializer.Serialize(this.Settings, 1, this.Settings.Name).Save(IO.Path.Combine(TaskPath, "task.xml"));

                // Saving text maker
                if (this.TextMaker != null)
                {
                    this.TextMaker.Save(TaskPath);
                }

                // Saving image maker
                if (this.ImageMaker != null)
                {
                    this.ImageMaker.Save(TaskPath);
                }
            }
            catch (Exception)
            {
            }
        }

        public virtual void Load(string TaskPath)
        {
            try
            {
                this.Settings =
                    (ITaskSettings)
                    CustomXmlDeserializer.Deserialize(
                        IO.File.ReadAllText(IO.Path.Combine(TaskPath, "task.xml"), Encoding.Default), 1);

                // Initializing text maker
                for (int i = 0; i < this.Text.Makers.Count; i++)
                {
                    if (this.Text.Makers[i].GUIName == (this.Settings as TaskSettings).TextMakerName)
                    {
                        this.TextMaker = (ITextMaker)this.Text.Makers[i].NewInstance();
                        this.TextMaker.Load(TaskPath);

                        if (this.TextMaker is ITextDataCompatible)
                        {
                            (this.TextMaker as ITextDataCompatible).TextData = this.Data.Select((this.Settings as TaskSettings).WorkSpaceID, ItemSelectType.ID).Text;
                        }

                        break;
                    }
                }

                // Initializing image maker
                if ((this.Settings as TaskSettings).Images)
                {
                    for (int i = 0; i < this.Images.Makers.Count; i++)
                    {
                        if (this.Images.Makers[i].GUIName == (this.Settings as TaskSettings).ImageMakerName)
                        {
                            this.ImageMaker = (IImageMaker)this.Images.Makers[i].NewInstance();
                            this.ImageMaker.Load(TaskPath);

                            if (this.ImageMaker is IImageDataCompatible)
                            {
                                (this.ImageMaker as IImageDataCompatible).ImageData = this.Data.Select((this.Settings as TaskSettings).WorkSpaceID, ItemSelectType.ID).Images;
                            }

                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        protected List<ITaskContext> Context { get; set; }

        public virtual void Invoke()
        {
            this.State = TaskStateType.Running;

            this.SelectedKeywordsCount = 0;

            // Make keywords
            this.MakeKeywords();

            // File tokens
            this.InitializeFileTokens();

            // Find number of threads that can be started
            this.Logger.Add(DateTime.Now.ToString() + " Starting...");
            if ((this.Settings as TaskSettings).GeneralSiteCount < (this.Settings as TaskSettings).GeneralThreadCount)
            {
                (this.Settings as TaskSettings).GeneralThreadCount = (this.Settings as TaskSettings).GeneralSiteCount;
            }

            // Counting number of sites per thread
            int index = 0;
            int sitesPerThread = (this.Settings as TaskSettings).GeneralSiteCount / (this.Settings as TaskSettings).GeneralThreadCount;

            while (index < (this.Settings as TaskSettings).GeneralThreadCount)
            {
                ITaskContext context = this.MakeContext();

                int endIndex = ((this.Settings as TaskSettings).GeneralSiteCount < (index + sitesPerThread))
                                   ? (this.Settings as TaskSettings).GeneralSiteCount
                                   : (index + sitesPerThread);

                context.Logger = this.Logger;
                context.StartIndex = index;
                context.EndIndex = endIndex;
                context.Data = this.Data;
                context.Tokens = this.Tokens;
                context.Settings = this.Settings;
                context.TextMaker = this.TextMaker;
                context.ImageMaker = this.ImageMaker;
                context.FileTokens = this.FileTokens;

                context.Keywords = this.SelectKeywords(endIndex - index);

                context.StateChanged += this.ContextStateChanged;
                context.ProgressChanged += this.ContextProgressChanged;

                this.Context.Add(context);

                index += sitesPerThread;
            }

            for (int i = 0; i < this.Context.Count; i++)
            {
                ThreadPool.QueueUserWorkItem(this.Execute, this.Context[i]);
            }

            this.Logger.Add(DateTime.Now.ToString() + "Started.");
        }

        /// <summary>
        /// Make context for execution
        /// </summary>
        /// <returns>Execution context</returns>
        protected abstract ITaskContext MakeContext();

        protected virtual void ContextProgressChanged()
        {
            if (this.ProgressChanged != null)
            {
                this.ProgressChanged.Invoke();
            }
        }

        protected virtual void ContextStateChanged()
        {
            bool done = true;
            for (int i = 0; i < this.Context.Count; i++)
            {
                if (this.Context[i].State != TaskStateType.Done)
                {
                    done = false;
                }

                if (this.Context[i].State == TaskStateType.Error)
                {
                    this.State = TaskStateType.Error;
                    break;
                }

                if (this.Context[i].State == TaskStateType.Uploading)
                {
                    this.State = TaskStateType.Uploading;
                    break;
                }
            }

            if (done)
            {
                // Links
                if ((this.Settings as TaskSettings).LinksSave != LinksSaveType.DontSave)
                {
                    this.SaveLinks();
                }

                this.state = TaskStateType.Done;
            }
        }

        protected List<string> Keywords { get; set; }

        /// <summary>
        /// Initializes keywords for the task
        /// </summary>
        protected virtual void MakeKeywords()
        {
            this.Keywords.AddRange(this.Data.Select((this.Settings as TaskSettings).WorkSpaceID, ItemSelectType.ID)
                                       .SelectKeyword((this.Settings as TaskSettings).KeywordsID, ItemSelectType.ID).Items);

            // Clean up
            for (int i = 0; i < this.Keywords.Count; i++)
            {
                this.Keywords[i].Clear();
            }

            // Synonyms
            if ((this.Settings as TaskSettings).KeywordsSynonyms != KeywordsSynonymsType.None)
            {
                this.SynonymizeKeywords();
            }

            // Generate
            if ((this.Settings as TaskSettings).KeywordsGenerateTwoWords || (this.Settings as TaskSettings).KeywordsGenerateThreeWords || (this.Settings as TaskSettings).KeywordsGenerateFourWords)
            {
                this.GenerateKeywords();
            }

            // Reorder
            if ((this.Settings as TaskSettings).KeywordsReorder)
            {
                for (int i = 0; i < this.Keywords.Count - 1; i++)
                {
                    this.Keywords.Swap(i, this.Random.Next(this.Keywords.Count));
                }
            }

            // Merge
            if ((this.Settings as TaskSettings).KeywordsMerge != KeywordsMergeType.None)
            {
                this.MergeKeywords();
            }
        }

        /// <summary>
        /// Synonymize keywords
        /// </summary>
        protected virtual void SynonymizeKeywords()
        {
            string[] synonymKeywords = new string[0];

            // Load keywords to synonymize with
            switch ((this.Settings as TaskSettings).KeywordsSynonyms)
            {
                case KeywordsSynonymsType.Internal:
                    {
                        if ((this.Settings as TaskSettings).KeywordsSynonymsID == -1)
                        {
                            return;
                        }

                        synonymKeywords = this.Data.Select((this.Settings as TaskSettings).WorkSpaceID, ItemSelectType.ID).SelectKeyword((this.Settings as TaskSettings).KeywordsSynonymsID, ItemSelectType.ID).Items;
                        break;
                    }

                case KeywordsSynonymsType.External:
                    {
                        if (!IO.File.Exists((this.Settings as TaskSettings).KeywordsSynonymsFilePath))
                        {
                            return;
                        }

                        synonymKeywords = IO.File.ReadAllLines((this.Settings as TaskSettings).KeywordsSynonymsFilePath,
                                                     ((this.Settings as TaskSettings).KeywordsSynonymsFileEncoding == EncodingType.ANSI) ? Encoding.Default : Encoding.UTF8);

                        break;
                    }
            }

            // Synonymize
            int chance = this.Random.Next((this.Settings as TaskSettings).KeywordsSynonymsMinPercent, (this.Settings as TaskSettings).KeywordsSynonymsMaxPercent);

            for (int i = 0; i < this.Keywords.Count; i++)
            {
                if (this.Random.Next(100) < chance)
                {
                    this.Keywords[i] = synonymKeywords[this.Random.Next(synonymKeywords.Length)];
                }
            }
        }

        /// <summary>
        /// Merge keywords
        /// </summary>
        protected virtual void MergeKeywords()
        {
            string[] mergeKeywords = new string[0];

            // Load keywords to merge with
            switch ((this.Settings as TaskSettings).KeywordsMerge)
            {
                case KeywordsMergeType.Internal:
                    {
                        if ((this.Settings as TaskSettings).KeywordsSynonymsID == -1)
                        {
                            return;
                        }

                        mergeKeywords = this.Data.Select((this.Settings as TaskSettings).WorkSpaceID, ItemSelectType.ID).SelectKeyword((this.Settings as TaskSettings).KeywordsMergeID, ItemSelectType.ID).Items;
                        break;
                    }

                case KeywordsMergeType.External:
                    {
                        if (!IO.File.Exists((this.Settings as TaskSettings).KeywordsMergeFilePath))
                        {
                            return;
                        }

                        mergeKeywords = IO.File.ReadAllLines((this.Settings as TaskSettings).KeywordsMergeFilePath,
                                                     ((this.Settings as TaskSettings).KeywordsMergeFileEncoding == EncodingType.ANSI) ? Encoding.Default : Encoding.UTF8);

                        break;
                    }
            }

            // Merge
            switch ((this.Settings as TaskSettings).KeywordsMergeUsage)
            {
                case KeywordsMergeUsageType.OneToOne:
                    {
                        for (int i = 0; i < this.Keywords.Count; i++)
                        {
                            if (mergeKeywords.Length < i)
                            {
                                break;
                            }

                            this.Keywords[i] += " " + mergeKeywords[i];
                        }

                        break;
                    }

                case KeywordsMergeUsageType.OneToMany:
                    {
                        List<string> items = new List<string>();

                        for (int i = 0; i < this.Keywords.Count; i++)
                        {
                            if (i < mergeKeywords.Length)
                            {
                                items.Add(this.Keywords[i]);
                            }
                            else
                            {
                                int mergeKeywordsCount = this.Random.Next((this.Settings as TaskSettings).KeywordsMergeMin, (this.Settings as TaskSettings).KeywordsMergeMax);

                                if (mergeKeywords.Length < mergeKeywordsCount)
                                {
                                    mergeKeywordsCount = mergeKeywords.Length;
                                }

                                for (int k = 0; k < mergeKeywordsCount; k++)
                                {
                                    items.Add(this.Keywords[i] + " " + mergeKeywords[this.Random.Next(mergeKeywords.Length)]);
                                }
                            }
                        }


                        this.Keywords = items;
                        break;
                    }

                case KeywordsMergeUsageType.OneToAll:
                    {
                        List<string> items = new List<string>();

                        for (int i = 0; i < this.Keywords.Count; i++)
                        {
                            if (i < mergeKeywords.Length)
                            {
                                items.Add(this.Keywords[i]);
                            }
                            else
                            {
                                for (int k = 0; k < mergeKeywords.Length; k++)
                                {
                                    items.Add(this.Keywords[i] + " " + mergeKeywords[k]);
                                }
                            }
                        }

                        this.Keywords = items;
                        break;
                    }
            }
        }

        /// <summary>
        /// Generates keywords
        /// </summary>
        protected virtual void GenerateKeywords()
        {
            List<string> items = new List<string>();
            List<string> remove = new List<string>();

            // Make 2-words
            if ((this.Settings as TaskSettings).KeywordsGenerateTwoWords)
            {
                int chance = this.Random.Next((this.Settings as TaskSettings).KeywordsGenerateTwoWordsMin, (this.Settings as TaskSettings).KeywordsGenerateTwoWordsMax);

                for (int i = 0; i < this.Keywords.Count; i++)
                {
                    if (this.Keywords[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length == 2)
                    {
                        if (this.Random.Next(100) < chance)
                        {
                            remove.Add(this.Keywords[i]);
                            items.AddRange(this.Keywords[i].Combinations());
                        }
                    }
                }
            }

            // Make 3-words
            if ((this.Settings as TaskSettings).KeywordsGenerateThreeWords)
            {
                int chance = this.Random.Next((this.Settings as TaskSettings).KeywordsGenerateThreeWordsMin, (this.Settings as TaskSettings).KeywordsGenerateThreeWordsMax);

                for (int i = 0; i < this.Keywords.Count; i++)
                {
                    if (this.Keywords[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length == 3)
                    {
                        if (this.Random.Next(100) < chance)
                        {
                            remove.Add(this.Keywords[i]);
                            items.AddRange(this.Keywords[i].Combinations());
                        }
                    }
                }
            }

            // Make 4-words
            if ((this.Settings as TaskSettings).KeywordsGenerateFourWords)
            {
                int chance = this.Random.Next((this.Settings as TaskSettings).KeywordsGenerateFourWordsMin, (this.Settings as TaskSettings).KeywordsGenerateFourWordsMax);

                for (int i = 0; i < this.Keywords.Count; i++)
                {
                    if (this.Keywords[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length == 3)
                    {
                        if (this.Random.Next(100) < chance)
                        {
                            remove.Add(this.Keywords[i]);
                            items.AddRange(this.Keywords[i].Combinations());
                        }
                    }
                }
            }


            // Remove
            for (int i = 0; i < remove.Count; i++)
            {
                this.Keywords.Remove(remove[i]);
            }

            // Add
            this.Keywords.AddRange(items);
        }

        protected int SelectedKeywordsCount { get; set; }

        /// <summary>
        /// Select keywords for the context
        /// </summary>
        /// <returns></returns>
        protected virtual List<string> SelectKeywords(int SitesCount)
        {
            List<string> items = new List<string>();

            switch ((this.Settings as TaskSettings).KeywordsSelect)
            {
                case KeywordsSelectType.First:
                    {
                        return this.Keywords.Cut(this.Random.Next((this.Settings as TaskSettings).KeywordsSelectMin, (this.Settings as TaskSettings).KeywordsSelectMax));
                    }

                case KeywordsSelectType.Last:
                    {
                        int number = this.Random.Next((this.Settings as TaskSettings).KeywordsSelectMin, (this.Settings as TaskSettings).KeywordsSelectMax);
                        return this.Keywords.Cut(this.Keywords.Count - number, number);
                    }

                case KeywordsSelectType.OneByOne:
                    {
                        for (int i = 0; i < SitesCount; i++)
                        {
                            while (this.Keywords.Count < this.SelectedKeywordsCount)
                            {
                                this.SelectedKeywordsCount -= this.Keywords.Count;
                            }

                            int number = this.Random.Next((this.Settings as TaskSettings).KeywordsSelectMin, (this.Settings as TaskSettings).KeywordsSelectMax);

                            for (int k = 0; k < number; k++)
                            {
                                if (this.Keywords.Count < this.SelectedKeywordsCount)
                                {
                                    this.SelectedKeywordsCount = 0;
                                }

                                items.Add(this.Keywords[this.SelectedKeywordsCount]);
                                this.SelectedKeywordsCount++;
                            }
                        }

                        return items;
                    }
            }

            // Select all keywords
            items.AddRange(this.Keywords);
            return items;
        }

        protected virtual void SaveLinks()
        {
            if (string.IsNullOrEmpty((this.Settings as TaskSettings).LinksSavePath))
            {
                return;
            }

            // Create directories
            IOHelper.CreateDirectory((this.Settings as TaskSettings).LinksSavePath);

            try
            {
                switch ((this.Settings as TaskSettings).LinksSave)
                {
                    case LinksSaveType.OneFilePerSite:
                        {
                            for (int i = 0; i < this.Context.Count; i++)
                            {
                                for (int k = 0; k < this.Context[i].Sites.Count; k++)
                                {
                                    string filename = this.Context[i].Sites[k].URL.ToLower().Replace("http://", string.Empty).Replace("https://", string.Empty).Replace("/", "-"); ;

                                    if (string.IsNullOrEmpty(filename))
                                    {
                                        filename = (i + 1).ToString() + "-" + (k + 1).ToString();
                                    }

                                    StringBuilder links = new StringBuilder();
                                    for (int l = 0; l < (this.Settings as TaskSettings).Links.Count; l++)
                                    {
                                        links.Append(this.MakeHTMLLinks(this.Context[i].Sites[k].HTMLLinks,
                                                                        (this.Settings as TaskSettings).Links[l]));
                                        links.Append("\r\n\r\n\r\n");
                                    }

                                    IO.File.WriteAllText(IO.Path.Combine((this.Settings as TaskSettings).LinksSavePath, filename + ".txt"),
                                                         links.ToString().Trim(),
                                                         (this.Settings as TaskSettings).LinksSaveEncoding == EncodingType.ANSI
                                                             ? Encoding.Default
                                                             : Encoding.UTF8);
                                }
                            }

                            break;
                        }

                    case LinksSaveType.ManyFilesPerSite:
                        {
                            for (int i = 0; i < this.Context.Count; i++)
                            {
                                for (int k = 0; k < this.Context[i].Sites.Count; k++)
                                {
                                    string filename = this.Context[i].Sites[k].URL.ToLower().Replace("http://", string.Empty).Replace("https://", string.Empty).Replace("/", "-"); ;

                                    if (string.IsNullOrEmpty(filename))
                                    {
                                        filename = (i + 1).ToString() + "-" + (k + 1).ToString();
                                    }

                                    for (int l = 0; l < (this.Settings as TaskSettings).Links.Count; l++)
                                    {
                                        IO.File.WriteAllText(IO.Path.Combine((this.Settings as TaskSettings).LinksSavePath, filename + "-" + (l + 1).ToString() + ".txt"),
                                                             this.MakeHTMLLinks(this.Context[i].Sites[k].HTMLLinks, (this.Settings as TaskSettings).Links[l]),
                                                             (this.Settings as TaskSettings).LinksSaveEncoding == EncodingType.ANSI
                                                                 ? Encoding.Default
                                                                 : Encoding.UTF8);
                                    }
                                }
                            }

                            break;
                        }

                    case LinksSaveType.OneFilePerTask:
                        {
                            StringBuilder links = new StringBuilder(10000);

                            for (int i = 0; i < this.Context.Count; i++)
                            {
                                for (int k = 0; k < this.Context[i].Sites.Count; k++)
                                {
                                    for (int l = 0; l < (this.Settings as TaskSettings).Links.Count; l++)
                                    {
                                        links.Append(this.MakeHTMLLinks(this.Context[i].Sites[k].HTMLLinks,
                                                                        (this.Settings as TaskSettings).Links[l]));
                                        links.Append("\r\n\r\n\r\n");
                                    }
                                }
                            }

                            IO.File.AppendAllText(IO.Path.Combine(
                                (this.Settings as TaskSettings).LinksSavePath, "Links.txt"),
                                                  links.ToString() + "\r\n",
                                                  (this.Settings as TaskSettings).LinksSaveEncoding == EncodingType.ANSI
                                                      ? Encoding.Default
                                                      : Encoding.UTF8);
                            break;
                        }

                    case LinksSaveType.ManyFilesPerTask:
                        {
                            for (int i = 0; i < this.Context.Count; i++)
                            {
                                for (int k = 0; k < this.Context[i].Sites.Count; k++)
                                {
                                    for (int l = 0; l < (this.Settings as TaskSettings).Links.Count; l++)
                                    {
                                        IO.File.AppendAllText(
                                            IO.Path.Combine((this.Settings as TaskSettings).LinksSavePath, (k + 1).ToString() + ".txt"),
                                            this.MakeHTMLLinks(this.Context[i].Sites[k].HTMLLinks, (this.Settings as TaskSettings).Links[l]) + "\r\n",
                                            (this.Settings as TaskSettings).LinksSaveEncoding == EncodingType.ANSI
                                                ? Encoding.Default
                                                : Encoding.UTF8);
                                    }
                                }
                            }

                            break;
                        }
                }
            }
            catch (Exception)
            {
            }
        }

        protected virtual string MakeHTMLLinks(List<HTMLLink> Links, string Template)
        {
            StringBuilder links = new StringBuilder(Links.Count * Template.Length);

            for (int i = 0; i < Links.Count; i++)
            {
                string keyword = string.Empty;

                if (Links[i].Keywords.Count != 0)
                {
                    keyword = Links[i].Keywords[this.Random.Next(Links[i].Keywords.Count)];
                }

                links.AppendLine(Template.Replace("[LINK]", Links[i].URL).Replace("[KEY]", keyword));
            }

            return links.ToString();
        }

        protected virtual void Execute(object Context)
        {
            ((ITaskContext)Context).Invoke();
        }

        public virtual void Pause()
        {
            this.PauseExecution();
            this.State = TaskStateType.Paused;
        }

        public virtual void Stop()
        {
            this.StopExecution();
            this.State = TaskStateType.Stopped;
        }

        public virtual void Kill()
        {
            this.StopExecution();
            this.State = TaskStateType.Killed;
        }

        protected virtual void PauseExecution()
        {
            for (int i = 0; i < this.Context.Count; i++)
            {
                this.Context[i].Pause();
            }
        }

        protected virtual void StopExecution()
        {
            for (int i = 0; i < this.Context.Count; i++)
            {
                this.Context[i].Stop();
            }
        }

        protected virtual List<FileTokenExecutor> FileTokens { get; set; }

        protected virtual void InitializeFileTokens()
        {
            for (int i = 0; i < (this.Settings as TaskSettings).FileTokens.Count; i++)
            {
                if (!IO.File.Exists((this.Settings as TaskSettings).FileTokens[i].Path))
                {
                    continue;
                }

                FileTokenExecutor token = new FileTokenExecutor((this.Settings as TaskSettings).FileTokens[i]);

                token.Initialize();

                this.FileTokens.Add(token);
            }
        }

        public abstract object NewInstance();

        public int TextID
        {
            get { return (this.TextMaker == null || this.TextMaker.Settings == null || !(this.TextMaker.Settings is ITextIDCompatible)) ? -1 : (this.TextMaker.Settings as ITextIDCompatible).TextID; }
        }

        public int ImageID
        {
            get { return (this.ImageMaker == null || this.ImageMaker.Settings == null || !(this.ImageMaker.Settings is IImageIDCompatible)) ? -1 : (this.ImageMaker.Settings as IImageIDCompatible).ImageID; }
        }
    }
}