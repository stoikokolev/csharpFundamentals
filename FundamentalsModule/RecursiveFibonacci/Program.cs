using System;
using System.Diagnostics.CodeAnalysis;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            int[] arr = new int[2] { 1,1 };
            for (int i = 0; i < number-1; i++)
            {
                int[] currArr = new int[2] { arr[1], arr[0] + arr[1] };
                arr = currArr;
            }
            Console.WriteLine(arr[0]);
        }
    }
}
