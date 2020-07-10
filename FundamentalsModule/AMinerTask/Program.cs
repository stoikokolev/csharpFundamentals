using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resource = new Dictionary<string, int>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (resource.ContainsKey(name))
                {
                    resource[name] += quantity;
                }
                else
                {
                    resource.Add(name, quantity);
                }

            }

            foreach (var item in resource)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
