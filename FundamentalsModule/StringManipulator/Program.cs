using System;
using System.Linq;

namespace StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string text = Console.ReadLine();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                if (command.Contains("Translate"))
                {
                    text = text.Replace((command[1]), (command[2]));
                    Console.WriteLine(text);
                }
                else if (command.Contains("Includes"))
                {
                    if (text.Contains(command[1]))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command.Contains("Start"))
                {
                    if (text.IndexOf(command[1]) == 0)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command.Contains("Lowercase"))
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (command.Contains("FindIndex"))
                {
                    Console.WriteLine(text.LastIndexOf((command[1])));
                }
                else if (command.Contains("Remove"))
                {
                    text = text.Remove(int.Parse(command[1]), int.Parse(command[2]));
                    Console.WriteLine(text);
                }
            }
        }
    }
}
