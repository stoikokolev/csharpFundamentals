using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.TrimStart(new char[] { '0' });
            int multyplier = int.Parse(Console.ReadLine());
            int remainder = 0;
            int current = 0;
            List<int> list = new List<int>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                remainder = (input[i] - '0') * multyplier + remainder;
                current = remainder % 10;
                remainder /= 10;
                list.Add(current);

            }
            if (remainder > 0)
            {
                list.Add(remainder);
            }
            list.Reverse();
            string final = string.Join("", list);
            final = final.TrimStart(new char[] { '0' });
            if (final == string.Empty)
            {
                final = "0";
            }
            Console.WriteLine(final);

            
        }
    }
}
