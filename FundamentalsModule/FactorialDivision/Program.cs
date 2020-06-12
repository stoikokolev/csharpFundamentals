using System;
using System.Diagnostics.CodeAnalysis;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{Division(Factorial(num1), Factorial(num2)):f2}");
        }

        private static decimal Division(decimal v1, decimal v2)
        {
            return v1 / v2;
        }

        private static decimal Factorial(decimal num)
        {
            decimal sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }

            return sum;
        }
    }
}
