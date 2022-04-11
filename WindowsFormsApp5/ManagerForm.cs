using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.ucM;
using System.IO;
using System.Reflection;

namespace WindowsFormsApp5
{
    public partial class ManagerForm : Form
    {
        private LoginForm lg;
        Bitmap bmp;
        public ManagerForm(LoginForm loginForm)
        {
            InitializeComponent();
            bmp = Properties.Resources.teek;
            this.CenterToScreen();
            this.lg = loginForm;
        }

        private void btnMEmployees_Click(object sender, EventArgs e)
        {
            panelMain.Controls.OfType<UserControl>().ToList().ForEach(uc => uc.Dispose());
            try
            {
                this.btnMEmployees.Image = bmp;
            }
            catch (Exception ex)
            {
                ex = new Exception("Error loading the image.");
                MessageBox.Show(ex.Message);
            }
            if (this.btnMStatistics.Image != null)
                this.btnMStatistics.Image = null;
            ucMEmployees ucME = new ucMEmployees();
            panelMain.Controls.Add(ucME);
            ucME.BringToFront();
        }

        private void btnMStatistics_Click(object sender, EventArgs e)
        {
            panelMain.Controls.OfType<UserControl>().ToList().ForEach(uc => uc.Dispose());
            try
            {
                this.btnMStatistics.Image = bmp;
            }
            catch (Exception ex)
            {
                ex = new Exception("Error loading the image.");
                MessageBox.Show(ex.Message);
            }
            if (this.btnMEmployees.Image != null)
                this.btnMEmployees.Image = null;
            ucMStatistics ucMS = new ucMStatistics();
            panelMain.Controls.Add(ucMS);
            ucMS.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            lg.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
