using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = new List<int>();
            wagon = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split().ToArray();
                if (command[0] == "Add")
                {
                    wagon.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < wagon.Count; i++)
                    {
                        if (int.Parse(command[0]) + wagon[i] <= maxCapacity)
                        {
                            wagon[i] += int.Parse(command[0]);
                            break;
                        }

                    }

                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', wagon));



        }
    }
}
