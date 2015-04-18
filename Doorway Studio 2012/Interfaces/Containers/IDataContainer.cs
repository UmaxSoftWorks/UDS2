using System;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;

namespace Umax.Interfaces.Containers
{
    public interface IDataContainer : IDisposable
    {
        IEventedList<IWorkSpace> Items { get; }

        IWorkSpace this[int Index] { get; }

        int Count { get; }

        IWorkSpace Select(int Value, ItemSelectType Type);
    }
}
