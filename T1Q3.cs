using System;

namespace Ayushi_Tutorials
{
    internal class T1Q3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any number to check whether it is even or odd :");
            int n = Convert.ToInt32(Console.ReadLine());    
            if (n % 2 == 0)
            {
                Console.WriteLine("The number " + n + " is even.");
            }
            else
            {
                Console.WriteLine("The number " + n + " is odd.");
            }
        }
    }
}
