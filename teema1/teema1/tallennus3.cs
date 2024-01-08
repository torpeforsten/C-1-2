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

            String etunimi = "Roope";
            String sukunimi = "Runnari";
            // KT4
            //Painoindeksin laskeminen
            double dpituus = 1.85;
            double dpaino = 133;
            //int.Parse(Console.ReadLine(), out);
            // Käytetään aikaisemman tehtävän string komentoa myös täällä
            Console.WriteLine(etunimi + " " + sukunimi);
            Console.WriteLine("pituuteni on " + dpituus + " m");
            Console.WriteLine("pituuteni on " + dpaino + " kg");
            // Float Komennolla muutetaan bmi kahden desimaalin tarkkuuteen
            float bmi = (float)(dpaino / Math.Pow(dpituus, 2));
            bmi = (float)System.Math.Round(bmi, 2);
            Console.WriteLine("Painoindeksi on siten " + bmi);
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
