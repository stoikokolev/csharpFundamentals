using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "swap":
                        int index1 = int.Parse(command[1]);
                        int index2 = int.Parse(command[2]);
                        int temp = arr[index1];
                        arr[index1] = arr[index2];
                        arr[index2] = temp;
                        break;
                    case "multiply":
                        int indexOne = int.Parse(command[1]);
                        int indexTwo = int.Parse(command[2]);
                        arr[indexOne] *= arr[indexTwo];
                        break;
                    case "decrease":
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] -= 1;
                        }
                        break;

                }

            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
