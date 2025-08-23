using System;

namespace Ayushi_Tutorials
{
    internal class T1Q14
    {
        public static void Main(string[] args)
        {
            Console.Write("INPUT : ");
            int no = Convert.ToInt32(Console.ReadLine());
            int digit;
            string output="";
            while (no > 0)
            {
                digit = no % 10;
                no = no / 10;
                string word = "";
                switch (digit)
                {
                    case 0: word = "Zero"; break;
                    case 1: word = "One"; break;
                    case 2: word = "Two"; break;
                    case 3: word = "Three"; break;
                    case 4: word = "Four"; break;
                    case 5: word = "Five"; break;
                    case 6: word = "Six"; break;
                    case 7: word = "Seven"; break;
                    case 8: word = "Eight"; break;
                    case 9: word = "Nine"; break;
                }

                output = word + " " + output;
            }

            Console.WriteLine("OUTPUT: " + output.Trim());
        }
    }
}
