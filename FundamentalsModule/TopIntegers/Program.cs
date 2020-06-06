using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int biggest = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                biggest = int.MinValue;
                for (int n = i+1; n < arr.Length; n++)
                {
                   if (arr[n]>biggest)
                    {
                        biggest = arr[n];
                    }
                }
                if (arr[i]>biggest)
                { 
                    Console.Write(arr[i]+" "); 
                }
                
            }
        }
    }
}
