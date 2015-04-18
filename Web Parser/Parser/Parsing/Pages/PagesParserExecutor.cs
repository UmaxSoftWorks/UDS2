using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using Umax.Interfaces.Tasks;
using Umax.Interfaces.WebParser;

namespace WebParser.Parser.Parsing.Pages
{
    public class PagesParserExecutor : IWebParserExecutor
    {
        public event SimpleEventHandler ProgressChanged;

        public event SimpleEventHandler StateChanged;

        public event SimpleEventHandler LogChanged;

        public string Name
        {
            get { return "PagesParserExecutor"; }
        }

        public void Invoke()
        {

        }

        public void Pause()
        {

        }

        public void Stop()
        {

        }

        public void Load(string TaskPath)
        {

        }

        public ITaskSettings Settings { get; set; }

        public TaskStateType State { get; set; }

        public int Progress
        {
            get { return 0; }
        }

        public string Log
        {
            get { return string.Empty; }
        }

        public void Save(string TaskPath)
        {

        }

        public void Kill()
        {
            this.Stop();
        }

        public object NewInstance()
        {
            return new PagesParserExecutor();
        }
    }
}
