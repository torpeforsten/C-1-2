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
            int iKuukausi;
            Console.Write("Ilmoita kuukauden numero\n");
            iKuukausi = int.Parse(Console.ReadLine());

            switch (iKuukausi)
            {
                case 1:
                    Console.WriteLine("Nyt on talvi");
                    break;
                case 2:
                    Console.WriteLine("Nyt on talvi");
                    break;
                case 3:
                    Console.WriteLine("Nyt on Kevät");
                    break;
                case 4:
                    Console.WriteLine("Nyt on Kevät");
                    break;
                case 5:
                    Console.WriteLine("Nyt on Kevät");
                    break;
                case 6:
                    Console.WriteLine("Nyt on Kesä");
                    break;
                case 7:
                    Console.WriteLine("Nyt on Kesä");
                    break;
                case 8:
                    Console.WriteLine("Nyt on Kesä");
                    break;
                case 9:
                    Console.WriteLine("Nyt on Syksy");
                    break;
                case 10:
                    Console.WriteLine("Nyt on Syksy");
                    break;
                case 11:
                    Console.WriteLine("Nyt on Syksy");
                    break;
                case 12:
                    Console.WriteLine("Nyt on Talvi");
                    break;
                default:
                    Console.WriteLine("Et vastannut väliltä 1-12");
                    break;
            }
        }
            
    }
}
