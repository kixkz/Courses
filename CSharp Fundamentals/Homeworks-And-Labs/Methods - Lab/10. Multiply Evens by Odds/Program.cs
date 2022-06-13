using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int oddDigitsSum = GetOddDigitsSum(number);
            int evenDigitsSum = GetEvenDigitsSum(number);

            Console.WriteLine(oddDigitsSum * evenDigitsSum);

        }
 
        static int GetOddDigitsSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 1)
                {
                    sum += digit;
                }
                number /= 10;
            }

            return sum;
        }

        static int GetEvenDigitsSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }

            return sum;
        }
    }
}
