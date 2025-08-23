using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_Tutorials
{
    internal class T2AQ4
    {
        public static void Main(String[] args)
        {
            int[] a1 = new int[5];
            int[] c1 = new int[5];
            Console.WriteLine("Enter any 5 numbers : ");
            for(int i = 0; i < a1.Length; i++)
            {
                a1[i] = Int32.Parse(Console.ReadLine());
            }
            // Copying elements from a1 to c1
            for(int i = 0; i < a1.Length; i++)
            {
                c1[i] = a1[i];
            }
            Console.WriteLine("Elements of c1 array : ");
            for(int i = 0; i < c1.Length; i++)
            {
                Console.WriteLine(c1[i]);
            }
        }
    }
}
