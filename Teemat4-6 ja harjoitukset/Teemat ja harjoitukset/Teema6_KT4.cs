using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teemat_ja_harjoitukset
{
    internal class Teema6_KT4
    {
        static void Main()
        {

            string file = "c:/temp/nimi.txt";

            StreamWriter sw = new StreamWriter(file);
            string sNimi;

            Console.Write("Anna nimesi (Mac. 18 merkkiä): ");
            sNimi = Console.ReadLine();
            
            while (sNimi.Length > 18)
            {
                Console.Write("Syötetty nimi on liian pitkä: ");
                sNimi = Console.ReadLine();
            }
            
            Console.WriteLine("");

            char[] cArray = sNimi.ToCharArray();
            Array.Reverse(cArray);

            int iPituus = cArray.Length -1;
            int iSijainti = Console.WindowWidth / 3;

            for (int i = 0; i < cArray.Length; i++)
            {
                if (i != cArray.Length -1)
                {
                    for (int j = iPituus * 3 - (i * 3) + 1; j > 1; j--) sw.Write(" ");
                }
                for (int k = iSijainti; k > 1; k--) sw.Write(" ");

                sw.WriteLine(cArray[i]);
            }
            sw.WriteLine("");

            sw.Close();

            StreamReader sr = new StreamReader(file);

            while (sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
