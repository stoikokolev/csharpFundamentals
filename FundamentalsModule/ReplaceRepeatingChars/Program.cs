using System;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(input[0].ToString());
            for (int i = 1; i <input.Length; i++)
            {
                if (input[i]!=input[i-1])
                {
                    sb.Append(input[i].ToString());
                }

            }

            Console.WriteLine(sb.ToString());
        }
    }
}
