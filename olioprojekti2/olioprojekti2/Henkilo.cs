using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioprojekti2
{
    internal class Henkilo
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }

        public void kysyTiedot()
        {
            Console.Write("Anna etunimi: ");
            Etunimi = Console.ReadLine();
            Console.Write("Anna sukunimi: ");
            Sukunimi = Console.ReadLine();
        }

        public void tulostaTiedot()
        {
            Console.WriteLine(Etunimi + " " + Sukunimi);
        }
    }
}
