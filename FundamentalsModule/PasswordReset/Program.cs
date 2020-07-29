using System;
using System.Linq;
using System.Text;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] arr = command.Split();
                switch (arr[0])
                {
                    case "TakeOdd":
                        string newInput = string.Empty;
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (i % 2 == 1)
                            {
                                newInput += input[i];
                            }

                        }

                        input = newInput;
                        Console.WriteLine(input);
                        break;
                    case "Cut":
                        input = input.Remove(int.Parse(arr[1]), int.Parse(arr[2]));
                        Console.WriteLine(input);
                        break;
                    case "Substitute":
                        if (input.IndexOf(arr[1]) >= 0)
                        {
                            input = input.Replace(arr[1], arr[2]);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        
                        break;
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
