using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02
{
    class pesukone
    {
        public bool Päällä { get; set; }
        public int Vedenlämpötila { get; set; }
        public int Linkous { get; set; }
        public bool Vedentulo { get; set; }

        public override string ToString()
        {
            return "Pesukoneen tila: " + Päällä + "\nVeden Lämpötila: " + Vedenlämpötila + "\nLinkous: " + Linkous + " Kierrosta/min" + "\n" + "Vedentulo: " + Vedentulo;

        }
    }
}