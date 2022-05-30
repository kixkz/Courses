using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                bool doesStudentExsist = DoesStudentExsist(students, firstName, lastName);

                if (doesStudentExsist)
                {
                    //Student exsistingStudent = GetExsistingStudent(students, firstName, lastName);

                    Student exsistingStudent = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

                    exsistingStudent.FirstName = firstName;
                    exsistingStudent.LastName = lastName;
                    exsistingStudent.Age = age;
                    exsistingStudent.City = city;
                }
                else
                {
                    Student student = new Student(firstName, lastName, age, city);
                    students.Add(student);
                }

                input = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();

            List<Student> filteredStudnets = students.Where(s => s.City == filterCity).ToList();

            foreach (Student student in filteredStudnets)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        //private static Student GetExsistingStudent(List<Student> students, string firstName, string lastName)
        //{
        //    foreach (Student student in students)
        //    {
        //        if (student.FirstName == firstName && student.LastName == lastName)
        //        {
        //            return student;
        //        }
        //    }

        //    return null;
        //}

        static bool DoesStudentExsist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }


}
