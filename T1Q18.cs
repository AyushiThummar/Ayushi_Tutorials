using System;

namespace Ayushi_Tutorials
{
    internal class T1Q18
    {
        public static void Main(string[] args)
        {
            int rows = 4; 
            int num = 1;  // Starting number

            for (int i = 1; i <= rows; i++)
            {
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
