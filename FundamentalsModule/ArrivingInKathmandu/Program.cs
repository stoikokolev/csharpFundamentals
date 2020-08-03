using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ArrivingInKathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<name>[A-Za-z\d!@#$?]+)=(?<lenght>\d+)<<(?<code>.+)$";
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Last note")
            {
                var match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    if (int.Parse(match.Groups["lenght"].Value) == match.Groups["code"].Length)
                    {
                        var sb = new StringBuilder();
                        string name = match.Groups["name"].Value;
                        for (int i = 0; i < name.Length; i++)
                        {
                            if (char.IsLetterOrDigit(name[i]))
                            {
                                sb.Append(name[i]);
                            }

                        }

                        Console.WriteLine($"Coordinates found! {sb} -> {match.Groups["code"].Value}");
                        continue;
                    }


                }


                Console.WriteLine("Nothing found!");
            }

        }
    }
}
