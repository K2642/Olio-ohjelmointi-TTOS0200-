using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05
{
    class Opiskelija
    {
        public string EtuNimi {get; set; }

        public string SukuNimi { get; set; }

        public string OpiskelijaNumero { get; set; }

        public string LuokkaTunnus { get; set; }

        public void Printdata()
        {
            Console.WriteLine(" Opiskelijan tiedot  ");
            Console.WriteLine(" Etunimi : " + EtuNimi);
            Console.WriteLine(" Sukunimi : " + SukuNimi);
            Console.WriteLine(" Opiskelijanumero : " + OpiskelijaNumero);
            Console.WriteLine(" Luokkatunnus : " + LuokkaTunnus);
            Console.WriteLine();
                        
        }


        
        public Opiskelija(string etunimi, string sukunimi, string opiskelijanumero, string luokkatunnus)
        {
            EtuNimi = etunimi;
            SukuNimi = sukunimi;
            OpiskelijaNumero = opiskelijanumero;
            LuokkaTunnus = luokkatunnus;
        }

    }
}