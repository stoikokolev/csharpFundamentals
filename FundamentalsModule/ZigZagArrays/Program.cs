using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements = int.Parse(Console.ReadLine());
            int[] arr1 = new int[elements];
            int[] arr2 = new int[elements];
            string[] arr3 = new string[2];
            for (int i = 1; i <= arr1.Length; i++)
            {
                arr3 = Console.ReadLine().Split().ToArray();
                if (i % 2 == 0)
                {
                    arr2[i - 1] = int.Parse(arr3[0]);
                    arr1[i - 1] = int.Parse(arr3[1]);
                }
                else
                {
                    arr1[i - 1] = int.Parse(arr3[0]);
                    arr2[i - 1] = int.Parse(arr3[1]);
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }
    }
}
