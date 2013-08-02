using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Largest_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int palin = 0;
            for (int i = 900; i < 1000; i++)
            {
                for (int j = 900; j < 1000; j++)
                {
                    char[] temp = (i * j).ToString().ToCharArray();
                    Array.Reverse(temp);
                    string check = new String(temp);
                    if ((i * j).ToString() == check)
                    {
                        palin = i * j;
                    }
                }
            }
            Console.Write(palin);
            Console.Write("\nLargest Palindrome Found : " + palin);
            Console.ReadKey();
        }
    }
}
