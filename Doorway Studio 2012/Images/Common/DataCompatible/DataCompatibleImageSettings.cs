using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Common.DataCompatible
{
    public abstract class DataCompatibleImageSettings: ImageSettings
    {
        public DataCompatibleImageSettings()
        {
            this.Location = LocationType.Internal;
            this.LocationPath = string.Empty;
        }

        public LocationType Location { get; set; }
        public string LocationPath { get; set; }
    }
}
