using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split('\\');
            string[] arr2 = arr[arr.Length-1].Split('.');
            Console.WriteLine($"File name: {arr2[0]}");
            Console.WriteLine($"File extension: {arr2[1]}");
        }
    }
}
