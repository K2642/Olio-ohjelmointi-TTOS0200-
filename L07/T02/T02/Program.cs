using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Club HPK = new Club("HPK", "Hämeenlinna");
            HPK.AddPlayer("Tuulola", "Eetu", "RW", 'R');
            HPK.AddPlayer("Leino", "Robert", "C", 'R');
            HPK.AddPlayer("Nikkilä", "Petteri", "RD", 'R');
            HPK.AddPlayer("Nenonen", "Markus", "LW", 'R');
            HPK.AddPlayer("Paajanen", "Otto", "C", 'R');
            HPK.AddPlayer("Turunen", "Teemu", "RW", 'R');
            HPK.AddPlayer("Cornet", "Philippe", "RW", 'L');
            HPK.AddPlayer("Riska", "Filip", "C", 'L');
            HPK.AddPlayer("Innala", "Jere", "LW", 'L');
            HPK.AddPlayer("Friman", "Niklas", "LD", 'L');
            HPK.AddPlayer("Lindgren", "Jesper", "RD", 'L');
            HPK.AddPlayer("Ruokonen", "Miro", "LW", 'L');
            HPK.AddPlayer("Laatikainen", "Arto", "LD", 'L');
            HPK.AddPlayer("Laavainen", "Roope", "RD", 'L');
            HPK.AddPlayer("Puustinen", "Valtteri", "RW", 'L');
            HPK.AddPlayer("Karjalainen", "Miro", "RD", 'L');
            HPK.AddPlayer("Kainulainen", "Harri", "C", 'L');
            HPK.AddPlayer("Brejcak", "Jan", "LD", 'L');
            HPK.AddPlayer("Kuusisto", "Jaakko", "LW", 'L');
            HPK.AddPlayer("Lahti", "Janne", "LW", 'L');
            HPK.AddPlayer("Larmi", "Emil", "G", 'L');
            HPK.AddPlayer("Krivosik", "Filip", "RW", 'L');
            HPK.AddPlayer("Lehtinen", "Oskari", "LW", 'L');
            HPK.AddPlayer("Almari", "Niclas", "LD", 'L');
            HPK.AddPlayer("Niemeläinen", "Markus", "LD", 'L');
            HPK.AddPlayer("Karjalainen", "Antti", "G", 'L');
            HPK.AddPlayer("Seppälä", "Erkka", "C", 'L');
            Console.WriteLine(HPK.ToString());
        }
    }
}