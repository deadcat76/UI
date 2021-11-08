using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccessLayer
{
    internal class DataContext : DbContext
    {

        public DbSet<Employee> Employee { get; set; }

        public DataContext() : base("Data Source = WIN-FTBQG5TIFFB\\SQLEXPRESS; Initial Catalog = tempdb; Integrated Security = True;")
        {

        }

    }
}
