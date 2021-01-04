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
using Sardirim_BLL;
using Sardirim_DAL;


namespace Sardirim_UI.Formlar.Randevu
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();
        private void OrderForm_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Orders.Where(x => x.FoodStatusID == 1002))
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = item.OrderID.ToString();
                lst.SubItems.Add(item.Customer.CustomerName + " " + item.Customer.CustomerSurname);
                lst.SubItems.Add(item.Table.TableID.ToString() + " - " + item.Table.TableName);
                lstChooseRes.Items.Add(lst);
            }
            foreach (var item in db.Products)
            {
                comboBox1.Items.Add(item.ProductName);
            }
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int Qid = Convert.ToInt32(lblOrderID.Text);
            var myOrder = db.Orders.FirstOrDefault(x => x.OrderID == Qid);
            myOrder.PaymentStatusID = 1;
            myOrder.FoodStatusID = 1;
            db.SaveChanges();

            //////////////////////////////////////////////////////////////////////
            OrderDetail od = new OrderDetail();
            int productid = Convert.ToInt32(lblpid.Text);
            var myProduct = db.Products.FirstOrDefault(x => x.ProductID == productid);
            od.OrderID = Qid;
            od.ProductID = Convert.ToInt32(lblpid.Text);
            decimal price = Convert.ToDecimal(myProduct.ProductPrice * numericUpDown1.Value);
            od.Price = price;
            OrderDetailRepository odr = new OrderDetailRepository();
            odr.Add(od);


            Bill bill = new Bill();
            bill.CustomerID = myOrder.CustomerID;
            bill.OrderID = myOrder.OrderID;
            bill.BillAmount = price;
            bill.CreatorID = myOrder.CreatorID;
            BillRepository br = new BillRepository();
            br.Add(bill);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList alist = new ArrayList();
            foreach (var item in db.Products)
            {
                alist.Add(item.ProductID);
            }
            int id;
            id = comboBox1.SelectedIndex;
            lblpid.Text = alist[id].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string OrderId = "";
            if (lstChooseRes.SelectedItems.Count > 0)
            {
                ListViewItem item = lstChooseRes.SelectedItems[0];
                OrderId = item.SubItems[0].Text;
            }
            lblOrderID.Text = OrderId;
            groupBox1.Visible = true;
        }
    }
}
