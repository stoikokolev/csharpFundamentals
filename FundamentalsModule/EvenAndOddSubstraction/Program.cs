using System;
using System.Linq;

namespace EvenAndOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    sumOdd += arr[i];
                }
                else
                {
                    sumEven += arr[i];
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
