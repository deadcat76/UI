using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IRepository<T> where T : class, new()
    {
        IEnumerable<T> GetAll();

        Employee GetEmployee(int id);

        void Add(T obj);

        void Update(T item);

        void Delete(T obj);

        void Save();

    }
}
