using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class AvailabilityChecker : IConstraintChecker
    {
        SQL sql;

        public AvailabilityChecker()
        {
            sql = new SQL();
        }

        public int Check(DateTime date)
        {
            return 0;
        }

        public bool Check(int id, DateTime date)
        {
            bool check = sql.CheckIfPersonIsAvailable(id, date);


            return check;
        }
    }
}
