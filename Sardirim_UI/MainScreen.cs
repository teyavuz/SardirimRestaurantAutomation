using Sardirim_UI.Formlar.Kasa;
using Sardirim_UI.Formlar.Kayıt_Sistemi;
using Sardirim_UI.Formlar.Mutfak;
using Sardirim_UI.Formlar.Randevu;
using Sardirim_UI.Formlar.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sardirim_UI
{
    public partial class SardirimRestaurant : Form
    {
        public SardirimRestaurant()
        {
            InitializeComponent();
        }

        private void müşteriYeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomerForm ChildForm = new NewCustomerForm();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void SardirimRestaurant_Load(object sender, EventArgs e)
        {

        }

        private void çalışanYeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStaffForm ChildForm = new NewStaffForm();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        

        private void yemekDurumuSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodStatusCheck ChildForm = new FoodStatusCheck();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void ödemeEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentScreen ChildForm = new PaymentScreen();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void stokTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockTrack ChildForm = new StockTrack();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void stokGirdiÇıktıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gelirGiderTakibiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountingForm ChildForm = new AccountingForm();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void yemekDurumuGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodStatusUpdate ChildForm = new FoodStatusUpdate();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void randevuEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationForm ChildForm = new ReservationForm();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void siparişEkleöeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void yemekEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFood ChildForm = new AddFood();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void anaMalzemeEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMainProduct ChildForm = new AddMainProduct();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void siparişAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm ChildForm = new OrderForm();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }
    }
}
