using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    class Company
    {
        public string name { get; private set; }
        public List<Employee> employees;
        public List<Shift> allShifts;
        public SQL sQL;

        public Company()
        {
            name = "Media Bazaar";
            sQL = new SQL();
            reloadObjects();
        }

        public void reloadObjects()
        {
            employees = sQL.GetEmployees();
        }

        public Employee GetEmployeeByName(string name)
        {
            foreach (Employee e in employees)
            {
                if (e.firstName == name)
                {
                    return e;
                }
            }
            return null;
        }

        //public void AssignShift(string name, DateTime date, SHIFTTYPE time)
        //{
        //    string convertedDate = date.ToString("yyyy-MM-dd HH:mm:ss");
        //    string convertedTime = time.ToString();
        //    MessageBox.Show(convertedTime);

        //    int i = sQL.GetEmployeeIdFromName(name);
        //    int a = sQL.GetShiftIDFromEmployeeInfo(name, convertedDate, convertedTime);
        //    if (a == 0) {
        //        sQL.CreateShift(i, convertedDate, convertedTime);
        //    }
        //    else
        //    {
        //        MessageBox.Show("The selected employee already has a Shift at that time.");
        //    }
        //}


        //public void DeleteShiftFromDataBase(string name, DateTime date, SHIFTTYPE time)
        //{ 
        //    string convertedDate = date.ToString("yyyy-MM-dd HH:mm:ss");
        //    string convertedTime = time.ToString();

        //    int shiftId = sQL.GetShiftIDFromEmployeeInfo(name, convertedDate, convertedTime);

        //    sQL.DeleteShift(shiftId);
        //    reloadObjects();
        //}
    }
}
