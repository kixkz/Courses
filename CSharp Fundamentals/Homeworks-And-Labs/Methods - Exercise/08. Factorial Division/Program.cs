using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double factorielNum1 = CalculateFactoriel(num1);
            double factorielNum2 = CalculateFactoriel(num2);

            double divide = factorielNum1 / factorielNum2;

            Console.WriteLine($"{divide:f2}");
        }

        static double CalculateFactoriel(int num)
        {

            double result = 1;
            for (int i = num; i >= 2; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}