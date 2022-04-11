using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class _ShiftManager
    {
        public List<Shift> shifts;
        public SQL sql;

        public _ShiftManager()
        {
            sql = new SQL();
            shifts = sql.GetAllShifts();
        }

        public void CreateShift(Employee e, int id,DateTime dateTime, SHIFTTYPE time)
        {
            shifts.Add(new Shift(e, id ,dateTime, time));
        }

        public List<string[]> GetMorningShiftsByDate(DateTime date)
        {
            List<string[]> list = new List<string[]>();
            List<Shift> searchedShifts = GetShiftsByDate(date);

            foreach(Shift s in searchedShifts)
            {
                if(s.time == SHIFTTYPE.Morning)
                {
                    list.Add(s.GetDisplayInfo());
                }
            }

            return list;
        }

        public List<string[]> GetAfternoonShiftsByDate(DateTime date)
        {
            List<string[]> list = new List<string[]>();
            List<Shift> searchedShifts = GetShiftsByDate(date);

            foreach (Shift s in searchedShifts)
            {
                if (s.time == SHIFTTYPE.Afternoon)
                {
                    list.Add(s.GetDisplayInfo());
                }
            }

            return list;
        }

        public List<string[]> GetEveningShiftsByDate(DateTime date)
        {
            List<string[]> list = new List<string[]>();
            List<Shift> searchedShifts = GetShiftsByDate(date);

            foreach (Shift s in searchedShifts)
            {
                if (s.time == SHIFTTYPE.Evening)
                {
                    list.Add(s.GetDisplayInfo());
                }
            }

            return list;
        }

        public List<Shift> GetShiftsByDate(DateTime date)
        {
            List<Shift> list = new List<Shift>();

            foreach(Shift s in shifts)
            {
                if (s.day.ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd"))
                {
                    list.Add(s);
                }
            }

            return list;
        }
    }
}
