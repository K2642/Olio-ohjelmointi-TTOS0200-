using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CD cd = new CD("Guns N’ Roses", "Appetite for Destruction", "Rock", 25);

            Songs[] song = new Songs[12];
            song[0] = new Songs("Welcome to the Jungle", "4:32");
            song[1] = new Songs("It's So Easy", "3:21");
            song[2] = new Songs("Nightrain ", "04:26");
            song[3] = new Songs("Out Ta Get Me ", "04:20");
            song[4] = new Songs("Mr. Brownstone", "03:46");
            song[5] = new Songs("Paradise City", "06:46");
            song[6] = new Songs("My Michelle", "03:38");
            song[7] = new Songs("Think About You", "03.50");
            song[8] = new Songs("Sweet Child O' Mine", "05:55");
            song[9] = new Songs("You're Crazy", "03:25");
            song[10] = new Songs("Anything Goes", "03:25");
            song[11] = new Songs("Rocket Queen", "06:13");


            Console.WriteLine(cd.ToString());

            for (int i = 0; i < song.Length; i++)
            {
                song[i].Printdata();
            }

            Console.ReadLine();

        }
    }
}