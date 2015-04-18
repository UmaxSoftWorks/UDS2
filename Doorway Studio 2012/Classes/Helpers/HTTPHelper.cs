using System;
using System.Net;

namespace Umax.Classes.Helpers
{
    public static class HTTPHelper
    {
        public static string DownloadWebPage(string URL)
        {
            try
            {
                return new WebClient().DownloadString(URL);
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }
    }
}
