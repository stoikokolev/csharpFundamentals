using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string[] input = Console.ReadLine().Split();
            string word1 = input[0];
            string word2 = input[1];
            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                sum += word1[i] * word2[i];
            }

            if (word1.Length >= word2.Length)
            {
                for (int i = word2.Length; i < word1.Length; i++)
                {
                    sum += word1[i];
                }

            }
            else if (word2.Length >= word1.Length)
            {
                for (int i = word1.Length; i < word2.Length; i++)
                {
                    sum += word2[i];
                }

            }

            Console.WriteLine(sum);
        }
    }
}