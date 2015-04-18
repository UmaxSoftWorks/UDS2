using Umax.Plugins.Images.Classes;
using Umax.Plugins.Images.Modify.Common;

namespace Umax.Plugins.Images.Modify.Keywords
{
    public class ModifyKeywordsImageSettings : ModifyImageSettings
    {
        public ModifyKeywordsImageSettings()
        {
            this.Font = new FontSettings();
        }

        public FontSettings Font { get; set; }

        public override string Name
        {
            get { return "ModifyKeywordsImageSettings"; }
        }

        public override object NewInstance()
        {
            return new ModifyKeywordsImageSettings();
        }

        public override void Dispose()
        {

        }
    }
}
