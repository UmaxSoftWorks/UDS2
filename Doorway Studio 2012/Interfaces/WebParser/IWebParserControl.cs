using Umax.Interfaces.Tasks;

namespace Umax.Interfaces.WebParser
{
    public interface IWebParserControl : ITaskWindow
    {
        /// <summary>
        /// This method should create task executor and collect user's settings into it
        /// </summary>
        void Collect();
    }
}
