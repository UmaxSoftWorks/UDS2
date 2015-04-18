using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;

namespace Umax.Interfaces.Tasks
{
    public interface ITaskExecutor : IClone
    {
        event SimpleEventHandler ProgressChanged;
        event SimpleEventHandler StateChanged;
        event SimpleEventHandler LogChanged;

        string Name { get; }

        void Invoke();

        void Pause();
        void Stop();

        void Load(string TaskPath);

        ITaskSettings Settings { get; set; }

        TaskStateType State { get; set; }
        int Progress { get; }
        string Log { get; }

        void Save(string TaskPath);

        void Kill();
    }
}
