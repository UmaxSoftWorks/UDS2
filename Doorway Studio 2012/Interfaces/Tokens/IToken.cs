using System.Drawing;
using Umax.Interfaces.Compatibility.Tokens;

namespace Umax.Interfaces.Tokens
{
    public interface IToken : ITokensCompatible
    {
        #region Appearance

        bool Bold { get; }

        Color Color { get; }

        #endregion

        #region General

        string Name { get; }

        int Priority { get; }

        #endregion
    }
}
