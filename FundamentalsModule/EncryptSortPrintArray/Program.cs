using System;

namespace EncryptSortPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeats = int.Parse(Console.ReadLine());
            int[] codes = new int[repeats];
            for (int i = 0; i < repeats; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;
                for (int r = 0; r < input.Length; r++)
                {
                    if (input[r] == 'a' || input[r] == 'A' || input[r] == 'E' || input[r] == 'e' || input[r] == 'i' || input[r] == 'I' || input[r] == 'o' || input[r] == 'O' || input[r] == 'u' || input[r] == 'U')
                    {
                        sum += input[r] * input.Length;
                    }
                    else
                    {
                        sum += input[r] / input.Length;
                    }
                }
                codes[i] = sum;
            }
            Array.Sort(codes);
            foreach (var item in codes)
            {
                Console.WriteLine(item); ;
            }

        }
    }
}
