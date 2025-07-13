using System;

namespace Ayushi_Tutorials
{
    internal class T1Q11
    {
        public static void Main(string[] args)
        {
            Console.Write("NAME   : ");
            string name = Console.ReadLine();

            Console.Write("GENDER (M/F): ");
            char gender = Char.ToUpper(Console.ReadKey().KeyChar); // Read single character and convert to uppercase
            Console.WriteLine(); // move to next line

            if (gender == 'M')
            {
                Console.WriteLine("OUTPUT : Mr. " + name);
            }
            else if (gender == 'F')
            {
                Console.WriteLine("OUTPUT : Ms. " + name);
            }
            else
            {
                Console.WriteLine("Invalid gender entered. Please enter only 'M' or 'F'.");
            }
        }
    }
}
