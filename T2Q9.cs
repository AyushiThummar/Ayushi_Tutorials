using System;
namespace Ayushi_Tutorials
{
    class T2Q9
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 1, 4 }; // Example input
            int n = arr.Length;

            int xorAll = 0;

            // Step 1: XOR all elements
            for (int i = 0; i < n; i++)
            {
                xorAll ^= arr[i];
            }

            // Step 2: Find rightmost set bit
            int setBit = xorAll & ~(xorAll - 1);

            int x = 0, y = 0;

            // Step 3: Divide into two groups and XOR separately
            for (int i = 0; i < n; i++)
            {
                if ((arr[i] & setBit) != 0)
                    x ^= arr[i];
                else
                    y ^= arr[i];
            }

            Console.WriteLine("The two non-repeating numbers are: {0} {1}", x, y);
        }
    }
}