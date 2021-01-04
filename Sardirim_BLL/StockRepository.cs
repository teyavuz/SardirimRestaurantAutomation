using Sardirim_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sardirim_BLL
{
    public class StockRepository : IRepository<Stock>
    {
        SardirimRest_DBEntities dB = new SardirimRest_DBEntities();

        public void Add(Stock item)
        {
            dB.Stocks.Add(item);
            dB.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Stock GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Stock> SelectAll()
        {
            return dB.Stocks.ToList();
        }

        public void Update(Stock item)
        {
            Stock stock = dB.Stocks.Find(item.StockID);
            dB.Entry(stock).CurrentValues.SetValues(item);
            dB.SaveChanges();
        }
    }
}
