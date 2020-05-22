using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = 0;
            bool isDivisible = true;
            if (input % 10 == 0)
            {
                number = 10;
            }
            else if (input % 7 == 0)
            {
                number = 7;
            }
            else if (input % 6 == 0)
            {
                number = 6;
            }
            else if (input % 3 == 0)
            {
                number = 3;
            }
            else if (input % 2 == 0)
            {
                number = 2;
            }
            else
            {
                isDivisible = false;
            }

            if (isDivisible)
            {
                Console.WriteLine($"The number is divisible by {number}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
