using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[A-Za-z]";
            string pattern2 = @"\d";
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] players = Console.ReadLine().Split(", ").ToArray();
            foreach (var player in players)
            {
                if (!dict.ContainsKey(player))
                {
                    dict.Add(player, 0);
                }
            }
            string input = Console.ReadLine();

            while (input != "end of race")
            {
                var matches = Regex.Matches(input, pattern);
                var matches2 = Regex.Matches(input, pattern2);
                string name = string.Empty;

                foreach (var match in matches)
                {
                    name += match.ToString();
                }
                if (dict.ContainsKey(name))
                {
                    foreach (var number in matches2)
                    {
                        dict[name] += int.Parse(number.ToString());
                    }
                }

                input = Console.ReadLine();
            }
            int count = 1;
            foreach (var item in dict.OrderByDescending(x => x.Value).Take(3)) 
            {
                if (count == 1)
                {
                    Console.WriteLine($"{count}st place: {item.Key}");
                }
                else if (count ==2)
                {
                    Console.WriteLine($"{count}nd place: {item.Key}");
                }
                else
                {
                    Console.WriteLine($"{count}rd place: {item.Key}");
                }
                
                count++;
            }



        }
    }
}
