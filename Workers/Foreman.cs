using System;

namespace TZ_Anuitex.Workers
{
    public class Foreman : Employee
    {
        public Foreman() : base()
        {
        }

        public Foreman(string name, int exp) : base(name, exp)
        {
        }

        public void WorkersCheck()
        {
            Console.WriteLine("Workers are being checked");
        }

        public override void Work()
        {
            Console.WriteLine("Materials are being purchased");
            base.Work();
        }

    }
}
