﻿using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            SmallestOfThreeNumbers(num1, num2, num3);
        }

        private static void SmallestOfThreeNumbers(int num1, int num2, int num3)
        {
            Console.WriteLine(Math.Min(Math.Min(num1, num2), num3));
        }
    }
}
