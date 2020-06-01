using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 'a'; i < 'a' + number; i++)
            {
                for (int n = 'a'; n < 'a' + number; n++)
                {
                    for (int m = 'a'; m < 'a' + number; m++)
                    {
                        Console.WriteLine($"{(char)i}{(char)n}{(char)m}");
                    }
                }
            }
        }
    }
}
