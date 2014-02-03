using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            long i = 1;
            bool check = true;
            int count = 0;
            long value;
            do
            {
                count = 0;
                for (int j = 1; j <= 20; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        //check = false;
                    }
                    else
                    {
                        break;
                    }
                }
                value = i;
                i++;
            } while (check == true && count < 20);

            Console.Write("Done : " + value);
            Console.Read();
        }
    }
}
