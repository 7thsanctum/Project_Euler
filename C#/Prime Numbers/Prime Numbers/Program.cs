using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    class Program
    {
        static long limit = 600851475143;
        static bool[] numberList = new bool[limit + 1];

        static void Main(string[] args)
        {
            long total = 0;
            for (int i = 2; i <= limit; i++)
            {
                if (!numberList[i])
                {
                    //total += i;
                    for (int k = 2 * i; k <= limit; k += i)
                    {
                        numberList[k] = true;
                    }
                }
            }
            
            Console.Write("Total : " + total);
            Console.ReadKey();
        }

    }
}
