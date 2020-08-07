using System;
using System.Collections.Generic;
using System.Linq;

namespace MessagesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxMessages = int.Parse(Console.ReadLine());
            Dictionary<string, Person> persons = new Dictionary<string, Person>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] arr = command.Split("=", StringSplitOptions.RemoveEmptyEntries);
                switch (arr[0])
                {
                    case "Add":
                        string name = arr[1];
                        int sent = int.Parse(arr[2]);
                        int received = int.Parse(arr[3]);
                        if (!persons.ContainsKey(name))
                        {
                            persons.Add(name, new Person { Name = name, Sent = sent, Received = received });
                        }

                        break;
                    case "Message":
                        string sender = arr[1];
                        string receiver = arr[2];
                        if (persons.ContainsKey(sender) && persons.ContainsKey(receiver))
                        {
                            persons[sender].Sent++;
                            persons[receiver].Received++;
                            if ((persons[sender].Sent+ persons[sender].Received) == maxMessages)
                            {
                                Console.WriteLine($"{sender} reached the capacity!");
                                persons.Remove(sender);
                            }
                            if ((persons[receiver].Received+ persons[receiver].Sent) == maxMessages)
                            {
                                Console.WriteLine($"{receiver} reached the capacity!");
                                persons.Remove(receiver);
                            }

                        }

                        break;
                    case "Empty":
                        string user = arr[1];
                        if (persons.ContainsKey(user))
                        {
                            persons.Remove(user);
                        }
                        if (user == "All")
                        {
                            persons.Clear();
                        }
                        break;
                }
            }

            Console.WriteLine($"Users count: {persons.Count}");
            foreach (var item in persons.OrderByDescending(x => x.Value.Received).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Received + item.Value.Sent}");
            }

        }

        public class Person
        {
            public int Sent { get; set; }
            public int Received { get; set; }
            public string Name { get; set; }
        }
    }
}
