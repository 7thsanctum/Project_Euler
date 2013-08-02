using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Special_Pythagorean_Triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 1000;
            int foundX = 0;
            int foundY = 0;
            for (int x = 0; x < goal; x++)
            {
                for (int y = 0; y < goal; y++)
                {
                    if (x + y + (Math.Sqrt((x * x) + (y * y))) == 1000 && x != 0 && y != 0 )
                    {
                        foundX = x;
                        foundY = y;
                        Console.Write("\nFound X : " + x);
                        Console.Write("\nFound Y : " + y);
                        Console.Write("\nFound C : " + Math.Sqrt((x * x) + (y * y)));
                        Console.Write("\nFound Root : " + (x * x) + (y * y));                        
                        Console.ReadKey();
                    }
                }
            }

            
        }
    }
}
