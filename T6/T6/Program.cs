using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            Console.Write("Anna matka kilometreinä: ");
            matka = int.Parse(Console.ReadLine());
            double kulutus = matka / (100/7.02);
            double hinta = kulutus * 1.595;
            
            Console.Write("Bensan kulutus on: " + kulutus + " litraa " + "ja " + hinta + " euroa");
            Console.ReadLine();

        }
    }
}