using System.Collections.Generic;
using TZ_Anuitex.Workers;

namespace TZ_Anuitex
{
    public class Company
    {
        public List<Employee> WorkersList { get; set; }

        public static Company operator +(Company company, Employee worker)
        {
            company.WorkersList.Add(worker);
            return company;
        }
        public static Company operator -(Company company, Employee worker)
        {
            company.WorkersList.Remove(worker);
            return company;
        }



    }
}
