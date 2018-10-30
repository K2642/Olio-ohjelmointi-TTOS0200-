using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Human Matti = new Human("Matti", 175, 70, 20);
            Console.WriteLine(Matti.ToString());
            Matti.Move();

            Adult Pekka = new Adult("Pekka", 160, 80, 30, "Toyota");
            Console.WriteLine(Pekka.ToString());
            Pekka.Move();

            Infant Veeti = new Infant("Veeti", 60, 10, 1, "Pampers");
            Console.WriteLine(Veeti.ToString());
            Veeti.Move();
        }
    }
}