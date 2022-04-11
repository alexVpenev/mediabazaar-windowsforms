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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            this.FillCheckbox();
        }

        bool ok;
        string msg;
        InputValidation valid;
        SQL s;
        Company c;

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            timerButtons.Start();
            valid = new InputValidation();
            s = new SQL();
            c = new Company();
            ok = true;
            if (valid.ValidateName(tbFN.Text) == false)
            {
                ok = false;
                msg = "Incorrect name input.";
                this.ShowError(msg);
            }
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
            if(valid.ValidateDoubleString(tbHour.Text) == false)
            {
                ok = false;
                msg = "Incorrect hourly wage input.";
                this.ShowError(msg);
            }
            if(valid.ValidateNumberString(tbContact.Text) == false)
            {
                ok = false;
                msg = "Incorrect emergency contact input.";
                this.ShowError(msg);
            }
            if(!(tbPosition.Text is string) || tbPosition.Text == "")
            {
                ok = false;
                msg = "Incorrect position input.";
                this.ShowError(msg);
            }
            if(DateTime.Now.Year - dtpDoB.Value.Year < 18 )
            {
                ok = false;
                msg = "The employee must be over 18.";
                this.ShowError(msg);
            }
            else if(DateTime.Now.Year - dtpDoB.Value.Year == 18 && DateTime.Now.Month - dtpDoB.Value.Month < 0)
            {
                ok = false;
                msg = "The employee must be over 18.";
                this.ShowError(msg);
            }
            else if(DateTime.Now.Year - dtpDoB.Value.Year == 18 && DateTime.Now.Month - dtpDoB.Value.Month == 0 && DateTime.Now.Day - dtpDoB.Value.Day < 0)
            {
                ok = false;
                msg = "The employee must be over 18.";
                this.ShowError(msg);
            }
            
            if(ok == true)
            {
                int x = c.employees.Count + 1;
                Random random = new Random();
                Employee emp = new Employee(x, tbFN.Text, tbLN.Text, tbEmail.Text, dtpDoB.Value, tbPhone.Text, tbAddress.Text, chbMarried.Checked, tbBSN.Text,
                    chbFulltime.Checked, Convert.ToDouble(tbFTE.Text), Convert.ToDouble(tbHour.Text), tbContact.Text, chbBox.SelectedIndex + 1, chbBox.SelectedItem.ToString(), tbPosition.Text, random.Next(10000).ToString());
                s.AddEmployee(emp);
                MessageBox.Show("Employee added successfully!");
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
            foreach(Department d in Enum.GetValues(typeof(Department)))
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
            foreach(Button b in this.Controls.OfType<Button>().ToList())
            {
                if (b.Name == "error")
                    b.Dispose();
            }
            timerButtons.Stop();
        }
    }
}
