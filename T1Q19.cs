using System;

namespace Ayushi_Tutorials
{
    internal class T1Q19
    {
        public static void Main(string[] args)
        {
            int rows = 4; 

            for (int i = 1; i <= rows; i++)
            {
                // Print leading spaces
                for (int space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }

                // Print asterisks with space
                for (int star = 1; star <= i; star++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
