using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([=\/])(?<destination>[A-Z][A-Za-z]{2,})\1";
            string input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);
            List<string> list = new List<string>();
            int sum = 0;
            foreach (Match match in matches)
            {
                list.Add(match.Groups["destination"].Value);
                
            }
            foreach (var item in list)
            {
                sum += item.Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ",list).Trim()}");
            Console.WriteLine($"Travel Points: {sum}");

        }
    }
}
