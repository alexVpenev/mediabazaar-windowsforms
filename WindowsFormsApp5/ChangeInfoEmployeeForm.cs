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
    public partial class ChangeInfoEmployeeForm : Form
    {
        public ChangeInfoEmployeeForm(Employee emp)
        {
            InitializeComponent();
            this.FillCheckbox();
            valid = new InputValidation();
            s = new SQL();
            c = new Company();
            leid = emp.id;
            tbFN.Text = emp.firstName;
            tbLN.Text = emp.lastName;
            tbEmail.Text = emp.emailAddress;
            dtpDoB.Value = emp.dateOfBirth;
            tbPhone.Text = emp.phoneNo;
            tbAddress.Text = emp.address;
            tbPassword.Text = emp.password;
            tbPassword.Enabled = false;
            if (emp.maritalStatus == true)
                chbMarried.Checked = true;
            tbBSN.Text = emp.BSN;
            if (emp.fulltime == true)
            {
                chbFulltime.Checked = true;
                tbFTE.Text = "1";
            }
            else
            {
                chbFulltime.Checked = false;
                tbFTE.Text = emp.FTE.ToString();
            }
            tbHour.Text = emp.salary.ToString();
            tbContact.Text = emp.emergencyNo;
            chbBox.SelectedIndex = emp.departmentId - 1;
            tbPosition.Text = emp.position;
        }
        int leid;
        bool ok;
        string msg;
        InputValidation valid;
        SQL s;
        Company c;
        Employee god;

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            timerButtons.Start();
            ok = true;
            if (valid.ValidateName(tbFN.Text) == false)
            {
                ok = false;
                msg = "Incorrect name input.";
                this.ShowError(msg);
            }
            else
            if (valid.ValidateName(tbLN.Text) == false)
            {
                ok = false;
                msg = "Incorrect name input.";
                this.ShowError(msg);
            }
            if (valid.ValidateEmail(tbEmail.Text) == false)
            {
                ok = false;
                msg = "Incorrect email input.";
                this.ShowError(msg);
            }
            if (valid.ValidateNumberString(tbPhone.Text) == false)
            {
                ok = false;
                msg = "Incorrect phone input.";
                this.ShowError(msg);
            }
            if (valid.ValidateAddress(tbAddress.Text) == false)
            {
                ok = false;
                msg = "Incorrect address input.";
                this.ShowError(msg);
            }
            if (valid.ValidateNumberString(tbBSN.Text) == false)
            {
                ok = false;
                msg = "Incorrect BSN input.";
                this.ShowError(msg);
            }
            if (chbFulltime.Checked == false)
            {
                if (valid.ValidateFTE(tbFTE.Text) == false)
                {
                    ok = false;
                    msg = "Incorrect FTE input (0.1-0.9 is the correct interval, only one decimal!)";
                    this.ShowError(msg);
                }
            }

            if(ok == true)
            {
                god = new Employee(leid, tbFN.Text, tbLN.Text, tbEmail.Text, dtpDoB.Value, tbPhone.Text, tbAddress.Text, chbMarried.Checked, tbBSN.Text,
                    chbFulltime.Checked, Convert.ToDouble(tbFTE.Text), Convert.ToDouble(tbHour.Text), tbContact.Text, chbBox.SelectedIndex + 1, chbBox.SelectedItem.ToString(), tbPosition.Text, tbPassword.Text);
                s.UpdateEmployee(god);
                MessageBox.Show("Employee updated successfully!");
                this.Close();
            }
        }

        private void chbFulltime_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFulltime.Checked == true)
            {
                tbFTE.Enabled = false;
                tbFTE.Text = "1";
            }

            else
            {
                tbFTE.Enabled = true;
                tbFTE.Text = "";
            }
        }

        private void FillCheckbox()
        {
            foreach (Department d in Enum.GetValues(typeof(Department)))
            {
                chbBox.Items.Add(d);
            }
        }
        private void ShowError(string message)
        {
            Button b = new Button();
            b.Dock = DockStyle.Top;
            b.Text = message;
            b.BackColor = Color.Red;
            b.Name = "error";
            this.Controls.Add(b);
            b.BringToFront();
            b.Click += new EventHandler(this.CloseButton);
        }

        private void CloseButton(object sender, EventArgs e)
        {
            Button daButton = (Button)sender;
            daButton.Dispose();
        }

        private void timerButtons_Tick(object sender, EventArgs e)
        {
            foreach (Button b in this.Controls.OfType<Button>().ToList())
            {
                if (b.Name == "error")
                    b.Dispose();
            }
            timerButtons.Stop();
        }

    }
}
