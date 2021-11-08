using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee : IDomainObject
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }
        
        public int ID { get; set; }

        public override string ToString()
        {
            return ( Age + "  лет" + "  " + Name  + "  " + Salary + "  рублей");
        }

        public Employee(int _age, string _name, int _salary)
        {
            Age = _age;
            Name = _name;
            Salary = _salary;
        }
    }
}
