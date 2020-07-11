using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeats = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();
            for (int i = 0; i < repeats; i++)
            {
                string name = Console.ReadLine();
                double mark = double.Parse(Console.ReadLine());
                if (students.ContainsKey(name))
                {
                    students[name].Add(mark);
                }
                else
                {
                    students.Add(name, new List<double>());
                    students[name].Add(mark);
                }

            }
            foreach (var item in students.Where(x => x.Value.Average() >= 4.50).OrderByDescending(y => y.Value.Average()))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}
