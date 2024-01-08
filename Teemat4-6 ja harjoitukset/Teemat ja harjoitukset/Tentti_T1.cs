using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teemat_ja_harjoitukset
{
    internal class Tentti_T1
    {
        static int LuoArvo1()
        { return int.Parse(Console.ReadLine()); }

        static int LuoArvo2()
            { return int.Parse(Console.ReadLine()); }

        /*Esittele Main:ssa kaksi kokonaislukumuuttujaa. Lue niihin käyttäjältä arvot LueArvot-funktiossa
 * (funktio ei saa palauttaa mitään).
 * Tulosta lukujen osamäärä kahden desimaalin tarkkuudella Tulosta-funktiossa.
 * HUOM! LueArvot-funktiosta ei saa suoraan kutsua Tulosta-funktiota. */

        static void Main()
        {
            int iArvo1 = LuoArvo1();
            int iArvo2 = LuoArvo2();
            
            Console.WriteLine("Esittele kaksi lukumuuttujaa: ");
            Console.WriteLine("Lukujen osamäärä: {0}", iArvo2 / iArvo1);


        }
    }
}
