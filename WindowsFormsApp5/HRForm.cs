using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.ucHR;
using System.Reflection;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class HRForm : Form
    {
        private LoginForm lg;
        Bitmap bmp;
        public HRForm(LoginForm loginForm)
        {
            InitializeComponent();
            bmp = Properties.Resources.teek;
            this.CenterToScreen();
            this.lg = loginForm;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            lg.Show();
            this.Close();
        }

        private void btnHREmployees_Click(object sender, EventArgs e)
        {
            panelMain.Controls.OfType<UserControl>().ToList().ForEach(uc => uc.Dispose());
            try
            {
                this.btnHREmployees.Image = bmp;
            }
            catch (Exception ex)
            {
                ex = new Exception("Error loading the image.");
                MessageBox.Show(ex.Message);
            }
            if (this.btnHRShifts.Image != null)
                this.btnHRShifts.Image = null;

            ucHREmployees ucHRE = new ucHREmployees();
            panelMain.Controls.Add(ucHRE);
            ucHRE.BringToFront();
        }


        private void btnShifts2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.OfType<UserControl>().ToList().ForEach(uc => uc.Dispose());
            try
            {
                this.btnHRShifts.Image = bmp;
            }
            catch (Exception ex)
            {
                ex = new Exception("Error loading the image.");
                MessageBox.Show(ex.Message);
            }
            if (this.btnHREmployees.Image != null)
                this.btnHREmployees.Image = null;
            WeeklyShifts weeklyShifts = new WeeklyShifts();
            panelMain.Controls.Add(weeklyShifts);
            weeklyShifts.BringToFront();
        }
    }
}
