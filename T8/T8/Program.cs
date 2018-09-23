using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            Console.Write("Anna ensimmäinen luku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku: ");
            luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2 && luku1 > luku3)
            {
                Console.Write("Suurin luku on " + luku1);
            }
            else if (luku2 > luku1 && luku2 > luku3)
            {
                Console.Write("Suurin luku on " + luku2);
            }
            else if (luku3 > luku2 && luku3 > luku1)
            {
                Console.Write("Suurin luku on " + luku3);
            }
            Console.ReadLine();
        }
    }
}