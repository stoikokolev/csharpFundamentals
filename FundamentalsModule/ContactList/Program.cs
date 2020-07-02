using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();
            while (true)
            {
                string[] command = input.Split().ToArray();
                switch (command[0])
                {
                    case "Add":
                        string contact = command[1];
                        int position = int.Parse(command[2]);
                        if (contacts.Contains(contact))
                        {
                            if (position >= 0 && position < contacts.Count)
                            {
                                contacts.Insert(position, contact);
                            }
                        }
                        else
                        {
                            contacts.Add(contact);
                        }

                        break;
                    case "Remove":
                        int index = int.Parse(command[1]);
                        if (index >= 0 && index < contacts.Count)
                        {
                            contacts.RemoveAt(index);
                        }

                        break;
                    case "Export":
                        int count = int.Parse(command[1]) + int.Parse(command[2]);
                        if (count >= contacts.Count)
                        {
                            count = contacts.Count;
                        }

                        for (int i = int.Parse(command[1]); i < count; i++)
                        {
                            Console.Write(contacts[i] + " ");
                        }
                        Console.WriteLine();

                        break;
                    case "Print":
                        if (command[1] == "Normal")
                        {
                            Console.WriteLine($"Contacts: {string.Join(' ', contacts)}");
                            return;
                        }
                        else if (command[1] == "Reversed")
                        {
                            contacts.Reverse();
                            Console.WriteLine($"Contacts: {string.Join(' ', contacts)}");
                            return;
                        }

                        break;
                }

                input = Console.ReadLine();
            }

        }
    }
}
