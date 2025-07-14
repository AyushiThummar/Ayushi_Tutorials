using System;

namespace Ayushi_Tutorials
{
    internal class T1Q17
    {
        public static void Main(string[] args)
        {
            // This program prints a right-angled triangle pattern with numbers
            int rows = 4; 

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine(); 
            }
        }
    }
}
