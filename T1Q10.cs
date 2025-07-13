using System;

namespace Ayushi_Tutorials
{
    internal class T1Q10
    {
        public static void Main(string[] args)
        {
            Console.Write("INPUT : ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string firstPart = mobile.Substring(0, mobile.Length - 5);
                string maskedPart = new string('X', 5);
                string result = firstPart + maskedPart;

                Console.WriteLine("OUTPUT: " + result);
            }
            else
            {
                Console.WriteLine("Invalid mobile number. It must have at least 5 digits.");
            }
        }
    }
}
