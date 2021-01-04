using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sardirim_DAL;

namespace Sardirim_BLL
{
    public class AccountingRepositoey:IRepository<Accounting>
    {
        SardirimRest_DBEntities dB = new SardirimRest_DBEntities();

        public void Add(Accounting item)
        {
            dB.Accountings.Add(item);
            dB.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Accounting GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Accounting> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Accounting item)
        {
            throw new NotImplementedException();
        }
    }
}
