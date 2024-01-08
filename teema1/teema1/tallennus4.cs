using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teema1
{
    internal class Program
    {
        static void Main()
        {
            double pii = Math.PI;
            // KT5
            // Käytetään piin likiarvoa aikasemmasta tehtävästä 6 desimaalin tarkkuudella

            double halkaisija, piiri, pinta_ala, säde;
            pii = (double)System.Math.Round(pii, 6);
            // Console.WriteLine(pii);

            // Convert funktio sisältäen ReadLine Funktion

            halkaisija = Convert.ToDouble(Console.ReadLine());
            säde = halkaisija / 2;
            piiri = pii * säde * 2;
            Console.WriteLine(piiri);
            pinta_ala = pii * Math.Pow(säde, 2);
            Console.WriteLine(pinta_ala);

        }
    }
}
