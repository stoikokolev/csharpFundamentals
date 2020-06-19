using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input
                    .Split();

                if (command[0] == "Delete")
                {
                    Delete(list, int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    Insert(list, int.Parse(command[1]), int.Parse(command[2]));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', list));

        }

        private static void Insert(List<int> list, int element, int index)
        {
            list.Insert(index, element);
        }

        private static void Delete(List<int> list, int element)
        {
            while (list.Remove(element))
            {

            }
        }
    }
}
