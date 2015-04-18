namespace Umax.Windows.Interfaces
{
    public interface IStandardWindow
    {
        string Title { get; }

        bool IsDisposed { get; }

        void Restore();
    }
}
