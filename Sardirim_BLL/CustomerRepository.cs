using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sardirim_DAL;


namespace Sardirim_BLL
{
    public class CustomerRepository : IRepository<Customer>
    {
        SardirimRest_DBEntities dB = new SardirimRest_DBEntities();


        public void Add(Customer item)
        {
            dB.Customers.Add(item);
            dB.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
