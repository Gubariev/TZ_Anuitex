using System;
using System.Collections.Generic;
using System.Linq;
using TZ_Anuitex.Workers;

namespace TZ_Anuitex.Extensions
{
    public static class LINQExtesions
    {

        public static bool IsExists<T>(this IEnumerable<T> ListEmpl, Employee Emp) where T : Employee
        {
            return ListEmpl.Contains(Emp);
        }

        public static IEnumerable<T> GetEmployees<T>(this IEnumerable<T> ListEmpl) where T : Employee
        {
            return ListEmpl;
        }

        public static int GetNumbers<T>(this IEnumerable<T> ListEmpl) where T : Employee
        {
            return ListEmpl.Count();
        }


        public static void WriteEmployees<T>(this IEnumerable<T> ListEmpl) where T : Employee
        {
            foreach (var item in ListEmpl)
            {
                Console.WriteLine(item.Name + " " + item.Experience);
            }
        }
    }
}
