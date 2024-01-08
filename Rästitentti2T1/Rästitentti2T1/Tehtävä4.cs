using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rästitentti2T1
{
    internal class Tehtävä4
    {
        /*
        static void LueMerkkejä(out string oiLueMerkki)
        {
            string sLuetut;
            Console.WriteLine("Syötä merkkejä(Enter nappi lopettaa)");

            oiLueMerkki= Console.ReadLine();
            
            oiLueMerkki = sLuetut=Console.ReadKey().ToString();

            sLuetut = sLuetut.ToUpper();
            Console.WriteLine(sLuetut);
        }
        */
        
        static void Main()
        {
            string sLuetut;
            string oiLueMerkki;
            Console.WriteLine("Syötä merkkejä(Enter nappi lopettaa)");

            oiLueMerkki = Console.ReadLine();

            oiLueMerkki = sLuetut = Console.ReadKey().ToString();

            sLuetut = sLuetut.ToUpper();
            Console.WriteLine(sLuetut);

        }
    }
}
