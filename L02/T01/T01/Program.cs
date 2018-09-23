using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Anna luku: ");
            luku = int.Parse(Console.ReadLine());


            for (int i = 1; i <= luku; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
