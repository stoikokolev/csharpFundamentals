using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                for (int n = i+1; n < arr.Length; n++)
                {
                    if (arr[i]+arr[n]==magicNumber)
                    {
                        Console.WriteLine($"{arr[i]} {arr[n]}");
                    }
                }
            }

        }
    }
}
