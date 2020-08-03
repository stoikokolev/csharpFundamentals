using System;
using System.Collections.Generic;
using System.Linq;

namespace OnTheWayToAnnapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            while ((input=Console.ReadLine())!="END")
            {
                string[] command = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                if (command[0]=="Add")
                {
                    string[] items = command[2].Split(',', StringSplitOptions.RemoveEmptyEntries);
                    if (dict.ContainsKey(command[1]))
                    {
                        foreach (var item in items)
                        {
                            if (!dict[command[1]].Contains(item))
                            {
                                dict[command[1]].Add(item);
                            }

                        }

                    }
                    else
                    {
                        dict.Add(command[1], new List<string>());
                        dict[command[1]].Add(command[2]);
                    }

                }
                else if (command[0]=="Remove")
                {
                    if (dict.ContainsKey(command[1]))
                    {
                        dict.Remove(command[1]);
                    }

                }

            }
            Console.WriteLine("Stores list:");
            foreach (var item in dict.OrderByDescending(x=>x.Value.Count).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var thing in item.Value)
                {
                    Console.WriteLine($"<<{thing}>>");
                }
            }

        }
    }
}
    