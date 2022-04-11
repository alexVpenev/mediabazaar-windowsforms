using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class _Scheduler 
    {
        public _ShiftManager _ShiftManager;
        public _EmployeeManager _EmployeeManager;

        public SQL sQL;

        public _Scheduler()
        {
            LoadObjects();
            sQL = new SQL();
        }

        private void LoadObjects()
        {
            _ShiftManager = new _ShiftManager();
            _EmployeeManager = new _EmployeeManager();
        }

        public void AssignShift(int s, DateTime q, SHIFTTYPE l)
        {
            sQL.CreateShift(s, q, l);
            LoadObjects();
        }

        public void AutomaticSchedule(DateTime start, DateTime end, int pplPerShift)
        {
            IConstraintChecker a = new FteChecker();
            for (var day = start.Date; day <= end.Date; day = day.AddDays(1))
            {



                for (int i = 0; i < pplPerShift; i++)
                {
                    int personID = a.Check(day);


                    if (i < pplPerShift/2) {
                        sQL.CreateShift(_EmployeeManager.employees[personID].id, day, SHIFTTYPE.Morning);
                        sQL.CreateShift(_EmployeeManager.employees[personID].id, day, SHIFTTYPE.Afternoon);
                    }
                    else
                    {
                        sQL.CreateShift(_EmployeeManager.employees[personID].id, day, SHIFTTYPE.Afternoon);
                        sQL.CreateShift(_EmployeeManager.employees[personID].id, day, SHIFTTYPE.Evening);
                    }
                    //sQL.CreateShift(_EmployeeManager.employees[personID].id, day, SHIFTTYPE.Morning);
                    //if (!a.Check(personID, day))
                    //{
                    //    personID = random.Next(50);
                    //}
                    //sQL.CreateShift(_EmployeeManager.employees[personID].id, day, SHIFTTYPE.Afternoon);
                    //if (a.Check(personID, day))
                    //{
                    //    personID = random.Next(50);
                    //}
                    //sQL.CreateShift(_EmployeeManager.employees[personID].id, day, SHIFTTYPE.Evening);
                }
            }
            LoadObjects();

            //
            //a.bkla();
        }





    }
}
