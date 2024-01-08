using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioprojekti2
{
    internal class Perhe
    {
        public Henkilo isä = new Henkilo();
        public Henkilo äiti = new Henkilo();
        public Henkilo[] lapset = new Henkilo[2];

        public void kysyTiedot()
        {
            isä.kysyTiedot();
            äiti.kysyTiedot();
            for (int i = 0; i < lapset.Length; i++)
            {
                lapset[i] = new Henkilo();
                lapset[i].kysyTiedot();
            }
        }
            public void tulostaTiedot()
            {
                Console.WriteLine("isä: ");
                isä.kysyTiedot();
                Console.WriteLine("Äiti: ");
                äiti.kysyTiedot();
                Console.WriteLine("Lapset: ");

                for (int i = 0; i < lapset.Length; i++)
                {
                    lapset[i].tulostaTiedot();
                }
            }
        
    }
}
