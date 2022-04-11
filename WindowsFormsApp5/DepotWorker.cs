using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.ucDW;
using System.IO;
using System.Reflection;

namespace WindowsFormsApp5
{
    public partial class DepotWorker : Form
    {
        SQL sql = new SQL();
        private LoginForm lg;
        Bitmap bmp;
        public DepotWorker(LoginForm loginForm)
        {
            InitializeComponent();
            bmp = Properties.Resources.teek;
            this.CenterToScreen();
            this.lg = loginForm;
        }

        private void btnDWStockDepot_Click(object sender, EventArgs e)
        {
            panelMain.Controls.OfType<UserControl>().ToList().ForEach(uc => uc.Dispose());
            try
            {
                this.btnDWStockDepot.Image = bmp;
            }
            catch (Exception ex)
            {
                ex = new Exception("Error loading the image.");
                MessageBox.Show(ex.Message);
            }
            if (this.btnDWStockRequests.Image != null)
                this.btnDWStockRequests.Image = null;
            ucDWStockDepot ucDWSD = new ucDWStockDepot();
            panelMain.Controls.Add(ucDWSD);
            ucDWSD.BringToFront();
        }

        private void btnDWStockRequests_Click(object sender, EventArgs e)
        {
            panelMain.Controls.OfType<UserControl>().ToList().ForEach(uc => uc.Dispose());
            try
            {
                this.btnDWStockRequests.Image = bmp;
            }
            catch (Exception ex)
            {
                ex = new Exception("Error loading the image.");
                MessageBox.Show(ex.Message);
            }
            if (this.btnDWStockDepot.Image != null)
                this.btnDWStockDepot.Image = null;
            ucDWStockRequest ucDWSR = new ucDWStockRequest();
            panelMain.Controls.Add(ucDWSR);
            ucDWSR.BringToFront();
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
