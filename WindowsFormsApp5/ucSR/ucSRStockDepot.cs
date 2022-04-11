using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.ucSR
{
    public partial class ucSRStockDepot : UserControl
    {
        Storage storage;

        public ucSRStockDepot()
        {
            InitializeComponent();
            storage = new Storage();

            listView1.Items.Clear();
            foreach (ListViewItem i in this.LoadProducts())
            {
                listView1.Items.Add(i);
            }
        }

        private ListViewItem[] LoadProducts()
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            foreach (Product p in storage.products)
            {
                List<string> n = new List<string>();
                n.Add(p.Model);
                n.Add(p.BrandName);
                n.Add(p.Category.ToString());
                n.Add(p.Price.ToString());
                n.Add(p.NoInWarehouse.ToString());
                n.Add(p.AisleNumber.ToString());
                n.Add(p.ShelfID.ToString());

                listViewItems.Add(new ListViewItem(n.ToArray()));
            }
            return listViewItems.ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
