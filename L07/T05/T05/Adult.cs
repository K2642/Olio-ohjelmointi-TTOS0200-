using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05
{
    public class Adult : Human
    {
        public string Car { get; set; }

        public Adult(string name, int height, int weight, int age, string car)
            : base(name, height, weight, age)
        {
            Car = car;
        }

        public override void Move()
        {
            Console.WriteLine(Name + " says: I am walking!");
        }

        public override string ToString()
        {
            return base.ToString() + "\nCar: " + Car;
        }

    }
}