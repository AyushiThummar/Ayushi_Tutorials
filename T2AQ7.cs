using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_Tutorials
{
    internal class T2AQ7
    {
        public static void Main(String[] args)
        {
            int[] a1 = { 2, 5, 14, 20, 12, 10, 21, 25, 29, 30 };
            int[] even = new int[a1.Length];
            int[] odd = new int[a1.Length];

            int ec = 0, oc = 0;
            for(int i=0; i < a1.Length; i++)
            {
                if (a1[i] %2 == 0)
                {
                    even[ec] = a1[i];
                    ec++;
                }
                else
                {
                    odd[oc] = a1[i];
                    oc++;
                }
            }
            Console.WriteLine("Even Array :");
            for(int i = 0; i<ec; i++)
            {
                Console.Write(even[i]+ ",");
            }
            Console.WriteLine();
            Console.WriteLine("Odd Array : ");
            for(int i = 0; i<oc; i++)
            {
                Console.Write(odd[i]+ ",");
            }
            Console.WriteLine();
        }
    }
}
