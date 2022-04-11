using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.ucHR
{
    public partial class ucHRShifts : UserControl
    {
        Company comp;
        DateTime selectedDate;
        SHIFTTYPE selectedTime;

        public ucHRShifts()
        {
            comp = new Company();
            InitializeComponent();
        }

        private void calendarShift_DateChanged(object sender, DateRangeEventArgs e)
        {
            selectedDate = DateTime.Parse(calendarShift.SelectionRange.Start.ToString());
            comp.reloadObjects();
            loadList();
        }

        private void selectShiftTypecbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(selectShiftTypecbx.SelectedIndex.ToString(), out SHIFTTYPE time);
            selectedTime = time;
            loadList();
        }

        private void loadList()
        {
            try
            {
                peopleOnAShiftlbx.Items.Clear();
                foreach (Shift s in comp.allShifts)
                {
                    if (s.day == selectedDate && s.time == selectedTime)
                    {
                        peopleOnAShiftlbx.Items.Add(s.employeeName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ex = new Exception("Error loading employees!");
                MessageBox.Show(ex.Message);
            }
        }

        private void UnassignShiftbtn_Click(object sender, EventArgs e)
        {
            string name = peopleOnAShiftlbx.SelectedIndex.ToString();
            comp.DeleteShiftFromDataBase(name, selectedDate, selectedTime);
            loadList();
        }

        private void AddNewShiftbtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddShiftForm addEmployee = new AddShiftForm();
                addEmployee.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening form!");
            }
        }
    }
}
