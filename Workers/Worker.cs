using System;

namespace TZ_Anuitex.Workers
{
    public class Worker : Employee
    {
        public Worker() : base()
        {
        }

        public Worker(string name, int exp) : base(name, exp)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Products are being released");
            base.Work();
        }
    }
}
