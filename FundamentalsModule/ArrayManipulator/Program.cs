using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                switch (command[0])
                {
                    case "exchange":
                        ExecuteExchange(command, array);
                        break;
                    case "max":
                        ExecuteMax(command, array);
                        break;
                    case "min":
                        ExecuteMin(command, array);
                        break;
                    case "first":
                        ExecuteFirst(command, array);
                        break;
                    case "last":
                        ExecuteLast(command, array);
                        break;
                }

            }
            Console.WriteLine($"[{string.Join(',',array)}]");

        }

        private static void ExecuteLast(string[] command, int[] array)
        {
            throw new NotImplementedException();
        }

        private static void ExecuteFirst(string[] command, int[] array)
        {
            throw new NotImplementedException();
        }

        private static void ExecuteMin(string[] command, int[] array)
        {
            int min = int.MaxValue;
            int maxIndex = -1;
            if (command[1] == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] <= min)
                        {
                            min = array[i];
                            maxIndex = i;
                        }

                    }

                }

            }
            else if (command[1] == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1)
                    {
                        if (array[i] <= min)
                        {
                            min = array[i];
                            maxIndex = i;
                        }

                    }

                }

            }
            if (maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void ExecuteMax(string[] command, int[] array)
        {
            int max = int.MinValue;
            int maxIndex = -1;
            if (command[1] == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] >= max)
                        {
                            max = array[i];
                            maxIndex = i;
                        }

                    }

                }

            }
            else if (command[1] == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1)
                    {
                        if (array[i] >= max)
                        {
                            max = array[i];
                            maxIndex = i;
                        }

                    }

                }

            }
            if (maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void ExecuteExchange(string[] command, int[] array)
        {
            int index = int.Parse(command[1]);
            if (index >= array.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            else
            {
                int[] temp = new int[index + 1];

                for (int i = 0; i <= index; i++)// index =2
                {
                    temp[i] = array[i];
                }

                for (int i = 0; i <= index; i++)
                {
                    for (int k = 0; k < array.Length - 1; k++)
                    {
                        array[k] = array[k + 1];
                    }
                }

                int counter = 0;

                for (int i = array.Length - 1 - index; i < array.Length; i++)
                {
                    array[i] = int.Parse(temp[counter].ToString());
                    counter++;
                }

            }
        }
    }
}
