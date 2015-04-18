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
    /// <summary>
    /// The ITaskSite interface.
    /// </summary>
    public interface ITaskSite
    {
        /// <summary>
        /// Gets or sets Logger.
        /// </summary>
        List<string> Logger { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        IDataContainer Data { get; set; }

        /// <summary>
        /// Gets or sets Tokens.
        /// </summary>
        ITokenContainer Tokens { get; set; }

        /// <summary>
        /// Gets or sets Settings.
        /// </summary>
        ITaskSettings Settings { get; set; }

        /// <summary>
        /// Gets or sets TextMaker.
        /// </summary>
        ITextMaker TextMaker { get; set; }

        /// <summary>
        /// Gets or sets ImageMaker.
        /// </summary>
        IImageMaker ImageMaker { get; set; }

        /// <summary>
        /// Gets State.
        /// </summary>
        TaskStateType State { get; }

        /// <summary>
        /// Gets or sets Index.
        /// </summary>
        int Index { get; set; }

        /// <summary>
        /// Gets URL.
        /// </summary>
        string URL { get; }

        /// <summary>
        /// Gets HTMLLinks.
        /// </summary>
        List<HTMLLink> HTMLLinks { get; }

        /// <summary>
        /// Gets or sets FileTokens.
        /// </summary>
        List<FileTokenExecutor> FileTokens { get; set; }

        /// <summary>
        /// Gets or sets Keywords.
        /// </summary>
        List<string> Keywords { get; set; }

        /// <summary>
        /// Gets Progress.
        /// </summary>
        int Progress { get; }

        /// <summary>
        /// The state changed.
        /// </summary>
        event SimpleEventHandler StateChanged;

        /// <summary>
        /// The progress changed.
        /// </summary>
        event SimpleEventHandler ProgressChanged;

        /// <summary>
        /// The initialize.
        /// </summary>
        void Initialize();

        /// <summary>
        /// The invoke.
        /// </summary>
        void Invoke();

        /// <summary>
        /// The pause.
        /// </summary>
        void Pause();

        /// <summary>
        /// The stop.
        /// </summary>
        void Stop();

        /// <summary>
        /// Save
        /// </summary>
        void Save();
    }
}