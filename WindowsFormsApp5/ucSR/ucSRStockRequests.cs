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
    public partial class ucSRStockRequests : UserControl
    {
        private StockRequestForm stockRequestForm;
        
        private SQL sql = new SQL();

        public ucSRStockRequests()
        {
            InitializeComponent();

            lvRequests.Items.Clear();
            foreach (ListViewItem i in LoadRequests())
            {
                lvRequests.Items.Add(i);
            }
        }

        public void RefreshRequests()
        {
            lvRequests.Items.Clear();
            foreach (ListViewItem i in LoadRequests())
            {
                lvRequests.Items.Add(i);
            }
        }

        private ListViewItem[] LoadRequests()
        {
            StockRequests stockRequests = new StockRequests();
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            foreach (Request r in stockRequests.requests)
            {
                List<string> n = new List<string>();               
                n.Add(r.Model);
                n.Add(r.Quantity.ToString());
                n.Add(r.Id.ToString());
                n.Add(r.Status);

                listViewItems.Add(new ListViewItem(n.ToArray()));
            }
            return listViewItems.ToArray();
        }


        private void btnRequest_Click(object sender, EventArgs e)
        {
            stockRequestForm = new StockRequestForm(this);
            stockRequestForm.Show();
        }
    }
}
