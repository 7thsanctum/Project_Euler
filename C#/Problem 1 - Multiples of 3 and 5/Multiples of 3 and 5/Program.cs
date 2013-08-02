using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int total = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }
            Console.Write("Total : " + total);
            Console.ReadLine();
        }
    }
}
