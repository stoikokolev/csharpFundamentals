using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;

namespace WarriorsQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "For Azeroth")
            {
                string[] arr = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                switch (arr[0])
                {
                    case "GladiatorStance":
                        input = GladiatorStance(input);
                        Console.WriteLine(input);
                        break;

                    case "DefensiveStance":
                        input = DefensiveStance(input);
                        Console.WriteLine(input);
                        break;

                    case "Dispel":
                        input = Dispel(input, int.Parse(arr[1]), char.Parse(arr[2]));
                        break;

                    case "Target":
                        if (arr[1] == "Change")
                        {
                            input = TargetChange(input, arr[2], arr[3]);
                        }
                        else if (arr[1] == "Remove")
                        {
                            input = TargetRemove(input, arr[2]);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("Command doesn't exist!");
                        }
                        break;

                    default:
                        Console.WriteLine("Command doesn't exist!");
                        break;

                }

            }

            
        }

        private static string TargetRemove(string input, string substring)
        {
            
                var index = input.IndexOf(substring);

                return input.Remove(index, substring.Length);
            
        }

        private static string TargetChange(string input, string oldSubstring, string newSubstring)
        {
            input = input.Replace(oldSubstring, newSubstring);
            Console.WriteLine(input);
            return input;
        }

        private static string Dispel(string input, int index, char letter)
        {
            if (index >= 0 && index < input.Length)
            {
                char[] temp = input.ToCharArray();
                temp[index] = letter;
                input = new string(temp);
                Console.WriteLine("Success!");
                return input;
            }
            else
            {
                Console.WriteLine("Dispel too weak.");
                return input;
            }
        }

        private static string DefensiveStance(string input)
        {
            return input.ToLower();
        }

        private static string GladiatorStance(string input)
        {
            return input.ToUpper();

        }
    }
}
