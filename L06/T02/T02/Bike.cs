using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02
{
    class Bike : Vehicle
    {
        public string Gear { get; set; }

        public string GearName { get; set; }


        public Bike(string name, string model, int year, string color, string gear, string gearname)
            : base(name, model, year, color)
        {
            Gear = gear;
            GearName = gearname;


        }
        public Bike()
        {

        }

        public override string ToString()
        {
            Console.WriteLine("Bike info");
            return base.ToString() + " Gear:" + Gear + " Gear Name:" + GearName;
        }

    }
}
