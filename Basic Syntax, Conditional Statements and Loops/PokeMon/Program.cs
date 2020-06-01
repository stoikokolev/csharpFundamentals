using System;
using System.Threading;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int startPower = power;
            int distance = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());
            int count = 0;
            while (power>=distance)
            {
                if (2*power==startPower && exhaustionFactor>0)
                {
                    power /= exhaustionFactor;
                    if (power < distance)
                    {
                        break;
                    }
                }
                
                    power -= distance;
                    count++;
                
            }
            Console.WriteLine(power);
            Console.WriteLine(count);


        }
    }
}
