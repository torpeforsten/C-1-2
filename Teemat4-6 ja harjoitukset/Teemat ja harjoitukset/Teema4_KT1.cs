using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teemat_ja_harjoitukset
{
    internal class Teema4_KT1
    {
        static void Main()
        {
            double[] doubleTaulukko = new double[3];
            int iLuku;
            double dKeskiarvo;

            for (iLuku = 0; iLuku < doubleTaulukko.Length; iLuku++)
            {
                Console.Write("Määritä taulukon arvot {0}: ",iLuku + 1);
                doubleTaulukko[iLuku] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Taulukon lukujen summa: {0}", doubleTaulukko.Sum());

            dKeskiarvo = doubleTaulukko.Sum()/iLuku;
            Console.WriteLine("Taulukon lukujen keskiarvo: {0}", dKeskiarvo);
        }
    }
}
