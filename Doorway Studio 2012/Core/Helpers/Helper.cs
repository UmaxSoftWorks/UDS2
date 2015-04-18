using System;
using System.Collections.Generic;
using Core.Classes.Containers.Items;
using Core.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;

namespace Core.Helpers
{
    public static class Helper
    {
        public static void DeleteTask(int WorkSpaceIndex, int TaskIndex)
        {
            (Core.Instanse.Data[WorkSpaceIndex].Tasks[TaskIndex] as Task).Delete();
            Core.Instanse.Data[WorkSpaceIndex].Tasks.RemoveAt(TaskIndex);
        }

        public static void DeleteTasks(TaskStateType State)
        {
            for (int i = 0; i < Core.Instanse.Data.Count; i++)
            {
                for (int k = Core.Instanse.Data[i].Tasks.Count; k >= 0; k--)
                {
                    if (Core.Instanse.Data[i].Tasks[k].State == State)
                    {
                        DeleteTask(i, k);
                    }
                }
            }
        }

        public static void DeleteTasks()
        {
            for (int i = 0; i < Core.Instanse.Data.Count; i++)
            {
                for (int k = Core.Instanse.Data[i].Tasks.Count; k >= 0; k--)
                {
                    DeleteTask(i, k);
                }
            }
        }

        public static bool NewTaskExist()
        {
            for (int i = 0; i < Core.Instanse.Data.Count; i++)
            {
                if (NewTaskExist(i))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool NewTaskExist(int WorkSpaceIndex)
        {
            for (int i = 0; i < Core.Instanse.Data[WorkSpaceIndex].Tasks.Count; i++)
            {
                if (Core.Instanse.Data[WorkSpaceIndex].Tasks[i].State == TaskStateType.New)
                {
                    return true;
                }
            }

            return false;
        }

        public static void DeleteWorkSpace(int Index)
        {
            (Core.Instanse.Data[Index] as WorkSpace).Delete();
            Core.Instanse.Data.Items.RemoveAt(Index);
        }

        public static List<int[]> GetTasks(TaskFilterType Filter, DateTime Date)
        {
            List<int[]> originalTasks = GetTasks(Filter);

            List<int[]> newTasks = new List<int[]>();

            for (int i = 0; i < originalTasks.Count; i++)
            {
                if (Core.Instanse.Data[originalTasks[i][0]].Tasks[originalTasks[i][1]].StartTime.Date == Date.Date)
                {
                    newTasks.Add(originalTasks[i]);
                }
            }

            return newTasks;
        }

        public static List<int[]> GetTasks(TaskFilterType Filter)
        {
            List<int[]> items = new List<int[]>();

            // Filter
            switch (Filter)
            {
                case TaskFilterType.New:
                    {
                        for (int i = 0; i < Core.Instanse.Data.Count; i++)
                        {
                            for (int k = 0; k < Core.Instanse.Data[i].Tasks.Count; k++)
                            {
                                if (Core.Instanse.Data[i].Tasks[k].State == TaskStateType.New)
                                {
                                    items.Add(new int[] { i, k });
                                }
                            }
                        }

                        break;
                    }

                case TaskFilterType.Active:
                    {
                        for (int i = 0; i < Core.Instanse.Data.Count; i++)
                        {
                            for (int k = 0; k < Core.Instanse.Data[i].Tasks.Count; k++)
                            {
                                if (Core.Instanse.Data[i].Tasks[k].IsInProgress())
                                {
                                    items.Add(new int[] { i, k });
                                }
                            }
                        }

                        break;
                    }

                case TaskFilterType.Completed:
                    {
                        for (int i = 0; i < Core.Instanse.Data.Count; i++)
                        {
                            for (int k = 0; k < Core.Instanse.Data[i].Tasks.Count; k++)
                            {
                                if (Core.Instanse.Data[i].Tasks[k].IsCompleted())
                                {
                                    items.Add(new int[] { i, k });
                                }
                            }
                        }

                        break;
                    }

                default:
                    {
                        for (int i = 0; i < Core.Instanse.Data.Count; i++)
                        {
                            for (int k = 0; k < Core.Instanse.Data[i].Tasks.Count; k++)
                            {
                                items.Add(new int[] { i, k });
                            }
                        }

                        break;
                    }
            }

            return items;
        }

        public static List<int[]> GetTasks(TaskFilterDateType Filter)
        {
            List<int[]> items = new List<int[]>();

            // Filter
            switch (Filter)
            {
                case TaskFilterDateType.Day:
                    {
                        for (int i = 0; i < Core.Instanse.Data.Count; i++)
                        {
                            for (int k = 0; k < Core.Instanse.Data[i].Tasks.Count; k++)
                            {
                                if (Core.Instanse.Data[i].Tasks[k].StartTime.Date == DateTime.Now.Date)
                                {
                                    items.Add(new int[] { i, k });
                                }
                            }
                        }

                        break;
                    }

                case TaskFilterDateType.Month:
                    {
                        for (int i = 0; i < Core.Instanse.Data.Count; i++)
                        {
                            for (int k = 0; k < Core.Instanse.Data[i].Tasks.Count; k++)
                            {
                                if (Core.Instanse.Data[i].Tasks[k].StartTime.Month == DateTime.Now.Month)
                                {
                                    items.Add(new int[] { i, k });
                                }
                            }
                        }

                        break;
                    }

                case TaskFilterDateType.Year:
                    {
                        for (int i = 0; i < Core.Instanse.Data.Count; i++)
                        {
                            for (int k = 0; k < Core.Instanse.Data[i].Tasks.Count; k++)
                            {
                                if (Core.Instanse.Data[i].Tasks[k].StartTime.Year == DateTime.Now.Year)
                                {
                                    items.Add(new int[] { i, k });
                                }
                            }
                        }

                        break;
                    }

                default:
                    {
                        for (int i = 0; i < Core.Instanse.Data.Count; i++)
                        {
                            for (int k = 0; k < Core.Instanse.Data[i].Tasks.Count; k++)
                            {
                                items.Add(new int[] { i, k });
                            }
                        }

                        break;
                    }
            }

            return items;
        }
    }
}
