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
    public partial class ucDWStockRequest : UserControl
    {
        public string ReqId { get; set; }
        public string ReqModel { get; set; }
        public int ReqQuantity { get; set; }
        public string ReqStatus { get; set; }
        
        private SQL sql = new SQL();

        public ucDWStockRequest()
        {
            InitializeComponent();

            lvRequests.Items.Clear();
            foreach (ListViewItem i in LoadProducts())
            {
                lvRequests.Items.Add(i);
            }
        }

        private ListViewItem[] LoadProducts()
        {
            StockRequests stockRequests = new StockRequests();
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            foreach (Request r in stockRequests.requests)
            {
                List<string> n = new List<string>();
                n.Add(r.Id.ToString());
                n.Add(r.Model);
                n.Add(r.Quantity.ToString());
                n.Add(r.Status);

                listViewItems.Add(new ListViewItem(n.ToArray()));
            }
            return listViewItems.ToArray();
        }

        public void RefreshRequests()
        {
            lvRequests.Items.Clear();
            foreach (ListViewItem i in LoadProducts())
            {
                lvRequests.Items.Add(i);
            }
        }

        public string SelectedItemID()
        {
            if (lvRequests.SelectedItems.Count > 0)
            {
                var item = lvRequests.SelectedItems[0];
                ReqId = item.Text;
                return ReqId;
            }
            return "";
        }

        public string SelectedItemModel()
        {
            if (lvRequests.SelectedItems.Count > 0)
            {
                var item = lvRequests.SelectedItems[0].SubItems[1];
                ReqModel = item.Text;
                return ReqModel;
            }
            return "";
        }

        public int SelectedItemQuantity()
        {
            if (lvRequests.SelectedItems.Count > 0)
            {
                var item = int.Parse(lvRequests.SelectedItems[0].SubItems[2].Text);
                ReqQuantity = item;
                return ReqQuantity;
            }
            return -1;
        }
        public string SelectedItemStatus()
        {
            if (lvRequests.SelectedItems.Count > 0)
            {
                var item = lvRequests.SelectedItems[0].SubItems[3];
                ReqStatus = item.Text;
                return ReqStatus;
            }
            return "";
        }

        private void lblId_Click(object sender, EventArgs e)
        {
            
        }

        private void lvRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string id = SelectedItemID();
            string model = SelectedItemModel();
            int quantity = Convert.ToInt32(SelectedItemQuantity());

            if (id != "")
            {
                if (SelectedItemStatus() == "ACCEPTED" || SelectedItemStatus() == "DECLINED")
                {
                    MessageBox.Show("This request has been terminated already.");
                }
                else
                {
                    sql.AcceptRequest(Convert.ToInt32(id));
                    sql.UpdateQuantity(model, quantity);
                    RefreshRequests();
                    MessageBox.Show("Request has been successfully accepted.");
                }
            }
            else MessageBox.Show("Choose a request to accept first.");
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            string id = SelectedItemID();

            if (id != "")
            {
                if (SelectedItemStatus() == "ACCEPTED" || SelectedItemStatus() == "DECLINED")
                {
                    MessageBox.Show("This request has been terminated already.");
                }
                else
                {
                    sql.DeclineRequest(Convert.ToInt32(id));
                    RefreshRequests();
                    MessageBox.Show("Request has been successfully declined.");
                }
            }
            else MessageBox.Show("Choose a request to decline first.");
        }

        private void ucDWStockRequest_Load(object sender, EventArgs e)
        {

        }
    }
    
}
