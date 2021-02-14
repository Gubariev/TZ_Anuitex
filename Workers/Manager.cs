using System;

namespace TZ_Anuitex.Workers
{
    class Manager : Employee
    {
        public Manager() : base()
        {
        }

        public Manager(string name, int exp) : base(name, exp)
        {
        }

        public void GivingTask()
        {
            Console.WriteLine("Giving Task");
        }

        public override void Work()
        {
            Console.WriteLine("Collecting orders");
            base.Work();
        }
    }
}
