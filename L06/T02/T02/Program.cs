using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02
{
    class Program
    {
        static void Main(string[] args)
        {

            Bike bike = new Bike();

            bike.Name = "Jopo";
            bike.Model = "Street";
            bike.Year = 2016;
            bike.Color = "Blue";
            bike.Gear = "False";
            bike.GearName = "";

            Console.WriteLine(bike.ToString());
            Console.ReadLine();

            Bike bike1 = new Bike();

            bike1.Name = "Tunturi";
            bike1.Model = "Street";
            bike1.Year = 2010;
            bike1.Color = "Black";
            bike1.Gear = "True";
            bike1.GearName = "Shimano";

            Console.WriteLine(bike1.ToString());
            Console.ReadLine();


            Boat boat = new Boat();

            boat.Name = "Suvi";
            boat.Model = "S900";
            boat.Year = 1990;
            boat.Color = "White";
            boat.Type = "Rowboat";
            boat.Seats = 3;

            Console.WriteLine(boat.ToString());
            Console.ReadLine();

            Boat boat1 = new Boat();

            boat1.Name = "Yamaha";
            boat1.Model = "Model 1000";
            boat1.Year = 2010;
            boat1.Color = "Yellow";
            boat1.Type = "Motorboat";
            boat1.Seats = 5;

            Console.WriteLine(boat1.ToString());
            Console.ReadLine();





        }
    }
}