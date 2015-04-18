using System.Drawing;
using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Enums;
using Umax.Plugins.Images.Modify.Common;

namespace Umax.Plugins.Images.Modify.Resize
{
    public class ModifyResizeImageSettings : ModifyImageSettings
    {
        public ModifyResizeImageSettings()
        {
            this.WidthMin = 400;
            this.WidthMax = 500;

            this.HeightMin = 400;
            this.HeightMax = 500;

            this.Number = NumberType.All;
            this.NumberMin = 200;
            this.NumberMax = 300;

            this.Resize = ResizeType.KeepRatio;

            this.BackgroundColorSettings = new ColorSettings()
            {
                SelectedColor = Color.FromArgb(0, 0, 0)
            };
        }

        public override string Name
        {
            get { return "ModifyResizeImageSettings"; }
        }

        public int WidthMin { get; set; }
        public int WidthMax { get; set; }

        public int HeightMin { get; set; }
        public int HeightMax { get; set; }

        public NumberType Number { get; set; }
        public int NumberMin { get; set; }
        public int NumberMax { get; set; }

        public ResizeType Resize { get; set; }

        public ColorSettings BackgroundColorSettings { get; set; }

        public override object NewInstance()
        {
            return new ModifyResizeImageSettings();
        }

        public override void Dispose()
        {
            
        }
    }
}
