using System;
using System.Text.RegularExpressions;

namespace RegexDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[A-Z][a-z]+ [A-Z][a-z]+";
            Regex reg = new Regex(pattern);
            string input = Console.ReadLine();
            Console.WriteLine(reg.IsMatch(input));
            Console.WriteLine(reg.Match(input).Value);
            Console.WriteLine(reg.Matches(input).Count);
            var matchh = reg.Matches(input);
            foreach (var item in matchh)
            {
                item.ToString();
            }

        }
    }
}
