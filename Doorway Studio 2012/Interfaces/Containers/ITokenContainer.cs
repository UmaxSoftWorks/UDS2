using System;
using Umax.Interfaces.Tokens;

namespace Umax.Interfaces.Containers
{
    public interface ITokenContainer : IDisposable
    {
        IEventedList<IToken> Items { get; }
    }
}
