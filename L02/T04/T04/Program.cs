using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04
{
    class Program

    {

        static void Main(string[] args)

        {
            int[] arvosanat = { 0, 0, 0, 0, 0, 0 };
            int arvosana = -1;
            int x = 1;


            Console.WriteLine("Anna arvosanat. Syötä \"-1\" lopettaaksesi");


            do
            {
                Console.WriteLine("Opiskelija " + x + ": ");
                arvosana = int.Parse(Console.ReadLine());
                if (arvosana > -1)
                {
                    arvosanat[arvosana]++;
                }
                x++;
            } while (arvosana != -1);

            Console.WriteLine();
            Console.WriteLine("Arvosanajakauma:");
            for (int i = 0; i < arvosanat.Length; i++)
            {
                arvosana = arvosanat[i];
                Console.Write(i + ":");
                while (arvosana > 0)
                {
                    Console.Write("*");
                    arvosana--;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}