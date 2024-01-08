using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioprojekti1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Henkilo h;

            // Classissa pitää luoda new komennolla, jotta ohjelma toimii
            h = new Henkilo();
            h.etunimi = "Roope";
            h.sukunimi = "Forstén";
            h.ika = 21;

            //h.auto.Rekno = "NLO-677";
            //h.auto.Merkki = "Volvo";
            //h.auto.Malli = "v40";

            Auto a = new Auto();
            a.Rekno = "NLO-677";
            a.Merkki = "Volvo";
            a.Malli = "v40";
            h.auto = a;


            h.tulosta();
        }
    }
}
