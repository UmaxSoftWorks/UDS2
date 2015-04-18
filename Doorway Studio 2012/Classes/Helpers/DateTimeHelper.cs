using System;
using System.Threading;

namespace Umax.Classes.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime WeekStartDate
        {
            get
            {
                DayOfWeek day = Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
                DateTime date = DateTime.Now.Date;
                while (date.DayOfWeek != day)
                {
                    date = date.AddDays(-1);
                }

                return date;
            }
        }

        public static DateTime WeekEndDate
        {
            get
            {
                DayOfWeek day = Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
                DateTime date = DateTime.Now.Date;
                while (date.DayOfWeek != day)
                {
                    date = date.AddDays(1);
                }

                return date;
            }
        }
    }
}
