using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rästitentti2T1
{
    internal class Tehtävä2
    {

        // Koodissa en saanut doublea toimimaan...
        static void Main()
        {
            double[] dTaulu = new double[5];
            Random rnd = new Random();
            double iSumma = 0;
            double iKeskiarvo = 0;

            for (int d = 0; d < dTaulu.Length; d++)
            {
                dTaulu[d] = (rnd.NextDouble() * (4.7 - 1.5)) + 1.5;
                Console.WriteLine(dTaulu[d]);
                iSumma += dTaulu[d];
            }
            iKeskiarvo = iSumma / dTaulu.Length;
            Console.WriteLine("Summa on {0:f2} ja keskiarvo {1:f2}", iSumma, iKeskiarvo);
        }
    }
}
