using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1001_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int currentCheck = 2;
            int currentPrime = 2;
            do{
                for (int i = currentCheck-1; i >= 2; i--)
                {
                    if (currentCheck % i == 0 )
                    {
                        //Not prime so we break
                        break;
                    }
                    else if (i == 2)
                    {
                        // Is prime so we store it and continue
                        currentPrime = currentCheck;
                        count++;
                    }
                }
                currentCheck++;

            }while(count != 10000);
            Console.Write("\nFound the prime : " + currentPrime);
            Console.ReadKey();
        }
    }
}
