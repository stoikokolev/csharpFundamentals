using System;
using System.Data;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;
            double price = 0;
            bool isValid = true;
            while (command != "Start")
            {
                double coin = double.Parse(command);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    sum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Nuts")
                {
                    price = 2;
                }
                else if (command == "Water")
                {
                    price = 0.7;
                }
                else if (command == "Crisps")
                {
                    price = 1.5;
                }
                else if (command == "Soda")
                {
                    price = 0.8;
                }
                else if (command == "Coke")
                {
                    price = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    isValid = false;
                }

                if (sum >= price && isValid)
                {
                    Console.WriteLine($"Purchased {command.ToLower()}");
                    sum -= price;
                    price = 0;
                }
                else if (!isValid)
                {

                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                isValid = true;
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
