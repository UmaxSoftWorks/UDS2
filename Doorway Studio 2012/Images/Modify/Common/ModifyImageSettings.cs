using Umax.Plugins.Images.Common.DataCompatible;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Modify.Common
{
    public abstract class ModifyImageSettings : DataCompatibleImageSettings
    {
        public ModifyImageSettings()
        {
            this.Location = LocationType.Internal;
            this.LocationPath = string.Empty;

            this.ModificationsImageNoise = false;
        }

        public virtual RenameType Rename { get; set; }
        public virtual string RenameFile { get; set; }

        public virtual bool ModificationsImageNoise { get; set; }
    }
}
