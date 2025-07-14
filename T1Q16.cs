using System;

namespace Ayushi_Tutorials
{
    internal class T1Q16
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int original = number;
            int result = 0;
            int count = number.ToString().Length; // Number of digits

            while (number > 0)
            {
                int digit = number % 10;
                result += (int)Math.Pow(digit, count);
                number /= 10;
            }

            if (result == original)
            {
                Console.WriteLine(original + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(original + " is NOT an Armstrong number.");
            }
        }
    }
}
