using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number > ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Number is " + number);
            // or
            Console.WriteLine("Number is {0}", number);

        }
    }
}
