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
            pesukone pesukone = new pesukone();

            pesukone.Päällä = true;
            pesukone.Vedenlämpötila = 60;
            pesukone.Vedentulo = true;
            pesukone.Linkous = 600;

            Console.WriteLine(pesukone.ToString());
            Console.ReadLine();

            pesukone.Päällä = false;
            pesukone.Vedenlämpötila = 20;
            pesukone.Vedentulo = false;
            pesukone.Linkous = 200;

            Console.WriteLine(pesukone.ToString());
            Console.ReadLine();
        }
    }
}
