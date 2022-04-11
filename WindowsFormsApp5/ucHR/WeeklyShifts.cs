using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.ucHR
{
    public partial class WeeklyShifts : UserControl
    {
        _Scheduler scheduler;
        DateTime selectedDate;
        SHIFTTYPE selectedTime;
        int weekSelector = 0;

        public WeeklyShifts()
        {
            scheduler = new _Scheduler();
            InitializeComponent();

            foreach (string[] e in scheduler._EmployeeManager.GetAllEmployeesDisplayInfo())
            {
                //Employeescbx.Items.Add(e.firstName + e.lastName);
                SelectEmployeeToAssignLv.Items.Add(new ListViewItem(e));
            
            }

            ReloadElements();
        }

        private void ReloadElements()
        {
            shiftsMonLv.Items.Clear();
            shiftsTueLv.Items.Clear();
            shiftsWedLv.Items.Clear();
            shiftsThuLv.Items.Clear();
            shiftsFriLv.Items.Clear();
            shiftsSatLv.Items.Clear();
            shiftsSunLv.Items.Clear();


            dateMon.Text = DateTime.Now.StartOfWeek(DayOfWeek.Monday, weekSelector).ToString("d-M");
            dateTue.Text = DateTime.Now.StartOfWeek(DayOfWeek.Tuesday, weekSelector).ToString("d-M");
            dateWed.Text = DateTime.Now.StartOfWeek(DayOfWeek.Wednesday, weekSelector).ToString("d-M");
            dateThu.Text = DateTime.Now.StartOfWeek(DayOfWeek.Thursday, weekSelector).ToString("d-M");
            dateFri.Text = DateTime.Now.StartOfWeek(DayOfWeek.Friday, weekSelector).ToString("d-M");
            dateSat.Text = DateTime.Now.StartOfWeek(DayOfWeek.Saturday, weekSelector).ToString("d-M");
            dateSun.Text = DateTime.Now.StartOfWeek(DayOfWeek.Sunday, weekSelector).ToString("d-M");

            shiftsMonLv.Items.Add(new ListViewItem(new string[] { "-----", "Morning"}));
            foreach(string[] s in scheduler._ShiftManager.GetMorningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Monday, weekSelector)))
            {
                shiftsMonLv.Items.Add(new ListViewItem(s));
            }
            shiftsMonLv.Items.Add(new ListViewItem(new string[] { "-----", "Afternoon" }));
            foreach (string[] s in scheduler._ShiftManager.GetAfternoonShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Monday, weekSelector)))
            {
                shiftsMonLv.Items.Add(new ListViewItem(s));
            }
            shiftsMonLv.Items.Add(new ListViewItem(new string[] { "-----", "Evening" }));
            foreach (string[] s in scheduler._ShiftManager.GetEveningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Monday, weekSelector)))
            {
                shiftsMonLv.Items.Add(new ListViewItem(s));
            }


            shiftsTueLv.Items.Add(new ListViewItem(new string[] { "-----", "Morning" }));
            foreach (string[] s in scheduler._ShiftManager.GetMorningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Tuesday, weekSelector)))
            {
                shiftsTueLv.Items.Add(new ListViewItem(s));
            }
            shiftsTueLv.Items.Add(new ListViewItem(new string[] { "-----", "Afternoon" }));
            foreach (string[] s in scheduler._ShiftManager.GetAfternoonShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Tuesday, weekSelector)))
            {
                shiftsTueLv.Items.Add(new ListViewItem(s));
            }
            shiftsTueLv.Items.Add(new ListViewItem(new string[] { "-----", "Evening" }));
            foreach (string[] s in scheduler._ShiftManager.GetEveningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Tuesday, weekSelector)))
            {
                shiftsTueLv.Items.Add(new ListViewItem(s));
            }


            shiftsWedLv.Items.Add(new ListViewItem(new string[] { "-----", "Morning" }));
            foreach (string[] s in scheduler._ShiftManager.GetMorningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Wednesday, weekSelector)))
            {
                shiftsWedLv.Items.Add(new ListViewItem(s));
            }
            shiftsWedLv.Items.Add(new ListViewItem(new string[] { "-----", "Afternoon" }));
            foreach (string[] s in scheduler._ShiftManager.GetAfternoonShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Wednesday, weekSelector)))
            {
                shiftsWedLv.Items.Add(new ListViewItem(s));
            }
            shiftsWedLv.Items.Add(new ListViewItem(new string[] { "-----", "Evening" }));
            foreach (string[] s in scheduler._ShiftManager.GetEveningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Wednesday, weekSelector)))
            {
                shiftsWedLv.Items.Add(new ListViewItem(s));
            }


            shiftsThuLv.Items.Add(new ListViewItem(new string[] { "-----", "Morning" }));
            foreach (string[] s in scheduler._ShiftManager.GetMorningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Thursday, weekSelector)))
            {
                shiftsThuLv.Items.Add(new ListViewItem(s));
            }
            shiftsThuLv.Items.Add(new ListViewItem(new string[] { "-----", "Afternoon" }));
            foreach (string[] s in scheduler._ShiftManager.GetAfternoonShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Thursday, weekSelector)))
            {
                shiftsThuLv.Items.Add(new ListViewItem(s));
            }
            shiftsThuLv.Items.Add(new ListViewItem(new string[] { "-----", "Evening" }));
            foreach (string[] s in scheduler._ShiftManager.GetEveningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Thursday, weekSelector)))
            {
                shiftsThuLv.Items.Add(new ListViewItem(s));
            }


            shiftsFriLv.Items.Add(new ListViewItem(new string[] { "-----", "Morning" }));
            foreach (string[] s in scheduler._ShiftManager.GetMorningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Friday, weekSelector)))
            {
                shiftsFriLv.Items.Add(new ListViewItem(s));
            }
            shiftsFriLv.Items.Add(new ListViewItem(new string[] { "-----", "Afternoon" }));
            foreach (string[] s in scheduler._ShiftManager.GetAfternoonShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Friday, weekSelector)))
            {
                shiftsFriLv.Items.Add(new ListViewItem(s));
            }
            shiftsFriLv.Items.Add(new ListViewItem(new string[] { "-----", "Evening" }));
            foreach (string[] s in scheduler._ShiftManager.GetEveningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Friday, weekSelector)))
            {
                shiftsFriLv.Items.Add(new ListViewItem(s));
            }


            shiftsSatLv.Items.Add(new ListViewItem(new string[] { "-----", "Morning" }));
            foreach (string[] s in scheduler._ShiftManager.GetMorningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Saturday, weekSelector)))
            {
                shiftsSatLv.Items.Add(new ListViewItem(s));
            }
            shiftsSatLv.Items.Add(new ListViewItem(new string[] { "-----", "Afternoon" }));
            foreach (string[] s in scheduler._ShiftManager.GetAfternoonShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Saturday, weekSelector)))
            {
                shiftsSatLv.Items.Add(new ListViewItem(s));
            }
            shiftsSatLv.Items.Add(new ListViewItem(new string[] { "-----", "Evening" }));
            foreach (string[] s in scheduler._ShiftManager.GetEveningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Saturday, weekSelector)))
            {
                shiftsSatLv.Items.Add(new ListViewItem(s));
            }


            shiftsSunLv.Items.Add(new ListViewItem(new string[] { "-----", "Morning" }));
            foreach (string[] s in scheduler._ShiftManager.GetMorningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Sunday, weekSelector)))
            {
                shiftsSunLv.Items.Add(new ListViewItem(s));
            }
            shiftsSunLv.Items.Add(new ListViewItem(new string[] { "-----", "Afternoon" }));
            foreach (string[] s in scheduler._ShiftManager.GetAfternoonShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Sunday, weekSelector)))
            {
                shiftsSunLv.Items.Add(new ListViewItem(s));
            }
            shiftsSunLv.Items.Add(new ListViewItem(new string[] { "-----", "Evening" }));
            foreach (string[] s in scheduler._ShiftManager.GetEveningShiftsByDate(DateTime.Now.StartOfWeek(DayOfWeek.Sunday, weekSelector)))
            {
                shiftsSunLv.Items.Add(new ListViewItem(s));
            }
        }

        private void AssignShiftbtn_Click(object sender, EventArgs e)
        {
            //string selectedEmployee = Employeescbx.Text;
            int employeeId = Convert.ToInt32(SelectEmployeeToAssignLv.SelectedItems[0].SubItems[0].Text);
            DateTime selectedDate = DateTime.Parse(pickDateCld.SelectionRange.Start.ToString());
            Enum.TryParse(selectShiftTypecbx.SelectedIndex.ToString(), out SHIFTTYPE selectedTime);

            scheduler.AssignShift(employeeId, selectedDate, selectedTime);

            ReloadElements();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            weekSelector += 7;
            ReloadElements();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            weekSelector -= 7;
            ReloadElements();
        }

        private void AutomaticScheduleBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(startDateAS.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            DateTime endDate = DateTime.Parse(EndDateAS.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            int pplPerShift = Convert.ToInt32(pplPerShiftTbx.Text);

            scheduler.AutomaticSchedule(startDate, endDate, pplPerShift);
        }
    }
}
