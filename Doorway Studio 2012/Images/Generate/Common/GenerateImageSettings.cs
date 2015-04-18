using Umax.Plugins.Images.Common;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Generate.Common
{
    public abstract class GenerateImageSettings : ImageSettings
    {
        public GenerateImageSettings()
        {
            this.Names = NameType.Random;
            this.NamesFile = string.Empty;

            this.WidthMin = 400;
            this.WidthMax = 500;

            this.HeightMin = 400;
            this.HeightMax = 500;
        }

        public virtual NameType Names { get; set; }
        public virtual string NamesFile { get; set; }

        public virtual int WidthMin { get; set; }
        public virtual int WidthMax { get; set; }

        public virtual int HeightMin { get; set; }
        public virtual int HeightMax { get; set; }
    }
}
