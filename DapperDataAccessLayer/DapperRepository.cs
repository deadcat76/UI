using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
using Dapper;
using System.Data;
using System.Configuration;

namespace DapperDataAccessLayer
{
    public class DapperRepository
    {

        //string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        static string connectionString = "Data Source=WIN-FTBQG5TIFFB\\SQLEXPRESS; Initial Catalog= tempdb; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False";
        IDbConnection db = new SqlConnection(connectionString);

        public void Add(Employee t)
        {
            var sqlQuery = "INSERT INTO Employees (Name) VALUES(\'" + t.Name + "\'); SELECT CAST(SCOPE_IDENTITY() as int)";
            int employeeId = db.Query<int>(sqlQuery, t).FirstOrDefault();
            t.ID = employeeId;

        }

        public void Delete(int id)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                
                var sqlQuery = "DELETE FROM Employee WHERE Id - @id";
                db.Execute(sqlQuery, new {id});

            }
        }

        public IEnumerable<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                employees = db.Query<Employee>("SELECT * FROM Employee").ToList();
            }
            return (IEnumerable<Employee>)employees;
        }

        public Employee GetEmployee(int id)
        {
            Employee employee = null;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                employee = db.Query<Employee>("SELECT * FROM Employee WHERE Id - @id", new { id }).FirstOrDefault();
                
            }
            return employee;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Employee employee)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE Employee SET Name - @Name, Age - @Age, Salary - @Salary WHERE Id - @id";
                db.Execute(sqlQuery, employee);
               
            }
        }
    }
}
