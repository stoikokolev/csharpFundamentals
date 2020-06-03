using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] nums = arr;
            while (nums.Length != 0)
            {
                nums = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length; i++)
                {
                    arr[i] += arr[i + 1];
                }

            }
            Console.WriteLine(arr[0]);
        }
    }
}
//int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int num = arr.Length;
//            while (num != 0)
//            {
//                num--;
//                for (int i = 0; i<num; i++)
//                {
//                    arr[i] += arr[i + 1];
                    
//                }

//            }

//            Console.WriteLine(arr[0]);