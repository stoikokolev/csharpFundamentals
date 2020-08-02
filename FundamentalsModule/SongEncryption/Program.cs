
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<artist>[A-Z][a-z' ]+):(?<song>[A-Z ]+)$";
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                var match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    StringBuilder sb = new StringBuilder();
                    int key = match.Groups["artist"].Length;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == ':')
                        {
                            sb.Append("@");
                        }
                        else if (input[i] == ' ' || input[i] == '\'')
                        {
                            sb.Append(input[i]);
                        }
                        else
                        {

                            if (input[i] >= 'A' && input[i] <= 'Z')
                            {
                                char newChar = (char)(input[i] + key);
                                if (newChar>'Z')
                                {
                                    newChar = (char)(newChar - 26);
                                }
                                sb.Append(newChar);
                            }
                            else if (input[i] >= 'a' && input[i] <= 'z')
                            {
                                char newChar = (char)(input[i] + key);
                                if (newChar > 'z')
                                {
                                    newChar = (char)(newChar - 26);
                                }
                                sb.Append(newChar);
                            }
                            
                            
                        }

                    }
                    Console.WriteLine($"Successful encryption: {sb}");

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }
    }
}
