using System;

namespace _09._Sum_of_Odd_Numbers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                int currOddNumber = 1 + (i * 2);
                Console.WriteLine(currOddNumber);
                sum += currOddNumber;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
