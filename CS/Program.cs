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
            Console.WriteLine("/*Напишите A,Av или*/ S/*(Add,Average и Shoв)*/");
            string selection = Console.ReadLine();
            Console.Beep();
            
            switch (selection)
            {

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
