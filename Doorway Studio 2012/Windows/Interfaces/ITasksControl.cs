using System;

namespace Umax.Windows.Interfaces
{
    public interface ITasksControl
    {
        void CreateTask(object sender, EventArgs e);

        void CopyTask(object sender, EventArgs e);
        void EditTask(object sender, EventArgs e);
        void DeleteTask(object sender, EventArgs e);

        void RunTask(object sender, EventArgs e);
        void PauseTask(object sender, EventArgs e);
        void StopTask(object sender, EventArgs e);
    }
}
