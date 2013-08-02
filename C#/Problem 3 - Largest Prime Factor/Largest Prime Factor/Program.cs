using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Largest_Prime_Factor
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 600851475143;
            long largestPrime = 2;

            if(number % largestPrime == 0)
            {
                // Then move on to next prime number
            }
            else
            {
                // This value is largest primefactor
            }

            for (long i = number / 2; i > 2; i--)
            {
                Console.Write("\n" + i);
                if (number % i == 0)
                {
                    largestPrime = number;
                    Console.Write(largestPrime);
                    Console.ReadKey();
                }
            }
            
        } 
    }
}
