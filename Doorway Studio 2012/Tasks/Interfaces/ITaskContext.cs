using System.Collections.Generic;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using Umax.Interfaces.Images;
using Umax.Interfaces.Tasks;
using Umax.Interfaces.Text;
using Umax.Plugins.Tasks.Classes;

namespace Umax.Plugins.Tasks.Interfaces
{
    public interface ITaskContext
    {
        event SimpleEventHandler StateChanged;
        event SimpleEventHandler ProgressChanged;

        List<string> Logger { get; set; }

        IDataContainer Data { get; set; }
        ITokenContainer Tokens { get; set; }

        ITaskSettings Settings { get; set; }
        ITextMaker TextMaker { get; set; }
        IImageMaker ImageMaker { get; set; }

        int StartIndex { get; set; }
        int EndIndex { get; set; }

        List<ITaskSite> Sites { get; }

        List<string> Keywords { get; set; }
        List<FileTokenExecutor> FileTokens { get; set; }

        int Progress { get; }
        TaskStateType State { get; }

        void Invoke();
        void Pause();
        void Stop();
    }
}
