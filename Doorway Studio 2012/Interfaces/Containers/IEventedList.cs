using System.Collections.Generic;
using Umax.Interfaces.Events;

namespace Umax.Interfaces.Containers
{
    public interface IEventedList<T>
    {
        int NextID();

        void Add(T Item);
        void Remove(T Item);
        void RemoveAt(int Index);

        bool Contains(T Item);
        bool Contains(int ID);

        int Number(T Item);
        int Number(int ID);

        int IndexOf(T Item);
        int IndexOf(int ID);

        List<T> ToList();
        T[] ToArray();

        T this[int Index] { get; set; }
        int Count { get; }

        event SimpleEventHandler CountChanged;
        event SimpleSenderEventHandler ItemAdded;
        event SimpleSenderEventHandler ItemRemoved;
        event SimpleSenderEventHandler ItemChanged;
    }
}
