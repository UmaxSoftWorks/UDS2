using System.Resources;

namespace WebParser
{
    public class RunTime
    {
        private static RunTime instance;

        public static RunTime Instance
        {
            get { return instance ?? (instance = new RunTime()); }
        }

        private RunTime()
        {
        }

        public ResourceManager Localization { get; set; }
    }
}
