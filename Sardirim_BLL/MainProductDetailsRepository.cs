using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sardirim_DAL;

namespace Sardirim_BLL
{
    public class MainProductDetailsRepository : IRepository<MainProductDetail>
    {
        SardirimRest_DBEntities db = new SardirimRest_DBEntities();

        public void Add(MainProductDetail item)
        {
            db.MainProductDetails.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public MainProductDetail GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MainProductDetail> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(MainProductDetail item)
        {
            throw new NotImplementedException();
        }
    }
}
