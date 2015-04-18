using System.Linq;
using Umax.Classes.Containers;
using Umax.Interfaces.Events;
using Umax.Windows.Interfaces;

namespace Umax.Windows.Classes
{
    public class WindowsCollection
    {
        public WindowsCollection()
        {
            this.Items = new EventedList<IStandardWindow>();
        }

        public IStandardWindow this[int Index]
        {
            get { return this.Items[Index]; }
        }

        private EventedList<IStandardWindow> Items { get; set; }

        public int Count { get { return this.Items.Count; } }

        public void Add(IStandardWindow Window)
        {
            this.Items.Add(Window);

            this.OnCountChanged();
        }

        public void Remove(IStandardWindow Window)
        {
            this.Items.Remove(Window);

            this.OnCountChanged();
        }

        public void Update()
        {
            // Clear list from disposed windows
            this.Items = new EventedList<IStandardWindow>(this.Items.ToList().Where(Window => !Window.IsDisposed));

            this.OnCountChanged();
        }

        private void OnCountChanged()
        {
            if (this.CountChanged != null)
            {
                this.CountChanged();
            }
        }

        public event SimpleEventHandler CountChanged;
    }
}
