using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DapperDataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {

        private DataContext _context = new DataContext();

        private EFRepository<Employee> _employees;


        public IRepository<Employee> Employees
        {
            get
            {
                return _employees ?? (_employees = new EFRepository<Employee>(_context));

            }
            set
            {

            }
        }

        public void Discard()
        {
            _context.Dispose();
            _context = new DataContext();
        }

        public bool SaveChanges()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
