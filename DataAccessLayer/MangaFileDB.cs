using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.Interfaces;

namespace DataAccessLayer
{
    public class MangaFileDB : IDataGetter<string>
    {
        public void Add(string item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string item)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public string GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(string item)
        {
            throw new NotImplementedException();
        }
    }
}
