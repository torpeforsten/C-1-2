using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioprojekti2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perhe p = new Perhe();

            p.kysyTiedot();
            p.tulostaTiedot();
        }
    }
}
