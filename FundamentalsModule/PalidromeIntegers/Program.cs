using System;
using System.Linq;

namespace PalidromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input=Console.ReadLine()) != "END")
            {
                IsPalindrome(input);
                
            }

        }

        private static void IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[input.Length - i - 1])
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("false");
                    return;
                }

            }

            Console.WriteLine("true");
        }
    }
}
