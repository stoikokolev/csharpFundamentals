using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<count>[0-9]+)\|[^|$%.]*?(?<price>[0-9]+\.*[0-9]*)\$";
            string input = Console.ReadLine();
            double total = 0;
            while (input != "end of shift")
            {
                var matches = Regex.Matches(input, pattern);
                foreach (Match match in matches)
                {
                    Console.WriteLine($"{match.Groups["name"].Value}: {match.Groups["product"].Value} - {double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["count"].Value):f2}");
                    total += double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["count"].Value);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
