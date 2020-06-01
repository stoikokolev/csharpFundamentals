using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeats = int.Parse(Console.ReadLine());
            string biggestName = string.Empty;
            double biggestVolume = double.MinValue; ;
            for (int i = 1; i <= repeats; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestName = name;
                }

            }
            Console.WriteLine(biggestName);
        }
    }
}
