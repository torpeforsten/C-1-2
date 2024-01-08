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
            int iLuku1, iLuku2;
            String sOperator;

            Console.WriteLine("Anna ensimmäinen kokonaisluku: ");
            iLuku1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna Toinen kokonaisluku: ");
            iLuku2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Minkä toiminnon haluat suorittaa? ( + , - , * , / )");
            sOperator = Console.ReadLine();

            switch (sOperator)

            {
                case "+":
                    Console.Write("{0}{1}{2} = {3} ", iLuku1, sOperator, iLuku2, (iLuku1 + iLuku2));
                    break;

                case "-":
                    Console.Write("{0}{1}{2} = {3} ", iLuku1, sOperator, iLuku2, (iLuku1 - iLuku2));
                    break;

                case "*":
                    Console.Write("{0}{1}{2} = {3} ", iLuku1, sOperator, iLuku2, (iLuku1 * iLuku2));
                    break;

                case "/":
                    if (iLuku2 == 0)
                    {
                        Console.WriteLine("Virhe, nollalla jako ");
                    }

                    Console.Write("{0}{1}{2} = {3} ", iLuku1, sOperator, iLuku2, (iLuku1 / iLuku2));
                    break;

                default:
                    Console.WriteLine("Virhe. Anna sallittu operaatio luvuille. ( + , - , * , / ");
                    break;
            }
        }
            
    }
}
