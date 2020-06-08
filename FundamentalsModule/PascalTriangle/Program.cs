using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(1);
            if (number == 1)
            {
                return;
            }
            int[] lastArray = new int[] { 1, 1 };
            Console.WriteLine(string.Join(' ', lastArray));
            if (number == 2)
            {
                return;
            }
            else
            {
                for (int i = 0; i < lastArray.Length + 1; i++)
                {
                    int[] arr = new int[lastArray.Length + 1];
                    arr[0] = 1;
                    arr[arr.Length - 1] = 1;
                    for (int r = 1; r < arr.Length - 1; r++)
                    {
                        arr[r] = lastArray[r] + lastArray[r - 1];
                    }
                    Console.WriteLine(string.Join(' ', arr));
                    lastArray = arr;
                    if (lastArray.Length == number)
                    {
                        break;
                    }
                }

            }

        }
    }
}
