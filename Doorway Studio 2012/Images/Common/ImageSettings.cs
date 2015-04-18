using Umax.Interfaces.Images;

namespace Umax.Plugins.Images.Common
{
    public abstract class ImageSettings: IImageSettings
    {
        public ImageSettings()
        {
            this.ImageID = -1;
        }

        public abstract string Name { get; }

        public virtual int ImageID { get; set; }

        public abstract void Dispose();

        public abstract object NewInstance();
    }
}
