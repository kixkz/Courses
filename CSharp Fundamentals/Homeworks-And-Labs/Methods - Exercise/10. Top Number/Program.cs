using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNumbers(number);
        }

        static void PrintTopNumbers(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                if (isTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool isTopNumber(int number)
        {
            int sum = 0;
            int count = 0;

            while (number > 0)
            {
                int currentNum = number % 10;
                if (currentNum % 2 == 1)
                {
                    count++;
                }
                sum += currentNum;
                number /= 10;
            }

            if (sum % 8 == 0 && count >= 1)
            {
                return true;
            }

            return false;
        }
    }
}
