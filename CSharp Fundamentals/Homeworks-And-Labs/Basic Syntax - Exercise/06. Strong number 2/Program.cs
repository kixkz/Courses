using System;

namespace _06._Strong_number_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int sum = 0;

            while (number > 0)
            {
                int factorielNumber = 1;
                int currentNum = number % 10;
                number /= 10;

                for (int i = currentNum; i >= 1; i--)
                {
                    factorielNumber *= i;
                }

                sum += factorielNumber;
            }

            Console.WriteLine(sum == numberCopy ? "yes" : "no");
        }
    }
}
