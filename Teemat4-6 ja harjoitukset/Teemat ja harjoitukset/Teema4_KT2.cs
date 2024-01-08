using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teemat_ja_harjoitukset
{
    internal class Teema4_KT2
    {
        static void Main()
        {
            Random rnd = new Random();
            int i;
            byte[] byteTaulukko = new byte[10];
            

            foreach (byte luku in byteTaulukko)
            {
                i = 2*rnd.Next(6);
                Console.Write("{0} \t", i);
            }
            Console.WriteLine();
        }
    }
}
