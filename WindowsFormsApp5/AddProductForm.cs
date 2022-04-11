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
    public partial class AddProductForm : Form
    {
        private SQL sql = new SQL();
        private ucDW.ucDWStockDepot sd;

        public AddProductForm(ucDW.ucDWStockDepot ucDWStockDepot)
        {
            InitializeComponent();
            this.CenterToParent();
            this.sd = ucDWStockDepot;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Enum.TryParse(cbCategory.Text, out Department category);

                DateTime shipDate;
                if (tbShipDate.Text == "")
                {
                    shipDate = DateTime.Now;
                }
                else shipDate = Convert.ToDateTime(tbShipDate.Text);

                if (tbAisle.Text == "" || tbBrand.Text == "" || tbHeight.Text == "" || tbLocLeft.Text == "" || tbLocRight.Text == "" || tbModel.Text == "" || tbPrice.Text == "" || tbRegEmp.Text == "" || tbWarehouseNr.Text == "" || tbWeight.Text == "" || tbWidth.Text == "")
                {
                    MessageBox.Show("Please enter required information.");
                }
                else
                {
                    sql.AddProduct(tbModel.Text, tbBrand.Text, Convert.ToDouble(tbWeight.Text), Convert.ToDouble(tbHeight.Text), Convert.ToDouble(tbWidth.Text), tbDescription.Text, category, Convert.ToDouble(tbPrice.Text), Convert.ToInt32(tbAisle.Text), Convert.ToInt32(tbLocLeft.Text), Convert.ToInt32(tbLocRight.Text), tbRegEmp.Text, Convert.ToInt32(tbWarehouseNr.Text), shipDate);
                    //sql.AddShelf(tbModel.Text, 20, Convert.ToInt32(tbWarehouseNr.Text));
                    sd.RefreshProducts();
                    MessageBox.Show("Added.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
