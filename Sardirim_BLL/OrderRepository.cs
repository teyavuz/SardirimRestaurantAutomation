using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sardirim_DAL;

namespace Sardirim_BLL
{
    public class OrderRepository:IRepository<Order>
    {
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();

        public void Add(Order item)
        {
            db.Orders.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Order GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> SelectAll()
        {
            return db.Orders.ToList();
        }

        public void Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
