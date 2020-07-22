using System;
using System.Text;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                if (ValidUsernames(arr[i]))
                {
                    sb.AppendLine(arr[i]);
                }

            }
            Console.WriteLine(sb.ToString());

        }

        private static bool ValidUsernames(string word)
        {
            if (word.Length >= 3 && word.Length <= 16)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLetterOrDigit(word[i]) || word[i] == '-' || word[i] == '_')
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
