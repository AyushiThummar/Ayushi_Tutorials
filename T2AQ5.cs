using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_Tutorials
{
    internal class T2AQ5
    {
        public static void Main(String[] args)
        {
            int[] a1 = { 1, 2, 2, 5, 3, 5, 10, 2, 5, 1, 20 };
            int dc = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                bool isD = false;
                for (int j = i+1; j < a1.Length; j++)
                {
                    if (a1[i] == a1[j])
                    {
                        isD = true;
                        break;
                    }
                }
                if (isD)
                {
                    bool alreadyCounted = false;
                    for(int k = 0; k < i; k++)
                    {
                        if (a1[i] == a1[k])
                        {
                            alreadyCounted = true;
                            break;
                        }
                    }
                    if (!alreadyCounted)
                    {
                        dc++;
                    }
                }
            }
            Console.WriteLine("The total number of duplicate elements in the array is : " + dc);
        }
    }
}
