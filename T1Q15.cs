using System;

namespace Ayushi_Tutorials
{
    internal class T1Q15
    {
        public static void Main(string[] args)
        {
            int rows = 4; // Number of rows in the triangle

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // Move to next line
            }
        }
    }
}
