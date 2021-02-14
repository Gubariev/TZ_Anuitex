namespace TZ_Anuitex.Workers
{
    public class Employee
    {
        public string Name { get; set; }
        public int Experience { get; set; }

        public Employee()
        {
            Name = "--";
            Experience = 0;
        }

        public Employee(string name, int exp)
        {
            Name = name;
            Experience = exp;
        }

        public virtual void Work()
        {

        }
    }
}
