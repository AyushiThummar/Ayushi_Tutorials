using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_Tutorials
{
    internal class T2Q11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];
            int sum = 0;

            // Input elements
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i]; // add element to sum
            }

            // Print sum
            Console.WriteLine("Sum of the array elements: {0}", sum);
        }
    }
}
