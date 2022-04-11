using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class AddShiftForm : Form
    {
        Company comp;

        public AddShiftForm()
        {
            InitializeComponent();
            comp = new Company();

            foreach (Employee e in comp.employees)
            {
                Employeescbx.Items.Add(e.firstName + e.lastName);
            }
        }

        private void AssignShiftbtn_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(selectShiftTypecbx.Text) && string.IsNullOrEmpty(Employeescbx.Text))
            //{
                string selectedEmployee = Employeescbx.Text;
                DateTime selectedDate = DateTime.Parse(pickDateCld.SelectionRange.Start.ToString());
                Enum.TryParse(selectShiftTypecbx.SelectedIndex.ToString(), out SHIFTTYPE selectedTime);

                //comp.AssignShift(selectedEmployee, selectedDate, selectedTime);
                this.Close();

            //}
            //else
            //{
            //    MessageBox.Show("Please fill in all fields");
            //}
        }
    }
}


