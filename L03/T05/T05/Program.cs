using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05
{
    class Program
    {
        
            static void Main(string[] args)
            {

                Opiskelija[] opiskelija = new Opiskelija[5];
                opiskelija[0] = new Opiskelija("Matti", "Möttönen", "H8545", "TTV14S4");
                opiskelija[1] = new Opiskelija("Mikko", "Mallikas", "K7789", "TTV15S7");
                opiskelija[2] = new Opiskelija("Maija", "Virtanen", "H1234", "TTV16S2");
                opiskelija[3] = new Opiskelija("Juha", "Nieminen", "K2288", "TTV12S3");
                opiskelija[4] = new Opiskelija("Kimi", "Räikkönen", "H4569", "TTV16S1");


                for (int i = 0; i < opiskelija.Length; i++)
                {
                    opiskelija[i].Printdata();
                }

                Console.ReadLine();
                
  
            }
        }
    }
