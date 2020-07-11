using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, List<string>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string company = command.Split(" -> ")[0];
                string id = command.Split(" -> ")[1];
                if (dict.ContainsKey(company))
                {
                    if (dict[company].Contains(id))
                    {
                        continue;
                    }
                    else
                    {
                        dict[company].Add(id);
                    }
                }
                else
                {
                    dict.Add(company, new List<string>());
                    dict[company].Add(id);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
                foreach (var element in item.Value)
                {
                    Console.WriteLine($"-- {element}");
                }
            }

        }
    }
}
