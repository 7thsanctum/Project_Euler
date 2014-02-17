using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum_Square_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sqrSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i * i;
                sqrSum += i;
            }
            
            int difference = (sqrSum*sqrSum) - sum;
            Console.Write("Sum : " + sum + "\nSqrSum : " + sqrSum + "\nDifference : " + difference);
            Console.ReadKey();
        }
    }
}