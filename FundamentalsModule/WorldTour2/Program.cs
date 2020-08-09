using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldTour2
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeats = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
            for (int i = 0; i < repeats; i++)
            {
                string input = Console.ReadLine();
                string[] inputArr = input.Split("<->");
                string name = inputArr[0];
                double rarity = double.Parse(inputArr[1]);
                if (plants.ContainsKey(name))
                {
                    plants[name].Rarity = rarity;
                }
                else
                {
                    plants.Add(name, new Plant { Rarity = rarity, Name = name, Rating = new List<double>() });

                }

            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] action = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                if (action.Contains("Rate"))
                {
                    string[] splitted = action[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string name = splitted[0];
                    double rating = double.Parse(splitted[1]);
                    if (plants.ContainsKey(name))
                    {
                        plants[name].Rating.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action.Contains("Update"))
                {
                    string[] splitted = action[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string name = splitted[0];
                    double rarity = double.Parse(splitted[1]);
                    if (plants.ContainsKey(name))
                    {
                        plants[name].Rarity = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (action.Contains("Reset"))
                {
                    string name = action[1];
                    if (plants.ContainsKey(name))
                    {
                        plants[name].Rating = new List<double>();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }


            }

            foreach (var item in plants)
            {
                if (item.Value.Rating.Count==0)
                {
                    item.Value.Rating.Add(0);
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Plants for the exhibition:");

            foreach (var item in plants.OrderByDescending(x=>x.Value.Rarity).ThenBy(x=>x.Value.Rating.Average()))
            {
                sb.AppendLine($"- {item.Key}; Rarity: {(int)item.Value.Rarity}; Rating: {item.Value.Rating.Average():f2}");
            }

            Console.WriteLine(sb);

        }
        public class Plant
        {
            public string Name { get; set; }
            public List<double> Rating { get; set; }
            public double Rarity { get; set; }
        }
    }
}
