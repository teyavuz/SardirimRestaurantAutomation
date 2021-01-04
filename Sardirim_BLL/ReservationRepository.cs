using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sardirim_DAL;

namespace Sardirim_BLL
{
    public class ReservationRepository : IRepository<Reservation>
    {
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();

        public void Add(Reservation item)
        {
            db.Reservations.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Reservation GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Reservation item)
        {
            throw new NotImplementedException();
        }
    }
}
