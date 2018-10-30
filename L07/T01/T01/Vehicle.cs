using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01
{
    public class Vehicle
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public List<Tyre> Tyres { get; set; }
        public Vehicle(string manu, string model)
        {
            Manufacturer = manu;
            Model = model;
            Tyres = new List<Tyre>();
            Console.WriteLine("Vehicle " + Manufacturer + " " + Model + " created.");
        }

        public void AddTyres(int quantity, string brand, string model, int width, int prof, int rad)
        {
            for (int i = 0; i < quantity; i++)
            {
                Tyres.Add(new Tyre(brand, model, width, prof, rad));
                Console.WriteLine("Tyre " + brand + " added to vehicle " + Manufacturer + " " + Model + ".");
            }
        }

        public void AddTyre(string brand, string model, int width, int prof, int rad)
        {
            Tyres.Add(new Tyre(brand, model, width, prof, rad));
            Console.WriteLine("Tyre " + brand + " added to vehicle " + Manufacturer + " " + Model + ".");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Tyre item in Tyres)
            {
                sb.Append(item.ToString());
            }

            return "\nVehicle name: " + Manufacturer + " " + Model + sb.ToString() + "\n\n";
        }
    }
}