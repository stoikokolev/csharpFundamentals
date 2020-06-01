using System;
using System.Security.Claims;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= lines; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += (int)symbol;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
