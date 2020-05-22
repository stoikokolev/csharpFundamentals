using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = input;
            int sum = 0;
            while (number != 0)
            {
                int currentPosition = number % 10;
                number /= 10;
                int currentSum = 1;
                for (int i = 2; i <= currentPosition; i++)
                {
                    currentSum *= i;
                }
                sum += currentSum;
            }
            if (input == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
