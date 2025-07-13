using System;

namespace Ayushi_Tutorials
{
    internal class T1Q9
    {
        // Regular method to toggle case
        public static string ToToggle(string input)
        {
            string result = "";
            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                    result += char.ToLower(ch);
                else if (char.IsLower(ch))
                    result += char.ToUpper(ch);
                else
                    result += ch;
            }
            return result;
        }
        public static void Main(string[] args)
        {
            string str1, str2;
            Console.Write("INPUT : ");
            str1 = Console.ReadLine();
            str2 = ToToggle(str1); // calling the regular method
            Console.Write("OUTPUT : " + str2);
        }
    }
}
