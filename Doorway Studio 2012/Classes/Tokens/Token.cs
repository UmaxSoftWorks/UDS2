using System.Drawing;
using Umax.Interfaces.Tokens;

namespace Umax.Classes.Tokens
{
    public abstract class Token : IToken
    {
        public abstract bool Bold { get; }

        public abstract Color Color { get; }

        public abstract string Name { get; }

        public abstract int Priority { get; }

        public abstract string[] Tokens { get; }
    }
}
