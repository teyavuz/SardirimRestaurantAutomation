using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sardirim_DAL;

namespace Sardirim_BLL
{
    public class StaffRepository : IRepository<Staff>
    {
        SardirimRest_DBEntities dB = new SardirimRest_DBEntities();

        public void Add(Staff item)
        {
            dB.Staffs.Add(item);
            dB.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Staff GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Staff> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Staff item)
        {
            throw new NotImplementedException();
        }
    }
}
