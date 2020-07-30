using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = arr[1];
                switch (arr[0])
                {
                    case "Enroll":
                        if (dict.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} is already enrolled.");
                        }
                        else
                        {
                            dict.Add(name, new List<string>());
                        }

                        break;

                    case "Learn":
                        if (dict.ContainsKey(name))
                        {
                            if (dict[name].Contains(arr[2]))
                            {
                                Console.WriteLine($"{name} has already learnt {arr[2]}.");
                            }
                            else
                            {
                                dict[name].Add(arr[2]);
                            }

                        }
                        else
                        {
                            Console.WriteLine($"{name} doesn't exist.");

                        }

                        break;

                    case "Unlearn":
                        if (dict.ContainsKey(name))
                        {
                            if (dict[name].Contains(arr[2]))
                            {
                                dict[name].Remove(arr[2]);
                            }
                            else
                            {
                                Console.WriteLine($"{name} doesn't know {arr[2]}.");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"{name} doesn't exist.");

                        }

                        break;
                }

            }

            Console.WriteLine("Heroes:");
            foreach (var item in dict.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"== {item.Key}: {string.Join(", ",item.Value)}");
                //foreach (var spell in item.Value)
                //{
                //    Console.WriteLine(spell);
                //}
                //Console.WriteLine();
            }

        }

    }
}

