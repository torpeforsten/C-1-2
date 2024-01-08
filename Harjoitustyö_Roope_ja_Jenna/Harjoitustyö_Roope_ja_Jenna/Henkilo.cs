using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustyö_Roope_ja_Jenna
{
    internal class Henkilo
    {
        /*
         * "Henkilo" Class tehtiin säästääkseen koodia yhdellä formilla.
         */

        //  Henkilötiedot
        public string Etunimet { get; set; }
        public string Sukunimi { get; set; }
        public string Kutsumanimi { get; set; }
        public string Hetu { get; set; }
        //  Osoitetiedot
        public string Katuosoite { get; set; }
        public string PostiNro { get; set; }
        public string PostiPaikka { get; set; }
        //  Työsuhteen tiedot
        public DateTime Alkaminen { get; set; }
        public DateTime Paattyminen { get; set; }
        public string Nimike { get; set; }
        public string Yksikko { get; set; }
    }
}
