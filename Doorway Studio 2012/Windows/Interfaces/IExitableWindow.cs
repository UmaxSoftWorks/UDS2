using Umax.Interfaces.Events;

namespace Umax.Windows.Interfaces
{
    public interface IExitableWindow
    {
        bool Exit { get; set; }

        bool IsDisposed { get; }

        bool Visible { get; set; }

        void ShowWindow();

        void Execute();

        void Show();

        void Close();

        event SimpleEventHandler Dismissed;
    }
}
