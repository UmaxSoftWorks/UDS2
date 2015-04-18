using Umax.Plugins.Images.Common.DataCompatible;
using Umax.Plugins.Images.Enums;

namespace Umax.Plugins.Images.Copy
{
    public class CopyImageSettings : DataCompatibleImageSettings
    {
        public CopyImageSettings()
        {
            this.Rename = RenameType.NameToEn;
            this.RenameFile = string.Empty;

            this.Number = NumberType.All;
            this.NumberMin = 200;
            this.NumberMax = 300;
        }

        public override string Name
        {
            get { return "CopyImageSettings"; }
        }

        public RenameType Rename { get; set; }
        public string RenameFile { get; set; }

        public NumberType Number {get; set; }
        public int NumberMin { get; set; }
        public int NumberMax { get; set; }

        public override object NewInstance()
        {
            return new CopyImageSettings();
        }

        public override void Dispose()
        {
        }
    }
}
