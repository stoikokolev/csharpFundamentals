using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(Add(num1, num2), num3));
        }

        private static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        private static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
