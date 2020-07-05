using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reworkedInput = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == ' ' || input[i] == '-')
                    reworkedInput += input[i];
            }

            List<int> list = reworkedInput
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            double sum = 0;
            list.Sort();
            foreach (var item in list)
            {
                sum += item;
            }
            double average = sum / list.Count;

            List<int> newList = new List<int>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (newList.Count == 5)
                {
                    break;
                }
                if (list[i] > average)
                {
                    newList.Add(list[i]);
                }
            }
            if (newList.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                newList.Sort();
                newList.Reverse();
                Console.WriteLine(string.Join(' ', newList));
            }
        }
    }
}
