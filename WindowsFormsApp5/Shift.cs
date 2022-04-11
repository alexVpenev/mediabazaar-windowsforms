using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Shift
    {
        public Employee employee { get; set; }

        public int shiftID { get; set; }

        public DateTime day { get; set; }

        public SHIFTTYPE time { get; set; }


        public Shift(Employee employee, int shiftID, DateTime day, SHIFTTYPE time)
        {
            this.employee = employee;
            this.shiftID = shiftID;
            this.day = day;
            this.time = time;

        }


        public string[] GetDisplayInfo()
        {
            return new string[] { employee.id.ToString(), employee.firstName + " " + employee.lastName };
        }
    }
}
