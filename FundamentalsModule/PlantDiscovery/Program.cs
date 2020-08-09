using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeats = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> dict = new Dictionary<string, Plant>();
            for (int i = 0; i < repeats; i++)
            {
                string input = Console.ReadLine();
                string[] command1 = input.Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string name = command1[0];
                int rarity = int.Parse(command1[1]);
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new Plant { Rarity = rarity , Rating=new List<double>() });
                }
                else
                {
                    dict[name].Rarity = rarity;
                }

            }

            string command = string.Empty;
            while ((command=Console.ReadLine()) != "Exhibition")
            {
                string[] arr = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                if (arr[0].Contains("Rate"))
                {
                    string[] arr2 = arr[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string name = arr2[0];
                    double rating = double.Parse(arr2[1]);
                    dict[name].Rating.Add(rating);
                }
                else if (arr[0].Contains("Update"))
                {
                    string[] arr2 = arr[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string name = arr2[0];
                    int rarity = int.Parse(arr2[1]);
                    dict[name].Rarity = rarity;
                }
                else if (arr[0].Contains("Reset"))
                {
                    string name = arr[1];
                    dict[name].Rating = new List<double>();
                }
                else
                {
                    Console.WriteLine("error");
                }

                
            }
            foreach (var item in dict)
            {
                if (item.Value.Rating.Count==0)
                {
                    item.Value.Rating.Add(0);
                }
                

            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Plants for the exhibition:");
            //Console.WriteLine("Plants for the exhibition:");
            foreach (var item in dict.OrderByDescending(x=>x.Value.Rarity).ThenByDescending(x=>x.Value.Rating.Average()))
            {
                sb.AppendLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {item.Value.Rating.Average():f2}");
            }
            Console.WriteLine(sb);

        }

        public class Plant
        {
            public List<double> Rating { get; set; }
            public int Rarity { get; set; }
            

        }
    }
}
