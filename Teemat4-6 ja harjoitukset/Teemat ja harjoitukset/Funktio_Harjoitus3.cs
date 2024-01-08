using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teemat_ja_harjoitukset
{
    internal class Funktio_Harjoitus3
    {
        static int Kokonaisluku1()
        {
            Console.WriteLine("Syötä ekaluku");
            return int.Parse(Console.ReadLine());
        }
        static int Kokonaisluku2()
        {
            Console.WriteLine("Syötä tokaluku");
            return int.Parse(Console.ReadLine());
        }
        static void Main()
        {
            int iEkaluku = Kokonaisluku1();
            int iTokaluku = Kokonaisluku2();
            Console.WriteLine("Lukujen summa on {0}", iEkaluku + iTokaluku);
        }
    }
}
