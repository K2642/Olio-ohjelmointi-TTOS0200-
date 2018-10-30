using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Vehicle Fiesta = new Vehicle("Ford", "Fiesta");
            Fiesta.AddTyres(4, "Nokia", "Hakkapeliitta", 195, 65, 15);
            Console.WriteLine(Fiesta.ToString());

            Vehicle Lolvo = new Vehicle("Volvo", "XC70");
            Lolvo.AddTyres(4, "Nordman", "2", 225, 55, 18);
            Console.WriteLine(Lolvo.ToString());

            Vehicle Ducati = new Vehicle("Ducati", "Diavel");
            Ducati.AddTyre("MIC", "Pilot", 160, 55, 17);
            Ducati.AddTyre("MIC", "Pilot", 140, 55, 16);
            Console.WriteLine(Ducati.ToString());


        }
    }
}