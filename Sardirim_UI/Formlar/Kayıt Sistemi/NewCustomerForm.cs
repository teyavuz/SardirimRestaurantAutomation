using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sardirim_UI;
using Sardirim_BLL;
using Sardirim_DAL;

namespace Sardirim_UI.Formlar.Kayıt_Sistemi
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }


        
        
        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheck.Checked == true)
            {
                btnSave.Enabled = true;
            }
        }

        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            chkCheck.Checked = false;
            btnSave.Enabled = false;
            try
            {
                Customer customer = new Customer();
                customer.CustomerName = txtCustomerName.Text;
                customer.CustomerSurname = txtCustomerSurname.Text;
                customer.CustomerPhone = txtCustomerPhone.Text;
                if (cmbCreator.SelectedIndex == 0)
                {
                    customer.CreatorID = 2;
                }
                else if (cmbCreator.SelectedIndex == 1)
                {
                    customer.CreatorID = 1;
                }
                customer.CreateDate = DateTime.Now;

                CustomerRepository customerRepository = new CustomerRepository();
                customerRepository.Add(customer);
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Oluştu.");

            }
            catch
            {
                MessageBox.Show("Bir sorun oluştu lütfen bilgileri doğru giriniz");
            }


            //Customers tablosuna girilen bilgiler kaydedilecek. Comboboxta 1. seçili ise CreatorID->1 2. seçili ise CreatorID->1002 girilecek CreateDate Date.Now girilecek.
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            chkCheck.Checked = false;
            btnSave.Enabled = false;

        }
    }
}
