using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int bestCount = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {

                int currElement = arr[i];
                int currCount = 1;
                
                if (currElement == 0)
                {
                    continue;
                }
                for (int currIndex = i + 1; currIndex < arr.Length; currIndex++)
                {
                    if (arr[currIndex] == 1)

                    {
                        currCount++;
                    }
                }

                if (currCount > bestCount)
                {
                    bestCount = currCount;
                }

            }




        }



    }


}


