using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class LoginForm : Form
    {
        private LoginCheck loginCheck;
        private ManagerForm managerForm;
        private HRForm hrForm;
        private DepotWorker depotworkerForm;
        private SalesRepresentative salesrepresentativeForm;
        public LoginForm()
        {
            InitializeComponent();
            try
            {
                System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
                this.CenterToScreen();
                loginCheck = new LoginCheck();
                tbUser.Enter += new EventHandler(tbUser_Enter);
                tbPassword.Enter += new EventHandler(tbPassword_Enter);
                tbPassword.KeyUp += new KeyEventHandler(tbPassword_KeyUp);
            }
            catch(Exception ex)
            {
                ex = new Exception("Error loading the form.");
                MessageBox.Show(ex.Message);
            }

        }


        private void tbUser_Enter(object sender, EventArgs e)
        {
            try
            {
                if (tbUser.Text == "Log In")
                    tbUser.Text = "";
                tbUser.ForeColor = System.Drawing.Color.Black;
                tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            }
            catch(Exception ex)
            {
                ex = new Exception("Error accessing the textbox!");
                MessageBox.Show(ex.Message);
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            try
            {
                if (tbPassword.Text == "Password")
                    tbPassword.Text = "";
                tbPassword.ForeColor = System.Drawing.Color.Black;
                tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            }
            catch(Exception ex)
            {
                ex = new Exception("Error accessing the textbox.");
                MessageBox.Show(ex.Message);
            }
        }

        private void tbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                    this.btnLogin.PerformClick();
            }
            catch (Exception ex)
            {
                ex = new Exception("Error pressing 'enter' to log in.");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = tbUser.Text;
            string pass = tbPassword.Text;
            if (loginCheck.CheckLogin(user, pass) == true)
            {
                if (loginCheck.GetAccessByUsername(user) == ACCESS.Manager)
                {
                    managerForm = new ManagerForm(this);
                    managerForm.Show();
                    this.Hide();
                }
                else if (loginCheck.GetAccessByUsername(user) == ACCESS.HR)
                {
                    hrForm = new HRForm(this);
                    hrForm.Show();
                    this.Hide();
                }
                else if (loginCheck.GetAccessByUsername(user) == ACCESS.DepotWorker)
                {
                    depotworkerForm = new DepotWorker(this);
                    depotworkerForm.Show();
                    this.Hide();
                }
                else if (loginCheck.GetAccessByUsername(user) == ACCESS.SalesRepresentative)
                {
                    salesrepresentativeForm = new SalesRepresentative(this);
                    salesrepresentativeForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }
    }
}
