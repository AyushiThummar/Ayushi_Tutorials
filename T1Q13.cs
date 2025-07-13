using System;

namespace Ayushi_Tutorials
{
    internal class T1Q13
    {
        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3;
            int terms = 11; // Number of terms to print

            Console.Write("Fibonacci Series: ");
            Console.Write(n1 + " " + n2 + " ");

            for (int i = 3; i <= terms; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
