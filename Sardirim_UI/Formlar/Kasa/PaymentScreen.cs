using Sardirim_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sardirim_DAL;
using System.Data.SqlClient;
using System.Collections;

namespace Sardirim_UI.Formlar.Kasa
{
    public partial class PaymentScreen : Form
    {

        private static int SelectedIndex { get; set; }
        public PaymentScreen()
        {
            InitializeComponent();
        }
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string OrderId = ""; 
            if (lstPaymenStatus.SelectedItems.Count > 0)
            {
                ListViewItem item = lstPaymenStatus.SelectedItems[0];
                OrderId = item.SubItems[0].Text;
            }
            else
            {
                MessageBox.Show("Seçim Yapınız");
                return;
            }
            if (String.IsNullOrEmpty(OrderId))
            {
                MessageBox.Show("Seçim Yapınız");
                return;
            }
            int intorder = Convert.ToInt32(OrderId);
            var myOrder = db.Orders.FirstOrDefault(x => x.OrderID == intorder);
            if (myOrder == null)
            {
                MessageBox.Show("Sipariş Bulunamadı.");
                return;
            }
            myOrder.PaymentStatusID = 2;
            db.SaveChanges();

            lstPaymenStatus.Items.Clear();
            IQueryable<Order> orders = db.Orders.Where(x => x.PaymentStatusID == 1);


            foreach (var order in orders)
            {

                ListViewItem lst = new ListViewItem();
                lst.Text = order.OrderID.ToString(); 
                lst.SubItems.Add(order.Table.TableName);
                lst.SubItems.Add(order.Customer.CustomerName);
                if (order.PaymentStatusID == 1)
                {
                    lst.SubItems.Add("Ödenmedi");
                }
                lst.SubItems.Add(order.Bills.Sum(x => x.BillAmount).ToString());
                lstPaymenStatus.Items.Add(lst);
            }

            checkBox1.Checked = false;
            button1.Enabled = false;
        }

        private void PaymentScreen_Load(object sender, EventArgs e)
        {
            SardirimRest_DBEntities db = new SardirimRest_DBEntities();

            IQueryable<Order> orders = db.Orders.Where(x => x.PaymentStatusID == 1 && x.PaymentStatusID != 3);
            

            foreach (var order in orders)
            {

                ListViewItem lst = new ListViewItem();
                lst.Text = order.OrderID.ToString();
                lst.SubItems.Add(order.Table.TableName);
                lst.SubItems.Add(order.Customer.CustomerName);
                if (order.PaymentStatusID == 1)
                {
                    lst.SubItems.Add("Ödenmedi");
                }
                lst.SubItems.Add(order.Bills.Sum(x => x.BillAmount).ToString());
                lstPaymenStatus.Items.Add(lst);
            }

        }

        private void lstPaymenStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
