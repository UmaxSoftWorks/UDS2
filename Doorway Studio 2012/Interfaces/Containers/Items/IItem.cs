using System;

namespace Umax.Interfaces.Containers.Items
{
    public interface IItem : IDisposable
    {
        int ID { get; }
        string Name { get; }
        string Path { get; }
    }
}
