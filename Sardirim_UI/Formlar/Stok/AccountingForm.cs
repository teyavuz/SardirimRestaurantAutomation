using System;
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

namespace Sardirim_UI.Formlar.Stok
{
    public partial class AccountingForm : Form
    {
        public AccountingForm()
        {
            InitializeComponent();
        }

            SardirimRest_DBEntities db = new SardirimRest_DBEntities();
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Accounting aco = new Accounting();
            aco.SourceID = cmbSource.SelectedIndex;
            aco.Amount = Convert.ToDecimal(txtValue.Text);
            if (rdbGider.Checked == true)
            {
                aco.Factor = -1;
            }
            else if (rdbGelir.Checked == true)
            {
                aco.Factor = 1;
            }
            aco.Comment = rtxtComment.Text;
            aco.CreateDate = DateTime.Now;
            aco.CreatorID = 2;

            AccountingRepositoey accountingRepositoey = new AccountingRepositoey();
            accountingRepositoey.Add(aco);

            lstAccountingShow.Items.Clear();
            foreach (var item in db.Accountings)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = item.AccountigID.ToString();
                lst.SubItems.Add(item.SourceType.SourceComment);
                lst.SubItems.Add(item.SourceType.SourceName);
                lst.SubItems.Add(item.Amount.ToString());
                lst.SubItems.Add(item.Factor.ToString());
                lst.SubItems.Add(item.Comment);
                lstAccountingShow.Items.Add(lst);

            }


        }

        private void AccountingForm_Load(object sender, EventArgs e)
        {
            foreach (var item in db.SourceTypes)
            {
                cmbSource.Items.Add(item.SourceName);
            }
            
            foreach (var item in db.Accountings)
            {
            ListViewItem lst = new ListViewItem();
                lst.Text = item.AccountigID.ToString();
                lst.SubItems.Add(item.SourceType.SourceComment);
                lst.SubItems.Add(item.SourceType.SourceName);
                lst.SubItems.Add(item.Amount.ToString());
                lst.SubItems.Add(item.Factor.ToString());
                lst.SubItems.Add(item.Comment);
                lstAccountingShow.Items.Add(lst);
                
            }
        }

        private void rdbGelir_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGelir.Checked == true)
            {
                rdbGider.Checked = false;
                
            }
            else if(rdbGelir.Checked == false)
            {
                rdbGider.Checked = true;
            }
        }

        private void rdbGider_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGider.Checked == true)
            {
                rdbGelir.Checked = false;

            }
            else if (rdbGider.Checked == false)
            {
                rdbGelir.Checked = true;
            }
        }
    }
}
