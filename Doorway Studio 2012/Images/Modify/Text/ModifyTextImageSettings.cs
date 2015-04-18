using Umax.Classes.Enums;
using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Enums;
using Umax.Plugins.Images.Modify.Common;

namespace Umax.Plugins.Images.Modify.Text
{
    public class ModifyTextImageSettings : ModifyImageSettings
    {
        public ModifyTextImageSettings()
        {
            this.Font = new FontSettings();

            this.Number = NumberType.All;
            this.NumberMin = 200;
            this.NumberMax = 300;

            this.StringSelect = StringSelectType.Sentense;

            this.TextFile = string.Empty;
        }

        public NumberType Number { get; set; }
        public int NumberMin { get; set; }
        public int NumberMax { get; set; }

        public StringSelectType StringSelect { get; set; }

        public string TextFile { get; set; }

        public FontSettings Font{get; set;}

        public override string Name
        {
            get { return "ModifyTextImageSettings"; }
        }

        public override object NewInstance()
        {
            return new ModifyTextImageSettings();
        }

        public override void Dispose()
        {

        }
    }
}
