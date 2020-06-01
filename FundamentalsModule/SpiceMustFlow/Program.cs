using System;
using System.Numerics;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger startingYeld = BigInteger.Parse(Console.ReadLine());
            BigInteger spiceExtracted = 0;
            BigInteger days = 0;
            if (startingYeld < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(spiceExtracted);
            }
            else
            { 
            while (startingYeld >= 100)
            {
                spiceExtracted += startingYeld;
                spiceExtracted -= 26;
                startingYeld -= 10;
                days++;
            }
            spiceExtracted -= 26;
            Console.WriteLine(days);
            Console.WriteLine(spiceExtracted);
        }
        }
    }
}
