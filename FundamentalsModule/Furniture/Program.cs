using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<name>[A-z]+)<<(?<price>\d+\.?\d+?)!(?<quantity>\d+)";
            double sum = 0;
            List<string> list = new List<string>();
            while (input != "Purchase")
            {
                var match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    list.Add(match.Groups["name"].Value);
                    sum += double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["quantity"].Value);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
