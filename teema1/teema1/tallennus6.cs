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
            // KT1
            //Muuttujien harjoittelua
            double pii = Math.PI;
            string osoite = "Kärängänkatu 1 A2";
            string tunnus = "131200XXXXX";
            String kirjain = "R";
            double lämpö = 10.5;


            Console.WriteLine(pii);
            Console.WriteLine(osoite);
            Console.WriteLine(tunnus);
            Console.WriteLine(kirjain);
            Console.Write(lämpö + " Astetta celsiusta");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // KT2
            // String muuttujat
            String etunimi = "Roope";
            String sukunimi = "Runnari";
            Console.WriteLine("Nimeni on" + " " + etunimi + " " + sukunimi);
            Console.WriteLine();
            Console.WriteLine();

            // KT3
            // int muuttujat
            int num1 = 5;
            int num2 = 10;
            int summa = num2 + num1;
            int erotus = num2 - num1;
            int tulo = num2 * num1;

            Console.WriteLine("Summa:\t 10+5=" + summa);
            Console.WriteLine("Erotus:\t 10-5=" + erotus);
            Console.WriteLine("Tulo:\t 10*5=" + tulo);
            Console.WriteLine();
            Console.WriteLine();

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
