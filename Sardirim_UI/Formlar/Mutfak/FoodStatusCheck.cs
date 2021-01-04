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
    public partial class FoodStatusCheck : Form
    {
        public FoodStatusCheck()
        {
            InitializeComponent();
        }
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();
        private void FoodStatusCheck_Load(object sender, EventArgs e)
        {
            IQueryable<Order> orders = db.Orders.Where(x => x.FoodStatusID < 5);


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

        private void button1_Click(object sender, EventArgs e)
        {
            //FormLoad olunca Food Status Hazır(ID->5) olmayanlar listelenecek. Button listeyi clear layıp tekrar sıralıyacak
        }

        

        private void lstFoodStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
