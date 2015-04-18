using System.Resources;
using Umax.Windows.Classes;
using Umax.Windows.Interfaces;

namespace Umax.Windows
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
            this.Windows = new WindowsCollection();
        }

        public WindowsCollection Windows { get; set; }

        public ResourceManager Localization { get; set; }

        public IExitableWindow MainWindow { get; set; }
        public IExitableWindow LogWindow { get; set; }
    }
}