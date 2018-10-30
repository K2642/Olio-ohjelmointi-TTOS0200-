using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05
{

    public class Infant : Human
    {
        public string Diapers { get; set; }
        public Infant(string name, int height, int weight, int age, string diapers)
            : base(name, height, weight, age)
        {
            Diapers = diapers;
        }

        public override void Move()
        {
            Console.WriteLine(Name + " says: I am crawling!");
        }

        public override string ToString()
        {
            return base.ToString() + "\nDiapers: " + Diapers;
        }
    }
}