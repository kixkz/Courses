using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Student student = new Student(input[0], input[1], float.Parse(input[2]));
                students.Add(student);
            }

            List<Student> orderedStudents = students.OrderByDescending(students => students.Grade).ToList();

            foreach (Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
