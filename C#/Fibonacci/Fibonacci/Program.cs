using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static long total = 0;
        static long limit = 4000000;
        static void Main(string[] args)
        {
            nextFib(1, 2);
            Console.Write("\nDONE : " + total + 2); // Add 2 because the nextFib skips the first 2 that's entered
            Console.ReadKey();
        }

        static void nextFib(long x, long y)
        {
            long currX = y;
            long currY = x + y;
            
            Console.Write("\n" + y);
            if (currY > limit) return;
            else
            {
                if (currY % 2 == 0) total += currY;
                nextFib(currX, currY);
            }
        }
    }
}
