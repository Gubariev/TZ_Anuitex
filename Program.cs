using System;
using System.Collections.Generic;
using TZ_Anuitex.Extensions;
using TZ_Anuitex.Workers;

namespace TZ_Anuitex
{
    class Program
    {
        static void Main(string[] args)
        {
            var Com = new Company();
            Com.WorkersList = new List<Employee>
            {
                new Worker {Name = "Gosha", Experience = 22},
                new Manager {Name = "Pasha", Experience = 22},
                new Foreman {Name = "Sasha", Experience = 22},
                new Worker {Name = "Dasha", Experience = 22},
            };
            var persone = new Manager("kolya", 21);
            Com += persone;


            Console.WriteLine("\nDoes this person '" + persone.Name + "' exists in EmployeeList? " + Com.WorkersList.IsExists(persone));

            Console.WriteLine("\nNumber of exact employees");
            Console.WriteLine(Com.WorkersList.GetNumbers<Manager>());//count of exact type of employees

            Console.WriteLine("\nList of exact employees");
            var TList = Com.WorkersList.GetEmployees<Manager>();// return a list of exact type of employees

            foreach (var item in TList)
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine("\nAll Employees ");
            Com.WorkersList.CwEmployees();

        }
    }
}
