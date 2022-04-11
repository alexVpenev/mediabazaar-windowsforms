using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.ucDW
{
    public partial class ucDWStockDepot : UserControl
    {
        public string Id { get;  set; }
        public string Brand { get; set; }
        public string Price { get; set; }
        public string NrInWarehouse { get; set; }
        public string AisleNr { get; set; }

        private EditProductForm editProductForm;
        private AddProductForm addProductForm;
        
        private SQL sql = new SQL();


        public ucDWStockDepot()
        {
            InitializeComponent();

            listView1.Items.Clear();
            foreach (ListViewItem i in LoadProducts())
            {
                listView1.Items.Add(i);
            }
        }

        private ListViewItem[] LoadProducts()
        {
            Storage storage = new Storage();
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            foreach(Product p in storage.products) //was storage.productsInfo
            {
                List<string> n = new List<string>();
                n.Add(p.Model);
                n.Add(p.BrandName);
                //n.Add(p.Description);
                //n.Add(p.Category.ToString());
                n.Add(p.Price.ToString());
                n.Add(p.NoInWarehouse.ToString());
                n.Add(p.AisleNumber.ToString());
                n.Add(p.ShelfID);
                
                listViewItems.Add(new ListViewItem(n.ToArray()));
            }
            return listViewItems.ToArray();
        }
        
        public void RefreshProducts()
        {
            listView1.Items.Clear();
            foreach (ListViewItem i in LoadProducts())
            {
                listView1.Items.Add(i);
            }
        }
       
        public string SelectedItemID()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];             
                Id = item.Text;
                return Id;
            }
            return "";
        }

        public string SelectedItemBrand()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0].SubItems[1];
                Brand = item.Text;
                return Brand;
            }
            return "";
        }

        public string SelectedItemPrice()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0].SubItems[2];
                Price = item.Text;
                return Price;
            }
            return "";
        }

        public string SelectedItemNrInWarehouse()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0].SubItems[3];
                NrInWarehouse = item.Text;
                return NrInWarehouse;
            }
            return "";
        }

        public string SelectedItemAisleNr()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0].SubItems[4];
                AisleNr = item.Text;
                return AisleNr;
            }
            return "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblItem.Text = SelectedItemID();
        }

        //private ListViewItem[] SearchProduct(string entry)
        //{           
        //    List<ListViewItem> result = new List<ListViewItem>();
        //    LoadProducts();

        //    if (textBox1.Text != "")
        //    {
        //        foreach (ListViewItem listViewItem in listView1.Items)
        //        {
        //            if (listViewItem.Text.ToLower().Contains(textBox1.Text.ToLower()))
        //            {
        //                listViewItem.Selected = true;
        //            }
        //            else
        //            {
        //                listView1.Items.Remove(listViewItem);
        //            }
        //        }
        //        if (listView1.SelectedItems.Count == 1)
        //        {
        //            listView1.Focus();
        //        }

        //    }

        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            editProductForm  = new EditProductForm(this);
            editProductForm.Show();
        }

        private void lblSelected_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addProductForm = new AddProductForm(this);
            addProductForm.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string id = SelectedItemID();
            if (id != "")
            {
                var confimation = MessageBox.Show("Are you sure you want to remove product: "+ id +"?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confimation == DialogResult.Yes)
                {
                    sql.RemoveProduct(id);
                    RefreshProducts();
                }
            }
            else MessageBox.Show("Choose a product you want to remove first.");                  
        }

        private void lblItem_Click(object sender, EventArgs e)
        {

        }
    }
}
