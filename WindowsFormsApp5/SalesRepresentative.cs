using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.ucSR;
using System.IO;
using System.Reflection;

namespace WindowsFormsApp5
{
    public partial class SalesRepresentative : Form
    {
        private LoginForm lg;
        Bitmap bmp;
        public SalesRepresentative(LoginForm loginForm)
        {
            InitializeComponent();
            bmp = Properties.Resources.teek;
            this.CenterToScreen();
            this.lg = loginForm;
        }

        private void btnSRStockDepot_Click(object sender, EventArgs e)
        {
            panelMain.Controls.OfType<UserControl>().ToList().ForEach(uc => uc.Dispose());
            try
            {
                this.btnSRStockDepot.Image = bmp;
            }
            catch(Exception ex)
            {
                ex = new Exception("Error loading the image.");
                MessageBox.Show(ex.Message);
            }
            if (this.btnSRStockRequests.Image != null)
                this.btnSRStockRequests.Image = null;
            if (this.btnSRAttendance.Image != null)
                this.btnSRAttendance.Image = null;
            ucSRStockDepot ucSRSD = new ucSRStockDepot();
            panelMain.Controls.Add(ucSRSD);
            ucSRSD.BringToFront();
        }

        private void btnSRStockRequests_Click(object sender, EventArgs e)
        {
            panelMain.Controls.OfType<UserControl>().ToList().ForEach(uc => uc.Dispose());
            try
            {
                this.btnSRStockRequests.Image = bmp;
            }
            catch (Exception ex)
            {
                ex = new Exception("Error loading the image.");
                MessageBox.Show(ex.Message);
            }
            if (this.btnSRStockDepot.Image != null)
                this.btnSRStockDepot.Image = null;
            if (this.btnSRAttendance.Image != null)
                this.btnSRAttendance.Image = null;
            ucSRStockRequests ucSRSR = new ucSRStockRequests();
            panelMain.Controls.Add(ucSRSR);
            ucSRSR.BringToFront();
        }

        private void btnSRStatistics_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSRAttendance_Click(object sender, EventArgs e)
        {
            panelMain.Controls.OfType<UserControl>().ToList().ForEach(uc => uc.Dispose());
            try
            {
                this.btnSRAttendance.Image = bmp;
            }
            catch (Exception ex)
            {
                ex = new Exception("Error loading the image.");
                MessageBox.Show(ex.Message);
            }
            if (this.btnSRStockDepot.Image != null)
                this.btnSRStockDepot.Image = null;
            if (this.btnSRStockRequests.Image != null)
                this.btnSRStockRequests.Image = null;
            ucSRAttendance ucSRS = new ucSRAttendance();
            panelMain.Controls.Add(ucSRS);
            ucSRS.BringToFront();
        }
    }
}
