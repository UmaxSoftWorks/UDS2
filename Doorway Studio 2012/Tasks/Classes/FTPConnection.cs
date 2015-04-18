namespace Umax.Plugins.Tasks.Classes
{
    public class FTPConnection
    {
        public FTPConnection()
        {
            this.Host = string.Empty;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.RemoteDirectory = string.Empty;
        }

        public string Host { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string RemoteDirectory { get; set; }
    }
}
