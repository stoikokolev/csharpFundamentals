﻿using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int m = 0; m < i; m++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
