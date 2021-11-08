using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DapperDataAccessLayer
{
    internal class EFRepository<T> : IRepository<T> where T: class, IDomainObject, new()
    {

        private readonly DataContext _context;

        public EFRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(T obj)
        {
            _context.Set<T>().Add(obj); 
        }

        public void Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
