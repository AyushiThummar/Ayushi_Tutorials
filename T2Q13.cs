using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_Tutorials
{
    internal class T2Q13
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] count = new int[notes.Length];

            int remaining = amount;

            for (int i = 0; i < notes.Length; i++)
            {
                count[i] = remaining / notes[i]; // number of notes of this denomination
                remaining = remaining % notes[i]; // remaining amount
            }

            // Print result
            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine("Notes of Rs.{0} = {1}", notes[i], count[i]);
            }

            Console.ReadLine();
        }
    }
}
