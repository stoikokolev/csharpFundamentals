using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputa = string.Empty;
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            Dictionary<string, List<string>> dict2 = new Dictionary<string, List<string>>();
            int totalTime = 0;
            while ((inputa = Console.ReadLine()) != "start of concert")
            {
                string[] arr = inputa.Split("; ");
                string command = arr[0];
                string bandName = arr[1];
                if (command == "Add")
                {
                    string[] members = arr[2].Split(", ");
                    if (dict1.ContainsKey(bandName))
                    {
                        foreach (var member in members)
                        {
                            if (dict2[bandName].Contains(member))
                            {
                                continue;
                            }
                            else
                            {
                                dict2[bandName].Add(member);
                            }

                        }

                    }
                    else
                    {
                        dict1.Add(bandName, 0);
                        dict2.Add(bandName, new List<string>());
                        foreach (var member in members)
                        {
                            dict2[bandName].Add(member);
                        }
                    }

                }
                else if (command == "Play")
                {
                    int time = int.Parse(arr[2]);
                    totalTime += time;
                    if (dict1.ContainsKey(bandName))
                    {
                        dict1[bandName] += time;

                    }
                    else
                    {
                        dict1.Add(bandName, time);
                        dict2.Add(bandName, new List<string>());
                    }

                }

            }

            Console.WriteLine($"Total time: {totalTime}");
            foreach (var band in dict1.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            string finalLine = Console.ReadLine();
            foreach (var item in dict2)
            {
                if (item.Key == finalLine)
                {
                    Console.WriteLine(item.Key);
                    foreach (var member in item.Value)
                    {
                        Console.WriteLine($"=> {member}");
                    }
                }
            }
        }
    }
}
