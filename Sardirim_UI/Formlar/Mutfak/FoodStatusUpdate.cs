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

namespace Sardirim_UI.Formlar.Mutfak
{
    public partial class FoodStatusUpdate : Form
    {
        public FoodStatusUpdate()
        {
            InitializeComponent();
        }
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            string OrderId = "";
            if (lstFoodStatuesCheck.SelectedItems.Count > 0)
            {
                ListViewItem item = lstFoodStatuesCheck.SelectedItems[0];
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
            if (cmbFoodStatesUpdate.SelectedIndex == 0)
            {
                myOrder.FoodStatusID = 1;
            }
            else if (cmbFoodStatesUpdate.SelectedIndex == 1)
            {
                myOrder.FoodStatusID = 2;
            }
            else if (cmbFoodStatesUpdate.SelectedIndex == 2)
            {
                myOrder.FoodStatusID = 3;
            }
            else if (cmbFoodStatesUpdate.SelectedIndex == 3)
            {
                myOrder.FoodStatusID = 4;
            }
            else if (cmbFoodStatesUpdate.SelectedIndex == 4)
            {
                myOrder.FoodStatusID = 5;
            }
            db.SaveChanges();

            lstFoodStatuesCheck.Items.Clear();
            IQueryable<Order> orders = db.Orders.Where(x => x.FoodStatusID != 5);


            foreach (var order in orders)
            {

                ListViewItem lst = new ListViewItem();
                lst.Text = order.OrderID.ToString();
                lst.SubItems.Add(order.Table.TableName);
                lst.SubItems.Add(order.Customer.CustomerName);
                lst.SubItems.Add(order.Staff.StaffName + " " + order.Staff.StaffSurname);
                if (order.FoodStatusID == 1)
                {
                    lst.SubItems.Add("Sipariş Alındı");
                }
                else if (order.FoodStatusID == 2)
                {
                    lst.SubItems.Add("Hazırlanıyor");
                }
                else if (order.FoodStatusID == 3)
                {
                    lst.SubItems.Add("Pişiyor");
                }
                else if (order.FoodStatusID == 4)
                {
                    lst.SubItems.Add("Servis Bekliyor");
                }
                else if (order.FoodStatusID == 5)
                {
                    lst.SubItems.Add("Hazır!");
                }
                lst.SubItems.Add(order.Bills.Sum(x => x.BillAmount).ToString());
                lstFoodStatuesCheck.Items.Add(lst);
            }
        }
        
        private void FoodStatusUpdate_Load(object sender, EventArgs e)
        {
            IQueryable<Order> orders = db.Orders.Where(x => x.FoodStatusID < 5);


            foreach (var order in orders)
            {

                ListViewItem lst = new ListViewItem();
                lst.Text = order.OrderID.ToString(); 
                lst.SubItems.Add(order.Table.TableName);
                lst.SubItems.Add(order.Customer.CustomerName);
                lst.SubItems.Add(order.Staff.StaffName + " " + order.Staff.StaffSurname);
                if (order.FoodStatusID==1)
                {
                    lst.SubItems.Add("Sipariş Alındı");
                }
                else if (order.FoodStatusID == 2)
                {
                    lst.SubItems.Add("Hazırlanıyor");
                }
                else if (order.FoodStatusID == 3)
                {
                    lst.SubItems.Add("Pişiyor");
                }
                else if (order.FoodStatusID == 4)
                {
                    lst.SubItems.Add("Servis Bekliyor");
                }
                else if (order.FoodStatusID == 5)
                {
                    lst.SubItems.Add("Hazır!");
                }
                lst.SubItems.Add(order.Bills.Sum(x => x.BillAmount).ToString());
                lstFoodStatuesCheck.Items.Add(lst);
            }
        }

        private void lstFoodStatuesCheck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
