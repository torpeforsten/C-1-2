using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teemat_ja_harjoitukset
{
    internal class Teema5_KT2
    {
        static int KysyKoko()
        {
            int.TryParse(Console.ReadLine(), out int iKoko);
            return iKoko;
        }
        static int[] LuoTaulukko()
        {
            int[] iTaulukko = new int[KysyKoko()];
            return iTaulukko;
        }
        static void ArvoArvosanat(int[] iTaulukko)
        {
            Random rnd = new Random();

            for (int i = 0; i < iTaulukko.Length; i++)
            {
                iTaulukko[i] = rnd.Next(6);
            }
        }
        static int TutkiHylätyt(int[] iTaulukko)
        {
            int iHylätyt = 0;

            foreach(int i in iTaulukko)
            {
                if (i == 0)
                {
                    iHylätyt++;
                }
            }
            return iHylätyt;

        }
        
        static void Tulosta(int iHylätyt)
        {
            Console.WriteLine(iHylätyt);
        }

        static void Main()
        {
            Console.Write("Määritä taulukon koko: ");
            int[] iTaulukko = LuoTaulukko();
            ArvoArvosanat(iTaulukko);
            int iHylätyt = TutkiHylätyt(iTaulukko);
            Tulosta(iHylätyt);
        }
    }
}
