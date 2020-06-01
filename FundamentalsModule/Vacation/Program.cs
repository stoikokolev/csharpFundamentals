using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double pricePerPerson = 0;
            double total = 0;
            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 8.45;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 10.90;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.60;
                            break;
                        case "Sunday":
                            pricePerPerson = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 15;
                            break;
                        case "Saturday":
                            pricePerPerson = 20;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50;
                            break;
                    }
                    break;
            }
            if (type == "Students" && number >= 30)
            {
                total = number * pricePerPerson * 0.85;
            }
            else if (type == "Business" && number >= 100)
            {
                total = (number - 10) * pricePerPerson;
            }
            else if (type == "Regular" && number >= 10 && number <= 20)
            {
                total = number * pricePerPerson * 0.95;
            }
            else
            {
                total = number * pricePerPerson;
            }

            Console.WriteLine($"Total price: {total:f2}");

        }
    }
}
