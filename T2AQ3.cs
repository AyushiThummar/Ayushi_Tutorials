using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_Tutorials
{
    internal class T2AQ3
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter number of elements.");
            int n = Int32.Parse(Console.ReadLine());
            int[] a1 = new int[n];

            Console.WriteLine("Enter the elements : ");
            for(int i = 0; i < a1.Length; i++)
            {
                   a1[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Elements in reverse order : ");
            for(int i = a1.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a1[i]);
            }
        }
    }
}
