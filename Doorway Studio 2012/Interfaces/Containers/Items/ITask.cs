using System;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using Umax.Interfaces.Tasks;

namespace Umax.Interfaces.Containers.Items
{
    public interface ITask : IItem
    {
        event SimpleEventHandler ProgressChanged;
        event SimpleEventHandler StateChanged;

        DateTime StartTime { get; set; }

        TaskStateType State { get; }

        int Progress { get; }
        string Log { get; }

        ITaskExecutor Executor { get; set; }

        void Save(string TaskPath);

        void Invoke();

        void Pause();
        void Stop();

        void Kill();
    }
}
