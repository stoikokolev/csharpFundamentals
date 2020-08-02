using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TheIsleOfManTTRace
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#$%*&])(?<name>[A-Za-z]+)\1=(?<lenght>[0-9]+)!!(?<code>.+)";
            string input = Console.ReadLine();
            while (true)
            {
                var match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    if (match.Groups["code"].Length==int.Parse(match.Groups["lenght"].Value))
                    {
                        StringBuilder sb = new StringBuilder();
                        string word = match.Groups["code"].Value;
                        int code = int.Parse(match.Groups["lenght"].Value);
                        for (int i = 0; i < word.Length; i++)
                        {
                            sb.Append((char)(word[i] + code));
                        }
                        Console.WriteLine($"Coordinates found! {match.Groups["name"].Value} -> {sb}");
                        break;
                    }
                    
                }
                Console.WriteLine("Nothing found!");

                input = Console.ReadLine();
            }

        }
    }
}
