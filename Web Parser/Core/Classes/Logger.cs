namespace WebParser.Core.Classes
{
    public class Logger : Umax.Classes.Logger
    {
        private static Logger instanse;

        public static Logger Instanse
        {
            get { return instanse ?? (instanse = new Logger()); }
        }

        protected Logger()
        {

        }
    }
}
