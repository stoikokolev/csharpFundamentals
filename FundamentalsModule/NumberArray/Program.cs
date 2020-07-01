using System;
using System.Linq;

namespace NumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string input = string.Empty;
            while((input=Console.ReadLine())!="End")
            {
                string[] command = input.Split().ToArray();
                switch (command[0])
                {
                    case "Switch":
                        if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < arr.Length)
                        {
                            arr[int.Parse(command[1])] *= -1;
                        }
                        break;
                    case "Change":
                        if (int.Parse(command[1])>=0 && int.Parse(command[1])<arr.Length)
                        {
                            arr[int.Parse(command[1])] = int.Parse(command[2]);
                        }
                        break;
                    case "Sum":
                        if (command[1]=="Positive")
                        {
                            int sum = 0;
                            foreach (var item in arr)
                            {
                                if (item>0)
                                {
                                sum += item;
                                                                    }
                            }
                            Console.WriteLine(sum);
                        }
                        else if (command[1] == "Negative")
                        {
                            int sum = 0;
                            foreach (var item in arr)
                            {
                                if (item < 0)
                                {
                                    sum += item;
                                }
                            }
                            Console.WriteLine(sum);
                        }
                        else if (command[1] == "All")
                        {
                            int sum = 0;
                            foreach (var item in arr)
                            {
                                sum += item;
                            }
                            Console.WriteLine(sum);
                        }

                        break;
                    
                }

                
            }
            foreach (var item in arr)
            {
                if (item >= 0)
                {
                    Console.Write(item + " ");
                }
            }

        }
    }
}
