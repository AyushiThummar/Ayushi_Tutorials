using System;

namespace Ayushi_Tutorials
{
    internal class T2Q4
    {
        public static void Main(string[] args)
        {
            // Input two numbers
            Console.WriteLine("Enter first number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            // Arithmetic operators
            Console.WriteLine("~~~ Arithmetic Operators ~~~");
            Console.WriteLine("Addition : " + (n1 + n2));
            Console.WriteLine("Subtraction : " + (n1 - n2));
            Console.WriteLine("Multiplication : " + (n1 * n2));
            Console.WriteLine("Division : " + ((double)n1/n2));  // using double for division
            Console.WriteLine("Modulo : "+ (n1 % n2));

            // Relational Operators
            Console.WriteLine("~~~ Relational Operators ~~~");
            Console.WriteLine("Equal to : " + (n1 == n2));
            Console.WriteLine("Not equal to : " + (n1 != n2));
            Console.WriteLine("Greater than : " + (n1 > n2));
            Console.WriteLine("Less than : " + (n1 < n2));
            Console.WriteLine("Greater than or equal to : " + (n1 >= n2));
            Console.WriteLine("Less than or equal to: " + (n1 <= n2));

            // Logical Operators
            Console.WriteLine("~~~ Logical Operators ~~~");
            bool cond1 = (n1 > 0);
            bool cond2 = (n2 > 0);
            Console.WriteLine("Logical AND : " + (cond1 && cond2));
            Console.WriteLine("Logical OR : " + (cond1 || cond2));
            Console.WriteLine("Logical NOT : " + (!cond1));

            // Bitwise Operators
            Console.WriteLine("~~~ Bitwise Operators ~~~");
            Console.WriteLine("Bitwise AND : " + (n1 & n2));
            Console.WriteLine("Bitwise OR : " + (n1 | n2));
            Console.WriteLine("Bitwise XOR : " + (n1 ^ n2));
            Console.WriteLine("Bitwise Complement(NOT) : " + (~n1));
            Console.WriteLine("Left shift : " + (n1 << 1));
            Console.WriteLine("Right shift : " + (n2 >> 1));

            // Assignment Operators
            Console.WriteLine("~~~ Assignment Operators ~~~");
            int x = n1;
            x = n2; Console.WriteLine("Simple assignment : " + x);
            x += n2; Console.WriteLine("Add and assign : " + x);
            x -= n2; Console.WriteLine("Subtract and assign : " + x);
            x *= n2; Console.WriteLine("Multiply and assign : " + x);
            x /= n2; Console.WriteLine("Divide and assign : " + x);
            x %= n2; Console.WriteLine("Modulus and assign : " + x);

            // Unary Operators
            Console.WriteLine("~~~ Unary Operators ~~~");
            int y = n1;
            Console.WriteLine("Unary plus : " + (+y));
            Console.WriteLine("Unary minus : " + (-y));
            Console.WriteLine("Pre Increment : " + (++y));
            Console.WriteLine("Pre Decrement : " + (--y));
            Console.WriteLine("Post Increment : " + (y++));
            Console.WriteLine("Post Decrement : " + (y--));

            // Other Operators
            Console.WriteLine("~~~ Other Operators ~~~");
            Console.WriteLine("Ternary Operator : " + (n1 > n2 ? n1 : n2));
            Console.WriteLine("Type Cast Operator : " + ((double)n1));
            Console.WriteLine($"String Interpolation : n1 = {n1}, n2 = {n2}");
        }
    }
}
