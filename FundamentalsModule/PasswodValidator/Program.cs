using System;

namespace PasswodValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            IsValidPassword(password);
        }

        private static void IsValidPassword(string password)
        {
            if (IsLenghtValid(password) && IsConsistValid(password) && IsTwoDigitsValid(password))
            {
                Console.WriteLine("Password is valid");
                return;
            }

            if (!IsLenghtValid(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!IsConsistValid(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!IsTwoDigitsValid(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

        }

        private static bool IsLenghtValid(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static bool IsConsistValid(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'a' && password[i] <= 'z')
                {
                    continue;
                }

                if (password[i] >= 'A' && password[i] <= 'Z')
                {
                    continue;
                }

                if (password[i] >= '0' && password[i] <= '9')
                {
                    continue;
                }

                return false;
            }

            return true;
        }

        private static bool IsTwoDigitsValid(string password)
        {
            int digitsCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    digitsCount++;
                }

            }

            if (digitsCount >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
