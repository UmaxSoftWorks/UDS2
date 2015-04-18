namespace Umax.Interfaces.Text
{
    public interface ITextControl : IClone
    {
        string Name { get; }
        ITextMaker TextMaker { get; set; }
    }
}
