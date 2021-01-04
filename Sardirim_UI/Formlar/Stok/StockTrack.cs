using Sardirim_BLL;
using Sardirim_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sardirim_UI.Formlar.Stok
{
    public partial class StockTrack : Form
    {
        public StockTrack()
        {
            InitializeComponent();
        }
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();
        
        private void StockTrack_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Stocks)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = item.StockID.ToString(); ;
                lst.SubItems.Add(item.MainProduct.MainProductName);
                lst.SubItems.Add(item.UnitType.TypeVal);
                lst.SubItems.Add(item.Value.ToString());
                listView1.Items.Add(lst);
            }
        }
        
        
        
    }
}
