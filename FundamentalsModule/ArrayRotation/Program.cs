using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            if (number>arr.Length)
            { number = number%arr.Length; }
            for (int i = number; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (int i = 0; i < number; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
