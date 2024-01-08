using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rästitentti2T1
{
    internal class Program
    {
        static void LueArvot(out string osNimi, out int oiVuosi, out double odSaldo)
        {
            Console.WriteLine("Anna Nimi: ");
            osNimi = (Console.Read());

            Console.WriteLine("Anna syntymävuosi: ");
            oiVuosi = int.Parse(Console.Read());

            Console.WriteLine("Anna tilin saldo: ");
            odSaldo = double.Parse(Console.Read());
        }

        static void Tulosta(string asNimi, int aiVuosi, double adSaldo)
        {
            Console.WriteLine("Nimi: {0}", asNimi);
            Console.WriteLine("Syntymävuosi: {0}", aiVuosi);
            Console.WriteLine("Pankkitilin saldo: {0} euroa", adSaldo);

        }
        static void Main()
        {
            int iVuosi;
            string sNimi;
            double dSaldo;

            LueArvot(out sNimi, out iVuosi, out dSaldo);
            Tulosta(sNimi, iVuosi, dSaldo);
        }
    }
}
