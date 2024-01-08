using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teemat_ja_harjoitukset
{
    internal class Funktio_Harjoitus2
    {

        static void Tulosta_ika(int aiIka)
        {
            Console.WriteLine("Ikäsi on " + aiIka);
        }
        static void Main()
        {
            int iIka;
            Console.Write("Anna Ikäsi: ");
            iIka = int.Parse(Console.ReadLine());

            Tulosta_ika(iIka);
        }
    }
}
