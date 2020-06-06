using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxLenght = 0;
            int currentLenght = 1;
            int finalPosition = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentLenght++;
                    if (currentLenght > maxLenght)
                    {
                        maxLenght = currentLenght;
                        finalPosition = i;
                    }
                }
                else
                {
                    currentLenght = 1;
                }

            }
            for (int i = 1; i <= maxLenght; i++)
            {
                Console.Write(arr[finalPosition] + " ");
            }
        }
    }
}
