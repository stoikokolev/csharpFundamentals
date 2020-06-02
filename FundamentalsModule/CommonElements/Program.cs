using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string[] arr1 = first.Split().ToArray();
            string[] arr2 = second.Split().ToArray();
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int n = 0; n < arr1.Length; n++)
                {
                    if (arr1[n] == arr2[i])
                    { Console.Write(arr2[i] + " "); }
                }
            }

        }
    }
}
