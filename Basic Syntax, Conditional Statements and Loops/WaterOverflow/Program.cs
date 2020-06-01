using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeats = int.Parse(Console.ReadLine());
            int filled = 0;
            for (int i = 1; i <= repeats; i++)
            {
                int water = int.Parse(Console.ReadLine());
                if (filled + water > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    filled += water;
                }

            }
            Console.WriteLine(filled);
        }
    }
}
