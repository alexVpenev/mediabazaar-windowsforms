using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class FteChecker : IConstraintChecker
    {
        public SQL sql;

        public FteChecker() 
        {
            sql = new SQL();
        }

        public int Check(DateTime date)
        {
            var random = new Random();
            int personID = 0;
            bool check = true;

            IConstraintChecker checker = new AvailabilityChecker();

            while(check)
            {
                personID = random.Next(60);

                if (!sql.CheckIfPersonIsScheduled(personID, date) && !checker.Check(personID, date))
                {
                    return personID;
                }

            }
            return personID;
        }

        public bool Check(int id, DateTime date)
        {
            return true;
        }
    }
}
