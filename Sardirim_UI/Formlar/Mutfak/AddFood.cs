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
    public partial class AddFood : Form
    {
        public AddFood()
        {
            InitializeComponent();
        }
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                Product pd = new Product();
                pd.ProductName = txtFoodName.Text;
                pd.ProductPrice = Convert.ToDecimal(txtFoodPriceMasked.Text);
                ProductRepository pr = new ProductRepository();
                pr.Add(pd);
                MessageBox.Show("Lütfen Yeni Kayıt Oluşturduğunuz Ürün İçin Gerekli Ana Malzemeleri Giriniz.");
            }
            catch
            {
                MessageBox.Show("Lütfen Bilgileri Doğru Giriniz!");
            }
            cmbSelectFood.Items.Clear();
            foreach (var item in db.Products)
            {
                cmbSelectFood.Items.Add(item.ProductName);
            }
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Products)
            {
                cmbSelectFood.Items.Add(item.ProductName);
            }
            foreach (var item in db.MainProducts)
            {
                cmbChooseMain.Items.Add(item.MainProductName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MainProductDetail mpd = new MainProductDetail();
                mpd.ProductID = Convert.ToInt32(lblfoodid.Text);
                mpd.MainProductID = Convert.ToInt32(lblmainid.Text);
                if (radioGram.Checked == true)
                {
                    mpd.UnitTypeID = 1;
                    mpd.Value = Convert.ToDecimal(txtMaskedGram.Text);

                }
                else if (radioPiece.Checked == true)
                {
                    mpd.UnitTypeID = 2;
                    mpd.Value = Convert.ToDecimal(nmrPiece.Value);
                }
                MainProductDetailsRepository mpdr = new MainProductDetailsRepository();
                mpdr.Add(mpd);
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Oluşturuldu");
            }
            catch 
            {

                MessageBox.Show("Lütfen Bilglileri Eksiksiz ve Sorunsuz Bir Biçimde Giriniz.");
            }
        }

        private void cmbSelectFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList alist = new ArrayList();
            foreach (var item in db.Products)
            {
                alist.Add(item.ProductID.ToString());
            }
            int lblid = cmbSelectFood.SelectedIndex;
            lblfoodid.Text = alist[lblid].ToString();
        }

        private void radioGram_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGram.Checked == true)
            {
                radioPiece.Checked = false;
                txtMaskedGram.Enabled = true;
            }
            else if(radioGram.Checked == false)
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

        private void cmbChooseMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList alist = new ArrayList();
            foreach (var item in db.MainProducts)
            {
                alist.Add(item.MainProductID.ToString());
            }
            int lblid2 = cmbChooseMain.SelectedIndex;
            lblmainid.Text = alist[lblid2].ToString();
        }
    }
}
