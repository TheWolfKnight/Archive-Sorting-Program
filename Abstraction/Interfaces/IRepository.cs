using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAllItems();

        T GetItemById(int id);
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        void DeleteById(int id);
    }
}
