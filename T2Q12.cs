using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_Tutorials
{
    internal class T2Q12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];

            // Input array elements
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Input element to search
            Console.Write("Enter element to search: ");
            int key = Convert.ToInt32(Console.ReadLine());

            int found = 0; // 0 = not found, 1 = found

            // Search loop
            for (int i = 0; i < N; i++)
            {
                if (arr[i] == key)
                {
                    found = 1;
                    break;
                }
            }

            Console.WriteLine(found);
            Console.ReadLine();
        }
    }
}
