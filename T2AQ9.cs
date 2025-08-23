using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_Tutorials
{
    internal class T2AQ9
    {
        public static void Main(String[] args)
        {
            int[] a1 = { 10, 50, 20, 5, 30, 1 };
            int n = a1.Length;
            Console.WriteLine("Array : ");
            for(int i = 0; i<n; i++)
            {
                Console.Write(a1[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Enter position to delete element.");
            int pos = Convert.ToInt32(Console.ReadLine());

            for(int i = pos-1; i<n-1; i++)
            {
                a1[i] = a1[i + 1];
            }
            n--;

            Console.WriteLine("Array after deletion : ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(a1[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
