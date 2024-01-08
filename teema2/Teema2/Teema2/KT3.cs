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
            int iLampotila;
            Console.WriteLine("Syötä mikä tahansa lämpötilan arvo");
            iLampotila = int.Parse(Console.ReadLine());

            if (iLampotila >= 39)
            {
                Console.WriteLine("Liian Kuuma");
            }
            else if (iLampotila >= 11)
            {
                Console.WriteLine("Lämmintä");
            }
            else if (iLampotila >= 0)
            {
                Console.WriteLine("Haaleaa");
            }
            else if (iLampotila >= -30)
            {
                Console.WriteLine("Pakkasta");
            }
            else if (iLampotila < -30)
            {
                Console.WriteLine("Liian Kylmää");
            }
        }
            
    }
}
