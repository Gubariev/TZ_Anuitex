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
            foreach (var item in Com.WorkersList)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(Com.WorkersList.IsExists(persone));
            var c = Com.WorkersList.GetEmployees();
            Console.WriteLine(c.GetNumbers());            
            c.WriteEmployees();
        }
    }
}
