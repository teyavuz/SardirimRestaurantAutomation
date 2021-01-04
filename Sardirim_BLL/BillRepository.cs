using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sardirim_BLL;
using Sardirim_DAL;

namespace Sardirim_BLL
{
    public class BillRepository:IRepository<Bill>
    {
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();

        public void Add(Bill item)
        {
            db.Bills.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Bill GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bill> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Bill item)
        {
            throw new NotImplementedException();
        }
    }
}
