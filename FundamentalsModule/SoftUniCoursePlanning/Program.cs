using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> schedule = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "course start")
            {
                List<string> modify = command.Split(':').ToList();
                switch (modify[0])
                {
                    case "Add":
                        AddLesson(schedule, modify[1]);
                        break;
                    case "Insert":
                        InsertLesson(schedule, modify[1], int.Parse(modify[2]));
                        break;
                    case "Remove":
                        RemoveLesson(schedule, modify[1]);
                        break;
                    case "Swap":
                        schedule = SwapLesson(schedule, modify[1], modify[2]);
                        break;
                    case "Exercise":
                        ExcerciseLesson(schedule, modify[1]);
                        break;
                }

            }
            for (int i = 1; i <= schedule.Count; i++)
            {
                Console.WriteLine($"{i}.{schedule[i - 1]}");
            }

        }

        private static void ExcerciseLesson(List<string> schedule, string lesson)
        {
            if (schedule.Contains(lesson))
            {
                if (!schedule.Contains($"{lesson}-Exercice"))
                {
                    int index = schedule.IndexOf(lesson);
                    string name = $"{lesson}-Exercise";
                    if (index == schedule.Count - 1)
                    {
                        schedule.Add(name);
                    }
                    else
                    {
                        schedule.Insert(index + 1, name);
                    }

                }

            }
            else
            {
                schedule.Add(lesson);
                schedule.Add($"{lesson}-Exercise");
            }

        }

        private static void RemoveLesson(List<string> schedule, string lesson)
        {
            if (schedule.Contains(lesson))
            {
                schedule.Remove(lesson);
            }
            if (schedule.Contains($"{lesson}-Exercise"))
            {
                schedule.Remove($"{lesson}-Exercise");
            }

        }

        private static void InsertLesson(List<string> schedule, string lesson, int index)
        {
            if (!schedule.Contains(lesson))
            {
                if (index >= schedule.Count)
                {
                    schedule.Add(lesson);
                }
                else
                {
                    schedule.Insert(index, lesson);
                }

            }

        }

        private static void AddLesson(List<string> schedule, string lesson)
        {
            if (!schedule.Contains(lesson))
            {
                schedule.Add(lesson);
            }

        }

        private static List<string> SwapLesson(List<string> schedule, string positionOne, string positionTwo)
        {
            List<string> list = schedule.ToList();
            int indexOne = list.IndexOf(positionOne);
            int indexTwo = list.IndexOf(positionTwo);

            if (list.Contains(positionOne) && list.Contains(positionTwo))
            {
                string temp = list[indexOne];
                list[indexOne] = list[indexTwo];
                list[indexTwo] = temp;
                string lessonOne = list[indexOne];
                string lessonTwo = list[indexTwo];
                if (list.Contains($"{lessonOne}-Exercise"))
                {
                    if (list.IndexOf(lessonOne) >= list.Count)
                    {
                        list.Remove($"{lessonOne}-Exercise");
                        list.Add($"{lessonOne}-Exercise");
                    }
                    else
                    {
                        list.Remove($"{lessonOne}-Exercise");
                        list.Insert(list.IndexOf(positionTwo) + 1, $"{lessonOne}-Exercise");
                    }
                }
                if (list.Contains($"{lessonTwo}-Exercise"))
                {
                    if (list.IndexOf(lessonTwo) >= list.Count)
                    {
                        list.Remove($"{lessonTwo}-Exercise");
                        list.Add($"{lessonTwo}-Exercise");
                    }
                    else
                    {
                        list.Remove($"{lessonTwo}-Exercise");
                        list.Insert(list.IndexOf(positionOne) + 1, $"{lessonTwo}-Exercise");
                    }
                }
            }





            return list;
        }
    }
}
