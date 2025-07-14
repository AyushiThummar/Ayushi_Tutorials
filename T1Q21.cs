using System;

namespace Ayushi_Tutorials
{
    internal class T1Q21
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the number of terms : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Input number : ");
            int digit = int.Parse(Console.ReadLine());

            int term = 0;
            int sum = 0;

            Console.Write("Series : ");
            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + digit; // Build the term like 5, 55, 555, ...
                Console.Write(term);
                if (i != n) Console.Write(" + ");
                sum += term;
            }

            Console.WriteLine("\nThe Sum is : " + sum);
        }
    }
}
