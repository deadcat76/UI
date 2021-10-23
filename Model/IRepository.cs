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

        T GetEmployee(int id);

        void Create(T item);

        void Update(T item);

        void Delete(int id);

        void Save();

    }
}
