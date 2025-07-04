using System;   // Importing the System namespace.
namespace Ayushi_Tutorials      // Defining a namespace for the program.
{
    internal class T1Q5     // Defining a class named T1Q5.
    {
        static void Main(string[] args)     // Main method, the entry point of the program.
        {
            int n, fact = 1;    // Declaring variables: n for the number and fact for the factorial.
            Console.WriteLine("Enter Number : "); // User input.
            string str = Console.ReadLine(); // Reading input from the console.
            n = Convert.ToInt32(str); // Converting the input string to an integer.
            for (int i = 1; i <= n; i++) // For loop from 1 to n to calculate the factorial.
            {
                fact = fact * i; // Multiplying fact by i in each iteration.
            }
            Console.WriteLine("Factorial : {0}", fact);     // Printing factorial of the number.
            Console.Read();     // To hold the screen open.
        }
    }
}