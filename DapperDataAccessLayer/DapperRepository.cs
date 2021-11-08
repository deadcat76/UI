using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
using Dapper;
using System.Data;

namespace DapperDataAccessLayer
{
    public class DapperRepository<T> : IRepository<T> where T : class, IDomainObject, new()
    {

        // string connectionString =  ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbConnection;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        IDbConnection db = new SqlConnection(connectionString);

        public void Create(T t)
        {
            var sqlQuery = "INSERT INTO Employees (Name) VALUES(@Name); SELECT CAST(SCOPE_IDENTITY() as int)";
            int employeeId = db.Query<int>(sqlQuery, t).FirstOrDefault();
            t.ID = employeeId;

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return db.Query<T>("SELECT * FROM Employees").ToList(); ;
        }

        public T GetEmployee(int id)
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
