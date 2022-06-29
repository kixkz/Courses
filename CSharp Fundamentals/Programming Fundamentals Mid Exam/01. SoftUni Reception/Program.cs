using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main()
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int employeeCount = employee1 + employee2 + employee3;
            int studentsCount = int.Parse(Console.ReadLine());
            int hours = 0;
            int counter = 1;

            while (studentsCount > 0)
            {
                if (counter == 4)
                {
                    hours++;
                    counter = 1;
                }
                else
                {
                    studentsCount -= employeeCount;
                    hours++;
                    counter++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
