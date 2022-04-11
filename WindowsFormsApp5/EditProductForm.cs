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
    public partial class EditProductForm : Form
    {
        private SQL sql = new SQL();
        private ucDW.ucDWStockDepot sd;

        public EditProductForm(ucDW.ucDWStockDepot ucDWStockDepot)
        {
            InitializeComponent();
            this.CenterToParent();
            this.sd = ucDWStockDepot;

            lblModel.Text = sd.SelectedItemID();
            tbBrand.Text = sd.SelectedItemBrand();
            tbPrice.Text = sd.SelectedItemPrice();
            tbWarehouseNr.Text = sd.SelectedItemNrInWarehouse();
            tbAisle.Text = sd.SelectedItemAisleNr();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            if(lblModel.Text == "")
            {
                MessageBox.Show("Please choose a product to edit.");
            }
            else if(tbBrand.Text == "" || tbPrice.Text == "" || tbWarehouseNr.Text == "" || tbAisle.Text == "")
            {
                MessageBox.Show("Provide required information.");

            }
            else
            {

                sql.EditProduct(tbBrand.Text, Convert.ToInt32(tbPrice.Text), Convert.ToInt32(tbWarehouseNr.Text), Convert.ToInt32(tbAisle.Text),sd.SelectedItemID());
                sd.RefreshProducts();
                MessageBox.Show("Edited.");
                this.Close();
            }
            
        }
    }
}
