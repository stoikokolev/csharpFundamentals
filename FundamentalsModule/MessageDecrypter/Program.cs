using System;
using System.Text.RegularExpressions;

namespace MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([$%])(?<tag>[A-Z][a-z]{2,})\1: \[(?<first>[0-9]+)\]\|\[(?<second>[0-9]+)\]\|\[(?<third>[0-9]+)\]\|$";

            int repeats = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeats; i++)
            {
                string input = Console.ReadLine();
                var match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string text = match.Groups["tag"].Value + ": "
                        + (char)(int.Parse(match.Groups["first"].Value))
                        + (char)(int.Parse(match.Groups["second"].Value))
                        + (char)(int.Parse(match.Groups["third"].Value));
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }

        }
    }
}
