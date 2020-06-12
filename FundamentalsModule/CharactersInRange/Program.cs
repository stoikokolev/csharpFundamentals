using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            PrintCharactersBetween(symbol1, symbol2);
        }

        private static void PrintCharactersBetween(char symbol1, char symbol2)
        {
            for (int i = (Math.Min(symbol1, symbol2)) + 1; i < Math.Max(symbol1, symbol2); i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
