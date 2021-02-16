using System;
using System.Collections;
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

        public static IEnumerable<T> GetEmployees<T>(this IEnumerable ListEmpl) where T : Employee
        {
            var TList = new List<T>();
            foreach (var item in ListEmpl)
            {
                if (item.GetType() == typeof(T))
                {
                    TList.Add((T)item);
                }
            }
            return TList;
        }

        public static int GetNumbers<T>(this IEnumerable ListEmpl)
        {
            int count = 0;
            foreach (var item in ListEmpl)
            {
                if (item.GetType()==typeof(T))
                {
                    count++;
                }
            }
            return count;
        }


        public static void CwEmployees<T>(this IEnumerable<T> ListEmpl) where T : Employee
        {
            foreach (var item in ListEmpl)
            {
                Console.WriteLine(item.Name + " " + item.Experience);
            }
        }
    }
}
