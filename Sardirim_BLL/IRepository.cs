using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sardirim_BLL
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Update(T item);
        void Delete(int id);
        List<T> SelectAll();
        T GetByID(int id);
    }
}
