using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;

namespace Umax.Classes.Helpers
{
    public static class TaskHelper
    {
        /// <summary>
        /// Indicates whether task is active
        /// </summary>
        /// <param name="Task"></param>
        /// <returns></returns>
        public static bool IsActive(this ITask Task)
        {
            return Task.State == TaskStateType.Running || Task.State == TaskStateType.Paused || Task.State == TaskStateType.Uploading;
        }

        /// <summary>
        /// Indicates whether task can be started
        /// </summary>
        /// <param name="Task"></param>
        /// <returns></returns>
        public static bool IsRunable(this ITask Task)
        {
            return Task.State == TaskStateType.New || Task.State == TaskStateType.Done || Task.State == TaskStateType.Error || Task.State == TaskStateType.Stopped || Task.State == TaskStateType.Killed;
        }

        /// <summary>
        /// Indicates whether task state can be changed to New
        /// </summary>
        /// <param name="Task"></param>
        /// <returns></returns>
        public static bool IsNewable(this ITask Task)
        {
            return Task.State == TaskStateType.Running || Task.State == TaskStateType.Paused || Task.State == TaskStateType.Stopped || Task.State == TaskStateType.Uploading ||
                   Task.State == TaskStateType.Killed;
        }

        /// <summary>
        /// Indicates whether task is copyable
        /// </summary>
        /// <param name="Task"></param>
        /// <returns></returns>
        public static bool IsCopyable(this ITask Task)
        {
            return Task.State == TaskStateType.New || Task.State == TaskStateType.Done || Task.State == TaskStateType.Error || Task.State == TaskStateType.Killed;
        }

        /// <summary>
        /// Indicates whether task is finished
        /// </summary>
        /// <param name="Task"></param>
        /// <returns></returns>
        public static bool IsCompleted(this ITask Task)
        {
            return Task.State == TaskStateType.Done || Task.State == TaskStateType.Error || Task.State == TaskStateType.Killed;
        }

        /// <summary>
        /// Indicates whether task in progress
        /// </summary>
        /// <param name="Task"></param>
        /// <returns></returns>
        public static bool IsInProgress(this ITask Task)
        {
            return Task.State == TaskStateType.Running || Task.State == TaskStateType.Paused || Task.State == TaskStateType.Uploading || Task.State == TaskStateType.Stopped;
        }
    }
}
