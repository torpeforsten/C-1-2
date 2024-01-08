using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rästitentti2T1
{
    internal class Tehtävä3
    {
        static int arvosanat()
        {
            Console.Write("Kuinka monta arvosanaa haluat syöttää : ");
            int iArvosanat = int.Parse(Console.ReadLine());
            return iArvosanat;
        }

        static void LueArvot(int[] aiTaulu)
        {
            for (int i = 0; i < aiTaulu.Length; i++)
            {
                aiTaulu[i] = int.Parse(Console.ReadLine());

                if (aiTaulu[i] < 4)
                {
                    Console.WriteLine("Luku ei ollut välistä 4-10!");
                    i--;
                }
                else if (aiTaulu[i] > 10)
                {
                    Console.WriteLine("Luku ei ollut välistä 4-10!");
                    i--;
                }

            }
            Array.Sort(aiTaulu);

        }



        static void Main()
        {

            int iKoko = arvosanat();

            int[] iTaulu = new int[iKoko];

            LueArvot(iTaulu);
            Console.WriteLine("Arvosanoja arvttiin {0} kpl", iKoko);
            foreach (var item in iTaulu)
            {
                Console.WriteLine("Arvosana: {0}", item);
            }

            //LueArvotJaTulostaSumma();
        }
    }
}
