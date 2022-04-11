using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.ucSR
{
    public partial class ucSRAttendance : UserControl
    {
        private SQL sql = new SQL();      
        string username;

        public ucSRAttendance()
        {
            InitializeComponent();
            //this.users = sql.GetUsers();
            username = GetUsername();
            lblUsername.Text = username;
            
            listView1.Items.Clear();
            foreach (ListViewItem i in this.LoadAttendanceList())
            {
                listView1.Items.Add(i);
            }
        }

        public string GetUsername()
        {           
            try
            {
                List<User> users;
                users = sql.GetUsers();

                foreach (User u in users)
                {
                        return  u.Username;
                }
                throw new Exception("Username not found!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddCheckIn()
        {
            Attendance attendance = new Attendance();
            attendance.Comment = tbComment.Text;
            attendance.Username = lblUsername.Text;
            attendance.DateTime = DateTime.Now;

            if (rbCheckin.Checked)
            {
                attendance.Type = "Check-In";
            }
            else if (rbCheckout.Checked)
            {
                attendance.Type = "Check-out";
            }
            else MessageBox.Show("Please choose whether you want to check in or out");

            sql.AddAttendance(attendance.Username, attendance.Type, attendance.DateTime, attendance.Comment);
        }

        private ListViewItem[] LoadAttendanceList()
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            foreach (Attendance a in sql.GetAttendanceList())
            {
                List<string> n = new List<string>();
                if (a.Type == "Check-In") { n.Add("IN"); }
                else if(a.Type == "Check-out") { n.Add("OUT"); }
                n.Add(a.DateTime.ToShortDateString());
                n.Add(a.DateTime.ToShortTimeString());
                n.Add(a.Comment);

                listViewItems.Add(new ListViewItem(n.ToArray()));
            }
            return listViewItems.ToArray();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                AddCheckIn();
                //listView1.Items.Clear();
                foreach (ListViewItem i in this.LoadAttendanceList())
                {
                    listView1.Items.Add(i);
                }

                rbCheckin.Checked = false;
                rbCheckout.Checked = false;
                tbComment.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }
    }
}
