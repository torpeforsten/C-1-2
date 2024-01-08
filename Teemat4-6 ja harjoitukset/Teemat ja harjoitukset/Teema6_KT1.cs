using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teemat_ja_harjoitukset
{
    internal class Teema6_KT1
    {
        static void Main()
        {
            int i = 1;
            for (; i <= 10;)
            {
                Directory.CreateDirectory(@"c:\temp\Hakemisto1");
                if (Directory.Exists(@"c:\temp\Hakemisto1") == true)
                {
                    Directory.CreateDirectory(@"c:\temp\Hakemisto" + i++);
                }
            }
            string[] hakemistot = Directory.GetDirectories("c:\\temp\\");
            foreach (string dir in hakemistot)
                Console.WriteLine(dir);
                
            for (i = 0; i < 10; i++)
            {
                Directory.Delete(hakemistot[i]);
            }
        }
    }
}
