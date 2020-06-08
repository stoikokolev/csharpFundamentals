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
            string input = Console.ReadLine();
            int bestLenght = -1;
            int bestStartIndex = 0;
            int count = 0;
            int bestCount = 0;
            int[] bestArr = new int[n];
            int bestSum = 0;
            while (input != "Clone them!")
            {
                int[] arr = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                count++;
                int lenght = 1;
                int endIndex = 0;
                int sum = 0;
                
                foreach (var item in arr)
                {
                    sum += item;
                }
                for (int i = 1; i < n; i++)
                {
                    
                    if (arr[i] == arr[i - 1] )
                    {
                        lenght++;
                        endIndex = i ;
                        {
                            if (lenght > bestLenght)
                            {
                                bestLenght = lenght;
                                bestStartIndex = endIndex-lenght;
                                bestCount = count;
                                bestArr = arr.ToArray();
                                bestSum = sum;
                            }
                            else if (lenght == bestLenght)
                            {
                                if (endIndex-lenght < bestStartIndex)
                                {
                                    bestLenght = lenght;
                                    bestStartIndex = endIndex - lenght;
                                    bestCount = count;
                                    bestArr = arr.ToArray();
                                    bestSum = sum;
                                }
                                else if (endIndex - lenght == bestStartIndex)
                                {
                                    if (sum > bestSum)
                                    {
                                        bestLenght = lenght;
                                        bestStartIndex = endIndex - lenght;
                                        bestCount = count;
                                        bestArr = arr.ToArray();
                                        bestSum = sum;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        lenght = 1;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestCount} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(' ', bestArr)}");


        }



    }


}


