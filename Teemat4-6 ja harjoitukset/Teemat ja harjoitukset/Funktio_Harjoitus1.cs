using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teemat_ja_harjoitukset
{
    internal class Funktio_Harjoitus1
    {

        static string KysyNimi()
        {
            //string sNimi;
            //Console.Write("Anna nimi: ");
            //sNimi = Console.ReadLine();
            //return sNimi;

            //Nopeampi tapa
            Console.Write("Anna nimi: ");
            return Console.ReadLine();

        }
        static int KysyIka()
        {
            //int iVuosi;
            //string sIka;
            //Console.Write("Anna syntymävuosi: ");
            //iVuosi = int.Parse(Console.ReadLine());
            //sIka = iIka.ToString();
            //return iVuosi;

            //Nopeampi tapa
            Console.Write("Anna syntymävuosi: ");
            return int.Parse(Console.ReadLine());
        }
        static void Main()
        {
            string sNimi = KysyNimi();
            int iIka = KysyIka();

            Console.WriteLine("Olet {0}, olet {1}-vuotta vanha.", sNimi, 2022 - iIka);
        }
    }
}
