using System;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int power = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == '>')
                {
                    power += input[i + 1] - '0';
                    sb.Append(input[i].ToString());
                }
                else if (power > 0)
                {
                    power--;
                }
                else
                {
                    sb.Append(input[i].ToString());
                }

            }

            Console.WriteLine(sb.ToString());
        }
    }
}
