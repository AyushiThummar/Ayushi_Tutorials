// 6 : Write missing statement to get the desired output.

using System;
namespace Ayushi_Tutorials

{
    class T1Q6
    {
        static void Main(string[] args)
        {
            int a, b, c, result;
            string str;
            Console.Write("Enter Number  1 : ");

            //Missing statement
            str = Console.ReadLine();

            a = Convert.ToInt32(str);
            Console.Write("Enter Number  2 : ");

            //Missing statement
            str = Console.ReadLine();

            b = Convert.ToInt32(str);
            Console.Write("Enter Number  3 : ");
            str = Console.ReadLine();

            //Missing statement
            c = Convert.ToInt32(str);

            result = Sum(a, b, c);

            //Missing statement
            Console.WriteLine("Sum : " + result);

            Console.Read();

        }
        static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            return res;
        }
    }
}