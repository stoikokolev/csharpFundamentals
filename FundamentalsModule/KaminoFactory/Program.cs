using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            int bestCount = 1;
            int bestSum = 0;
            int bestIndex = 0;
            int bestLenght = 0;
            int[] bestArray = new int[number];
            string command = Console.ReadLine();
            while (command != "Clone them!")
            {
                int[] arr = command.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                count++;
                int currSum = SumCurrArray(arr);
                int lenght = 0;
                int currIndex = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 1)
                    {
                        lenght++;
                        currIndex = i + 1 - lenght;
                        if (lenght > bestLenght)
                        {
                            bestLenght = lenght;
                            bestCount = count;
                            bestSum = currSum;
                            bestIndex = currIndex;
                            bestArray = arr.ToArray();
                        }
                        else if (lenght == bestLenght)
                        {
                            if (currIndex < bestIndex)
                            {
                                bestLenght = lenght;
                                bestCount = count;
                                bestSum = currSum;
                                bestIndex = currIndex;
                                bestArray = arr.ToArray();
                            }
                            else if (currIndex == bestIndex)
                            {
                                if (currSum > bestSum)
                                {
                                    bestLenght = lenght;
                                    bestCount = count;
                                    bestSum = currSum;
                                    bestIndex = currIndex;
                                    bestArray = arr.ToArray();
                                }

                            }

                        }

                    }
                    else
                    {
                        lenght = 0;
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestCount} with sum: {bestSum}.");
            Console.WriteLine(string.Join(' ', bestArray));



        }

        private static int SumCurrArray(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }


}


