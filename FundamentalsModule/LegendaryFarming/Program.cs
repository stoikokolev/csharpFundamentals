using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var resource = new Dictionary<string, int>();
            resource.Add("shards", 0);
            resource.Add("fragments", 0);
            resource.Add("motes", 0);
            var junk = new SortedDictionary<string, int>();
            string item = string.Empty;
            while (item == string.Empty)
            {

                string input = Console.ReadLine();
                string[] arr = input.Split();
                for (int i = 1; i < arr.Length; i += 2)
                {
                    string name = arr[i].ToLower();
                    int value = int.Parse(arr[i - 1]);
                    if (resource.ContainsKey(name))
                    {
                        resource[name] += value;
                        if (resource[name] >= 250)
                        {
                            resource[name] -= 250;
                            switch (name)
                            {
                                case "fragments":
                                    item = "Valanyr";
                                    break;
                                case "shards":
                                    item = "Shadowmourne";
                                    break;
                                case "motes":
                                    item = "Dragonwrath";
                                    break;
                            }
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(name))
                        {
                            junk[name] += value;
                        }
                        else
                        {
                            junk.Add(name, value);
                        }
                    }
                }


            }
            Console.WriteLine($"{item} obtained!");
            foreach (var element in resource.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
            foreach (var element in junk)
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
        }
    }
}
