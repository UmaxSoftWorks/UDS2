using Umax.Classes.Enums;
using Umax.Plugins.Images.Enums;
using Umax.Plugins.Images.Modify.Border.Common;

namespace Umax.Plugins.Images.Modify.Border.Text
{
    public class ModifyBorderTextImageSettings : ModifyBorderImageSettings
    {
        public ModifyBorderTextImageSettings()
        {
            this.Number = NumberType.All;
            this.NumberMin = 200;
            this.NumberMax = 300;

            this.StringSelect = StringSelectType.Sentense;

            this.TextFile = string.Empty;
        }

        public override string Name
        {
            get { return "ModifyBorderTextImageSettings"; }
        }

        public NumberType Number { get; set; }

        public int NumberMin { get; set; }
        public int NumberMax { get; set; }

        public StringSelectType StringSelect { get; set; }

        public string TextFile { get; set; }

        public override object NewInstance()
        {
            return new ModifyBorderTextImageSettings();
        }

        public override void Dispose()
        {

        }
    }
}
