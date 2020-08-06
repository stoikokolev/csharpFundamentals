using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, Town> towns = new Dictionary<string, Town>();
            while ((input = Console.ReadLine()) != "Sail")
            {
                var arr = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string name = arr[0];
                int population = int.Parse(arr[1]);
                int gold = int.Parse(arr[2]);
                if (!towns.ContainsKey(name))
                {
                    towns.Add(name, new Town { Name = name, Gold = gold, Population = population });

                }
                else
                {
                    towns[name].Gold += gold;
                    towns[name].Population += population;
                }

            }

            while ((input = Console.ReadLine()) != "End")
            {
                var command = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                if (command.Contains("Plunder"))
                {
                    Console.WriteLine($"{command[1]} plundered! {command[3]} gold stolen, {command[2]} citizens killed.");
                    towns[command[1]].Gold -= int.Parse(command[3]);
                    towns[command[1]].Population -= int.Parse(command[2]);
                    if (towns[command[1]].Gold <= 0 || towns[command[1]].Population <= 0)
                    {
                        towns.Remove(command[1]);
                        Console.WriteLine($"{command[1]} has been wiped off the map!");
                    }
                }
                else if (command.Contains("Prosper"))
                {
                    int gold = int.Parse(command[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");

                    }
                    else
                    {
                        towns[command[1]].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {command[1]} now has {towns[command[1]].Gold} gold.");
                    }
                }
            }

            if (towns.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
                foreach (var item in towns.OrderByDescending(x => x.Value.Gold).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg");
                }
            }
        }


        public class Town
        {
            public int Population { get; set; }
            public int Gold { get; set; }
            public string Name { get; set; }
        }
    }
}