using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teema2
{
    internal class Program
    {
        static void Main()
        {
            int iLuku;

            Console.WriteLine("Syötä luku 4-10 väliltä");
            iLuku = int.Parse(Console.ReadLine());

            if (iLuku == 10)
            {
                Console.WriteLine("Hyvä jos arvosana oli 9 tai 10");
            }

            else if (iLuku == 9)
            {
                Console.WriteLine("Hyvä jos arvosana oli 9 tai 10");
            }
            else if (iLuku == 8)

            {
                Console.WriteLine("Kelpo, jos 7 tai 8");
            }
            else if (iLuku == 7)
            {
                Console.WriteLine("Kelpo, jos 7 tai 8");
            }
            else if (iLuku == 6)
            {
                Console.WriteLine("Tyydyttävä, jos 5 tai 6");
            }
            else if (iLuku == 5)
            {
                Console.WriteLine("Tyydyttävä, jos 5 tai 6");
            }
            else if (iLuku == 4)
            {
                Console.WriteLine("Heikko, jos 4");
            }

            else Console.WriteLine("Et antanut arvosanaa annetulta väliltä");
        }
    }
}
