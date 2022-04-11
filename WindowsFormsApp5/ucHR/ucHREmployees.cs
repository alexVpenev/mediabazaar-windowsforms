﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.ucHR
{
    public partial class ucHREmployees : UserControl
    {
        Company comp;
        SQL s;
        public ucHREmployees()
        {
            InitializeComponent();
            comp = new Company();
            s = new SQL();
            //this.CheckTerminated();

        }

        private void ViewEmployeeListActive()
        { 
            comp = new Company();
            try
            {
                listView1.Items.Clear();
                foreach (ListViewItem item in this.LoadEmployeesActive())
                {
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ex = new Exception("Error showing employees!");
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewEmployeeList()
        {
            comp = new Company();
            try
            {
                listView1.Items.Clear();
                foreach (ListViewItem item in this.LoadEmployees())
                {
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ex = new Exception("Error showing employees!");
                MessageBox.Show(ex.Message);
            }
        }
        private void ViewEmployeeListSearch(string pattern)
        {
            if (cmbSearch.SelectedIndex >= 0)
            {
                try
                {
                    listView1.Items.Clear();
                    int x;
                    if (cmbSearch.SelectedIndex == 0)
                        x = 1;
                    else if (cmbSearch.SelectedIndex == 1)
                        x = 0;
                    else
                        x = 6;
                    if (chbTerminated.Checked == true)
                    {
                        foreach (ListViewItem item in this.LoadEmployees())
                        {
                            if (item.SubItems[x].Text.Contains(pattern))
                                listView1.Items.Add(item);
                        }
                    }
                    else
                    {
                        foreach (ListViewItem item in this.LoadEmployeesActive())
                        {
                            if (item.SubItems[x].Text.Contains(pattern))
                                listView1.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ex = new Exception("Error showing employees!");
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Please select a search criteria.");
        }
        private ListViewItem[] LoadEmployees()
        {
            List<ListViewItem> lvItem = new List<ListViewItem>();
            string[] lecontracts = s.GetContractsStatus();
            int cnt = 0;
            try
            {
                foreach (Employee e in comp.employees)
                {
                    List<string> i = new List<string>();
                    i.Add(e.BSN);
                    i.Add(e.firstName + " " + e.lastName);
                    i.Add(e.emailAddress);
                    i.Add(e.phoneNo);
                    i.Add(e.address);
                    if (lecontracts[cnt] == "True")
                        lecontracts[cnt] = "Active";
                    else
                        lecontracts[cnt] = "Terminated";
                    i.Add(lecontracts[cnt]);
                    i.Add(e.position);
                    lvItem.Add(new ListViewItem(i.ToArray()));
                    cnt++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ex = new Exception("Error loading employees!");
                MessageBox.Show(ex.Message);
            }
            return lvItem.ToArray();
        }

        private ListViewItem[] LoadEmployeesActive()
        {
            List<ListViewItem> lvItem = new List<ListViewItem>();
            string[] lecontracts = s.GetContractsStatus();
            int cnt = 0;
            try
            {
                foreach (Employee e in comp.employees)
                {
                    if(lecontracts[cnt] == "True")
                    {
                        List<string> i = new List<string>();
                        i.Add(e.BSN);
                        i.Add(e.firstName + " " + e.lastName);
                        i.Add(e.emailAddress);
                        i.Add(e.phoneNo);
                        i.Add(e.address);
                        lecontracts[cnt] = "Active";
                        i.Add(lecontracts[cnt]);
                        i.Add(e.position);
                        lvItem.Add(new ListViewItem(i.ToArray()));
                    }
                    cnt++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ex = new Exception("Error loading employees!");
                MessageBox.Show(ex.Message);
            }
            return lvItem.ToArray();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                AddEmployeeForm addEmployee = new AddEmployeeForm();
                addEmployee.ShowDialog();
                this.CheckTerminated();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error opening form!");
                throw ex;
            }
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an employee to modify!");
            }
            else
            {
                try
                {
                    ChangeInfoEmployeeForm changeEmployee = new ChangeInfoEmployeeForm(s.GetEmployeeByBSN(listView1.SelectedItems[0].SubItems[0].Text));
                    changeEmployee.ShowDialog();
                    this.CheckTerminated();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void btnFireEmployee_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an employee to modify!");
            }
            else
            {
                try
                {
                    if (richTextBox1.Text == "")
                        MessageBox.Show("Please enter a reason for terminating the employee!");
                    else if(listView1.SelectedItems[0].SubItems[5].Text == "Terminated")
                    {
                        MessageBox.Show("Please select an employee that is still in the company.");
                    }
                    else
                    {
                        s.FireEmployee(s.GetEmployeeByBSN(listView1.SelectedItems[0].SubItems[0].Text), richTextBox1.Text);
                        this.CheckTerminated();
                        MessageBox.Show("Employee terminated successfully.");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            this.ViewEmployeeListSearch(tbSearch.Text);
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            this.CheckTerminated();
        }

        private void ucHREmployees_Load(object sender, EventArgs e)
        {
            this.CheckTerminated();
        }

        private void chbTerminated_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckTerminated();
        }

        private void ucHREmployees_MouseClick(object sender, MouseEventArgs e)
        {
            this.CheckTerminated();
        }

        private void CheckTerminated()
        {
            if (chbTerminated.Checked == false)
                this.ViewEmployeeListActive();
            else
                this.ViewEmployeeList();
            tbSearch.Text = "";
        }
    }
}