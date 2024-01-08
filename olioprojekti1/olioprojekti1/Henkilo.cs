using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioprojekti1
{
    internal class Henkilo
    {
        public int ika;
        public string etunimi;
        public string sukunimi;

        public Auto auto = new Auto();

        public void tulosta() 
        {
            Console.WriteLine(etunimi + " " + sukunimi + " " + ika);

            auto.tulosta();
        }
    }
}
