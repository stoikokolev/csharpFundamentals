using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Dictionary<string, Product>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }
                string name = input.Split()[0];
                double price = double.Parse(input.Split()[1]);
                int quantity = int.Parse(input.Split()[2]);
                var product = new Product(name, price, quantity);
                if (menu.ContainsKey(name))
                {
                    menu[name].Price = price;
                    menu[name].Quantity += quantity;
                }
                else
                {
                    menu.Add(name, product);
                }

            }
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Price * item.Value.Quantity:f2}");
            }
        }

        public class Product
        {
            public string Name;
            public double Price;
            public int Quantity;
            public Product(string name, double price, int quantity)
            {
                this.Name = name;
                this.Price = price;
                this.Quantity = quantity;
            }
        }

    }
}
