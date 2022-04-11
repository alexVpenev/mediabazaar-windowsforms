using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class _EmployeeManager
    {
        public List<Employee> employees;
        public SQL sql;

        public _EmployeeManager()
        {
            sql = new SQL();
            employees = sql.GetEmployees();
        }

        public List<string[]> GetAllEmployeesDisplayInfo()
        {
            List<string[]> list = new List<string[]>();

            foreach(Employee e in employees)
            {
                list.Add(e.GetDisplayInfo());
            }

            return list;
        }

    }
}
