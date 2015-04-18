using System.Drawing;
using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Modify.Common;

namespace Umax.Plugins.Images.Modify.Border.Common
{
    public abstract class ModifyBorderImageSettings : ModifyImageSettings
    {
        public ModifyBorderImageSettings()
        {
            this.TopMin = 100;
            this.TopMax = 500;

            this.RightMin = 100;
            this.RightMax = 500;

            this.BottomMin = 100;
            this.BottomMax = 500;

            this.LeftMin = 100;
            this.LeftMax = 500;

            this.BackgroundColorSettings = new ColorSettings()
            {
                SelectedColor = Color.FromArgb(0, 0, 0)
            };

            this.Font = new FontSettings()
                            {
                                FontColorSettings = new ColorSettings()
                                                        {
                                                            SelectedColor = Color.FromArgb(255, 255, 255)
                                                        }
                            };

            this.ModificationsBorderNoise = false;
        }

        public virtual FontSettings Font { get; set; }

        public virtual int TopMin { get; set; }
        public virtual int TopMax { get; set; }

        public virtual int RightMin { get; set; }
        public virtual int RightMax { get; set; }

        public virtual int LeftMin { get; set; }
        public virtual int LeftMax { get; set; }

        public virtual int BottomMin { get; set; }
        public virtual int BottomMax { get; set; }

        public virtual ColorSettings BackgroundColorSettings { get; set; }

        public virtual bool ModificationsBorderNoise { get; set; }
    }
}
