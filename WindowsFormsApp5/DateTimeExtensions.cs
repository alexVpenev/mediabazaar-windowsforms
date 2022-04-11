using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek, int i)
        {
            if (startOfWeek > DateTime.Today.DayOfWeek || startOfWeek == DayOfWeek.Sunday)
            {
                i -= 7;
            }

            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays((-1 * diff) - i).Date;
        }
    }
}
