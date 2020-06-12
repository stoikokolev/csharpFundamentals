using System;
using System.Linq;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VowelsInString(input);
        }

        private static void VowelsInString(string input)
        {
            int sum = 0;
            string[] arr = new string[] { "o", "u", "i", "e", "a" };
            for (int i = 0; i < input.Length; i++)
            {
                if (arr.Contains(input[i].ToString().ToLower()))
                {
                    sum++;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
