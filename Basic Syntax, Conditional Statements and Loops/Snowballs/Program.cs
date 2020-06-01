using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = byte.Parse(Console.ReadLine());
            short bestSnow = short.MinValue;
            short bestTime = short.MinValue;
            short bestQuality = short.MinValue;
            BigInteger bestValue = 0;
            for (byte i = 1; i <= number; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                short snowballQuality = short.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((BigInteger)(1.0 * snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > bestValue)
                {
                    bestValue = snowballValue;
                    bestTime = snowballTime;
                    bestSnow = snowballSnow;
                    bestQuality = snowballQuality;
                }

            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
