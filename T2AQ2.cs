using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_Tutorials
{
    internal class T2AQ2
    {
        public static void Main(String[] args)
        {
            int[] a1 = new int[5];
            Console.WriteLine("Enter any 5 numbers : ");
            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = Int32.Parse(Console.ReadLine());
            }
            // Sorting
            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = i + 1; j < a1.Length; j++)
                {
                    if (a1[i] > a1[j])
                    {
                        int temp = a1[i];
                        a1[i] = a1[j];
                        a1[j] = temp;
                    }
                }
            }
            // Displaying in ascending order.
            Console.WriteLine("The numbers in ascending order are :");
            foreach (int num in a1)
            {
                Console.WriteLine(num);
            }
        }
    }
}
