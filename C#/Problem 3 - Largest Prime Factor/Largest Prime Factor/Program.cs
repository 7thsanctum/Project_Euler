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
            //int number = 360;
            long temp = number;
            long largestPrime = 2;

            do{
                if (temp % largestPrime == 0)
                {
                    temp = temp / largestPrime;
                }
                else
                {
                    if (temp != 1)
                    {
                        int count = 0;
                        // Find next prime
                        for (long i = largestPrime + 1; count == 0; i++)
                        {
                            for (int k = 2; k < i; k++)
                            {
                                if (i % k == 0)
                                {
                                    break;
                                }
                                else if (k + 1 == i)
                                { 
                                    largestPrime = i;
                                    count++;
                                }
                            }
                        }
                        count = 0;
                    }
                }
            }while(temp > 2);
            
            Console.Write(largestPrime);
            Console.ReadKey();

        } 
    }
}
