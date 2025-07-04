//using System;
//namespace ConsoleApplication1
//{
//    {
//        static void Main(string[] args)
//    {
//        int x;
//        Console.WriteLine("Enter Number : ");
//        x = Convert.ToInt32(str);
//        Console.WriteLine("Number is Even");
//            else
//            Console.Read();
//        string str = Console.ReadLine();
//        if (x % 2 == 0)
//            Console.WriteLine("Number is Odd");
//    }
//}
//}
//class Program
//using System;

using System;

namespace Ayushi_Tutorials
{
    internal class T1Q4
    {
        public static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter Number : ");
            string str = Console.ReadLine();
            x = Convert.ToInt32(str);
            if(x % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            Console.Read();
        }
    }
}
