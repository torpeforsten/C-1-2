using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teemat_ja_harjoitukset
{
    internal class Teema5_KT1
    {
        static int KysyJaTestaaLuku()
        {
            Console.Write("Määritä Luku 1 / -1 / 0 : ");
            return int.Parse(Console.ReadLine());
        }
        static void Main()
        {
            int iLuku = KysyJaTestaaLuku();
            
            switch (iLuku)
            {
                case 1:
                    Console.WriteLine("Luku oli positiivinen");
                    break;
                case 0:
                    Console.WriteLine("Luku oli nolla");
                    break;
                case -1:
                    Console.WriteLine("Luku oli negatiivinen");
                    break;
                default:
                    Console.WriteLine("Et syöttänyt oikeaa lukua");
                    break;
            }
        }
    }
}
