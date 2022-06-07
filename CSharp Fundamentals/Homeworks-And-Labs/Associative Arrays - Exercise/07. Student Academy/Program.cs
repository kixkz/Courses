using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    List<double> newGradesList = new List<double>(){grade};
                    students.Add(name, newGradesList);
                }
            }

            foreach (var student in students)
            {
                double avgGrade = student.Value.Sum() / student.Value.Count;
                if (avgGrade >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {avgGrade:f2}");
                }
            }
        }
    }
}
