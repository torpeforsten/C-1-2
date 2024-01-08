using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioprojekti1
{
    internal class Auto
    {
        public string Rekno { get; set; }
        public string Merkki { get; set; }
        public string Malli { get; set; }

        public void tulosta()
        {
            Console.WriteLine(Rekno + " " + Merkki + " " + Malli);
        }
    }
}
