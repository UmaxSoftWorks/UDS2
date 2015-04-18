using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;

namespace Umax.Interfaces.Tokens
{
    public interface IComplexToken : IToken
    {
        string Invoke(IPage Page, IContentContainer ContentContainer);
    }
}
