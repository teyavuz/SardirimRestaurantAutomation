using Sardirim_DAL;
using Sardirim_BLL;
using Sardirim_UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sardirim_UI.Formlar.Randevu
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        SardirimRest_DBEntities db = new SardirimRest_DBEntities();
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Customers)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = item.CustomerID.ToString();
                lst.SubItems.Add(item.CustomerName);
                lst.SubItems.Add(item.CustomerSurname);
                lst.SubItems.Add(item.CustomerPhone);
                lstChooseCustomer.Items.Add(lst);
            }
            foreach (var item in db.Staffs.Where(x=>x.StaffTypeID==3))
            {
                cmbOrderTaker.Items.Add(item.StaffName + " " + item.StaffSurname);
                
            }
        }

        private void cmbChooseBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstChooseTable.Items.Clear();
            foreach (var item in db.Tables.Where(x => x.BranchID == cmbChooseBranch.SelectedIndex + 1))
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = item.TableID.ToString();
                lst.SubItems.Add(item.TableName);
                lst.SubItems.Add(item.Branch.BranchName);
                lstChooseTable.Items.Add(lst);

            }
        }

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            


        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            OrderForm ChildForm = new OrderForm();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CustomerList(txtSearchName.Text);
        }
        public void CustomerList(string CustomerName)
        {
            lstChooseCustomer.Items.Clear();
            foreach (var item in db.Customers.Where(x=>x.CustomerName.StartsWith(CustomerName)))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.CustomerID.ToString();
                lvi.SubItems.Add(item.CustomerName);
                lvi.SubItems.Add(item.CustomerSurname);
                lvi.SubItems.Add(item.CustomerPhone);
                lstChooseCustomer.Items.Add(lvi);
            }
        }

        private void cmbChooseBranch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lstChooseTable.Items.Clear();
            foreach (var item in db.Tables.Where(x => x.BranchID == cmbChooseBranch.SelectedIndex + 1))
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = item.TableID.ToString();
                lst.SubItems.Add(item.TableName);
                lst.SubItems.Add(item.Branch.BranchName);
                lstChooseTable.Items.Add(lst);

            }
        }

        private void btnCreateReservation_Click_1(object sender, EventArgs e)
        {
            int creator;
            try
            {
                Reservation rez = new Reservation();
                rez.CustomerID = Convert.ToInt32(lblcustomer.Text);
                rez.TableID = Convert.ToInt32(lbltable.Text);
                rez.ReservationDate = dtmPickDate.Value;
                creator = Convert.ToInt32(lblStaffid.Text);
                rez.CreatorID = creator;
                ReservationRepository rp = new ReservationRepository();
                rp.Add(rez);
            }
            catch 
            {

                MessageBox.Show("Lütfen Bilglileri Doğru ve Düzgün Giriniz!");
            }
            Order order = new Order();
            order.TableID = Convert.ToInt32(lbltable.Text);
            order.CustomerID = Convert.ToInt32(lblcustomer.Text);
            creator = Convert.ToInt32(lblStaffid.Text);
            order.OrderTakerStaffID = creator;
            order.FoodStatusID = 1002;
            order.PaymentStatusID = 3;
            order.CreatorID = creator;
            OrderRepository op = new OrderRepository();
            op.Add(order);
            try
            {
                
            }
            catch 
            {
                MessageBox.Show("Hata!");
            }
        }

        private void cmbOrderTaker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                ArrayList alist = new ArrayList();
            foreach (var item in db.Staffs.Where(x => x.StaffTypeID == 3))
            {                
                alist.Add(item.StaffID.ToString());
            }
            int id = cmbOrderTaker.SelectedIndex;
            lblStaffid.Text = alist[id].ToString();
        }

        

        private void lstChooseCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region rez.customerıd
            string CustomerId = "";
            if (lstChooseCustomer.SelectedItems.Count > 0)
            {
                ListViewItem item = lstChooseCustomer.SelectedItems[0];
                CustomerId = item.SubItems[0].Text;
            }

            lblcustomer.Text = CustomerId;
            #endregion
        }

        private void lstChooseTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region rez.tableid
            string TableId = "";
            if (lstChooseTable.SelectedItems.Count > 0)
            {
                ListViewItem item = lstChooseTable.SelectedItems[0];
                TableId = item.SubItems[0].Text;
            }

            lbltable.Text = TableId;
            #endregion
        }
    }
}
