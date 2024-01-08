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
            double dSade, dTulos;
            int iOperaattori;

            Console.Write("Anna ympyrän säde: ");
            dSade = double.Parse(Console.ReadLine());

            Console.WriteLine("Haluatko laskea ympyrän piirin, valitse 1." +
                "\nHaluatko laskea ympyrän pinta-alan, valitse 2.");
            iOperaattori = int.Parse(Console.ReadLine());

            if (iOperaattori == 1)
            {
                dTulos = 2 * Math.PI * dSade;
                Console.WriteLine("Ympyrän piiri on {0:f3}", dTulos);
            }
            else if (iOperaattori == 2)
            {
                dTulos = Math.PI * (dSade * dSade);
                Console.WriteLine("Ympyrän Pinta-ala on {0:f3}", dTulos);
            }
            else
            {
                Console.WriteLine("Et antanut valintaa oikein");
            }
        }
        
            
    }
}
