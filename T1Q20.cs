using System;

namespace Ayushi_Tutorials
{
    internal class T1Q20
    {
        public static void Main(string[] args)
        {
            int rows = 4; // Number of pyramid levels
            int num = 1;  // Starting number

            for (int i = 1; i <= rows; i++)
            {
                // Print leading spaces
                for (int space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }

                // Print numbers with space
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
}
