using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string courseName = command.Split(" : ")[0];
                string studentName = command.Split(" : ")[1];
                if (courses.ContainsKey(courseName))
                {
                    if (courses[courseName].Contains(studentName))
                    {
                        continue;
                    }
                    else
                    {
                        courses[courseName].Add(studentName);
                    }

                }
                else
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }

            }
            foreach (var item in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var student in item.Value.OrderBy(y => y))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
