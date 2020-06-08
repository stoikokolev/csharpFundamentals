using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string first = "";

            string middle = "";

            for (int i = input.Length / 4 - 1; i >= 0; i--)
            {
                first += input[i] + " ";
            }
            for (int i = input.Length - 1; i >= input.Length - (input.Length / 4); i--)
            {
                first += input[i] + " ";
            }
            for (int i = input.Length / 4; i < input.Length - (input.Length / 4); i++)
            {
                middle += input[i] + " ";
            }

            int[] one = first.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] two = middle.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < one.Length; i++)
            {
                Console.Write(one[i] + two[i] + " ");
            }
        }
    }
}
