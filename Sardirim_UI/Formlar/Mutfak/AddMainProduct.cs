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

namespace Sardirim_UI.Formlar.Mutfak
{
    public partial class AddMainProduct : Form
    {
        public AddMainProduct()
        {
            InitializeComponent();
        }
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();

        private void btnAddMain_Click(object sender, EventArgs e)
        {
            try
            {
                cmbMainProductSelect.Items.Clear();
                MainProduct mp = new MainProduct();
                mp.MainProductName = txtMainName.Text;
                mp.MainProductPrice = Convert.ToDecimal(txtMainPriceMasked.Text);
                MainProductRepository mpr = new MainProductRepository();
                mpr.Add(mp);
                MessageBox.Show("Lütfen Yeni Kayıt Oluşturduğunuz Ürün İçin Gerekli İlk Stok Bilgilerini Giriniz.");

                foreach (var item in db.MainProducts)
                {
                    cmbMainProductSelect.Items.Add(item.MainProductName);
                }

            }
            catch
            {

                MessageBox.Show("Lütfen Bilgileri Doğru Giriniz!");
            }
        }

        private void radioGram_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGram.Checked == true)
            {
                radioPiece.Checked = false;
                txtMaskedGram.Enabled = true;
            }
            else if (radioGram.Checked == false)
            {
                radioPiece.Checked = true;
                txtMaskedGram.Enabled = false;
            }
        }

        private void radioPiece_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPiece.Checked == true)
            {
                radioGram.Checked = false;
                nmrPiece.Enabled = true;
            }
            else if (radioPiece.Checked == false)
            {
                radioGram.Checked = true;
                nmrPiece.Enabled = false;
            }
        }

        private void cmbMainProductSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList alist = new ArrayList();
            foreach (var item in db.MainProducts)
            {
                alist.Add(item.MainProductID);
            }
            int id;
            id = cmbMainProductSelect.SelectedIndex;
            lblid.Text = alist[id].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Stock stock = new Stock();
                stock.MainProductID = Convert.ToInt32(lblid.Text);
                if (radioGram.Checked == true)
                {
                    stock.UnitTypesID = 1;
                    stock.Value = Convert.ToDecimal(txtMaskedGram.Text);
                }
                else if (radioPiece.Checked == true)
                {
                    stock.UnitTypesID = 2;
                    stock.Value = Convert.ToDecimal(nmrPiece.Value);
                }
                StockRepository sr = new StockRepository();
                sr.Add(stock);
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Oluşturuldu.");
            }
            catch 
            {

                MessageBox.Show("Lütfen Bilgileri Doğru Giriniz!");
            }

        }

        private void AddMainProduct_Load(object sender, EventArgs e)
        {
            foreach (var item in db.MainProducts)
            {
                cmbMainProductSelect.Items.Add(item.MainProductName);
            }
        }
    }
}
