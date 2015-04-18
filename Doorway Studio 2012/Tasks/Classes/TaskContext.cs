using System;
using System.Collections.Generic;
using System.Threading;
using Core.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using Umax.Interfaces.Images;
using Umax.Interfaces.Tasks;
using Umax.Interfaces.Text;
using Umax.Plugins.Tasks.Common;
using Umax.Plugins.Tasks.Enums;
using Umax.Plugins.Tasks.Interfaces;

namespace Umax.Plugins.Tasks.Classes
{
    public abstract class TaskContext : ITaskContext
    {
        public TaskContext()
        {
            this.State = TaskStateType.New;
            this.Logger = new List<string>();

            this.StartIndex = 0;
            this.EndIndex = 0;

            this.SelectedKeywordsCount = 0;

            this.Random = new Random(Environment.TickCount);

            this.Keywords = new List<string>();
            this.FileTokens = new List<FileTokenExecutor>();

            this.Sites = new List<ITaskSite>();
        }

        public event SimpleEventHandler StateChanged;
        public event SimpleEventHandler ProgressChanged;

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
                for (int i = 0; i < this.Sites.Count; i++)
                {
                    progress += this.Sites[i].Progress;
                }

                return this.Sites.Count == 0 ? this.Sites.Count : progress/this.Sites.Count;
            }
        }

        protected Random Random { get; set; }

        public List<string> Logger { get; set; }

        public IDataContainer Data { get; set; }
        public ITokenContainer Tokens { get; set; }

        public ITaskSettings Settings { get; set; }
        public ITextMaker TextMaker { get; set; }
        public IImageMaker ImageMaker { get; set; }

        public int StartIndex { get; set; }
        public int EndIndex { get; set; }

        public List<ITaskSite> Sites { get; protected set; }

        public virtual void Invoke()
        {
            this.State = TaskStateType.Running;

            this.SelectedKeywordsCount = 0;

            int siteCount = this.EndIndex - this.StartIndex;

            // Initialization
            for (int i = 0; i < siteCount; i++)
            {
                ITaskSite site = this.MakeSite();

                site.Logger = this.Logger;
                site.Index = i + this.StartIndex;
                site.Data = this.Data;
                site.Tokens = this.Tokens;
                site.Settings = this.Settings;
                site.TextMaker = this.TextMaker;
                site.ImageMaker = this.ImageMaker;
                site.FileTokens = this.FileTokens;

                site.Keywords = this.SelectKeywords();

                site.StateChanged += this.SiteStateChanged;
                site.ProgressChanged += this.SiteProgressChanged;

                this.Sites.Add(site);
            }

            // Initialize
            for (int i = 0; i < siteCount; i++)
            {
                try
                {
                    this.Sites[i].Initialize();
                    Thread.Sleep(500);
                }
                catch (Exception ex)
                {
                    this.Logger.Add(ex.ToString());
                    this.State = TaskStateType.Error;
                    return;
                }
            }

            // Invoke
            for (int i = 0; i < siteCount; i++)
            {
                try
                {
                    this.Sites[i].Invoke();
                }
                catch (Exception ex)
                {
                    this.Logger.Add(ex.ToString());
                    this.State = TaskStateType.Error;
                    return;
                }
            }

            // Save
            this.Save();

            this.State = TaskStateType.Done;
        }

        protected abstract ITaskSite MakeSite();

        public List<FileTokenExecutor> FileTokens { get; set; }

        protected int SelectedKeywordsCount { get; set; }

        /// <summary>
        /// Select keywords for the site
        /// </summary>
        /// <returns></returns>
        protected virtual List<string> SelectKeywords()
        {
            List<string> items = new List<string>();

            switch ((this.Settings as TaskSettings).KeywordsSelect)
            {
                case KeywordsSelectType.Random:
                    {
                        int number = this.Random.Next((this.Settings as TaskSettings).KeywordsSelectMin, (this.Settings as TaskSettings).KeywordsSelectMax);

                        if (this.Keywords.Count < number)
                        {
                            items.AddRange(this.Keywords);
                        }
                        else
                        {
                            while (items.Count < number)
                            {
                                string keyword = this.Keywords[this.Random.Next(this.Keywords.Count)];
                                if (!items.Contains(keyword))
                                {
                                    items.Add(keyword);
                                }
                            }
                        }

                        break;
                    }

                case KeywordsSelectType.OneByOne:
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

                        break;
                    }
            }

            return items;
        }

        protected virtual void SiteProgressChanged()
        {
            if (this.ProgressChanged != null)
            {
                this.ProgressChanged.Invoke();
            }
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

        protected virtual void PauseExecution()
        {
            for (int i = 0; i < this.Sites.Count; i++)
            {
                this.Sites[i].Pause();
            }
        }

        protected virtual void StopExecution()
        {
            for (int i = 0; i < this.Sites.Count; i++)
            {
                this.Sites[i].Stop();
            }
        }

        protected virtual void SiteStateChanged()
        {
            bool done = true;
            for (int i = 0; i < this.Sites.Count; i++)
            {
                if (this.Sites[i].State != TaskStateType.Done)
                {
                    done = false;
                }

                if (this.Sites[i].State == TaskStateType.Error)
                {
                    this.State = TaskStateType.Error;
                    break;
                }

                if (this.Sites[i].State == TaskStateType.Uploading)
                {
                    this.State = TaskStateType.Uploading;
                    break;
                }
            }

            if (done)
            {
                this.state = TaskStateType.Done;
            }
        }

        public List<string> Keywords { get; set; }

        protected virtual void Save()
        {
            for (int i = 0; i < this.Sites.Count; i++)
            {
                this.Sites[i].Save();
            }
        }
    }
}
