using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sardirim_DAL;

namespace Sardirim_BLL
{
    public class ProductRepository:IRepository<Product>
    {
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();

        public void Add(Product item)
        {
            db.Products.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
