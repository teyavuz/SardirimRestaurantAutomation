using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sardirim_DAL;

namespace Sardirim_BLL
{
    public class MainProductRepository: IRepository<MainProduct>
    {
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();

        public void Add(MainProduct item)
        {
            db.MainProducts.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public MainProduct GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MainProduct> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(MainProduct item)
        {
            throw new NotImplementedException();
        }
    }
}
