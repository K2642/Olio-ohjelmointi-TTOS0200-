using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05
{
    public class Human : Mammal
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public Human(string name, int height, int weight, int age) : base(age)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }

        public override void Move()
        {
            Console.WriteLine(Name + " says: I am moving!");
        }
        public void GrowUp()
        {
            Age++;
        }

        public override string ToString()
        {
            return "\n" + this.GetType().Name + ", " + Name + "\nAge: " + Age + "\nHeight: " + Height + "\nWeight: " + Weight;
        }

    }
}