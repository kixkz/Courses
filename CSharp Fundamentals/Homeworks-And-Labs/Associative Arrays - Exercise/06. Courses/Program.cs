using System;
using System.Collections.Generic;

namespace _06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> courses = new Dictionary<string, int>();
            Dictionary<string, string> studentsCount = new Dictionary<string, string>();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string course = tokens[0];
                string studentName = tokens[1];
                if (!courses.ContainsKey(course))
                {
                    courses[course] = 1;
                    studentsCount[studentName] = course;
                }
                else
                {
                    courses[course]++;
                    studentsCount[studentName] = course;
                }
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value}");
                foreach (var student in studentsCount)
                {
                    if (course.Key == student.Value)
                    {
                        Console.WriteLine($"-- {student.Key}");
                    }
                }
            }
        }
    }
}
