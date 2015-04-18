using System;

namespace Umax.Interfaces.Images
{
    public interface IImageSettings : IClone, IDisposable
    {
        string Name { get; }
    }
}
