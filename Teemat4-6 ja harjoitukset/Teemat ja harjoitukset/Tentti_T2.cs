using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teemat_ja_harjoitukset
{
    internal class Tentti_T2
    {
        static void Main()
        {
            /*Lue käyttäjältä teksti string tyyppiseen muuttujaan. Muuta koko teksti pieniksi kirjaimiksi.
             * Tulosta allekkain joka toinen kirjain alkaen ensimmäisestä. Esimerkiksi jos alkuperäinen teksti oli "TiiSTaI",
             * niin se muutetaan "tiistai" ja tulostetaan */

            

            Console.Write("Syötä jotakin tekstiä: ");
            String sTeksti = Console.ReadLine();

            string alennettu = sTeksti.ToLower();
            //Debuggaus
            //Console.WriteLine(alennettu);
            // Joka toisen kirjaimen laskuri
            var jokatoinen = string.Empty;
            for (var i = 0; i < sTeksti.Length; i++)
            {
                if (i % 2 == 0) jokatoinen += sTeksti[i];
            }
            // Taulukkoon siirtäminen
            char[] cArray = jokatoinen.ToCharArray();

            for (int i = 0; i < cArray.Length; i++)
            {

                Console.WriteLine(cArray[i]);
            }
        }
    }
}
