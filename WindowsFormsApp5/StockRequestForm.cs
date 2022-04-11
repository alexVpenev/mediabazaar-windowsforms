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
    public partial class StockRequestForm : Form
    {
        private SQL sql = new SQL();
        private ucSR.ucSRStockRequests sr;
        Storage storage = new Storage();

        public StockRequestForm(ucSR.ucSRStockRequests ucSRStockRequests)
        {
            InitializeComponent();
            this.CenterToParent();
            this.sr = ucSRStockRequests;
            ComboBoxItems();
        }

        private void ComboBoxItems()
        {
            foreach (Product p in storage.products)
            {
                cbRequest.Items.Add(p.Model);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string model = cbRequest.Text;
            int quantity = Convert.ToInt32(numQuantity.Value);
            string status = "REQUESTED";

            if (cbRequest.Text == "" || numQuantity.Value == 0)
            {
                MessageBox.Show("Provide required information.");
            }
            else
            {
                sql.MakeRequest(model,quantity,status);
                sr.RefreshRequests();
                MessageBox.Show("Requested.");
                this.Close();
            }
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
