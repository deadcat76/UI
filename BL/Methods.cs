using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BL
{
    public class Methods
    {

        public List<Employee> employees = new List<Employee>() 
        {
            new Employee(18,"Николай", 25000),
            new Employee(20,"Егор", 18000),
            new Employee(15,"Никита", 21000),
            new Employee(35,"Антон", 40000)
        };

        public void Add(int age, string name, int salary)
        {
            employees.Add(new Employee(age, name, salary));
        }
        
        //public void Delete(int age, string name, int salary)
        //{
        //    List<Employee> employeesclone = employees;
        //    foreach (var eclone in employeesclone)
        //    {
        //        if ((age == eclone.Age)&&(name == eclone.Name))
        //        {
        //            employees.Remove(eclone);
        //        }
        //    }
        //}

        //public void Edit(int age, string name, int salary, string firstname)
        //{
        //    foreach (var e in employees)
        //    {
        //        if (firstname == e.Name)
        //        {
        //            e.Age = age;
        //            e.Salary = salary;
        //            e.Name = name;
        //        }
        //    }

        //}

        public int AverageSalary ()
        {
            int av_sa = 0;
            foreach (var s in employees)
            {
                av_sa += s.Salary;

            }
            av_sa = (av_sa / employees.Count);
            return av_sa;
        }
        public void ShowEmployees ()
        {
            foreach (var e in employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
