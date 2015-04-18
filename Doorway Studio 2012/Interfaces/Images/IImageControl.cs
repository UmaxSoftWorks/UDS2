namespace Umax.Interfaces.Images
{
    public interface IImageControl : IClone
    {
        string Name { get; }
        IImageMaker ImageMaker { get; set; }
    }
}
