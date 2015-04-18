using Umax.Interfaces.Compatibility.Tasks;
using Umax.Interfaces.Tasks;

namespace Core.Helpers
{
    public static class ITaskExecutorHelper
    {
        public static void Fill(this ITaskExecutor Executor)
        {
            // Data containers
            if (Executor is ITaskDataCompatible)
            {
                (Executor as ITaskDataCompatible).Data = Core.Instanse.Data;
            }

            // Text containers
            if (Executor is ITaskTextCompatible)
            {
                (Executor as ITaskTextCompatible).Text = Core.Instanse.Text;
            }

            // Token containers
            if (Executor is ITaskTokensCompatible)
            {
                (Executor as ITaskTokensCompatible).Tokens = Core.Instanse.Tokens;
            }

            // Image containers
            if (Executor is ITaskImageCompatible)
            {
                (Executor as ITaskImageCompatible).Images = Core.Instanse.Images;
            }
        }
    }
}
