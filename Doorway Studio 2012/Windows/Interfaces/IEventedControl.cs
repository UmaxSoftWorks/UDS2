namespace Umax.Windows.Interfaces
{
    public interface IEventedControl
    {
        void InitializeEvents();
        void DeInitializeEvents();
        void UpdateControl();
    }
}
