using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sardirim_BLL;
using Sardirim_DAL;

namespace Sardirim_BLL
{
    public class OrderDetailRepository : IRepository<OrderDetail>
    {
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();
        public void Add(OrderDetail item)
        {
            db.OrderDetails.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetail GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderDetail item)
        {
            throw new NotImplementedException();
        }
    }
}
