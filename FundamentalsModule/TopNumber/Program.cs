using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopNumber(number);

        }

        private static void PrintTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (IsDivisibleByEight(i) && IsHoldsOddDigit(i))
                {
                    Console.WriteLine(i);
                }

            }
        }

        private static bool IsHoldsOddDigit(int number)
        {
            while (number>0)
            {
                if ((number%10)%2==1)
                {
                    return true;
                }
                else
                {
                    number /= 10;
                    
                }
                
            }
            return false;
        }

        private static bool IsDivisibleByEight(int number)
        {
            int sum = 0;
            while (number>0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum%8==0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
