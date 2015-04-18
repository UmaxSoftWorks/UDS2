namespace Umax.Interfaces.Tokens
{
    public interface ISimpleToken : IToken
    {
        string Invoke(string Content);
    }
}
