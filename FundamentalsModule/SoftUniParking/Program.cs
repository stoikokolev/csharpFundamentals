using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeats = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Ticket>();
            for (int i = 0; i < repeats; i++)
            {
                var input = Console.ReadLine().Split();
                string command = input[0];
                string name = input[1];
                switch (command)
                {
                    case "register":
                        string plate = input[2];
                        if (dict.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {dict[name].plate}");
                        }
                        else
                        {
                            dict.Add(name, new Ticket(name, plate));
                            Console.WriteLine($"{name} registered {plate} successfully");
                        }
                        break;

                    case "unregister":
                        if (dict.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} unregistered successfully");
                            dict.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        break;

                }

            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value.plate}");
            }

        }
        public class Ticket
        {
            public string name { get; set; }
            public string plate { get; set; }

            public Ticket(string name, string plate)
            {
                this.name = name;
                this.plate = plate;
            }
        }
    }
}
