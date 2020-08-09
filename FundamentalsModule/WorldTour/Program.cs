using System;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] arr = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                switch (arr[0])
                {
                    case "Add Stop":
                        int index = int.Parse(arr[1]);
                        if (index >= 0 && index < text.Length)
                        {
                            text = text.Insert(index, arr[2]);
                        }
                        Console.WriteLine(text);
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(arr[1]);
                        int endIndex = int.Parse(arr[2]);
                        int count = endIndex - startIndex + 1;
                        if (startIndex >= 0 && startIndex < text.Length && endIndex > 0 && endIndex < text.Length && count>=0)
                        {
                            text = text.Remove(startIndex, count);
                        }
                        Console.WriteLine(text);
                            break;
                    case "Switch":
                        string oldString = arr[1];
                        string newString = arr[2];
                        if (text.Contains(oldString))
                        {
                            text = text.Replace(oldString, newString);
                        }
                        Console.WriteLine(text);
                        break;
                    default:
                        Console.WriteLine(text);
                        break;
                }
                



            }
            Console.WriteLine($"Ready for world tour! Planned stops: {text}");



        }
    }
}
