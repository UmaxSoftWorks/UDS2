using System;
using Umax.Interfaces.Text;

namespace Umax.Interfaces.Containers
{
    public interface ITextContainer : IDisposable
    {
        IEventedList<ITextSettings> Settings { get; }
        IEventedList<ITextMaker> Makers { get; }
        IEventedList<ITextControl> Controls { get; }
    }
}
