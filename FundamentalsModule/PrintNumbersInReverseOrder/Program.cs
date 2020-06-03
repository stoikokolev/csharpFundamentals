using System;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] numbers = new string[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Console.ReadLine();
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[numbers.Length - i - 1] + " ");
            }
        }
    }
}
