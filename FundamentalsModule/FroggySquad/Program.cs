using System;
using System.Collections.Generic;
using System.Linq;

namespace FroggySquad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogs = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .ToList();
            string input = Console.ReadLine();
            while (true)
            {
                string[] command = input.Split().ToArray();
                switch (command[0])
                {
                    case "Join":
                        if (!frogs.Contains(command[1]))
                        {
                            frogs.Add(command[1]);

                        }
                        break;
                    case "Jump":
                        string frog = command[1];
                        int position = int.Parse(command[2]);
                        if (position >= 0 && position < frogs.Count)
                        {
                            frogs.Insert(position, frog);
                        }

                        break;
                    case "Dive":
                        int pos = int.Parse(command[1]);
                        if (pos >= 0 && pos < frogs.Count)
                        {
                            frogs.RemoveAt(pos);
                        }
                        break;
                    case "First":
                        int count = int.Parse(command[1]);
                        if (count > frogs.Count)
                        {
                            count = frogs.Count;
                        }
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write(frogs[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                    case "Last":
                        int number = int.Parse(command[1]);
                        if (number > frogs.Count)
                        {
                            for (int i = 0; i < frogs.Count; i++)
                            {
                                Console.Write(frogs[i] + " ");
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            for (int i = frogs.Count - number; i < frogs.Count; i++)
                            {
                                Console.Write(frogs[i] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "Print":
                        if (command[1] == "Normal")
                        {
                            Console.WriteLine($"Frogs: {string.Join(' ', frogs)}");
                            return;
                        }
                        else if (command[1] == "Reversed")
                        {
                            frogs.Reverse();
                            Console.WriteLine($"Frogs: {string.Join(' ', frogs)}");
                            return;
                        }

                        break;

                }
                input = Console.ReadLine();
            }
        }

    }
}
