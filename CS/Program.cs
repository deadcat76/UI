using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using Model;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            Console.WriteLine("/*Напишите A,Av или*/ S/*(Add,Average и Show)*/");
            string selection = Console.ReadLine();
            Console.Beep();
            
            switch (selection)
            {
                //case "A":
                //    Console.Write("Введите возраст - ");
                //    int age = Convert.ToInt32(Console.ReadLine());
                //    Console.Write("Введите имя - ");
                //    string name = Console.ReadLine();
                //    Console.Write("Введите зарплату - ");
                //    int salary = Convert.ToInt32(Console.ReadLine());
                //    methods.employees.Add(new Employee(age,name,salary));
                //    break;

                //case "Av":
                //    Console.WriteLine(methods.AverageSalary());
                //    break;

                case "S":
                    methods.ShowEmployees();
                    break;
                default:

                    Console.WriteLine("Вы ввели неверную букву");
                    break;
                    
            }
            Console.ReadKey();
        }
    }
}
