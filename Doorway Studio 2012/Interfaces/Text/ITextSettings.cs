using System;

namespace Umax.Interfaces.Text
{
    public interface ITextSettings : IClone, IDisposable
    {
        string Name { get; }
    }
}
