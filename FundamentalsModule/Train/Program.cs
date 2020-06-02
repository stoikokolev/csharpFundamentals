using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] train = new int[wagons];
            int sum = 0;
            foreach (int i in train)
            {
                train[i] = int.Parse(Console.ReadLine());
                Console.Write(train[i] + " ");
                sum += train[i];
            }
            Console.WriteLine();
            Console.WriteLine(sum);



        }
    }
}
