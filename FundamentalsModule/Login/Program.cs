using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            
            for (int i = 1; i <= 4; i++)
            {
                string word = Console.ReadLine();
                string password = string.Empty;
                for (int n = word.Length - 1; n >= 0; n--)
                {
                    password += word[n];
                }
                if (username == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else if (i < 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");

                }
                else
                {
                    Console.WriteLine($"User {username} blocked!");
                }
            }



        }
    }
}
