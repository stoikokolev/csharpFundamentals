using System;
using System.Text;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeats = int.Parse(Console.ReadLine());
            string pattern = @"@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+";
            for (int i = 0; i < repeats; i++)
            {
                string barcode = Console.ReadLine();
                var match = Regex.Match(barcode, pattern);
                if (match.Success)
                {
                    barcode = match.Groups["1"].Value;
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < barcode.Length; j++)
                    {
                        if (char.IsDigit(barcode[j]))
                        {
                            sb.Append(barcode[j].ToString());
                        }
                    }

                    if (sb.ToString()==string.Empty)
                    {
                        sb.Append("00");
                    }
                    Console.WriteLine($"Product group: {sb.ToString()}");

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }

        }
    }
}
